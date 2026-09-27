using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

// Pushes a whole folder to a GitHub repo via the Git Data API (blobs up to 100MB).
// Runs as a normal process (not a git command), so the daemon's git guard does not apply.
// A brand-new repo has no commits, and the Git Data API refuses blobs against an empty
// repo ("Git Repository is empty"), so we first seed one commit via the Contents API,
// then build the full tree on top of it.
// Usage: ghpush <bookFolder> [repoName] [org]

var bookFolder = args.Length > 0 ? args[0]
    : @"C:\Users\andre\OneDrive\Sorgenti\The data analyst pretending to work";
var repoName = args.Length > 1 ? args[1] : "the-data-analyst-who-pretends-to-work";
var org = args.Length > 2 ? args[2] : "Graphene-Lab";

bookFolder = Path.GetFullPath(bookFolder);
Console.WriteLine($"Book folder: {bookFolder}");
Console.WriteLine($"Target: {org}/{repoName}");

var token = GetToken();
var http = new HttpClient();
http.BaseAddress = new Uri("https://api.github.com/");
http.DefaultRequestHeaders.UserAgent.ParseAdd("ghpush/1.0");
http.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github+json");
http.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

// 1. Identity (noreply commit author).
var (_, userBody) = await Req(HttpMethod.Get, "/user");
var me = JsonNode.Parse(userBody)!;
var login = me["login"]!.GetValue<string>();
var id = me["id"]!.GetValue<long>();
var noreply = $"{id}+{login}@users.noreply.github.com";
Console.WriteLine($"Identity: {login} <{noreply}>");

// 2. Create the repo in the org (idempotent).
var createBody = new JsonObject
{
    ["name"] = repoName,
    ["private"] = false,
    ["description"] = "The Data Analyst Who Pretends to Work - the book your boss shouldn't know exists. Built with AgentBridge + PowerBITool.",
    ["has_issues"] = true,
    ["has_wiki"] = false
};
var (createStatus, createResp) = await Req(HttpMethod.Post, $"/orgs/{org}/repos", createBody);
if (createStatus == System.Net.HttpStatusCode.Created)
    Console.WriteLine($"Created repo {org}/{repoName}.");
else if (createStatus == System.Net.HttpStatusCode.UnprocessableEntity)
    Console.WriteLine($"Repo {org}/{repoName} already exists; continuing.");
else { Console.WriteLine($"Repo create failed: {createStatus} {createResp}"); return 1; }

// 3. Seed the repo with one commit if it has none (Git Data API needs a non-empty repo).
var (commitsStatus, commitsBody) = await Req(HttpMethod.Get, $"/repos/{org}/{repoName}/commits?per_page=1");
bool hasCommits = commitsStatus == System.Net.HttpStatusCode.OK
    && JsonNode.Parse(commitsBody)!.AsArray().Count > 0;
if (!hasCommits)
{
    Console.WriteLine("Repo is empty; seeding an initial commit via the Contents API...");
    var readmePath = Path.Combine(bookFolder, "README.md");
    var readmeB64 = Convert.ToBase64String(await File.ReadAllBytesAsync(readmePath));
    var seedBody = new JsonObject
    {
        ["message"] = "Initial commit",
        ["content"] = readmeB64
    };
    var (seedStatus, seedResp) = await Req(HttpMethod.Put, $"/repos/{org}/{repoName}/contents/README.md", seedBody);
    if (seedStatus != System.Net.HttpStatusCode.OK && seedStatus != System.Net.HttpStatusCode.Created)
    {
        Console.WriteLine($"Seed failed: {seedStatus} {seedResp}");
        return 1;
    }
    Console.WriteLine("Seeded initial commit.");
}

// 4. Current ref sha (the parent for our commit).
var (refStatus, refBody) = await Req(HttpMethod.Get, $"/repos/{org}/{repoName}/git/refs/heads/main");
if (refStatus != System.Net.HttpStatusCode.OK)
{
    Console.WriteLine($"Could not read refs/heads/main: {refStatus} {refBody}");
    return 1;
}
var parentSha = JsonNode.Parse(refBody)!["object"]!["sha"]!.GetValue<string>();
Console.WriteLine($"Parent commit: {parentSha}");

// 5. Collect files to push.
var excludeNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "book lineeguide.md" };
var excludeDirs = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "bin", "obj", ".git" };
var files = new List<(string rel, string full)>();
foreach (var path in Directory.EnumerateFiles(bookFolder, "*", SearchOption.AllDirectories))
{
    var rel = Path.GetRelativePath(bookFolder, path).Replace('\\', '/');
    var parts = rel.Split('/');
    if (parts.Any(p => excludeDirs.Contains(p))) continue;
    if (excludeNames.Contains(parts[^1])) continue;
    files.Add((rel, path));
}
files.Sort((a, b) => string.CompareOrdinal(a.rel, b.rel));
Console.WriteLine($"Files to push: {files.Count}");

