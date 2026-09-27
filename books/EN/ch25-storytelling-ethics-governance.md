# 25. Storytelling, Ethics, and Governance

Here is the part the tool cannot do for you. It can build the measure, validate the
DAX, and document the model. It cannot decide what the story means, whether the
number is honest, or whether the model is safe to trust. That is yours. This
chapter is about the three things that stay human.

## Storytelling: the number is not the point

A dashboard full of correct numbers that tells no story is a wall of noise. The
value of analysis is the decision it drives. So the analyst's real job is to turn
numbers into a story someone can act on.

A simple structure works:

- **What happened.** The fact, plainly. "Kitchen sales fell this quarter."
- **Why it matters.** The stakes. "Kitchen is 40% of our revenue."
- **What to do.** The action. "Review the supplier price on the top SKU."

The assistant gives you the first line instantly. The second and third lines are
judgement — context the tool doesn't have.

> A curiosity: the word "data" comes from the Latin *dare*, "to give." Data is
> meant to be given, not hoarded. A number that never reaches a decision was never
> really given at all.

## The honesty of a chart

The same data can tell opposite stories depending on how you draw it. A truncated
axis makes a small change look huge. A cherry-picked time window makes a dip look
like a trend. This is not new — it is as old as charts themselves — but a tool that
makes charts effortless also makes misleading ones effortless.

The rule is simple: **draw the honest chart, then tell the honest story.** If you
would feel uneasy explaining why you cut the axis at that point, don't cut it.

> A famous caution: "There are three kinds of lies: lies, damned lies, and
> statistics." The joke endures because a number carries an air of truth that words
> don't. That air is a responsibility, not a trick.

## Ethics: three questions to ask before you publish

Before any analysis reaches a decision-maker, ask:

1. **Is it true?** Does the number actually mean what the label claims? (The
   assistant's validation helps here — but you own the meaning.)
2. **Is it fair?** Could this analysis be used to hurt someone unfairly — to
   single out a person, penalise a group, or hide an uncomfortable truth?
3. **Is it private?** Does the data include personal information that should be
   protected or aggregated?

A tool that makes analysis fast also makes it easy to skip these questions. Don't.
Speed is no excuse for a careless or harmful conclusion.

## Governance: the model is an asset

A model that drives decisions is a business asset, and assets need governance:

- **Who owns it?** Someone must be accountable for the numbers.
- **Where did it come from?** The data source and the transformations must be
  traceable.
- **Is it documented?** A model nobody understands is a model nobody can trust —
  or safely change.
- **Is it checked?** Regular best-practice and quality checks keep drift out.

This is where the assistant quietly shines. Every measure it creates can carry a
description. Every model can get a generated data dictionary and a best-practices
report. Governance is usually the thing teams skip because it's tedious — and
tedious is exactly what an assistant removes.

> A curiosity: the term "governance" in data comes from the same root as
> "government." It is not bureaucracy for its own sake — it is the rule of law for
> your numbers. Without it, the data is a failed state.

## The human edge, restated

The assistant can do the *how*. You own the *what*, the *why*, and the *should*.
That division is not a limitation — it is the whole reason a human is still in the
loop. The analyst of the future is not replaced by the tool; the analyst is the one
who asks the tool the right questions and answers the ethical ones the tool can't.

## A short checklist for the human

Before you publish anything the assistant helped build:

- [ ] The chart is honest (no misleading axis, no cherry-picked window).
- [ ] The number means what the label says.
- [ ] The story answers "so what?" and "now what?"
- [ ] The model is documented and has an owner.
- [ ] The analysis could not be used to harm unfairly.
- [ ] Personal data is protected or aggregated.

Six boxes. The tool did the hours of work; these six checks are the human part that
keeps it trustworthy.

---

## What you'll carry from this chapter

- The number is not the point — the decision is.
- Draw the honest chart, tell the honest story.
- Ask: is it true, fair, private?
- The model is an asset: owner, traceability, documentation, checks.
- The tool does the *how*; you own the *what*, *why*, and *should*.

Next: your career as a data analyst in the age of the assistant.
