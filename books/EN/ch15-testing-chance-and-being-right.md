# 15. Testing, Chance, and Being Right

You changed the website and conversions went up 2%. Did your change work, or was it
just luck? This is the question that separates real analysis from wishful thinking,
and the answer lives in the unglamorous world of testing and chance. Don't worry —
we'll keep it painless.

## The problem: was it the change or the luck?

Any number can bounce around by chance. If you flip a coin 10 times and get 7 heads,
you don't conclude the coin is rigged. Same with business: if a new ad gets a few
more clicks, it might be better, or it might be noise. The question is: **how
confident can you be that the difference is real?**

## The idea of a sample

You almost never see the whole population — you see a **sample**. 1,000 visitors to
your site, not all the people who could ever visit. A sample is a small taste of a
much bigger pot. The trick is that a small taste can tell you about the whole pot —
*if* it's big enough and unbiased.

Big sample + random selection = trustworthy. Tiny sample or cherry-picked =
dangerous. A/B tests work because they split visitors randomly into two groups and
compare.

## A/B testing: the honest experiment

The gold standard for "does this work?":

1. Split your audience **randomly** into two groups.
2. Group A sees the old version; Group B sees the new version.
3. Measure the outcome in both.
4. Compare. If B beats A by more than chance explains, the change is real.

Randomness is the whole trick. It makes the two groups identical except for the one
thing you changed, so any difference must be the change.

## Significance: is the difference real?

Statisticians use a **p-value** to answer "could this be chance?" A p-value below
0.05 is the usual bar: it means "if there were really no difference, we'd see
something this extreme less than 5% of the time." Below the bar, you call it
**statistically significant** — likely real. Above it, you shrug and say "not
enough evidence."

You don't need to compute p-values by hand. You need the instinct: **a small
difference on a small sample is probably noise; a clear difference on a big sample
is probably real.**

## The two ways to be wrong

- **Type I error (false positive):** you say the change worked when it didn't. You
  ship a useless change. The 5% bar controls this.
- **Type II error (false negative):** you say the change didn't work when it did.
  You throw away a good idea. Usually caused by too small a sample.

Both happen. Good testing balances them: enough data to catch real effects, a
strict enough bar to avoid chasing ghosts.

## Comparing two groups, live

You don't need a lab to see the shape of a comparison. The assistant can put two
groups side by side in one query:

> "Compare North vs Center sales."

![Compare two groups](../../assets/examples/e033.png)

Scale this up with random assignment and a big sample, and you have an A/B test.
The logic is identical: two groups, one difference, measure and compare.

## A curiosity: the cookie that fooled everyone

A company ran an A/B test, saw a big lift, and celebrated. The catch: the two
groups weren't actually random — a bug put all the mobile users in one group. The
"win" was really just mobile users behaving differently. The test was sound in
theory and broken in practice. **Randomisation is everything.** A test is only as
good as the split behind it.

## When you don't need a formal test

Not every decision needs a p-value. If you change the price of one item and watch
one week of sales, you're not running an experiment — you're observing. Formal
testing is for the decisions that matter and can be run properly. For everything
else, be honest that you're guessing, and keep the decision reversible.

---

## What you'll carry from this chapter

- A difference can be luck; ask how confident you are.
- Samples let a small taste tell you about the whole pot — if they're big and random.
- A/B testing = random split, change one thing, compare.
- "Significant" means "unlikely to be pure chance."
- Randomisation is everything; a bad split fakes a win.

Part III is done — you can build metrics, tell the kinds of analysis apart, know
your customers, read trends, and tell real from noise. Next we make it all visible:
Power BI and the art of showing your data.
