using System.Globalization;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using PuppeteerSharp;

// Renders professional "dashboard card" PNGs using Apache ECharts (bundled locally).
// Reads a charts.json manifest: [{ out, title, type, labels[], values[], unit? }]
// ECharts computes layout, auto-rotates long category labels, fits margins
// (containLabel) and draws value labels — no clipping.

var manifestPath = args.Length > 0 ? args[0]
    : Path.Combine(AppContext.BaseDirectory, "charts.json");
if (!File.Exists(manifestPath))
{
    Console.Error.WriteLine($"charts.json not found: {manifestPath}");
    return 1;
}

var json = File.ReadAllText(manifestPath);
var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var charts = JsonSerializer.Deserialize<List<Chart>>(json, opts) ?? new List<Chart>();

var bookRoot = ResolveBookRoot(manifestPath);
Console.WriteLine($"book root: {bookRoot}");

var echartsPath = Path.Combine(bookRoot, "tools", "chartgen", "echarts.min.js");
if (!File.Exists(echartsPath))
{
    Console.Error.WriteLine($"echarts.min.js not found at {echartsPath}");
    return 1;
}
var echartsJs = File.ReadAllText(echartsPath);

var browser = await Puppeteer.LaunchAsync(new LaunchOptions
{
    ExecutablePath = FindBrowser() ?? throw new Exception("No Chromium/Edge found"),
    Args = new[] { "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage" },
});

var Palette = new[]
{
    "#118DFF", "#12239E", "#E66C37", "#6B007B", "#01B8AA",
    "#E044A7", "#744EC2", "#D9B300", "#37157D", "#3FC1C9"
};

int made = 0;
try
{
    foreach (var c in charts)
    {
        var outPath = Path.IsPathRooted(c.Out) ? c.Out : Path.Combine(bookRoot, c.Out);
        Directory.CreateDirectory(Path.GetDirectoryName(outPath)!);

        var optionJs = BuildOption(c, Palette);
        var html = CardHtml(c, echartsJs, optionJs);
        var tmp = Path.Combine(Path.GetTempPath(), $"chart-{Guid.NewGuid():N}.html");
        File.WriteAllText(tmp, html, new UTF8Encoding(false));
        try
        {
            await using var page = await browser.NewPageAsync();
            await page.SetViewportAsync(new ViewPortOptions { Width = 1100, Height = 680, DeviceScaleFactor = 2 });
            await page.GoToAsync(new Uri(tmp).AbsoluteUri,
                new NavigationOptions { WaitUntil = new[] { WaitUntilNavigation.Load } });
            await page.EvaluateExpressionAsync("document.fonts && document.fonts.ready");
            await Task.Delay(400); // let ECharts finish a synchronous draw
            await page.ScreenshotAsync(outPath, new ScreenshotOptions { Type = ScreenshotType.Png, FullPage = false });
            Console.WriteLine($"{c.Type,-6} -> {c.Out}  ({c.Labels.Length} pts)");
            made++;
        }
        finally { try { File.Delete(tmp); } catch { } }
    }
}
finally { await browser.CloseAsync(); }

Console.WriteLine($"rendered {made} chart(s)");
return 0;

