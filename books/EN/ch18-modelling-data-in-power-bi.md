# 18. Modelling Data in Power BI

Modelling is where the analysis is won or lost. A good model makes every question
easy; a bad model makes every question a fight. This chapter shows the assistant as
a careful modeller — one that not only builds the model but documents it and checks
it against best practices.

## What a good model looks like

You met the star schema in Chapter 8. In Power BI, a good model means:

- A clean **fact table** (the numbers: sales, transactions).
- Tidy **dimension tables** (the descriptions: products, customers, dates).
- **Relationships** wired correctly (many-to-one, no ambiguity).
- **Measures** with clear names, formats, and descriptions.
- **Documentation** so the next person (or you, in six months) understands it.

The assistant helps with all of these, live.

## Documenting as you go

Good models are documented models. The assistant can add descriptions to tables and
columns on request:

> "Add a description to the Sales table."

![Table description](../../assets/examples/e046.png)

> "Describe the Amount column."

![Column description](../../assets/examples/e047.png)

These small notes show up in the model and in the data dictionary. They are the
difference between a model that's a black box and one that's a shared asset.

> "Set a description on the Products table."

![Products description](../../assets/examples/e080.png)

## The data dictionary, table by table

You can document the whole model or a single table:

> "Generate a data dictionary for Products only."

![Products dictionary](../../assets/examples/e045.png)

A focused dictionary for one table — handy when you're handing a piece of the model
to a colleague.

## The health check: best practices

This is one of the assistant's most valuable moves. It scans the whole model and
reports problems and tips:

> "Check the model against best practices."

![Best practices report](../../assets/examples/e048.png)

It flags measures with no format string, tables with no description, disconnected
tables — the small sins that make a model hard to use. This is like a linter for
your data model: it won't stop you working, but it tells you where the model is
messy before the mess bites you.

## Re-checking after changes

As you build, the model drifts. Re-running the check keeps it honest:

> "Best practices after adding measures."

![Best practices after changes](../../assets/examples/e093.png)

A quick re-scan shows what your latest changes introduced. Build, check, fix,
repeat — the rhythm of a clean model.

## A curiosity: the bus factor

There's a metric in software teams called the **bus factor**: how many people would
have to be "hit by a bus" before a project is stuck because only one person
understands it. A model with no documentation has a bus factor of one — terrifying.
Every description and dictionary entry the assistant writes raises that number.
You're not just tidying; you're making the model survivable.

## Why the assistant is a good modeller

A human modeller under deadline pressure skips documentation and best practices.
The assistant doesn't get tired, doesn't skip steps, and checks everything. Pair a
human's judgement about *what* to model with the assistant's diligence about
*documenting and checking* it, and you get models that stay clean.

---

## What you'll carry from this chapter

- A good model: clean fact + dimensions, wired right, documented.
- Add descriptions to tables, columns, and measures as you go.
- Generate data dictionaries to document the whole model or one table.
- Run the best-practices check like a linter — often.
- Documentation raises the bus factor; it makes the model survivable.

Next: DAX, the language behind the numbers — and how you don't have to write it.
