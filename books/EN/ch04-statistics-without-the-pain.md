# 4. Statistics Without the Pain

You do not need a lot of statistics to be a good analyst. You need a handful of
ideas, understood deeply, and the wisdom to know when they fool you. Here is the
whole kit, in plain words.

## The three averages: mean, median, mode

People say "average" as if there were one. There are three, and choosing the wrong
one can lie without technically being wrong.

- **Mean** — add everything, divide by the count. The classic average.
- **Median** — the middle value when you line them all up. Half are above, half below.
- **Mode** — the most common value.

Why does it matter? Picture a small company. Ten staff earn €30,000, and the boss
earns €500,000.

- The **mean** salary is €72,727 — "we pay well!"
- The **median** salary is €30,000 — the typical worker's reality.

One number is "correct" and the other is "correct", and they tell completely
different stories. When a few extreme values (outliers) are in the mix, the **median**
is usually the honest one. When someone quotes an average, ask: *mean or median?*

## Spread: are things steady or wild?

An average hides how spread out the numbers are. Two delivery services both average
3 days. One always takes 3 days. The other takes 1 day or 5 days at random. Same
average, totally different experience.

The measure of spread you will use most is the **standard deviation** — roughly,
"how far from the average things usually are." Small standard deviation = steady,
predictable. Large = wild, unreliable. Averages tell you the centre; spread tells
you the risk.

## The bell curve (and why it shows up everywhere)

Many real things — heights, test scores, measurement errors — pile up around the
middle and thin out at the ends, forming a bell shape. This is the **normal
distribution**, and it is everywhere because of a beautiful fact: when many small
random influences add up, the result tends toward a bell. You do not need the math.
You need the instinct: most cases are near the middle, extremes are rare, and a
value far out in the tail is worth investigating.

## Outliers: the one weird number

An **outlier** is a value far from the rest. One customer buys €50,000 while
everyone else buys €50. One delivery takes 30 days while the rest take 3. Outliers
can be:
- **Errors** — a typo, a test record, a misplaced decimal.
- **Real but rare** — a whale customer, a genuine disaster.

Always look at outliers before you trust an average. A single fat client can make a
whole month look great and hide that the other 200 customers are leaving.

## The big trap: correlation is not causation

This is the single most important sentence in this book.

**Correlation** means two things move together. **Causation** means one thing
*causes* the other. They are not the same, and confusing them causes expensive
nonsense.

Classic example: **ice cream sales and drowning deaths rise together** every summer.
Does ice cream cause drowning? No. A third thing — hot weather — drives both. When
you see two things move together, always ask:
- Does A cause B?
- Does B cause A?
- Does some hidden C cause both?
- Is it just coincidence?

"Customers who use our app more are happier" might mean the app makes them happy —
or that already-happy customers use it more. Correlation points you at a clue. It
does not hand you the answer.

## A curiosity: the correlation coefficient

Statisticians squeeze "how strongly two things move together" into one number from
**-1 to +1**. +1 means they rise in perfect lockstep; -1 means one rises as the
other falls; 0 means no relationship. It is a useful thermometer for a
relationship — but remember, even a perfect +1 is still not proof of cause.

---

## What you'll carry from this chapter

- Know which average you are using; the median often tells the truth.
- Averages hide spread — watch the standard deviation.
- Outliers can fake a whole story; look at them first.
- Correlation is a clue, never proof. Always hunt for the hidden third thing.

Next: how to turn a fuzzy business worry into a sharp question you can actually
answer with data.
