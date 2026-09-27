using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json;
using PuppeteerSharp;
using PowerBIToolNS;

// BookBuild engine: sets up a realistic retail model in the LIVE Power BI Desktop,
// runs 100+ example operations through PowerBITool (capturing the real result of
// each and logging every call for bug-hunting), then renders a clean AgentBridge
// chat panel PNG per example and writes results.json for the manuscript.

var tool = new PowerBITool();
var bookRoot = ResolveBookRoot();
var exDir = Path.Combine(bookRoot, "assets", "examples");
Directory.CreateDirectory(exDir);
var logPath = Path.Combine(bookRoot, "tools", "bookbuild", "bookbuild.log");
var resultsPath = Path.Combine(bookRoot, "tools", "bookbuild", "results.json");
var log = new StringBuilder($"BookBuild run {DateTime.Now:O}\n");

Console.WriteLine("Waiting for the Power BI Desktop engine…");
bool up = false;
for (int i = 0; i < 60; i++)
{
    if (!tool.ListOpenReports().StartsWith("Error")) { up = true; break; }
    Thread.Sleep(2000);
}
if (!up) { Console.Error.WriteLine("Power BI Desktop engine not found. Open a report and retry."); return 1; }

var conn = tool.ConnectPowerBiDesktop();
Console.WriteLine(conn);
log.AppendLine("CONNECT: " + conn);

// ---- clean slate (also clears any tables left by earlier harness runs) ----
foreach (var (f, fc, t, tc) in new[]
{
    ("Sales","ProductID","Products","ProductID"),
    ("Sales","CustomerID","Customers","CustomerID"),
    ("Sales","StoreID","Stores","StoreID"),
    ("Sales","RegionId","Region","RegionId"),
    ("Sales","ProductId","Product","ProductId"),
})
    for (int i = 0; i < 3; i++) if (tool.DeleteRelationship(f, fc, t, tc).StartsWith("Error")) break;
foreach (var t in new[] { "Sales", "Products", "Product", "Customers", "Stores", "Region", "SalesByCategory", "CategoryPerf" })
    tool.DeleteTable(t);

// ---- build the demo model ----
string DT(string cols, IEnumerable<string> rows) => $"DATATABLE({cols}, {{ {string.Join(",", rows)} }})";

var products = new (int id, string name, string cat, double price)[]
{
    (1,"Espresso Machine","Kitchen",249.00),(2,"Coffee Grinder","Kitchen",89.00),
    (3,"Ceramic Mug Set","Kitchen",24.00),(4,"Wireless Kettle","Kitchen",59.00),
    (5,"Office Chair","Furniture",189.00),(6,"Standing Desk","Furniture",349.00),
    (7,"Desk Lamp","Furniture",39.00),(8,"Notebook Pack","Stationery",12.00),
};
var priceOf = products.ToDictionary(p => p.id, p => p.price);

var customers = new (int id, string name, string city, string seg)[]
{
    (1,"Anna Ricci","Milan","Business"),(2,"Luca Bianchi","Milan","Retail"),
    (3,"Sara Greco","Rome","Online"),(4,"Marco Rossi","Rome","Business"),
    (5,"Giulia Conti","Turin","Retail"),(6,"Paolo Esposito","Naples","Online"),
    (7,"Elena Gallo","Milan","Online"),(8,"Davito Costa","Rome","Retail"),
    (9,"Chiara Fontana","Turin","Business"),(10,"Andrea Marini","Naples","Business"),
    (11,"Martina Rizzo","Milan","Retail"),(12,"Simone Leone","Rome","Online"),
};

var stores = new (int id, string name, string city, string region)[]
{
    (1,"Milan Central","Milan","North"),(2,"Rome Downtown","Rome","Center"),
    (3,"Turin West","Turin","North"),(4,"Naples Bay","Naples","South"),
};

var rnd = new Random(42);
var salesRows = new List<string>();
for (int i = 1; i <= 60; i++)
{
    int pid = rnd.Next(1, 9);
    int cid = rnd.Next(1, 13);
    int sid = rnd.Next(1, 5);
    int qty = rnd.Next(1, 6);
    int year = rnd.Next(2024, 2026);
    int month = rnd.Next(1, 13);
    int day = rnd.Next(1, 28);
    int dateKey = year * 10000 + month * 100 + day;
    double amount = Math.Round(priceOf[pid] * qty, 2);
    salesRows.Add($"{{{i},{dateKey},{pid},{cid},{sid},{amount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)},{qty}}}");
}

