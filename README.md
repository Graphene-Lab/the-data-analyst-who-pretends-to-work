# The Data Analyst Who Pretends to Work

*The Book Your Boss Shouldn't Know Exists*

A practical, plain-English book about what a data analyst really does — and how an
AI assistant changes the job. Every example in the book was produced with
**AgentBridge** driving **PowerBITool** on a live Microsoft Power BI Desktop model:
real actions, real results, no mock-ups.

## What's inside

- `book.json` — book metadata (title, author, languages, cover).
- `books/EN/` — the full English manuscript: preface, 26 chapters, conclusion,
  and 8 appendices (glossary, checklists, real cases, exercises, solutions,
  portfolio model, interview FAQs).
- `assets/` — the cover, the two QR codes, and 100+ example panels rendered from
  real tool output.
- `tools/` — the generators used to build the images and run the examples
  (`imagegen`, `bookbuild`), plus the GitHub pusher (`ghpush`).
- `publish/` — the built reader PDF, EPUB, print PDF, and store cover.

## The tools behind every example

- **AgentBridge** — the local, plain-language AI assistant (the brain).
- **PowerBITool** — the plugin that operates Power BI Desktop (the hands).

PowerBITool is free and open source:
https://github.com/Graphene-Lab/PowerBITool

Need help? Open an issue and a real technician answers within about 24 hours with
a real fix — free:
https://github.com/Graphene-Lab/PowerBITool/issues

## Rebuilding the book

The book is built with [DistroBook](https://github.com/Graphene-Lab):

```
dotnet run --project <DistroBook>/src/DistroBook.Cli -c Release -- \
  prepare --book "<this folder>" --langs EN --force
```

This produces `publish/store/cover-EN.png`, `publish/dap-EN.pdf`,
`publish/dap-EN.epub`, and `publish/print/dap-EN-print.pdf`.

## Languages

The manuscript is authored in English first. Italian, French, Spanish, German, and
Russian conversions follow. The PNG images are English and are not translated in
other-language versions.