static string BuildOption(Chart c, string[] palette)
{
    var labels = JsonSerializer.Serialize(c.Labels);
    var values = JsonSerializer.Serialize(c.Values);
    var colors = JsonSerializer.Serialize(palette);
    int n = c.Labels.Length;
    bool longish = c.Labels.Any(l => l.Length > 8);
    int rotate = n >= 10 ? 42 : (n >= 6 || longish ? 28 : 0);
    string type = c.Type.ToLowerInvariant();

    if (type == "line")
    {
        return $$"""
        {
          animation: false,
          grid: { left: 70, right: 40, top: 30, bottom: 60, containLabel: true },
          xAxis: { type: 'category', boundaryGap: false, data: {{labels}},
                   axisLabel: { fontSize: 13, color: '#41586b' },
                   axisLine: { lineStyle: { color: '#c7d2dd' } } },
          yAxis: { type: 'value', axisLabel: { fontSize: 12, color: '#8a99a8',
                   formatter: function(v){ return v.toLocaleString('en-US'); } },
                   splitLine: { lineStyle: { color: '#e6ebf1' } } },
          series: [{ type: 'line', data: {{values}}, smooth: true, symbol: 'circle', symbolSize: 8,
                    lineStyle: { width: 3.5, color: '#118DFF' },
                    itemStyle: { color: '#118DFF' },
                    areaStyle: { color: { type:'linear', x:0,y:0,x2:0,y2:1,
                       colorStops:[{offset:0,color:'rgba(17,141,255,0.28)'},{offset:1,color:'rgba(17,141,255,0.02)'}] } },
                    label: { show: true, position: 'top', fontSize: 11, color: '#274156',
                       formatter: function(p){ return p.value.toLocaleString('en-US'); } } }]
        }
        """;
    }

    if (type == "donut" || type == "pie")
    {
        return $$"""
        {
          animation: false,
          legend: { orient: 'vertical', right: 24, top: 'middle',
                    textStyle: { fontSize: 15, color: '#33506a' }, itemGap: 14 },
          series: [{ type: 'pie', radius: ['46%', '72%'], center: ['34%', '52%'],
                    avoidLabelOverlap: true,
                    itemStyle: { borderColor: '#ffffff', borderWidth: 3 },
                    label: { show: true, formatter: '{b}: {d}%', fontSize: 14, color: '#274156' },
                    labelLine: { length: 14, length2: 14 },
                    data: {{labels}}.map(function(name, i){ return { name: name, value: {{values}}[i],
                       itemStyle: { color: {{colors}}[i % {{colors}}.length] } }; }) }]
        }
        """;
    }

    // bar (default)
    return $$"""
    {
      animation: false,
      grid: { left: 70, right: 30, top: 34, bottom: 90, containLabel: true },
      xAxis: { type: 'category', data: {{labels}},
               axisLabel: { interval: 0, rotate: {{rotate}}, fontSize: 13, color: '#41586b' },
               axisLine: { lineStyle: { color: '#c7d2dd' } },
               axisTick: { alignWithLabel: true } },
      yAxis: { type: 'value', axisLabel: { fontSize: 12, color: '#8a99a8',
               formatter: function(v){ return v.toLocaleString('en-US'); } },
               splitLine: { lineStyle: { color: '#e6ebf1' } } },
      series: [{ type: 'bar', barMaxWidth: 78,
                data: {{values}}.map(function(v, i){ return { value: v,
                   itemStyle: { color: {{colors}}[i % {{colors}}.length], borderRadius: [5,5,0,0] } }; }),
                label: { show: true, position: 'top', fontSize: 12, fontWeight: 'bold', color: '#274156',
                   formatter: function(p){ return p.value.toLocaleString('en-US'); } } }]
    }
    """;
}

static string CardHtml(Chart c, string echartsJs, string optionJs)
{
    var title = Esc(c.Title ?? "");
    var foot = Esc(c.Footer ?? "AgentBridge  ·  real data from the live Power BI Desktop model");
    return $$"""
<!doctype html><html><head><meta charset="utf-8">
<script>{{echartsJs}}</script>
<style>
*{margin:0;padding:0;box-sizing:border-box}
html,body{width:1100px;height:680px;overflow:hidden;background:#eef1f5;font-family:'Segoe UI',Arial,sans-serif;padding:22px}
.card{width:100%;height:100%;background:#fff;border-radius:16px;box-shadow:0 8px 30px rgba(20,40,60,.14);
  display:flex;flex-direction:column;overflow:hidden}
.head{display:flex;align-items:center;padding:20px 26px 8px;gap:12px;flex:0 0 auto}
.title{font-size:24px;font-weight:700;color:#16324a}
.badge{margin-left:auto;background:#0f2733;color:#8fe9f5;font-size:13px;font-weight:700;padding:6px 12px;border-radius:20px}
.chart{flex:1 1 auto;width:100%;min-height:0}
.foot{flex:0 0 auto;padding:8px 26px 14px;color:#7a8a99;font-size:13px;font-style:italic;border-top:1px solid #eef2f6}
</style></head><body>
<div class="card">
  <div class="head"><div class="title">{{title}}</div><div class="badge">PowerBITool</div></div>
  <div id="chart" class="chart"></div>
  <div class="foot">{{foot}}</div>
</div>
<script>
var el = document.getElementById('chart');
var chart = echarts.init(el, null, { devicePixelRatio: 2 });
chart.setOption({{optionJs}});
</script>
</body></html>
""";
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

static string ResolveBookRoot(string manifestPath)
{
    var dir = Path.GetDirectoryName(Path.GetFullPath(manifestPath))!;
    for (int i = 0; i < 8; i++)
    {
        if (File.Exists(Path.Combine(dir, "book.json"))) return dir;
        var parent = Path.GetDirectoryName(dir);
        if (parent is null) break;
        dir = parent;
    }
    return Directory.GetCurrentDirectory();
}

static string Esc(string s) => HtmlEncoder.Create(UnicodeRanges.All).Encode(s);

record Chart
{
    public string Out { get; set; } = "";
    public string? Title { get; set; }
    public string Type { get; set; } = "bar";
    public string[] Labels { get; set; } = Array.Empty<string>();
    public double[] Values { get; set; } = Array.Empty<double>();
    public string? Footer { get; set; }
}