string productsD = DT("\"ProductID\", INTEGER, \"Name\", STRING, \"Category\", STRING, \"Price\", DOUBLE",
    products.Select(p => $"{{{p.id},\"{p.name}\",\"{p.cat}\",{p.price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}}}"));
string customersD = DT("\"CustomerID\", INTEGER, \"Name\", STRING, \"City\", STRING, \"Segment\", STRING",
    customers.Select(c => $"{{{c.id},\"{c.name}\",\"{c.city}\",\"{c.seg}\"}}"));
string storesD = DT("\"StoreID\", INTEGER, \"Name\", STRING, \"City\", STRING, \"Region\", STRING",
    stores.Select(s => $"{{{s.id},\"{s.name}\",\"{s.city}\",\"{s.region}\"}}"));
string salesD = DT("\"SaleId\", INTEGER, \"DateKey\", INTEGER, \"ProductID\", INTEGER, \"CustomerID\", INTEGER, \"StoreID\", INTEGER, \"Amount\", DOUBLE, \"Qty\", INTEGER",
    salesRows);

log.AppendLine("SETUP Products: " + tool.CreateCalculatedTable("Products", productsD));
log.AppendLine("SETUP Customers: " + tool.CreateCalculatedTable("Customers", customersD));
log.AppendLine("SETUP Stores: " + tool.CreateCalculatedTable("Stores", storesD));
log.AppendLine("SETUP Sales: " + tool.CreateCalculatedTable("Sales", salesD));
// base measures other examples build on (single-table, no relationships needed yet)
log.AppendLine("SETUP m TotalSales: " + tool.CreateMeasure("Sales", "Total Sales", "SUM(Sales[Amount])", "#,##0.00 €", "Total revenue"));
log.AppendLine("SETUP m TotalQty: " + tool.CreateMeasure("Sales", "Total Qty", "SUM(Sales[Qty])", "#,##0", "Units sold"));
log.AppendLine("SETUP m Orders: " + tool.CreateMeasure("Sales", "Orders", "DISTINCTCOUNT(Sales[SaleId])", "#,##0", "Number of sales"));

// ---- example definitions ----
var ex = new List<Ex>();
void E(string id, string ch, string prompt, string caption, Func<string> run)
    => ex.Add(new Ex(id, ch, prompt, caption, run));

// Ch1 / Ch16 / Ch17 — connect & see
E("e001","1","Connect to Power BI Desktop and list the tables in my model.","One sentence reads the whole live model.",()=>tool.ConnectPowerBiDesktop()+"\n\n"+tool.ListTables());
E("e002","16","Give me a summary of the model.","A high-level overview: tables, measures, relationships, rows.",()=>tool.GetModelSummary());
E("e003","17","Which Power BI reports are open right now?","Discovery: see every open report and its port.",()=>tool.ListOpenReports());
E("e004","17","What is the connection status?","Am I connected, and to what?",()=>tool.GetConnectionStatus());
E("e005","16","List every table with its row count.","The building blocks of the model.",()=>tool.ListTables());

// Ch6 — data sources & profiling
E("e006","6","Profile the Products table.","Distinct values, blanks, min/max, top values, samples.",()=>tool.ProfileTable("Products", 5, 3));
E("e007","6","Profile the Customers table.","See who is in the data at a glance.",()=>tool.ProfileTable("Customers", 4, 2));
E("e008","6","Show me the schema of the Sales table.","Every column, type, and role.",()=>tool.GetTableSchema("Sales"));
E("e009","6","What columns does Products have?","Column names and data types.",()=>tool.GetTableSchema("Products"));
E("e010","6","Profile the Stores table.","How many stores, where they are.",()=>tool.ProfileTable("Stores"));

