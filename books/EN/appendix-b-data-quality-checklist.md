# Appendix B — Data Quality Checklist

Use this before trusting any analysis. Each item can be checked with the assistant.

## Completeness

- [ ] No unexpected blank values in key columns. *(Profile the table; look at the
      Blanks column.)*
- [ ] Every expected row is present (no missing periods, regions, or products).
- [ ] Row counts match the source system.

## Accuracy

- [ ] Totals reconcile with the source of truth.
- [ ] Numbers are in the right unit (euros vs cents, units vs cases).
- [ ] No obviously wrong values (negative quantities, dates in the future).

## Consistency

- [ ] Text is standardised (no "Milan" vs "milan" vs "MILAN"). *(Add an
      UPPER/LOWER column to check.)*
- [ ] Same entity has the same name everywhere.
- [ ] Codes match across tables (every ProductID in Sales exists in Products).

## Uniqueness

- [ ] Key columns are unique where they should be (one row per SaleId).
- [ ] No duplicate customers, products, or stores.

## Validity

- [ ] Values fall within expected ranges (price > 0, dates valid).
- [ ] Categories come from an allowed list.
- [ ] Formats are correct (dates are dates, not text).

## Timeliness

- [ ] Data is current enough for the decision.
- [ ] The refresh happened when it was supposed to.

## Integrity

- [ ] Relationships are wired correctly (many-to-one, active).
- [ ] No orphan rows (sales pointing to a missing product).
- [ ] The model passes the best-practices check.

## How the assistant helps

- **Profile** each table to see distinct values, blanks, min/max, samples.
- **Validate** formulas before you save them.
- **Lint** DAX to catch risky patterns.
- **Best-practices report** to check the whole model at once.

A clean model is not a nice-to-have. Every number downstream inherits the quality
of the data upstream. Check it once, trust it everywhere.
