# 24. Automating the Analyst's Day

Let's spend a day inside the analyst's work and watch the assistant handle it. This
chapter strings together the examples the way a real working day goes: build,
validate, document, check, finish. Each image is a real action on a live model.

## Morning: build the reporting pieces

The day starts by turning raw tables into reporting pieces. Instead of clicking for
an hour, you ask for what the dashboard needs.

> "Build a category performance table with sales and product count."

![Category performance table](../../assets/examples/e065.png)

One ask, one new table — sales and product count per category, computed and live.

Then the KPIs the dashboard needs:

> "Create a KPI measure set for the dashboard."

![KPI measure set](../../assets/examples/e066.png)

A measure for revenue per customer, created and applied. The kind of small metric
that used to take a careful minute each now arrives in a sentence.

## Before the meeting: validate everything

Before you build the report, you check that the numbers are right. The assistant
validates a whole batch at once:

> "Validate a batch of measures before I build the report."

![Batch validation](../../assets/examples/e067.png)

Each measure returns OK with its value. No surprises in front of the boss.

## Mid-morning: catch the gaps

A good analyst looks for what's *missing*, not just what's present:

> "Which products never sold?"

![Products that never sold](../../assets/examples/e070.png)

The query runs and returns zero rows — every product sold at least once. That's a
useful answer too: no dead stock hiding in the catalogue.

## Late morning: model behaviour

You want to flag repeat behaviour without hand-tagging rows:

> "Create a returning-customer flag."

![Returning-customer flag](../../assets/examples/e085.png)

A Boolean column that marks each sale as repeat or not — computed across the whole
table in one go.

And the best performer:

> "Give me the top store by sales."

![Top store by sales](../../assets/examples/e087.png)

Milan Central leads. The ranking that used to need a pivot and a sort is now a
single question.

## Afternoon: targeting

The marketing team wants high-value customers:

> "Create a high-value customer measure."

![High-value customer measure](../../assets/examples/e095.png)

A flag for customers over a spend threshold, live in the model, ready to filter on.

And to see how the price bands we made earlier perform:

> "Sales by price band."

![Sales by price band](../../assets/examples/e097.png)

High, Mid, Low — the band column from Chapter 7 now drives a real breakdown. This
is the payoff of building small pieces: they combine later.

## End of day: document and check

Before you close, you document the work and check its health. The assistant writes
the dictionary for the whole model:

> "Document the final model."

![Final data dictionary](../../assets/examples/e099.png)

Every table, every measure, with its format and expression — documentation you would
never have written by hand, done for you.

Then the health check:

> "Final health check of the whole model."

![Final health check](../../assets/examples/e100.png)

Zero warnings. The two "info" notes are just disconnected summary tables, which is
expected. The model is clean.

## Close: the finished model

At the end of the day, you look at what you built:

> "Show the final list of tables."

![Final list of tables](../../assets/examples/e102.png)

Six tables, fourteen measures, three relationships — a working analytical model,
built and documented in a single day of plain-language asks.

## What the day shows

A whole working day — build, validate, catch gaps, model behaviour, target,
document, check — done by describing each step. The analyst's hands did none of the
clicking. The analyst's head did all the deciding.

That's the trade this book keeps making: **you keep the judgement, the tool takes
the drudgery.**

---

## What you'll carry from this chapter

- A full day of analyst work maps to a sequence of plain-language asks.
- Build pieces (tables, measures), validate them, catch gaps, document, check.
- Small pieces combine later (the price band drives a breakdown).
- The model ends clean, documented, and ready — with none of the manual clicking.

Next: storytelling, ethics, and governance — the part the tool can't do for you.