// Ch7 — cleaning
E("e011","7","Add a column with the category in capital letters.","Standardise text so it groups cleanly.",()=>tool.CreateCalculatedColumn("Products","CategoryUpper","String","UPPER(Products[Category])"));
E("e012","7","Bucket products into High / Mid / Low by price.","Turn a number into a usable category.",()=>tool.CreateCalculatedColumn("Products","PriceBand","String","IF(Products[Price] >= 200, \"High\", IF(Products[Price] >= 50, \"Mid\", \"Low\"))"));
E("e013","7","Make a customer label like 'Name (City)'.","Combine fields into one friendly label.",()=>tool.CreateCalculatedColumn("Customers","Label","String","Customers[Name] & \" (\" & Customers[City] & \")\""));
E("e014","7","Check this price-band formula before I save it.","Validate the DAX first, create it second.",()=>tool.ValidateDax("Products","IF(Products[Price] >= 200, \"High\", \"Low\")"));

// Ch8 — modelling
E("e015","8","Connect Sales to Products on ProductID.","A relationship so product data flows into sales.",()=>tool.CreateRelationship("Sales","ProductID","Products","ProductID"));
E("e016","8","Connect Sales to Customers on CustomerID.","Link each sale to the customer who made it.",()=>tool.CreateRelationship("Sales","CustomerID","Customers","CustomerID"));
E("e017","8","Connect Sales to Stores on StoreID.","Tie each sale to the store it happened in.",()=>tool.CreateRelationship("Sales","StoreID","Stores","StoreID"));
E("e018","8","Show all the relationships in the model.","The wiring diagram of the data.",()=>tool.ListRelationships());
E("e019","8","Build a small table of total sales per category.","A calculated table that summarises on the fly.",()=>tool.CreateCalculatedTable("SalesByCategory","SUMMARIZE(Products, Products[Category], \"Total\", SUM(Sales[Amount]))"));

// Ch9 — SQL & DAX queries
E("e020","9","How many rows are in Sales?","A simple count, run as DAX.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Sales rows\", COUNTROWS(Sales))"));
E("e021","9","What is the total of the Amount column?","Summing a column with DAX.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Total amount\", SUM(Sales[Amount]))"));
E("e022","9","Top 3 products by total sales.","Ranking with TOPN.",()=>tool.RunDaxQuery("EVALUATE TOPN(3, SUMMARIZECOLUMNS(Products[Name], \"s\", [Total Sales]), \"s\", DESC)"));
E("e023","9","Show me sales bigger than 500.","Filtering rows with DAX.",()=>tool.RunDaxQuery("EVALUATE FILTER(Sales, Sales[Amount] > 500)"));
E("e024","9","Total sales by store city.","Grouping across a relationship.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Stores[City], \"sales\", [Total Sales])"));
E("e025","9","For each sale, show the product name.","Pulling a related value with RELATED.",()=>tool.RunDaxQuery("EVALUATE TOPN(5, SELECTCOLUMNS(Sales, \"Sale\", Sales[SaleId], \"Product\", RELATED(Products[Name])))"));

// Ch11 — metrics
E("e026","11","Create a Total Sales measure with a euro format.","The most basic, most important measure.",()=>tool.CreateMeasure("Sales","Total Sales EUR","SUM(Sales[Amount])","#,##0 €","Total revenue in euros"));
E("e027","11","Create a measure for units sold.","Counting quantity, not money.",()=>tool.CreateMeasure("Sales","Units Sold","SUM(Sales[Qty])","#,##0","Units sold"));
E("e028","11","Create an average order value measure.","Revenue divided by orders, safely.",()=>tool.CreateMeasure("Sales","Avg Order Value","DIVIDE([Total Sales], [Orders])","#,##0.00 €","Average value per order"));
E("e029","11","How many active customers do we have?","Distinct customers in the sales.",()=>tool.CreateMeasure("Sales","Active Customers","DISTINCTCOUNT(Sales[CustomerID])","#,##0","Customers who bought"));
E("e030","11","What is the biggest single sale?","A MAX measure.",()=>tool.CreateMeasure("Sales","Largest Sale","MAX(Sales[Amount])","#,##0.00 €","Biggest single line"));

