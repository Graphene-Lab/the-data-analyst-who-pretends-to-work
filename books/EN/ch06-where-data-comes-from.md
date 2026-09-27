# 6. Where Data Comes From

Before you can analyse anything, you need data — and you need to know what shape
it is in. This chapter is about the raw material: where it comes from, the forms it
takes, and how to take its temperature before you build anything.

## Three kinds of data

Everything you will ever analyse falls into three buckets:

- **Structured** — tidy rows and columns. A sales table, a customer list, a bank
  statement. Easy for computers to read. This is your bread and butter.
- **Semi-structured** — has some order but not a neat grid. A web log, a JSON file
  from an app, an email with fields. Needs a little shaping.
- **Unstructured** — no built-in order. Text documents, images, videos, a customer's
  free-text complaint. The hardest to analyse, and where AI is getting surprisingly
  good.

Most business analysis lives in the structured world. That is the good news: it is
the kind you can point a tool at and get answers fast.

## The usual suspects: where business data hides

- **The ERP / management system** — orders, invoices, stock, customers.
- **The CRM** — leads, opportunities, contacts, sales pipeline.
- **Spreadsheets** — the universal fallback, for better and worse.
- **Databases** — SQL servers holding the company's records.
- **Web and app logs** — every click, page view, and event.
- **CSV / Excel exports** — data pulled from any system into a file.
- **APIs** — live data streamed from a service (weather, shipping, payments).
- **IoT sensors** — temperature, machine status, footfall counters.

A real analysis often stitches several of these together. The analyst's first move
is to find the data and understand its shape.

## Taking the temperature: profiling

Before you trust a table, you **profile** it: how many rows, what columns, how many
distinct values, how many blanks, the minimum and maximum, the most common values.
Profiling is a health check that tells you what you are dealing with before you
build a single chart.

Here is a real one. A person asked the assistant to profile the products table:

> "Profile the Products table."

![Profile the Products table](../../assets/examples/e006.png)

In one shot you can see: 8 products, 3 categories (Kitchen 4, Furniture 3,
Stationery 1), prices from €12 to €349, and a few sample rows. No guessing. The
shape of the data is now obvious.

The same works for customers:

> "Profile the Customers table."

![Profile the Customers table](../../assets/examples/e007.png)

Twelve customers across four cities and three segments. You can already see the
story forming — Milan and Rome are the biggest, the segments are balanced.

## Seeing the columns clearly

Sometimes you just want the structure — the columns and their types. The assistant
reads the schema directly:

> "Show me the schema of the Sales table."

![Schema of the Sales table](../../assets/examples/e008.png)

Every column, its type, and the measures already attached. This is the map you
carry into every later question.

## A curiosity: the "fifth kind" of data

There is a joke among analysts that the fifth kind of data is **data you did not
know you had** — the metadata. When did each record change? Who touched it? How
many times was a page viewed? Metadata is the data *about* your data, and it often
holds the most interesting answers of all.

---

## Try it yourself

> "How many distinct categories are there?"

![Count distinct categories](../../assets/examples/e071.png)

A one-line question, a one-line answer, straight from the live model.

## What you'll carry from this chapter

- Data comes in three shapes: structured, semi-structured, unstructured.
- Business data hides in ERP, CRM, databases, spreadsheets, logs, and APIs.
- Always **profile** before you build — know the shape and the gaps.
- Don't forget the metadata: the data about your data.

Next: the unglamorous, essential work of cleaning dirty data — and how a few
calculated columns fix a mess in seconds.
