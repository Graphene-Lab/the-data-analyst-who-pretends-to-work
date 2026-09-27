# 20. Choosing the Right Chart

A chart is not decoration. It is a tool for making a truth visible. The right chart
makes an insight obvious in a second; the wrong chart hides it or, worse, lies.
This chapter is about picking the right picture for the truth you want to show.

## The one rule

There is one rule that covers most of it:

> **Match the chart to the question, not to what looks cool.**

Comparing categories? Bars. Change over time? A line. Part of a whole? A pie (a
small one). Relationship between two numbers? A scatter. Pick the chart that answers
the question, and the answer shows itself.

## Comparing categories: use bars

When you want to compare "how much for each thing" — sales by category, by region,
by product — use a **bar chart** (or column chart). Bars are easy for the eye to
rank. The assistant can hand you the data shaped for exactly this:

> "Give me sales by category for a bar chart."

![Sales by category for a bar chart](../../assets/examples/e060.png)

Three categories, their totals, ready to become a bar chart. The eye instantly
sees Furniture on top, Stationery at the bottom.

And here is that same real data rendered as the chart:

![Sales by category — bar chart](../../assets/examples/chart-category.png)

> "Sales by region for a map or column chart."

![Sales by region](../../assets/examples/e061.png)

Regional totals, ready for a column chart or a map.

## Change over time: use a line

When the question is "how did this move over time?", a **line chart** shows the
shape of the trend — the rises, the dips, the season — better than any table.

![Total sales per month — line chart](../../assets/examples/chart-monthly.png)

Twelve months of real sales, one line. You can see the March peak and the autumn
trough at a glance — the kind of pattern a table of numbers hides.

## Part of a whole: use a pie (carefully)

A pie chart shows how a total splits into parts. It works with **three or four
slices**. It fails badly with ten.

> "Category share for a pie chart."

![Category share](../../assets/examples/e083.png)

Kitchen, Furniture, Stationery as shares of the whole — a clean pie. Add a dozen
categories and the same chart becomes unreadable confetti.

The same share, rendered as a donut with the values and percentages:

![Category share — donut chart](../../assets/examples/chart-share.png)

## The charts to avoid

- **3D charts** — they distort the data. A 3D pie tilts slices and lies about
  their size. Never.
- **Dual-axis charts** — two y-axes can make unrelated things look related. Use
  with extreme care, or not at all.
- **Pie charts with many slices** — unreadable. Use a bar chart instead.
- **Truncated axes** — a bar chart whose axis starts at 90% instead of 0 makes a
  tiny difference look huge. Start the axis at zero unless you have a strong reason.

## A curiosity: the chart that lied to a nation

In the 2012 U.S. election, a widely-shared chart showed President Obama winning
"98% of the vote" — because it was a map of *county* wins, and rural counties are
huge in area but tiny in population. The map showed land, not people, and misled
millions. The lesson: a chart can be technically accurate and completely
misleading. The analyst's job is to choose the view that shows the *truth*, not
just *a* truth.

## Colour with purpose

Colour is powerful and easily wasted:

- Use colour to **highlight**, not to decorate.
- Reserve red for "bad / below target", green for "good" — and don't overuse either.
- Design for **colour-blind** readers: don't rely on red/green alone; add labels or
  shapes.
- Fewer colours = clearer message.

## A dashboard is a story, not a paint palette

Every visual on a page should earn its place by advancing the story. If a chart
doesn't help the reader understand or decide, cut it. A clean page with three good
charts beats a busy page with twelve pretty ones.

---

## What you'll carry from this chapter

- Match the chart to the question, not to what looks cool.
- Bars for comparing; lines for time; small pies for parts of a whole.
- Avoid 3D, dual-axis tricks, many-slice pies, and truncated axes.
- A chart can be accurate and still misleading — choose the honest view.
- Use colour to highlight, and design for colour-blind readers.

Next: putting it together — reports and dashboards that people actually use.
