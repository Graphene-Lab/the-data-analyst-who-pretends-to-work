# Appendix E — Guided Exercises

Practice the agentic pattern. Each exercise gives you a goal and a hint. Try it
yourself first; the solutions are in Appendix F.

## Exercise 1 — Read the model

**Goal:** Connect to a Power BI report and list every table with its row count.
**Hint:** Ask for the tables and their rows in one sentence.
**You'll learn:** connection and discovery.

## Exercise 2 — Profile a table

**Goal:** Find out how many distinct categories exist and whether any column has
blanks.
**Hint:** Profile the table and read the Distinct and Blanks columns.
**You'll learn:** data quality at a glance.

## Exercise 3 — Clean text

**Goal:** Add a column that puts a text field in capital letters so it groups
cleanly.
**Hint:** Ask for an UPPER-style calculated column.
**You'll learn:** standardising messy data.

## Exercise 4 — Bucket a number

**Goal:** Turn a price column into High / Mid / Low bands.
**Hint:** Ask for a calculated column with a threshold rule.
**You'll learn:** turning a number into a usable category.

## Exercise 5 — Wire a relationship

**Goal:** Connect a sales table to a product table on the shared ID.
**Hint:** Ask for a many-to-one relationship on the matching column.
**You'll learn:** the wiring that lets data flow.

## Exercise 6 — Build a measure

**Goal:** Create a total-sales measure with a euro format.
**Hint:** Ask for a SUM measure with a currency format.
**You'll learn:** the most basic, most important measure.

## Exercise 7 — Filter a measure

**Goal:** Create a measure that counts only sales above a threshold.
**Hint:** Use CALCULATE with a filter condition.
**You'll learn:** conditional aggregation.

## Exercise 8 — Share of total

**Goal:** Make a measure showing each category's share of total sales.
**Hint:** Divide the filtered total by the ALL() total.
**You'll learn:** part-over-whole.

## Exercise 9 — Rank

**Goal:** Produce a leaderboard of products by sales.
**Hint:** Ask for a ranking with RANKX.
**You'll learn:** ordering by a metric.

## Exercise 10 — Validate before you save

**Goal:** Check that a formula is valid before creating the measure.
**Hint:** Validate the DAX first; create it second.
**You'll learn:** the safe order of operations.

## Exercise 11 — Lint

**Goal:** Find a risky division in a formula.
**Hint:** Lint a formula that uses `/` instead of DIVIDE.
**You'll learn:** catching anti-patterns.

## Exercise 12 — Document

**Goal:** Generate a data dictionary for the whole model.
**Hint:** Ask for the dictionary and read what it returns.
**You'll learn:** documentation as a one-sentence task.

Work through these in order. Each one is a real action on a live model — the same
kind you saw in the chapters. When you can do all twelve, you can do the job.
