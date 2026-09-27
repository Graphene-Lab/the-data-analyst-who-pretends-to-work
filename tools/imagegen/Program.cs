using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using PuppeteerSharp;
using QRCoder;

// Book image generator. Reads a panels.json manifest and renders every entry:
//   kind "cover" -> clean cover PNG at exact size (no title text; DistroBook overlays it)
//   kind "qr"    -> QR code PNG from a URL (QRCoder, no System.Drawing)
//   kind "chat"  -> an AgentBridge chat panel (prompt -> real tool result) as a clean PNG
// All rendering is deterministic and reuses one Chromium/Edge instance.

var manifestPath = args.Length > 0 ? args[0]
    : Path.Combine(AppContext.BaseDirectory, "panels.json");
if (!File.Exists(manifestPath))
{
    Console.Error.WriteLine($"panels.json not found: {manifestPath}");
    return 1;
}

var json = File.ReadAllText(manifestPath);
var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var panels = JsonSerializer.Deserialize<List<Panel>>(json, opts) ?? new List<Panel>();

// Resolve output paths relative to the book root (two levels above the exe: tools/imagegen/bin/... )
var bookRoot = ResolveBookRoot();
Console.WriteLine($"book root: {bookRoot}");

var browser = await Puppeteer.LaunchAsync(new LaunchOptions
{
    ExecutablePath = FindBrowser() ?? throw new Exception("No Chromium/Edge found"),
    Args = new[] { "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage" },
});

int made = 0;
try
{
    foreach (var p in panels)
    {
        var outPath = Path.IsPathRooted(p.Out) ? p.Out : Path.Combine(bookRoot, p.Out);
        Directory.CreateDirectory(Path.GetDirectoryName(outPath)!);

        if (p.Kind == "qr")
        {
            using var gen = new QRCodeGenerator();
            using var data = gen.CreateQrCode(p.Data!, QRCodeGenerator.ECCLevel.Q);
            var png = new PngByteQRCode(data).GetGraphic(p.Px > 0 ? p.Px : 10);
            File.WriteAllBytes(outPath, png);
            Console.WriteLine($"qr   -> {p.Out}");
            made++;
            continue;
        }

        string html = p.Kind == "cover" ? CoverHtml(p.W, p.H) : ChatHtml(p);
        var tmp = Path.Combine(Path.GetTempPath(), $"bookimg-{Guid.NewGuid():N}.html");
        File.WriteAllText(tmp, html, new UTF8Encoding(false));
        try
        {
            await using var page = await browser.NewPageAsync();
            var dsf = p.Kind == "cover" ? 1 : 2;
            await page.SetViewportAsync(new ViewPortOptions { Width = p.W, Height = p.H, DeviceScaleFactor = dsf });
            await page.GoToAsync(new Uri(tmp).AbsoluteUri,
                new NavigationOptions { WaitUntil = new[] { WaitUntilNavigation.Load } });
            await page.EvaluateExpressionAsync("document.fonts && document.fonts.ready");
            await page.ScreenshotAsync(outPath, new ScreenshotOptions
            {
                Type = ScreenshotType.Png,
                FullPage = false,
            });
            Console.WriteLine($"{p.Kind,-5} -> {p.Out}");
            made++;
        }
        finally { try { File.Delete(tmp); } catch { } }
    }
}
finally { await browser.CloseAsync(); }

Console.WriteLine($"generated {made} image(s)");
return 0;

static string ResolveBookRoot()
{
    // exe lives at <book>/tools/imagegen/bin/<cfg>/net10.0/ ; walk up to <book>
    var dir = AppContext.BaseDirectory;
    for (int i = 0; i < 8; i++)
    {
        if (File.Exists(Path.Combine(dir, "book.json"))) return dir;
        dir = Path.GetDirectoryName(dir)!;
    }
    return Directory.GetCurrentDirectory();
}

static string FindBrowser()
{
    string[] c =
    {
        @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
        @"C:\Program Files\Microsoft\Edge\Application\msedge.exe",
        @"C:\Program Files\Google\Chrome\Application\chrome.exe",
    };
    foreach (var x in c) if (File.Exists(x)) return x;
    return null!;
}