// Ch12 — four kinds of analysis
E("e031","12","Descriptive: total sales by region.","What happened, by region.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Stores[Region], \"sales\", [Total Sales])"));
E("e032","12","Diagnostic: which category earns the most?","Where the money comes from.",()=>tool.RunDaxQuery("EVALUATE TOPN(4, SUMMARIZECOLUMNS(Products[Category], \"s\", [Total Sales]), \"s\", DESC)"));
E("e033","12","Compare North vs Center sales.","A side-by-side diagnostic.",()=>tool.RunDaxQuery("EVALUATE ROW(\"North\", CALCULATE([Total Sales], Stores[Region]=\"North\"), \"Center\", CALCULATE([Total Sales], Stores[Region]=\"Center\"))"));
E("e034","12","Rank products by sales.","RANKX for a leaderboard.",()=>tool.RunDaxQuery("EVALUATE TOPN(3, ADDCOLUMNS(SUMMARIZECOLUMNS(Products[Name], \"s\", [Total Sales]), \"rank\", RANKX(ALL(Products), [Total Sales])), \"s\", DESC)"));

// Ch13 — customers
E("e035","13","Add a per-customer sales measure.","Each customer's total spend.",()=>tool.CreateMeasure("Customers","Customer Sales","CALCULATE([Total Sales])","#,##0.00 €","Total spent by this customer"));
E("e036","13","Top 5 customers by spend.","Who your best customers are.",()=>tool.RunDaxQuery("EVALUATE TOPN(5, SUMMARIZECOLUMNS(Customers[Name], \"s\", [Total Sales]), \"s\", DESC)"));
E("e037","13","Sales split by customer city.","Geographic segmentation.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Customers[City], \"sales\", [Total Sales], \"cust\", DISTINCTCOUNT(Customers[CustomerID]))"));
E("e038","13","Sales by customer segment.","Retail vs Business vs Online.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Customers[Segment], \"sales\", [Total Sales])"));

// Ch14 — trends
E("e039","14","Add a Year column from the date.","Extract the year for grouping.",()=>tool.CreateCalculatedColumn("Sales","Year","Int64","INT(Sales[DateKey] / 10000)"));
E("e040","14","Add a Month column from the date.","Extract the month for grouping.",()=>tool.CreateCalculatedColumn("Sales","Month","Int64","INT(MOD(Sales[DateKey], 10000) / 100)"));
E("e041","14","Total sales per year.","A year-over-year view.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Sales[Year], \"sales\", [Total Sales])"));
E("e042","14","Total sales per month.","A monthly trend.",()=>tool.RunDaxQuery("EVALUATE TOPN(12, SUMMARIZECOLUMNS(Sales[Month], \"sales\", [Total Sales]), \"sales\", DESC)"));
E("e043","14","Sales in 2025 only.","Filtering a period with CALCULATE.",()=>tool.RunDaxQuery("EVALUATE ROW(\"2025 sales\", CALCULATE([Total Sales], Sales[Year] = 2025))"));

// Ch16 / Ch18 — dictionary, descriptions, best practices
E("e044","16","Generate a data dictionary for the whole model.","Documentation, written for you.",()=>tool.GenerateDataDictionary());
E("e045","18","Generate a data dictionary for Products only.","One table, fully documented.",()=>tool.GenerateDataDictionary("Products"));
E("e046","18","Add a description to the Sales table.","Document what a table means.",()=>tool.SetDescription("Sales","One row per sale line item."));
E("e047","18","Describe the Amount column.","Document what a column means.",()=>tool.SetDescription("Sales","Line value in euros.", columnName:"Amount"));
E("e048","18","Check the model against best practices.","A health check with warnings and tips.",()=>tool.AnalyzeBestPractices());

// Ch19 — DAX skills
E("e049","19","Is this a valid measure? SUM(Sales[Amount])","Validate before you commit.",()=>tool.ValidateDax("Sales","SUM(Sales[Amount])"));
E("e050","19","Check this broken formula: SUMX(Sales[Amount])","Catch mistakes early.",()=>tool.ValidateDax("Sales","SUMX(Sales[Amount])"));
E("e051","19","Lint this DAX: SUM(a)/SUM(b)","Spot the risky division.",()=>tool.LintDax("SUM(Sales[Amount]) / SUM(Sales[Qty])"));
E("e052","19","Lint this clean DAX with DIVIDE.","A safe pattern passes.",()=>tool.LintDax("DIVIDE(SUM(Sales[Amount]), SUM(Sales[Qty]))"));
E("e053","19","Create a Milan-only sales measure.","CALCULATE to filter a measure.",()=>tool.CreateMeasure("Sales","Milan Sales","CALCULATE([Total Sales], Stores[City] = \"Milan\")","#,##0.00 €","Sales in Milan"));
E("e054","19","Change the format of Total Sales to whole euros.","Update a measure's format.",()=>tool.UpdateMeasure("Sales","Total Sales", formatString:"#,##0 €"));
E("e055","19","Delete the Milan Sales measure.","Remove what you no longer need.",()=>tool.DeleteMeasure("Sales","Milan Sales"));

