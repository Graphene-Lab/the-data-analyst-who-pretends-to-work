# 7. Dirty Data and How to Clean It

Here is a truth nobody puts on the job description: **most of an analyst's time is
spent cleaning data.** Real-world data is messy — misspelled, duplicated, missing,
inconsistent. Garbage in, garbage out. Before you can find any truth, you have to
sweep the floor.

## The usual mess

Every analyst meets the same cast of problems:

- **Inconsistent text** — "Milan", "milan", "MILANO", "Milano ". Four values, one
  city.
- **Mixed formats** — dates as 03/04/2025 and 2025-04-03 in the same column.
- **Missing values** — blank cities, empty categories, no phone number.
- **Duplicates** — the same customer twice under two emails.
- **Wrong types** — a number stored as text, so it won't add up.
- **Out-of-place values** — a negative sale that is really a refund.

None of these are dramatic. All of them will quietly ruin an analysis if you ignore
them.

## Cleaning with calculated columns

In Power BI, a lot of cleaning is done with **calculated columns** — new columns
you create with a formula that fixes or standardises existing data. This is exactly
where the assistant shines: you describe the fix in plain words, it writes the
formula and applies it live.

**Standardise text.** A person asked:

> "Add a column with the category in capital letters."

![Category in capitals](../../assets/examples/e011.png)

Now "kitchen", "Kitchen", and "KITCHEN" all become "KITCHEN" and group together.
One small column, one whole class of problem gone.

**Turn a number into a usable band.**

> "Bucket products into High / Mid / Low by price."

![Price band](../../assets/examples/e012.png)

A raw price of €249 is hard to group by. A band of "High" is easy to chart and easy
to talk about. This is one of the most useful tricks in analysis: turning a
continuous number into a friendly category.

And here is what that band buys you — sales grouped and charted by price band:

![Sales by price band — bar chart](../../assets/examples/chart-priceband.png)

**Combine fields into a label.**

> "Make a customer label like 'Name (City)'."

![Customer label](../../assets/examples/e013.png)

Now every customer has one clean display label, built from two columns, without
anyone typing a thing.

## Check before you commit

A good habit: **validate the formula before you save it.** The assistant can test a
formula and show you a sample value, so you know it works before it becomes part of
the model.

> "Check this price-band formula before I save it."

![Validate the price band](../../assets/examples/e014.png)

It returns "Valid" with a sample value. No surprises later.

## Hunting the blanks

Missing values are silent killers. A blank city means a customer vanishes from every
map. The assistant can hunt them down:

> "Any blank cities in the customer list?"

![Blank cities check](../../assets/examples/e072.png)

If the result is empty, you are clean. If not, you know exactly where the holes are
before they mislead a chart.

## A curiosity: 80/20 of the job

Ask any experienced analyst how their time splits and you'll hear a version of the
same joke: **80% of data science is cleaning data, and the other 20% is
complaining about cleaning data.** It's a cliché because it's true. The analysts who
are good at cleaning are worth their weight — because a beautiful model built on
dirty data is a beautiful way to be wrong.

## When cleaning is never enough

Sometimes the data is too far gone — missing 40% of a key field, or two systems
that simply disagree. A good analyst knows when to stop cleaning and escalate: *fix
this at the source*, or *collect better data next time*. Cleaning is a tool, not a
religion.

---

## What you'll carry from this chapter

- Real data is dirty; cleaning is most of the job.
- Calculated columns fix text, band numbers, and build labels in seconds.
- Validate a formula before you commit it.
- Hunt the blanks before they mislead a chart.
- Know when to stop cleaning and fix the source.

Next: how data pieces connect — tables, keys, and relationships — the wiring that
makes analysis possible.
