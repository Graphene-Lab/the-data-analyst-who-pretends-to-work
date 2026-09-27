# The Data Analyst Who Pretends to Work

### *The Book Your Boss Shouldn't Know Exists*

**A free, plain-English book about what a data analyst really does — and how an AI assistant changes the job.**

You do not need a degree in mathematics or computer science to work with data. This book explains, in ordinary words, how to think in data, clean it, model it, measure it, and turn it into dashboards people actually use — with **Microsoft Power BI** and an AI assistant (**AgentBridge** driving **PowerBITool**). Every table, measure, and chart in these pages was produced by a real tool working on a real Power BI Desktop model: real actions, real numbers, real charts. No mock-ups, no hand-typed tables.

## Who this book is for

- **Aspiring data analysts** and career changers who want a clear, honest map of the job.
- **Business users and small-business owners** who keep their own numbers and want them to finally make sense.
- **Excel users hitting "the wall"** — too much data, too many crashes — ready to move to Power BI.
- **Anyone curious** about how AI assistants do real analytical work, not just chat.

## What you will learn

- How to **think in data** and turn fuzzy questions into numbers.
- **Statistics without the pain** — the few ideas that actually matter at work.
- How to find, clean, and trust **dirty data**.
- **Data models, tables, and relationships** — and why the star schema wins.
- Asking questions with **SQL and DAX**, in plain English.
- The **metrics that matter**, and the vanity numbers to ignore.
- The **four kinds of analysis**: descriptive, diagnostic, predictive, prescriptive.
- **Power BI in plain English**: connecting, modelling, DAX, and choosing the right chart.
- Building **reports and dashboards people actually use**.
- The **AI-assisted analyst workflow** — what AgentBridge and PowerBITool can do, and what they cannot.
- Your **career** as a data analyst in the age of AI.

## What is inside

- **Part I — The Craft of the Data Analyst** (chapters 1–5)
- **Part II — Data, Quality, and Getting It Ready** (chapters 6–10)
- **Part III — Analysis and Metrics** (chapters 11–15)
- **Part IV — Power BI and Seeing Your Data** (chapters 16–21)
- **Part V — The Agentic Revolution and Your Career** (chapters 22–26)
- **Conclusion**, plus **8 appendices**: a glossary of terms, a data-quality checklist, a dashboard checklist, real cases by sector, guided exercises with full solutions, a portfolio project model, and interview FAQs.

## Read or download

The built book lives in the [`publish/`](publish) folder. Pick your language:

| Language | Reader PDF | EPUB | Print PDF |
|---|---|---|---|
| English | [dap-EN.pdf](publish/dap-EN.pdf) | [dap-EN.epub](publish/dap-EN.epub) | [dap-EN-print.pdf](publish/print/dap-EN-print.pdf) |
| Italiano | [dap-IT.pdf](publish/dap-IT.pdf) | [dap-IT.epub](publish/dap-IT.epub) | [dap-IT-print.pdf](publish/print/dap-IT-print.pdf) |
| Français | [dap-FR.pdf](publish/dap-FR.pdf) | [dap-FR.epub](publish/dap-FR.epub) | [dap-FR-print.pdf](publish/print/dap-FR-print.pdf) |
| Español | [dap-ES.pdf](publish/dap-ES.pdf) | [dap-ES.epub](publish/dap-ES.epub) | [dap-ES-print.pdf](publish/print/dap-ES-print.pdf) |
| Deutsch | [dap-DE.pdf](publish/dap-DE.pdf) | [dap-DE.epub](publish/dap-DE.epub) | [dap-DE-print.pdf](publish/print/dap-DE-print.pdf) |
| Русский | [dap-RU.pdf](publish/dap-RU.pdf) | [dap-RU.epub](publish/dap-RU.epub) | [dap-RU-print.pdf](publish/print/dap-RU-print.pdf) |

Store covers are in [`publish/store/`](publish/store).

## The tool behind every example

- **AgentBridge** — the local, plain-language AI assistant (the brain).
- **PowerBITool** — the free, open-source plugin that operates Microsoft Power BI Desktop (the hands).

Every example was made by talking to the assistant in ordinary sentences while it worked inside Power BI Desktop — on a real PC, with no cloud upload of your data.

**Get PowerBITool (free):** https://github.com/Graphene-Lab/PowerBITool

**Stuck? Open an issue** — a real technician answers within about 24 hours with a real fix, free: https://github.com/Graphene-Lab/PowerBITool/issues

## Available languages

English · Italiano · Français · Español · Deutsch · Русский. The manuscript is authored in English and translated into the other five; the chart images are shared across all editions.

## Repository layout

- `book.json` — book metadata (title, author, languages, cover).
- `books/<LANG>/` — the manuscript for each language (preface, 26 chapters, conclusion, 8 appendices). The `README.md` inside each folder is the table-of-contents order.
- `assets/` — the cover, the QR codes, and the chart panels rendered from real tool output.
- `tools/` — the chart generator (`chartgen`, Apache ECharts) and the GitHub pusher (`ghpush`).
- `publish/` — the built reader PDF, EPUB, print PDF, and store cover, per language.

## Rebuilding the book

Built with [DistroBook](https://github.com/Graphene-Lab):

```
dotnet run --project <DistroBook>/src/DistroBook.Cli -c Release -- \
  prepare --book "<this folder>" --langs EN,IT,FR,ES,DE,RU --force
```

This produces, for each language, `publish/store/cover-<LANG>.png`, `publish/dap-<LANG>.pdf`, `publish/dap-<LANG>.epub`, and `publish/print/dap-<LANG>-print.pdf`.