// Ch11/12 — more metrics
E("e056","11","Add a cost column and a margin measure.","Margin = revenue minus cost.",()=>tool.CreateCalculatedColumn("Products","Cost","Double","Products[Price] * 0.6"));
E("e057","11","Total margin across all sales.","Gross margin as a measure.",()=>tool.CreateMeasure("Sales","Total Margin","SUMX(Sales, Sales[Amount] - RELATED(Products[Cost]))","#,##0.00 €","Gross margin"));
E("e058","11","Share of total sales, as a percentage.","Part over whole with ALL().",()=>tool.CreateMeasure("Sales","Pct Of Total","DIVIDE([Total Sales], CALCULATE([Total Sales], ALL(Sales)))","0.0%","Share of total"));
E("e059","12","Average quantity per sale.","A quick operational metric.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Avg qty per sale\", AVERAGE(Sales[Qty]))"));

// Ch20/21 — preparing chart data (measures that feed visuals)
E("e060","20","Give me sales by category for a bar chart.","Data shaped for a visual.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Products[Category], \"sales\", [Total Sales])"));
E("e061","20","Sales by region for a map or column chart.","Regional breakdown.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Stores[Region], \"sales\", [Total Sales])"));
E("e062","21","A KPI set: total sales, orders, avg order.","Three numbers for a KPI card row.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Total Sales\", [Total Sales], \"Orders\", [Orders], \"Avg Order\", [Avg Order Value])"));
E("e063","21","Top products for a leaderboard visual.","Ranked list for a report.",()=>tool.RunDaxQuery("EVALUATE TOPN(5, SUMMARIZECOLUMNS(Products[Name], \"sales\", [Total Sales]), \"sales\", DESC)"));

// Ch22/23/24 — agentic workflows (each: a natural ask, the tool does the work)
E("e064","23","Meet PowerBITool: what can you do with my model?","A capability check.",()=>tool.GetModelSummary());
E("e065","24","Build a category performance table with sales and product count.","A mini report table, made in one ask.",()=>tool.CreateCalculatedTable("CategoryPerf","SUMMARIZE(Products, Products[Category], \"Products\", COUNTROWS(Products), \"Sales\", SUM(Sales[Amount]))"));
E("e066","24","Create a KPI measure set for the dashboard.","Several measures in one go.",()=>tool.CreateMeasure("Sales","Sales per Customer","DIVIDE([Total Sales], [Active Customers])","#,##0.00 €","Revenue per customer"));
E("e067","24","Validate a batch of measures before I build the report.","Batch validation.",()=>tool.ValidateMeasures("[{\"table\":\"Sales\",\"name\":\"a\",\"expression\":\"SUM(Sales[Amount])\"},{\"table\":\"Sales\",\"name\":\"b\",\"expression\":\"COUNTROWS(Sales)\"}]"));
E("e068","24","Document everything and check best practices.","Docs + health check together.",()=>tool.GenerateDataDictionary()+"\n\n"+tool.AnalyzeBestPractices());
E("e069","22","Ask in plain English, get a real model change.","The agentic promise in one line.",()=>tool.CreateMeasure("Sales","Big Sales Count","COUNTROWS(FILTER(Sales, Sales[Amount] > 300))","#,##0","Sales over 300"));
E("e070","24","Which products never sold?","Finding gaps in the data.",()=>tool.RunDaxQuery("EVALUATE EXCEPT(VALUES(Products[Name]), CALCULATETABLE(VALUES(Products[Name]), NOT(ISBLANK(Sales[Amount]))))"));

