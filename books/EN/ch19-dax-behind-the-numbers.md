# 19. DAX: The Language Behind the Numbers

DAX is the calculation language inside Power BI. It has a reputation for being
scary. This chapter is about why it matters, and why — with the assistant — you can
use it without ever fighting it.

## What DAX is for

DAX (Data Analysis Expressions) computes the numbers in your reports: totals,
averages, percentages, year-over-year, running totals, rankings. Every measure you
see on a Power BI dashboard is DAX under the hood.

The core functions are simple: `SUM`, `AVERAGE`, `COUNT`, `MIN`, `MAX`, and the
mighty `CALCULATE`, which lets you compute a number *under a specific filter*.

## The assistant writes it; you read it

You don't type DAX. You describe the number you want, and the assistant writes the
DAX and creates the measure live. But you should be able to *read* what it made, so
you trust it.

> "Create a Milan-only sales measure."

![Milan sales measure](../../assets/examples/e053.png)

Under the hood that's `CALCULATE([Total Sales], Stores[City] = "Milan")` — the
total sales, but only where the city is Milan. Once you see the pattern, DAX stops
being magic.

## Validate before you trust

The assistant can test a formula without creating anything:

> "Is this a valid measure? SUM(Sales[Amount])"

![Validate good measure](../../assets/examples/e049.png)

> "Check this broken formula: SUMX(Sales[Amount])"

![Validate broken measure](../../assets/examples/e050.png)

One passes, one fails — and you learn what's wrong *before* it becomes a broken
measure in the model. This "check first" habit saves hours of debugging.

> "Validate a CALCULATE measure."

![Validate CALCULATE](../../assets/examples/e081.png)

> "Validate a percentage measure."

![Validate percentage](../../assets/examples/e094.png)

## Linting: the style cop for DAX

Beyond "does it run?", the assistant can check "is it *well-written*?" — a process
called **linting**. It spots common mistakes and risky patterns.

> "Lint this DAX: SUM(a)/SUM(b)"

![Lint slash division](../../assets/examples/e051.png)

It warns: don't use a plain `/` — use `DIVIDE`, which handles division by zero
safely. A small nudge that prevents a whole class of `#DIV/0!` errors.

> "Lint this clean DAX with DIVIDE."

![Lint clean DAX](../../assets/examples/e052.png)

The clean version passes. You learn the good pattern by seeing it rewarded.

> "Lint a measure that uses IFERROR."

![Lint IFERROR](../../assets/examples/e082.png)

It flags `IFERROR` as a smell — wrapping errors can hide real bugs instead of
fixing them. The linter teaches good habits one warning at a time.

## Editing measures

Measures evolve. The assistant can update and delete them:

> "Change the format of Total Sales to whole euros."

![Update format](../../assets/examples/e054.png)

> "Delete the Milan Sales measure."

![Delete measure](../../assets/examples/e055.png)

Rename, reformat, remove — all live, all reversible until you save.

## A curiosity: the filter context beast

The reason DAX is called hard is one concept: **filter context** — the invisible
set of filters that a calculation sees at any moment (the current row, the current
slicer selection, the current visual). Master it and DAX is your friend;
misunderstand it and numbers look wrong in ways that are hard to trace. Here is the
liberating truth of this book: **you describe the answer, and the assistant handles
the filter context.** The beast becomes the tool's problem, not yours.

---

## What you'll carry from this chapter

- DAX computes the numbers; `CALCULATE` is its most powerful word.
- You describe the answer; the assistant writes the DAX.
- Validate a formula before you create it.
- Lint to catch bad patterns (plain `/`, `IFERROR` hiding bugs).
- The hard part — filter context — is now the tool's job.

Next: seeing is believing — how to choose the right chart and not lie with visuals.
