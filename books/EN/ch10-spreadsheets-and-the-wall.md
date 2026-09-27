# 10. Spreadsheets, Excel, and Hitting the Wall

No book about data analysis can skip the spreadsheet. It is where almost everyone
starts, and for good reason — it is brilliant. But it is also where people hit a
wall, and knowing where that wall is tells you when to move on.

## Why spreadsheets won

The spreadsheet is one of the most successful pieces of software ever made. Its
genius is that it is **direct manipulation**: you type a number in a box, and the
boxes that depend on it update instantly. No code, no compile, no waiting. You see
your work and your result side by side.

Spreadsheets gave ordinary people the power to model: budgets, forecasts, schedules,
price lists. Before the spreadsheet, that power lived only in mainframes and only
with programmers. After it, anyone with a PC could do it.

## The pivot table: analysis in a box

The **pivot table** is the spreadsheet's superpower. Drag a few fields and it
summarises thousands of rows: sales by month, by product, by region. For a huge
share of business analysis, a pivot table is the whole job. If you can pivot, you
can analyse.

## The wall

But spreadsheets have a ceiling, and every analyst eventually hits it:

- **Size** — past a million rows, Excel groans, slows, and crashes.
- **Fragility** — one deleted cell, one broken formula, and the whole workbook is
  quietly wrong. There is no safety net.
- **No relationships** — joining two tables means VLOOKUP, and VLOOKUP breaks the
  moment data moves.
- **Version chaos** — "Budget_FINAL_v3_really_final.xlsx" edited by five people,
  all disagreeing.
- **No refresh** — a report that gets updated by copy-paste every Monday is a
  report that is wrong every Tuesday.
- **No sharing story** — a spreadsheet is a file, not a live dashboard others can
  trust and explore.

If your Monday morning is "open the file, paste the new data, drag the formulas,
re-save, email it" — you are doing by hand what a proper model does by itself.

## The spreadsheet vs. the model

Here is the difference in one line:

> A spreadsheet stores numbers in cells. A model stores *logic* and computes the
> numbers fresh every time.

In a spreadsheet, the number *is* the answer, sitting in a cell, rotting. In a
model, the answer is recomputed from the data and the rules, every time you look,
always current.

## The same question, two ways

In Excel, "total sales" means a SUM formula over a column, correct only as long as
nobody touches the rows. In a model, it is a measure — `SUM(Sales[Amount])` — that
recomputes on demand and can be sliced by any dimension without a single new
formula:

> "What is the total of the Amount column?"

![Total amount as a measure](../../assets/examples/e021.png)

Same number, but now it lives in a model that can answer "by region", "by month",
"by customer" without any extra work — because the logic is stored, not the result.

## A curiosity: the spreadsheet that lost a billion

In 1998, a spreadsheet error helped cause a $1.2 billion loss at a major financial
fund (LTCM), and countless companies have been burned by a single wrong cell. In
2008, a famous research paper on debt and growth was found to have a spreadsheet
error — an accidentally excluded set of rows — that flipped its conclusion and had
influenced real policy for years. Spreadsheets are powerful, and that is exactly
why their mistakes are dangerous. A model with tested logic is safer than a
spreadsheet with a hidden `+` where a `-` should be.

## When to stay, when to go

Stay in the spreadsheet when: the data is small, the job is one-off, you are
sketching. Move to a model when: the data is big, the report repeats, more than one
person touches it, or you need it to be *right* and *current*. The assistant and
Power BI are how you cross that bridge without pain.

---

## What you'll carry from this chapter

- Spreadsheets are brilliant for small, direct, one-off work.
- The pivot table is a genuine superpower.
- The wall: size, fragility, no relationships, version chaos, no refresh.
- A model stores logic, not frozen results.
- Move on when the report repeats or the data grows.

Part II is done — you know where data comes from, how to clean it, how to wire it,
and how to ask it questions. Next we turn data into meaning: the metrics and kinds
of analysis that drive decisions.