// More spread examples to exceed 100
E("e071","6","How many distinct categories are there?","Counting distinct values.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Categories\", DISTINCTCOUNT(Products[Category]))"));
E("e072","7","Any blank cities in the customer list?","Hunting missing values.",()=>tool.RunDaxQuery("EVALUATE FILTER(Customers, ISBLANK(Customers[City]))"));
E("e073","8","How many relationships now?","Counting the wiring.",()=>tool.ListRelationships());
E("e074","9","Total quantity sold overall.","A single aggregate.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Total qty\", SUM(Sales[Qty]))"));
E("e075","11","Average unit price paid.","Price per unit across sales.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Avg unit price\", DIVIDE([Total Sales], [Total Qty]))"));
E("e076","12","Best month overall.","Peak period.",()=>tool.RunDaxQuery("EVALUATE TOPN(1, SUMMARIZECOLUMNS(Sales[Month], \"s\", [Total Sales]), \"s\", DESC)"));
E("e077","13","Customers in Milan only.","A simple segment.",()=>tool.RunDaxQuery("EVALUATE FILTER(Customers, Customers[City] = \"Milan\")"));
E("e078","14","Sales for the first half of a year.","Period filtering.",()=>tool.RunDaxQuery("EVALUATE ROW(\"H1 2025\", CALCULATE([Total Sales], Sales[Year]=2025, Sales[Month]<=6))"));
E("e079","16","What measures exist in Sales?","List the measures.",()=>tool.GetTableSchema("Sales"));
E("e080","18","Set a description on the Products table.","Documenting as you go.",()=>tool.SetDescription("Products","Product catalogue with price and category."));
E("e081","19","Validate a CALCULATE measure.","Checking a filtered measure.",()=>tool.ValidateDax("Sales","CALCULATE([Total Sales], Products[Category]=\"Kitchen\")"));
E("e082","19","Lint a measure that uses IFERROR.","Spot a swallow-errors pattern.",()=>tool.LintDax("IFERROR([Total Sales], 0)"));
E("e083","20","Category share for a pie chart.","Parts of a whole.",()=>tool.RunDaxQuery("EVALUATE ADDCOLUMNS(SUMMARIZECOLUMNS(Products[Category], \"s\", [Total Sales]), \"share\", DIVIDE([s], CALCULATE(SUM(Sales[Amount]), ALL(Products))))"));
E("e084","21","A single big-number KPI.","One number, big font.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Total Sales\", [Total Sales])"));
E("e085","24","Create a returning-customer flag.","A calculated column for behaviour.",()=>tool.CreateCalculatedColumn("Sales","IsRepeat","Boolean","CALCULATE(COUNTROWS(Sales), ALLEXCEPT(Sales, Sales[CustomerID])) > 1"));
E("e086","22","Turn a question into a measure automatically.","Ask, don't code.",()=>tool.CreateMeasure("Products","Avg Product Price","AVERAGE(Products[Price])","#,##0.00 €","Average list price"));
E("e087","24","Give me the top store by sales.","Best performer.",()=>tool.RunDaxQuery("EVALUATE TOPN(1, SUMMARIZECOLUMNS(Stores[Name], \"s\", [Total Sales]), \"s\", DESC)"));
E("e088","9","Count sales with quantity above 3.","Conditional count.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Big-qty sales\", COUNTROWS(FILTER(Sales, Sales[Qty] > 3)))"));
E("e089","11","Total sales excluding a category.","Subtracting a slice.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Excl Furniture\", CALCULATE([Total Sales], NOT(Products[Category]=\"Furniture\")))"));
E("e090","13","Average spend per business customer.","Segment metric.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Avg business spend\", CALCULATE([Total Sales], Customers[Segment]=\"Business\") / CALCULATE(DISTINCTCOUNT(Customers[CustomerID]), Customers[Segment]=\"Business\"))"));
E("e091","14","Month with the fewest sales.","The slow period.",()=>tool.RunDaxQuery("EVALUATE TOPN(1, SUMMARIZECOLUMNS(Sales[Month], \"s\", [Total Sales]), \"s\", ASC)"));
E("e092","16","Full model summary again, after all changes.","The model has grown.",()=>tool.GetModelSummary());
E("e093","18","Best practices after adding measures.","Re-check health.",()=>tool.AnalyzeBestPractices());
E("e094","19","Validate a percentage measure.","Percent format check.",()=>tool.ValidateDax("Sales","DIVIDE([Total Sales], CALCULATE([Total Sales], ALL(Sales)))"));
E("e095","24","Create a high-value customer measure.","Targeting high spenders.",()=>tool.CreateMeasure("Customers","High Value Flag","IF([Customer Sales] > 1000, 1, 0)","0","High-value customer"));
E("e096","22","Ask for a new column, get it live.","The live loop.",()=>tool.CreateCalculatedColumn("Sales","AmountBand","String","IF(Sales[Amount]>500,\"High\",IF(Sales[Amount]>100,\"Mid\",\"Low\"))"));
E("e097","24","Sales by price band.","Using the band we just made.",()=>tool.RunDaxQuery("EVALUATE SUMMARIZECOLUMNS(Products[PriceBand], \"sales\", [Total Sales])"));
E("e098","21","A compact KPI row for the top of a report.","Cards across the top.",()=>tool.RunDaxQuery("EVALUATE ROW(\"Sales\", [Total Sales], \"Customers\", [Active Customers], \"Orders\", [Orders])"));
E("e099","24","Document the final model.","A clean dictionary at the end.",()=>tool.GenerateDataDictionary());
E("e100","24","Final health check of the whole model.","Everything checked.",()=>tool.AnalyzeBestPractices());
E("e101","22","One sentence, one real change, visible instantly.","The whole book in one line.",()=>tool.CreateMeasure("Sales","Kitchen Sales","CALCULATE([Total Sales], Products[Category]=\"Kitchen\")","#,##0.00 €","Kitchen category sales"));
E("e102","24","Show the final list of tables.","The finished model.",()=>tool.ListTables());

