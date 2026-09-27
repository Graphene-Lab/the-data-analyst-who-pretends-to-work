# Appendix A — Glossary of Terms

Plain-English definitions of the terms used in this book.

**Agent / agentic.** Software that takes *actions* toward a goal, not just answers
questions. An agent closes the loop from intent to result.

**AgentBridge.** The local, plain-language AI assistant that plans and acts across
tools. The "brain" in this book.

**PowerBITool.** The AgentBridge plugin that operates Microsoft Power BI Desktop.
The "hands" in this book.

**Power BI Desktop.** Microsoft's tool for building data models and reports.

**Model.** The set of tables, columns, measures, and relationships that Power BI
uses to answer questions.

**Table.** A set of rows and columns. The basic container for data.

**Column.** A single field in a table, with a data type (text, number, date).

**Measure.** A calculated value (usually an aggregate like a sum or average) that
responds to filters in a report.

**Calculated column.** A new column added to a table, computed with a formula for
every row.

**Calculated table.** A new table created from a formula, computed on the fly.

**Relationship.** A link between two tables (e.g. Sales → Products) so data flows
between them.

**Cardinality.** The "one-to-many" or "many-to-one" nature of a relationship.

**DAX.** Data Analysis Expressions — the formula language of Power BI.

**SQL.** Structured Query Language — the standard language for querying databases.

**SUM / AVERAGE / COUNT.** Basic aggregates: total, mean, and count.

**DISTINCTCOUNT.** Count of unique values.

**CALCULATE.** A DAX function that changes the filter context of a measure.

**FILTER.** A DAX function that keeps rows matching a condition.

**RELATED.** A DAX function that pulls a value from a related table.

**DIVIDE.** A safe division function that handles divide-by-zero.

**ALL.** A DAX function that removes filters (often used for "% of total").

**RANKX.** A DAX function that ranks rows by a value.

**TOPN.** A DAX function that returns the top N rows.

**Filter context.** The set of filters currently applied when a measure computes.

**Row context.** The "current row" when a calculated column or iterator computes.

**Iterator.** A DAX function (SUMX, AVERAGEX) that evaluates row by row.

**Data dictionary.** Documentation of every table, column, and measure in a model.

**Profiling.** Inspecting a table's distinct values, blanks, min/max, and samples.

**Linting.** Static checks that flag risky patterns (e.g. `/` instead of `DIVIDE`).

**Best practices.** A health check of the model against known good patterns.

**Fail-closed guard.** A safety rule that blocks anything not clearly allowed.

**Data quality.** How clean, complete, and trustworthy the data is.

**Segmentation.** Splitting customers or data into groups for analysis.

**Seasonality.** Regular, repeating patterns over time.

**KPI.** Key Performance Indicator — a metric that matters to the business.

**Dashboard.** A view of key KPIs, usually on one screen.

**Report.** A detailed, interactive set of visuals built on a model.

**Data governance.** The rules, ownership, and controls around a data asset.

**Jevons paradox.** When something gets cheaper, we use more of it, not less.