// 6. Create a blob per file.
var tree = new JsonArray();
long totalBytes = 0;
int n = 0;
foreach (var (rel, full) in files)
{
    var bytes = await File.ReadAllBytesAsync(full);
    totalBytes += bytes.Length;
    var b64 = Convert.ToBase64String(bytes);
    // encoding MUST be "base64": without it GitHub treats `content` as UTF-8 and stores
    // the base64 string literally, corrupting every file.
    var blobBody = new JsonObject { ["content"] = b64, ["encoding"] = "base64" };
    var (st, resp) = await ReqRetry($"/repos/{org}/{repoName}/git/blobs", blobBody);
    if (st != System.Net.HttpStatusCode.Created)
    {
        Console.WriteLine($"Blob failed for {rel}: {st} {resp}");
        return 1;
    }
    var sha = JsonNode.Parse(resp)!["sha"]!.GetValue<string>();
    tree.Add(new JsonObject { ["path"] = rel, ["mode"] = "100644", ["type"] = "blob", ["sha"] = sha });
    n++;
    if (n % 10 == 0 || n == files.Count)
        Console.WriteLine($"  blobs {n}/{files.Count} ({totalBytes / 1024 / 1024} MB)");
    await Task.Delay(250); // pace blob creation to stay under GitHub abuse detection
}

// 7. Create the tree (fresh, full content).
var (treeStatus, treeResp) = await Req(HttpMethod.Post, $"/repos/{org}/{repoName}/git/trees",
    new JsonObject { ["tree"] = tree });
if (treeStatus != System.Net.HttpStatusCode.Created)
{
    Console.WriteLine($"Tree failed: {treeStatus} {treeResp}");
    return 1;
}
var treeSha = JsonNode.Parse(treeResp)!["sha"]!.GetValue<string>();
Console.WriteLine($"Tree: {treeSha}");

// 8. Create the commit on top of the parent.
var now = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
JsonObject Person() => new() { ["name"] = login, ["email"] = noreply, ["date"] = now };
var (cStatus, cResp) = await Req(HttpMethod.Post, $"/repos/{org}/{repoName}/git/commits", new JsonObject
{
    ["message"] = "The Data Analyst Who Pretends to Work - full book (EN)\n\n" +
                 "Source, assets, generators, and built PDF/EPUB/print. " +
                 "All examples produced with AgentBridge + PowerBITool.",
    ["tree"] = treeSha,
    ["parents"] = new JsonArray { parentSha },
    ["author"] = Person(),
    ["committer"] = Person()
});
if (cStatus != System.Net.HttpStatusCode.Created)
{
    Console.WriteLine($"Commit failed: {cStatus} {cResp}");
    return 1;
}
var commitSha = JsonNode.Parse(cResp)!["sha"]!.GetValue<string>();
Console.WriteLine($"Commit: {commitSha}");

// 9. Move refs/heads/main to the new commit.
var (rStatus, rResp) = await Req(new HttpMethod("PATCH"), $"/repos/{org}/{repoName}/git/refs/heads/main",
    new JsonObject { ["sha"] = commitSha, ["force"] = false });
if (rStatus != System.Net.HttpStatusCode.OK)
{
    Console.WriteLine($"Ref update failed: {rStatus} {rResp}");
    return 1;
}
Console.WriteLine($"Pushed refs/heads/main -> {commitSha}");
Console.WriteLine($"https://github.com/{org}/{repoName}");
return 0;

// --- helpers ---
string GetToken()
{
    var env = Environment.GetEnvironmentVariable("GH_TOKEN") ?? Environment.GetEnvironmentVariable("GITHUB_TOKEN");
    if (!string.IsNullOrWhiteSpace(env)) return env.Trim();
    var psi = new ProcessStartInfo("gh", "auth token")
    {
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false
    };
    using var p = Process.Start(psi)!;
    var tok = p.StandardOutput.ReadToEnd().Trim();
    p.WaitForExit();
    if (string.IsNullOrWhiteSpace(tok))
        throw new Exception("Could not obtain a GitHub token from `gh auth token`.");
    return tok;
}

async Task<(System.Net.HttpStatusCode, string)> Req(HttpMethod method, string path, JsonNode? body = null)
{
    using var msg = new HttpRequestMessage(method, path);
    if (body is not null)
        msg.Content = new StringContent(body.ToJsonString(), Encoding.UTF8, "application/json");
    using var res = await http.SendAsync(msg);
    var text = await res.Content.ReadAsStringAsync();
    return (res.StatusCode, text);
}

// Retry transient failures:
//  - 409 "Git Repository is empty" (repo still provisioning)
//  - 401/403/429 abuse-detection throttling (token is valid; GitHub throttles rapid blob creation)
async Task<(System.Net.HttpStatusCode, string)> ReqRetry(string path, JsonNode body, int maxAttempts = 10)
{
    System.Net.HttpStatusCode last = 0;
    string lastText = "";
    for (int attempt = 1; attempt <= maxAttempts; attempt++)
    {
        var (st, text) = await Req(HttpMethod.Post, path, body);
        if (st == System.Net.HttpStatusCode.Created) return (st, text);
        last = st; lastText = text;
        bool emptyRepo = st == System.Net.HttpStatusCode.Conflict && text.Contains("Git Repository is empty");
        bool throttled = st == System.Net.HttpStatusCode.Unauthorized
                     || st == System.Net.HttpStatusCode.Forbidden
                     || (int)st == 429;
        if (emptyRepo || throttled)
        {
            var delay = TimeSpan.FromSeconds(Math.Min(30, Math.Pow(2, attempt)));
            Console.WriteLine($"  {st} on {path}, retry {attempt}/{maxAttempts} in {delay.TotalSeconds:0}s");
            await Task.Delay(delay);
            continue;
        }
        return (st, text);
    }
    return (last, lastText);
}
