# Appendix H — Interview FAQs

Common data analyst interview questions, with short answers that show you understand
both the craft and the modern tooling.

## "What does a data analyst actually do?"

Turns business questions into data answers. Finds and cleans data, models it,
computes metrics, and tells a story that drives a decision. The tool handles the
doing; the analyst owns the question and the judgement.

## "SQL or DAX?"

Both. SQL for querying databases; DAX for modelling and measures in Power BI. They
complement each other. Knowing when to use which is the real skill.

## "What's the difference between a calculated column and a measure?"

A calculated column is computed once per row and stored. A measure is computed at
query time, responding to filters. Use a column for row-level attributes; use a
measure for aggregations that must react to the report's filters.

## "Explain CALCULATE."

CALCULATE changes the filter context of a measure. It's the most powerful function
in DAX because it lets you compute a value under a specific set of filters — for
example, sales for one category, or excluding a region.

## "How do you handle divide-by-zero?"

Use DIVIDE instead of `/`. DIVIDE returns a safe result (blank or a fallback) when
the denominator is zero. Never use raw `/` in a measure.

## "How do you check data quality?"

Profile the tables: distinct values, blanks, min/max, duplicates. Reconcile totals
with the source. Run a best-practices check on the model. A clean model is the
foundation of every trustworthy number.

## "What's a star schema?"

A central fact table (e.g. Sales) connected to dimension tables (Products,
Customers, Stores) by many-to-one relationships. It's the standard, efficient
shape for analytical models.

## "How do you deal with a misleading chart?"

Redraw it honestly. Check the axis, the time window, and the aggregation. If a
chart can be read two ways, the analyst's job is to make the honest reading the
obvious one.

## "What do you do when the data contradicts the expected answer?"

Trust the data, then investigate why. A surprising result is often the most
valuable one. Check the source, the filters, and the definitions before concluding.

## "How do you use AI tools in your workflow?"

As an accelerator, not a replacement. I use an assistant (AgentBridge +
PowerBITool) to build and validate measures, document the model, and run
best-practices checks — so I spend my time on the questions and the story, not the
syntax. I check every number before I publish it. The tool does the how; I own the
what and the why.

## "Tell me about a project you built."

Use the portfolio project from Appendix G: the question, the model, the metrics,
the dashboard, the story, and how the assistant helped. Show that you can do the
whole chain and that you understand every step.

## The meta-answer

Almost every good answer comes back to the same idea: **the tool makes the work
fast; the analyst makes it right.** Show that you know both halves and you stand out
from the people who only know one.
