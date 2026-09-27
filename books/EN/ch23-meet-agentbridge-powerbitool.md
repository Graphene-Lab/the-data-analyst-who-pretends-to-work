# 23. Meet AgentBridge and PowerBITool

Every example in this book was made with two tools working together. This chapter
introduces them properly — what each one is, how they fit together, and what they
can do.

## AgentBridge: the assistant

**AgentBridge** is an AI assistant that runs on your own computer. You talk to it in
plain words, and it does work across your tools. It is not a chatbot that only
talks — it acts. It can write documents, build spreadsheets, send email, research
the web, and, with the right plugin, operate Power BI.

The key properties:

- **Local.** It runs on your machine. Your data stays with you.
- **Plain-language.** You describe what you want; you don't write code.
- **Extensible.** Plugins give it new abilities. PowerBITool is one of them.

## PowerBITool: the hands inside Power BI

**PowerBITool** is the plugin that gives AgentBridge hands inside Microsoft Power
BI Desktop. Through it, the assistant can:

- **Connect** to the live model of an open report.
- **Inspect** — model summary, tables, schema, measures, relationships.
- **Edit the model** — create and delete tables, columns, measures, relationships;
  set descriptions.
- **Run and validate DAX** — with a safety guard that blocks anything dangerous.
- **Profile and document** — profile tables, generate a data dictionary, lint for
  best practices.

Here is the assistant introducing itself to a model:

> "Meet PowerBITool: what can you do with my model?"

![Meet PowerBITool](../../assets/examples/e064.png)

The summary it returns is the whole surface: tables, measures, relationships, row
counts — everything it can see and work with.

## How they fit together

```
You  →  AgentBridge (the brain)  →  PowerBITool (the hands)  →  Power BI Desktop (the model)
```

AgentBridge understands your words and plans the action. PowerBITool carries out
that action on the live Power BI model. You see the result immediately in Power BI
Desktop. The loop is: ask → think → act → see.

## The safety guard

One thing worth calling out: PowerBITool runs DAX through a **fail-closed guard**.
It allows read-only queries (`EVALUATE`, system views) and blocks anything that
could modify the model through the query door — no `DROP`, no `INSERT`, no
`DELETE`, no multi-statement tricks. If a query isn't clearly safe, it's rejected.
This is what makes it responsible to let an AI touch a live model.

## Free, and supported by real people

Both tools are free. PowerBITool is open on GitHub, and — as the preface promised —
the support is free too: open an issue and a real technician answers within about
24 hours with a real fix. That combination (free tool, free human support, fast
answers) is the promise behind every example you've seen.

## A curiosity: the plugin model

PowerBITool is not compiled into AgentBridge. It's a **plugin** dropped into a
`Tools` folder, discovered at startup. That means the assistant's abilities can
grow without changing the core — today Power BI, tomorrow other tools. The plugin
model is why the assistant can keep gaining new "hands" without getting bloated.

## What you can do with them, together

Everything in this book, and more: connect to a report, understand the model,
clean data with calculated columns, build measures, wire relationships, validate
and lint DAX, generate documentation, and check best practices — all by talking.

---

## What you'll carry from this chapter

- AgentBridge is the local, plain-language assistant (the brain).
- PowerBITool is the plugin that operates Power BI Desktop (the hands).
- The loop: ask → think → act → see, all local.
- A fail-closed guard keeps the live model safe.
- Free tool, free support, real humans, fast answers.

Next: a whole day of the analyst's work, automated.
