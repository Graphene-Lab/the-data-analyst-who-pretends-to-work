# A Note About the Tool Behind This Book

This book is about a job: the data analyst. It is about what that job really is,
where it came from, and where it is going. It uses plain words. You do not need a
degree in mathematics or computer science to follow it. If you run a small
business, keep your own numbers, or just like understanding how things work, this
book is for you.

Here is the honest part. Every single example you will see in this book — every
table, every measure, every chart, every "watch this" moment — was made with a
real tool, not typed by hand. That tool is **PowerBITool**, running inside
**AgentBridge**.

## What are AgentBridge and PowerBITool?

**AgentBridge** is an AI assistant that runs on your own computer. You talk to it
the way you would talk to a colleague: in ordinary sentences. It listens, it
thinks, and it does the work.

**PowerBITool** is a plugin that gives AgentBridge hands inside
**Microsoft Power BI Desktop** — the popular program people use to build dashboards
and reports. With PowerBITool, the assistant can open your data model, add tables,
create measures, connect tables together, run queries, check your work, and take a
screenshot of what it made — all while you watch it happen on your own screen.

No cloud. No uploading your company's data to a stranger's server. It works with
the Power BI Desktop already on your machine.

```
You  →  AgentBridge  →  PowerBITool  →  your Power BI Desktop (on your PC)
```

## How to get it (it is free)

PowerBITool is free and open. To try it yourself:

1. Install **AgentBridge** (free) from the GitHub page below.
2. Add the **PowerBITool** plugin to it.
3. Open a report in **Power BI Desktop**.
4. Start talking to your assistant.

Scan this code with your phone camera to open the PowerBITool page, where you will
find the download and simple, step-by-step install instructions:

![PowerBITool on GitHub](../../assets/qr-powerbitool-repo.png)

**github.com/Graphene-Lab/PowerBITool**

You can also just type that address into a browser.

## Stuck? Real people answer in 24 hours — for free

Here is something we are proud of. PowerBITool is free, and so is the help that
comes with it. If something does not work, or you want a feature, or you simply
found a bug, you open an **issue** on the same GitHub page and our technicians
answer — usually within **24 hours**, and with a real fix, not a canned reply.

Scan this code to reach the issues page and see how it works:

![Report an issue to PowerBITool](../../assets/qr-powerbitool-issues.png)

**github.com/Graphene-Lab/PowerBITool/issues**

That is the whole promise: a free tool, free support, real humans, fast answers.

## How to read this book

You do not need to install anything to enjoy this book. Read it like a story if
you like. But if you want to try things as you go — and we hope you will — each
hands-on example shows two things:

- **What a person typed** to the assistant (one or two ordinary sentences).
- **What came back** (the real result, from the real tool).

The pictures in this book show that exchange: the question on the right, the
answer from PowerBITool on the left, exactly as it appears in AgentBridge.

## About the images in this book

You will see two kinds of pictures.

**Chat panels** show the exchange itself: what a person typed, and the real result
PowerBITool returned from the live model.

**Chart images** show that same real data *visualised* — bar, line, and donut
charts drawn from the actual numbers the tool returned (sales by category, top
customers, the monthly trend, and so on). They are rendered visualisations of the
real captured output, so you can see the data as a picture, not only as text.

One honest note about Power BI Desktop itself. Power BI renders this same data on
its own report canvas, and the tool can capture that canvas as a PNG
(`CaptureReportScreenshot`, over the Power BI Desktop Bridge). That capture needs a
report with visuals already built in the Power BI Desktop window. This book was
produced in an environment without a GUI-built report, so the chart images here are
rendered from the real data rather than screen-captured from Power BI. The
procedure to capture authentic Power BI Desktop screenshots ships with the tool,
and you can drop those captures straight into these same spots.

Let's begin with the job itself.

*— Graphene Lab*
