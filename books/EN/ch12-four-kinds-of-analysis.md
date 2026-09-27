# 12. Four Kinds of Analysis

Every analysis you will ever do falls into one of four kinds, arranged by how much
they ask of the data. They climb a ladder: from looking back, to explaining why, to
guessing forward, to recommending what to do. Knowing which kind you are doing
tells you how hard to push and how much to trust the answer.

## 1. Descriptive — what happened?

The simplest and most common. You describe the past. "Sales were €22,023. The North
did €12,145." No explanation, no prediction — just the facts, clearly.

> "Descriptive: total sales by region."

![Descriptive by region](../../assets/examples/e031.png)

Most dashboards are descriptive. They answer "how are we doing?" and they are the
foundation everything else stands on.

The regional breakdown, as a chart:

![Sales by region — bar chart](../../assets/examples/chart-region.png)

## 2. Diagnostic — why did it happen?

Now you dig. Something changed, and you want the cause. You slice, compare, and
cross-reference until the reason surfaces.

> "Diagnostic: which category earns the most?"

![Diagnostic by category](../../assets/examples/e032.png)

> "Compare North vs Center sales."

![North vs Center](../../assets/examples/e033.png)

Diagnostic work is where the analyst earns their keep. Descriptive tells you the
patient has a fever; diagnostic finds the infection.

The same diagnostic eye turned on stores:

![Sales by store — bar chart](../../assets/examples/chart-store.png)

## 3. Predictive — what will happen?

You use the past to guess the future. Demand next quarter, churn next month, sales
by year-end. This usually needs statistics or machine learning, and it comes with a
confidence range — a good prediction says "about 11,000, give or take."

> "Best month overall."

![Best month](../../assets/examples/e076.png)

A single-period view like this is the raw material for prediction: you see the
pattern, then you project it forward.

## 4. Prescriptive — what should we do?

The top of the ladder. Given the prediction and the constraints, what action
maximises the goal? Which price, which promotion, which stock level. Prescriptive
analysis is the rarest and hardest, and it usually sits on top of the other three.

## The ladder in one picture

| Kind | Question | Effort | Trust needed |
|---|---|---|---|
| Descriptive | What happened? | Low | High (it's just facts) |
| Diagnostic | Why? | Medium | Medium (watch for false causes) |
| Predictive | What next? | High | Lower (it's a guess with a range) |
| Prescriptive | What to do? | Highest | Lowest (it's a recommendation) |

Notice the pattern: the higher you climb, the more value you add — and the less
certain you are. A good analyst is honest about that trade-off.

## Ranking: the analyst's favourite move

Ranking turns a flat list into a story. Who's first, who's last, who's improving.

> "Rank products by sales."

![Rank products](../../assets/examples/e034.png)

> "Average quantity per sale."

![Average quantity per sale](../../assets/examples/e059.png)

Ranking is descriptive, but it points the diagnostic work: the bottom of the list
is where you look first for a problem.

## A curiosity: the analytics maturity myth

Consultants love to sell a "maturity model" where you must climb from descriptive
to prescriptive or you're a laggard. In reality, **most businesses would be
transformed just by getting descriptive and diagnostic right.** Don't be ashamed
of a good "what happened and why" — it is where 90% of the value lives. The
predictive and prescriptive layers are the cherry on top, not the cake.

---

## What you'll carry from this chapter

- Four kinds: descriptive, diagnostic, predictive, prescriptive.
- Value and uncertainty both rise as you climb.
- Most value lives in descriptive + diagnostic.
- Ranking is the simplest way to find where to look.
- Be honest about how much to trust each kind.

Next: the customer — the most important subject of analysis there is.
