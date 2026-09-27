# 11. The Metrics That Matter

A metric is a number you watch to know how the business is doing. Choose the right
ones and you can steer. Choose the wrong ones and you can drive straight off a cliff
while the dashboard glows green. This chapter is about picking the numbers that
actually matter — and building them with the assistant.

## What makes a metric worth watching

A good metric passes three tests:

1. **It moves when the business moves.** If the business gets worse, the number
   should get worse.
2. **You can act on it.** A number you can only admire is decoration.
3. **It's honest.** It can't be gamed into looking good while things rot.

A **vanity metric** fails these. "Total registered users since 2010" only ever goes
up. It feels great and means nothing. Watch rates and changes, not ever-growing
totals.

## The core sales metrics

Every business that sells things watches a similar set:

- **Total sales** — the headline revenue.
- **Units sold** — how much stuff moved.
- **Orders** — how many transactions.
- **Average order value** — revenue per order.
- **Active customers** — how many people actually bought.
- **Largest sale** — the biggest single line (for spotting whales).

The assistant builds each of these from a plain request. Watch a set appear:

> "Create a Total Sales measure with a euro format."

![Total Sales measure](../../assets/examples/e026.png)

> "Create a measure for units sold."

![Units Sold measure](../../assets/examples/e027.png)

> "Create an average order value measure."

![Average order value](../../assets/examples/e028.png)

Notice the average order value uses `DIVIDE`, not a slash. That is deliberate —
`DIVIDE` handles the case where the bottom is zero without crashing. A small
safety habit that saves you from `#DIV/0!` errors later.

> "How many active customers do we have?"

![Active customers](../../assets/examples/e029.png)

> "What is the biggest single sale?"

![Largest sale](../../assets/examples/e030.png)

In a handful of sentences, the whole core KPI set exists, live in the model.

## Money metrics: margin and share

Revenue is vanity; profit is sanity. To know what you *keep*, you need cost:

> "Add a cost column and a margin measure."

![Cost column](../../assets/examples/e056.png)

> "Total margin across all sales."

![Total margin](../../assets/examples/e057.png)

And to see how a slice compares to the whole:

> "Share of total sales, as a percentage."

![Percent of total](../../assets/examples/e058.png)

A percentage-of-total is one of the most-used metrics in reporting — it turns any
number into "how big is this compared to everything?"

## A few more quick ones

> "Average unit price paid."

![Average unit price](../../assets/examples/e075.png)

> "Total sales excluding a category."

![Sales excluding a category](../../assets/examples/e089.png)

Each is a plain sentence, each is a real measure in the live model.

## A curiosity: the metric that backfired

When the Soviet Union measured nail production by **quantity**, factories made tiny
useless nails by the million. When they switched to measuring by **weight**, they
made a few enormous nails. Same goal, different metric, different absurdity. The
lesson every analyst must learn: **you get what you measure**, so measure
carefully — ideally a metric that can only improve if the business truly improves.

---

## What you'll carry from this chapter

- Choose metrics that move with the business, that you can act on, that can't be gamed.
- Avoid vanity metrics (ever-growing totals).
- The core sales set: revenue, units, orders, average order, active customers.
- Margin and share-of-total turn revenue into meaning.
- You get what you measure — measure wisely.

Next: the four kinds of analysis, from "what happened" all the way to "what should
we do."
