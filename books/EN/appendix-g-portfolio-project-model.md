# Appendix G — A Portfolio Project Model

A portfolio proves you can do the job. This model gives you a project to build,
document, and show. Do one or two of these and you have something to point at in an
interview.

## The project: a sales analysis dashboard

Build a small end-to-end analysis on a sample sales dataset (the same shape used
throughout this book: Sales, Products, Customers, Stores).

### Step 1 — Understand the data

- Profile each table.
- Note distinct values, blanks, and ranges.
- Write one sentence per table: what it holds.

### Step 2 — Clean and model

- Standardise messy text (UPPER/LOWER columns).
- Bucket numbers into bands (price bands).
- Wire the relationships (Sales → Products, Customers, Stores).

### Step 3 — Build the metrics

- Total Sales, Total Qty, Orders.
- Average Order Value, Sales per Customer.
- A margin measure (revenue minus cost).
- A share-of-total measure.

### Step 4 — Segment

- Top customers by spend.
- Sales by segment (Retail / Business / Online).
- Sales by region and by month.

### Step 5 — Validate and document

- Validate every measure before saving.
- Lint the DAX for anti-patterns.
- Generate the data dictionary.
- Run the best-practices report.

### Step 6 — Visualise

- A KPI card row (total sales, orders, avg order).
- A bar chart of sales by category.
- A line chart of the monthly trend.
- A leaderboard of top products.

## What to show in the portfolio

For each project, present:

1. **The question.** What business problem you were solving.
2. **The model.** A screenshot of the tables and relationships.
3. **The metrics.** The measures you built, with their DAX.
4. **The dashboard.** The final visuals.
5. **The story.** What you found and what you'd do about it.
6. **The tooling.** A note that you built it with AgentBridge + PowerBITool, and
   how the assistant helped (validation, documentation, best-practices).

## Why this works

An interviewer doesn't care that the tool made it fast. They care that you can:
frame a problem, build a clean model, validate your work, document it, and tell a
story. This project exercises all six. The tool is a bonus that shows you're current
— not a shortcut that replaces the thinking.

## Make it yours

Swap the sample data for a dataset you care about — a hobby, a public dataset, a
side project. The more you care about the subject, the better the questions you'll
ask, and the better the portfolio looks. The pattern is the same; the data is
yours to choose.
