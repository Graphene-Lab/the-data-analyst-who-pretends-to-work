# Appendix F — Exercise Solutions

Solutions to the guided exercises in Appendix E. Each shows the plain-English ask
and the DAX the assistant produces.

## Exercise 1 — Read the model

**Ask:** "List every table with its row count."
**What happens:** the assistant reads the live model and returns each table with its
type, row count, and column count. No DAX needed — it's a discovery call.

## Exercise 2 — Profile a table

**Ask:** "Profile the Products table."
**What happens:** the assistant returns a profile table with Distinct, Blanks, Min,
Max, and Top values per column. The distinct count of Category is 3; blanks show
per column.

## Exercise 3 — Clean text

**Ask:** "Add a column with the category in capital letters."
**DAX:** `UPPER(Products[Category])`
**Result:** a new calculated column `Products[CategoryUpper]`.

## Exercise 4 — Bucket a number

**Ask:** "Bucket products into High / Mid / Low by price."
**DAX:**
```
SWITCH(TRUE(),
  Products[Price] >= 200, "High",
  Products[Price] >= 50, "Mid",
  "Low")
```
**Result:** a new calculated column `Products[PriceBand]`.

## Exercise 5 — Wire a relationship

**Ask:** "Connect Sales to Products on ProductID."
**Result:** a many-to-one, single-direction, active relationship
`Sales[ProductID] → Products[ProductID]`.

## Exercise 6 — Build a measure

**Ask:** "Create a Total Sales measure with a euro format."
**DAX:** `SUM(Sales[Amount])` with format `#,##0.00 €`.
**Result:** a new measure `Sales[Total Sales]`.

## Exercise 7 — Filter a measure

**Ask:** "Count only sales above 300."
**DAX:** `COUNTROWS(FILTER(Sales, Sales[Amount] > 300))`
**Result:** a new measure `Sales[Big Sales Count]`.

## Exercise 8 — Share of total

**Ask:** "Each category's share of total sales."
**DAX:** `DIVIDE([Total Sales], CALCULATE([Total Sales], ALL(Sales)))`
**Result:** a new measure `Sales[Pct Of Total]` with a percent format.

## Exercise 9 — Rank

**Ask:** "Rank products by sales."
**DAX:** `RANKX(ALL(Products), [Total Sales])`
**Result:** a leaderboard with each product's rank.

## Exercise 10 — Validate before you save

**Ask:** "Is this a valid measure? SUM(Sales[Amount])"
**What happens:** the assistant validates and returns "Valid" with a sample value
(22023). Only then do you create the measure.

## Exercise 11 — Lint

**Ask:** "Lint this DAX: SUM(a)/SUM(b)"
**What happens:** the linter flags the `/` and suggests `DIVIDE()` to handle
divide-by-zero safely.

## Exercise 12 — Document

**Ask:** "Generate a data dictionary for the whole model."
**What happens:** the assistant returns a markdown dictionary listing every table,
its type and row count, and every measure with its format and expression.

## The pattern in every solution

Ask plainly → the assistant writes correct DAX → it applies the change live → it
reports exactly what it did. That loop is the whole skill. Once it feels natural,
you've internalised the book.
