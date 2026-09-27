# 16. Power BI in Plain English

You have heard the name. This chapter strips Power BI down to what it actually is,
without the marketing fog — and shows how the assistant talks to it directly.

## What Power BI actually is

Power BI is Microsoft's tool for turning data into **dashboards and reports** that
people can look at, click on, and explore. It has three main parts:

- **Power BI Desktop** — the free program on your PC where you build the model and
  the report. This is where the assistant works.
- **Power BI Service** — the online place where you publish dashboards so others
  can see them in a browser or on their phone.
- **Power BI Mobile** — the app for checking dashboards on the go.

You build in Desktop. You share through the Service. That's the whole picture.

## The three layers inside

Every Power BI project has three layers, and it helps to know their names:

1. **Data** — what you connect to (a database, a file, a web source).
2. **Model** — the tables, relationships, and measures you build on top of the data.
3. **Report** — the visual pages people actually look at.

The assistant works almost entirely in the **model** layer — the tables, measures,
and relationships. The report layer (the pretty visuals) is where a human arranges
things on the canvas. The model is the engine; the report is the dashboard.

## Seeing the model, live

The assistant can read the whole model and report it back:

> "Give me a summary of the model."

![Model summary](../../assets/examples/e002.png)

Tables, measures, relationships, row counts — the whole engine in one view. This is
the first thing you do when you open any Power BI project: understand the model.

> "List every table with its row count."

![List tables](../../assets/examples/e005.png)

The building blocks, counted and ready.

## The data dictionary: documentation for free

One of the assistant's most useful tricks is writing a **data dictionary** — a
document that lists every table, column, and measure with what it means.

> "Generate a data dictionary for the whole model."

![Data dictionary](../../assets/examples/e044.png)

Documentation that would take an analyst an afternoon appears in a second. This is
a big deal: good documentation is the difference between a model a team can trust
and a model only one person understands.

## Seeing the measures

> "What measures exist in Sales?"

![Measures in Sales](../../assets/examples/e079.png)

Every measure with its formula and format. When someone asks "how is Total Sales
calculated?", the answer is right there.

## A curiosity: Power BI's improbable rise

Power BI started in 2015 as a small add-on and raced to the top of the analytics
world, largely because Microsoft bundled it with tools companies already had and
priced it low enough that almost anyone could try it. Its quiet superpower is that
it sits inside the Microsoft ecosystem — Excel, Azure, Office — so for millions of
businesses it was the path of least resistance. The best tool is often not the
best tool; it's the one that's already there.

## Why the assistant matters here

Power BI is powerful but has a learning curve — DAX, the model view, the ribbon of
buttons. The assistant removes that curve for the model work: you describe what you
want, it edits the model live. You still arrange the visuals yourself, but the
hard part — the measures and the wiring — becomes a conversation.

---

## What you'll carry from this chapter

- Power BI = Desktop (build), Service (share), Mobile (view).
- Three layers: data, model, report.
- The assistant works in the model layer.
- It can summarise, list, and document the model on demand.
- The assistant removes the learning curve for the hard part.

Next: how the assistant finds and connects to your Power BI Desktop — the moment
the two meet.