// ---- run all examples, capture results, log ----
int ok = 0, bad = 0;
var results = new List<Res>();
foreach (var e in ex)
{
    string res;
    try { res = e.Run() ?? "(null)"; }
    catch (Exception exx) { res = "EXCEPTION: " + (exx.InnerException ?? exx).Message; }
    bool good = !res.StartsWith("Error") && !res.StartsWith("EXCEPTION");
    if (good) ok++; else bad++;
    log.AppendLine($"\n[{DateTime.Now:HH:mm:ss}] {e.Id} (ch{e.Ch}) prompt=\"{e.Prompt}\"\n  -> {res}");
    results.Add(new Res(e.Id, e.Ch, e.Prompt, e.Caption, res, good));
    Console.WriteLine($"{e.Id} ch{e.Ch} {(good ? "OK" : "CHECK")}  {e.Prompt}");
}

// ---- render chat panels ----
var browser = await Puppeteer.LaunchAsync(new LaunchOptions
{
    ExecutablePath = FindBrowser() ?? throw new Exception("No Chromium/Edge found"),
    Args = new[] { "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage" },
});
try
{
    foreach (var r in results)
    {
        var outPath = Path.Combine(exDir, r.Id + ".png");
        var html = ChatHtml(r.Prompt, Trim(r.Result, 900), r.Caption);
        var tmp = Path.Combine(Path.GetTempPath(), $"bb-{Guid.NewGuid():N}.html");
        File.WriteAllText(tmp, html, new UTF8Encoding(false));
        try
        {
            await using var page = await browser.NewPageAsync();
            await page.SetViewportAsync(new ViewPortOptions { Width = 1000, Height = 640, DeviceScaleFactor = 2 });
            await page.GoToAsync(new Uri(tmp).AbsoluteUri, new NavigationOptions { WaitUntil = new[] { WaitUntilNavigation.Load } });
            await page.EvaluateExpressionAsync("document.fonts && document.fonts.ready");
            await page.ScreenshotAsync(outPath, new ScreenshotOptions { Type = ScreenshotType.Png, FullPage = false });
        }
        finally { try { File.Delete(tmp); } catch { } }
    }
}
finally { await browser.CloseAsync(); }

File.WriteAllText(resultsPath, JsonSerializer.Serialize(results, new JsonSerializerOptions { WriteIndented = true }));
File.AppendAllText(logPath, log.ToString());

Console.WriteLine($"\nExamples: {ok} ok, {bad} need-check. Panels rendered to {exDir}");
Console.WriteLine($"Results: {resultsPath}");
return 0;

