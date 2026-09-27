# 14. Trends, Time, and Seasonality

A number is a snapshot. Add time, and it becomes a story. Sales of €11,000 means
little until you know whether that's up or down, and whether it's normal for this
time of year. Time is the dimension that turns a photo into a movie, and almost
every important business question lives in it.

## Why time is special

Time is the one dimension you cannot avoid. Every sale, every click, every record
happens *at* a moment. And time has a property other dimensions don't: **things
repeat.** Ice cream sells in summer. Retail spikes at Christmas. Tax software roars
in April. This repetition is **seasonality**, and spotting it stops you from
panicking over a "dip" that happens every single January.

## Getting the date into usable pieces

Raw dates are awkward. To analyse time, you break the date into pieces — year,
month, day — as columns you can group by:

> "Add a Year column from the date."

![Year column](../../assets/examples/e039.png)

> "Add a Month column from the date."

![Month column](../../assets/examples/e040.png)

Now you can group by year or month and see the shape of time.

## The year-over-year view

> "Total sales per year."

![Sales per year](../../assets/examples/e041.png)

Two years, side by side. Is 2025 better than 2024? The comparison is the whole
point — a single year tells you nothing, but two years tell you the direction.

The year-over-year comparison, as a chart:

![Sales per year — bar chart](../../assets/examples/chart-yearly.png)

## The monthly trend

> "Total sales per month."

![Sales per month](../../assets/examples/e042.png)

Twelve months of data. You can see the peaks and valleys — the busy months and the
quiet ones. This is the raw shape of your business's heartbeat.

The monthly heartbeat, drawn as a line:

![Sales per month — line chart](../../assets/examples/chart-monthly.png)

## Filtering a period

> "Sales in 2025 only."

![2025 sales](../../assets/examples/e043.png)

> "Sales for the first half of a year."

![First half of 2025](../../assets/examples/e078.png)

Slicing a specific window of time is how you answer "how did we do last quarter?"
in one sentence.

## Finding the slow period

> "Month with the fewest sales."

![Fewest sales month](../../assets/examples/e091.png)

Knowing your slowest month is as useful as knowing your busiest — it's when you
plan promotions, schedule maintenance, or brace for a quiet spell.

## Moving averages: smoothing the noise

Monthly numbers are bumpy. A **moving average** (say, the average of the last 3
months) smooths the bumps so the underlying trend shows through. It's the
difference between watching a shaky handheld camera and a smooth steadicam shot.
The trend is what you want to see; the moving average reveals it.

## A curiosity: the "January effect" that isn't

A manager sees January sales down 30% and calls an emergency meeting. But January
is *always* down after December's holiday rush. Without comparing to last January,
the drop is meaningless — it's the season, not a problem. This is why analysts
compare **year-over-year** (this January vs last January) rather than
**month-over-month** (January vs December). The right comparison turns a false
alarm into a non-event.

---

## What you'll carry from this chapter

- Time turns a snapshot into a story.
- Break dates into year/month/day to group and trend.
- Seasonality means things repeat — don't panic at the expected dip.
- Compare year-over-year, not just month-over-month.
- Moving averages smooth the noise to reveal the trend.

Next: how do you know a difference is real and not just luck? A gentle tour of
testing and chance.
