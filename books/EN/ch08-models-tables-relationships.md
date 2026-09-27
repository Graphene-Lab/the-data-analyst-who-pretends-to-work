# 8. Models, Tables, and Relationships

A pile of tables is not a model. A **model** is what you get when you tell the
computer how the tables *relate* to each other. Those connections — the wiring —
are what let you ask a question in one place and get an answer that spans many
tables. This chapter is about that wiring.

## Tables, rows, and keys

Every table has **rows** (one record each) and **columns** (one attribute each). The
magic is in the **key** — a column that uniquely identifies each row. A customer ID,
a product code, an order number. Keys are how tables recognise each other.

- A **primary key** is the unique ID in a table (one row per customer).
- A **foreign key** is a column in another table that points to that ID (each sale
  stores the customer's ID).

## The relationship: how two tables talk

A **relationship** connects a foreign key to a primary key. Once connected, the
computer can answer questions that cross tables: "which product was in this sale?"
"which city did this customer live in?" — without you ever merging files by hand.

The most common kind is **many-to-one**: many sales point to one product. Each sale
has a product ID; the product table has one row per product. Many sales, one
product. That is the backbone of almost every business model.

## Wiring it up, live

Here is the assistant creating a relationship from a plain request:

> "Connect Sales to Products on ProductID."

![Sales to Products relationship](../../assets/examples/e015.png)

The tool reports the direction (Many→One) and confirms it's live in Power BI
Desktop. Then the customer link:

> "Connect Sales to Customers on CustomerID."

![Sales to Customers relationship](../../assets/examples/e016.png)

And the store link:

> "Connect Sales to Stores on StoreID."

![Sales to Stores relationship](../../assets/examples/e017.png)

Three sentences, and the model now has a spine. Every later question about "sales
by product", "sales by customer", "sales by store" works because of these three
lines.

## Seeing the whole wiring

> "Show all the relationships in the model."

![All relationships](../../assets/examples/e018.png)

Three clean Many→One relationships, all active. This is the wiring diagram — the
thing you check first when a number looks wrong.

## The star schema: the shape you want

Pull it together and you get the most famous shape in business data: the **star
schema**. A fact table in the middle (Sales), surrounded by dimension tables
(Products, Customers, Stores, Date). The fact table holds the numbers; the
dimensions hold the descriptive detail. Drawn out, it looks like a star.

Why is it so loved? Because it is simple, fast, and matches how people ask
questions. "Sales by category" is just the fact table reaching over to the product
dimension. Almost every good BI model is a star, or a field of stars.

## A calculated table: summarising on the fly

Sometimes you want a small summary table built from the model itself:

> "Build a small table of total sales per category."

![Sales by category table](../../assets/examples/e019.png)

A new table, computed live, that rolls the detail up into a tidy summary. Handy for
a quick report or a snapshot.

## A curiosity: the many-to-many trap

The most dangerous relationship is **many-to-many** without care — many products in
many promotions, many students in many classes. Get it wrong and your totals
double-count or vanish. The fix is a "bridge" table in the middle. If your numbers
suddenly look inflated, a sloppy many-to-many is the first suspect.

---

## Try it yourself

> "How many relationships now?"

![Count relationships](../../assets/examples/e073.png)

A quick check that the wiring is all there.

## What you'll carry from this chapter

- A model is tables plus the relationships between them.
- Keys (primary and foreign) are how tables recognise each other.
- Many-to-one is the backbone of business data.
- The star schema is the shape you usually want.
- Beware sloppy many-to-many — it inflates totals.

Next: asking the data questions directly — SQL and DAX, the two languages of
getting answers.