static string Trim(string s, int n)
{
    s = s.Replace("\r", "");
    return s.Length <= n ? s : s[..n] + " …";
}
static string FindBrowser()
{
    string[] c = { @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
                   @"C:\Program Files\Microsoft\Edge\Application\msedge.exe",
                   @"C:\Program Files\Google\Chrome\Application\chrome.exe" };
    foreach (var x in c) if (File.Exists(x)) return x;
    return null!;
}
static string ResolveBookRoot()
{
    var dir = AppContext.BaseDirectory;
    for (int i = 0; i < 8; i++)
    {
        if (File.Exists(Path.Combine(dir, "book.json"))) return dir;
        dir = Path.GetDirectoryName(dir)!;
    }
    return Directory.GetCurrentDirectory();
}
static string Esc(string s) => HtmlEncoder.Create(UnicodeRanges.All).Encode(s);

static string ChatHtml(string prompt, string result, string caption)
{
    var cap = string.IsNullOrWhiteSpace(caption) ? "" : $"<div class=\"cap\">{Esc(caption)}</div>";
    return $$"""
<!doctype html><html><head><meta charset="utf-8"><style>
*{margin:0;padding:0;box-sizing:border-box}
html,body{width:1000px;height:640px;overflow:hidden;background:#eef1f5;font-family:'Segoe UI',Arial,sans-serif;padding:22px}
.card{width:100%;height:100%;background:#fff;border-radius:16px;box-shadow:0 8px 30px rgba(20,40,60,.14);overflow:hidden;display:flex;flex-direction:column}
.bar{height:52px;background:#0f2733;display:flex;align-items:center;padding:0 20px;gap:10px;flex:0 0 auto}
.dot{width:11px;height:11px;border-radius:50%}.d1{background:#ff5f57}.d2{background:#febc2e}.d3{background:#28c840}
.title{color:#eafcff;font-weight:700;font-size:16px;margin-left:8px}
.badge{margin-left:auto;background:#1f7f96;color:#eafcff;font-size:12px;font-weight:600;padding:4px 10px;border-radius:20px}
.body{flex:1 1 auto;padding:20px 22px;display:flex;flex-direction:column;gap:16px;overflow:hidden}
.user{align-self:flex-end;max-width:82%;background:#1f7f96;color:#fff;padding:12px 16px;border-radius:14px 14px 4px 14px;font-size:16px;line-height:1.4}
.user .who{display:block;font-size:11px;opacity:.8;margin-bottom:4px;font-weight:600;letter-spacing:.3px}
.res{align-self:stretch;background:#f6f8fa;border:1px solid #e2e8ef;border-radius:12px;overflow:hidden;display:flex;flex-direction:column}
.res .rh{background:#eef3f7;color:#33556b;font-size:12px;font-weight:700;padding:7px 14px;border-bottom:1px solid #e2e8ef}
.res .rh .t{background:#0f2733;color:#8fe9f5;font-size:11px;padding:2px 8px;border-radius:10px;font-weight:700;margin-right:6px}
.res pre{margin:0;padding:12px 16px;font-family:'Consolas','Menlo',monospace;font-size:13px;line-height:1.45;color:#1c2b36;white-space:pre-wrap;word-break:break-word;overflow-wrap:anywhere;overflow:hidden}
.cap{flex:0 0 auto;text-align:center;color:#5a6b7a;font-size:13px;font-style:italic;padding:2px 10px 4px}
</style></head><body>
<div class="card">
  <div class="bar"><span class="dot d1"></span><span class="dot d2"></span><span class="dot d3"></span>
    <span class="title">AgentBridge</span><span class="badge">PowerBITool</span></div>
  <div class="body">
    <div class="user"><span class="who">YOU</span>{{Esc(prompt)}}</div>
    <div class="res"><div class="rh"><span class="t">PowerBITool</span> result</div><pre>{{Esc(result)}}</pre></div>
  </div>
  {{cap}}
</div>
</body></html>
""";
}

record Ex(string Id, string Ch, string Prompt, string Caption, Func<string> Run);
record Res(string Id, string Ch, string Prompt, string Caption, string Result, bool Ok);