// ---- cover: clean 1024x1536 background, no title text ----
static string CoverHtml(int w, int h) => $$"""
<!doctype html><html><head><meta charset="utf-8"><style>
*{margin:0;padding:0;box-sizing:border-box}
html,body{width:{{w}}px;height:{{h}}px;overflow:hidden}
.bg{position:relative;width:100%;height:100%;
  background:linear-gradient(160deg,#0b1f2a 0%,#12303f 45%,#1c4a5e 100%);}
.grid{position:absolute;inset:0;opacity:.10;
  background-image:linear-gradient(#ffffff 1px,transparent 1px),linear-gradient(90deg,#ffffff 1px,transparent 1px);
  background-size:64px 64px;}
.glow{position:absolute;left:-10%;top:30%;width:120%;height:60%;
  background:radial-gradient(ellipse at center,rgba(64,200,220,.28),transparent 60%);}
.bars{position:absolute;left:12%;right:12%;bottom:20%;height:34%;display:flex;align-items:flex-end;gap:3.2%;}
.bar{flex:1;border-radius:8px 8px 0 0;background:linear-gradient(180deg,#3fd0e0,#1f7f96);opacity:.85;}
.trend{position:absolute;left:10%;right:10%;bottom:22%;height:30%;}
.trend svg{width:100%;height:100%}
.dots{position:absolute;inset:0}
.dot{position:absolute;border-radius:50%;background:#8fe9f5;opacity:.5}
</style></head><body>
<div class="bg">
  <div class="grid"></div>
  <div class="glow"></div>
  <div class="bars">
    <div class="bar" style="height:38%"></div>
    <div class="bar" style="height:55%"></div>
    <div class="bar" style="height:44%"></div>
    <div class="bar" style="height:70%"></div>
    <div class="bar" style="height:60%"></div>
    <div class="bar" style="height:88%"></div>
    <div class="bar" style="height:76%"></div>
  </div>
  <div class="trend">
    <svg viewBox="0 0 100 40" preserveAspectRatio="none">
      <polyline points="2,34 18,28 34,30 50,18 66,22 82,8 98,4"
        fill="none" stroke="#eafcff" stroke-width="1.1" stroke-linecap="round" stroke-linejoin="round" opacity=".9"/>
    </svg>
  </div>
  <div class="dots">
    <div class="dot" style="left:20%;top:64%;width:8px;height:8px"></div>
    <div class="dot" style="left:46%;top:52%;width:6px;height:6px"></div>
    <div class="dot" style="left:70%;top:40%;width:10px;height:10px"></div>
    <div class="dot" style="left:82%;top:58%;width:5px;height:5px"></div>
  </div>
</div>
</body></html>
""";

// ---- chat panel: AgentBridge prompt -> real PowerBITool result ----
static string ChatHtml(Panel p)
{
    var prompt = Esc(p.Prompt ?? "");
    var result = Esc(p.Result ?? "");
    var caption = Esc(p.Caption ?? "");
    var tool = Esc(string.IsNullOrWhiteSpace(p.Tool) ? "PowerBITool" : p.Tool!);
    var capHtml = string.IsNullOrEmpty(caption) ? "" : $"<div class=\"cap\">{caption}</div>";
    return $$"""
<!doctype html><html><head><meta charset="utf-8"><style>
*{margin:0;padding:0;box-sizing:border-box}
html,body{width:{{p.W}}px;height:{{p.H}}px;overflow:hidden;
  background:#eef1f5;font-family:'Segoe UI',Arial,sans-serif;padding:22px}
.card{width:100%;height:100%;background:#ffffff;border-radius:16px;
  box-shadow:0 8px 30px rgba(20,40,60,.14);overflow:hidden;display:flex;flex-direction:column}
.bar{height:52px;background:#0f2733;display:flex;align-items:center;padding:0 20px;gap:10px;flex:0 0 auto}
.dot{width:11px;height:11px;border-radius:50%}
.d1{background:#ff5f57}.d2{background:#febc2e}.d3{background:#28c840}
.title{color:#eafcff;font-weight:700;font-size:16px;margin-left:8px}
.badge{margin-left:auto;background:#1f7f96;color:#eafcff;font-size:12px;font-weight:600;
  padding:4px 10px;border-radius:20px}
.body{flex:1 1 auto;padding:20px 22px;display:flex;flex-direction:column;gap:16px;overflow:hidden}
.user{align-self:flex-end;max-width:82%;background:#1f7f96;color:#fff;
  padding:12px 16px;border-radius:14px 14px 4px 14px;font-size:16px;line-height:1.4}
.user .who{display:block;font-size:11px;opacity:.8;margin-bottom:4px;font-weight:600;letter-spacing:.3px}
.res{align-self:stretch;background:#f6f8fa;border:1px solid #e2e8ef;border-radius:12px;overflow:hidden}
.res .rh{background:#eef3f7;color:#33556b;font-size:12px;font-weight:700;padding:7px 14px;
  border-bottom:1px solid #e2e8ef;display:flex;align-items:center;gap:8px}
.res .rh .t{background:#0f2733;color:#8fe9f5;font-size:11px;padding:2px 8px;border-radius:10px;font-weight:700}
.res pre{margin:0;padding:14px 16px;font-family:'Consolas','Menlo',monospace;font-size:13.5px;
  line-height:1.5;color:#1c2b36;white-space:pre-wrap;word-break:break-word;overflow-wrap:anywhere;
  max-height:{{Math.Max(120, p.H - 250)}}px;overflow:hidden}
.cap{flex:0 0 auto;text-align:center;color:#5a6b7a;font-size:13px;font-style:italic;padding:2px 10px 4px}
</style></head><body>
<div class="card">
  <div class="bar">
    <span class="dot d1"></span><span class="dot d2"></span><span class="dot d3"></span>
    <span class="title">AgentBridge</span>
    <span class="badge">{{tool}}</span>
  </div>
  <div class="body">
    <div class="user"><span class="who">YOU</span>{{prompt}}</div>
    <div class="res">
      <div class="rh"><span class="t">{{tool}}</span> result</div>
      <pre>{{result}}</pre>
    </div>
  </div>
  {{capHtml}}
</div>
</body></html>
""";
}

static string Esc(string s) =>
    HtmlEncoder.Create(UnicodeRanges.All).Encode(s);

record Panel
{
    public string Out { get; set; } = "";
    public string Kind { get; set; } = "chat";
    public int W { get; set; } = 1000;
    public int H { get; set; } = 620;
    public string? Data { get; set; }
    public int Px { get; set; }
    public string? Prompt { get; set; }
    public string? Result { get; set; }
    public string? Caption { get; set; }
    public string? Tool { get; set; }
}
