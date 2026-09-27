# Anhang F — Lösungen der Übungen

Lösungen der geführten Übungen in Anhang E. Jede zeigt den Auftrag in normaler
Sprache und das DAX, das der Assistent produziert.

## Übung 1 — Das Modell lesen

**Auftrag:** „Liste jede Tabelle mit ihrer Zeilenzahl."
**Was passiert:** Der Assistent liest das Live-Modell und gibt jede Tabelle mit
ihrem Typ, ihrer Zeilenzahl und ihrer Spaltenzahl zurück. Kein DAX nötig – es ist
ein Discovery-Call.

## Übung 2 — Eine Tabelle profilieren

**Auftrag:** „Erstelle ein Profil der Products-Tabelle."
**Was passiert:** Der Assistent gibt eine Profil-Tabelle mit Distinct, Blanks, Min,
Max und Top-Werten pro Spalte zurück. Die Anzahl verschiedener Werte von Category
ist 3; Leerstellen zeigen pro Spalte.

## Übung 3 — Text säubern

**Auftrag:** „Füge eine Spalte hinzu mit der Kategorie in Großbuchstaben."
**DAX:** `UPPER(Products[Category])`
**Ergebnis:** eine neue berechnete Spalte `Products[CategoryUpper]`.

## Übung 4 — Eine Zahl in Bänder einteilen

**Auftrag:** „Sortiere die Produkte nach Preis in High / Mid / Low."
**DAX:**
```
SWITCH(TRUE(),
  Products[Price] >= 200, "High",
  Products[Price] >= 50, "Mid",
  "Low")
```
**Ergebnis:** eine neue berechnete Spalte `Products[PriceBand]`.

## Übung 5 — Eine Beziehung verdrahten

**Auftrag:** „Verbinde Sales mit Products über ProductID."
**Ergebnis:** eine viele-auf-eins-, gerichtete, aktive Beziehung
`Sales[ProductID] → Products[ProductID]`.

## Übung 6 — Ein Maß bauen

**Auftrag:** „Erstelle ein Maß Gesamtumsatz mit Euro-Format."
**DAX:** `SUM(Sales[Amount])` mit Format `#,##0.00 €`.
**Ergebnis:** ein neues Maß `Sales[Total Sales]`.

## Übung 7 — Ein Maß filtern

**Auftrag:** „Zähle nur Verkäufe über 300."
**DAX:** `COUNTROWS(FILTER(Sales, Sales[Amount] > 300))`
**Ergebnis:** ein neues Maß `Sales[Big Sales Count]`.

## Übung 8 — Anteil am Ganzen

**Auftrag:** „Der Anteil jeder Kategorie am Gesamtumsatz."
**DAX:** `DIVIDE([Total Sales], CALCULATE([Total Sales], ALL(Sales)))`
**Ergebnis:** ein neues Maß `Sales[Pct Of Total]` mit Prozentformat.

## Übung 9 — Rangieren

**Auftrag:** „Rangiere Produkte nach Umsatz."
**DAX:** `RANKX(ALL(Products), [Total Sales])`
**Ergebnis:** eine Rangliste mit dem Rang jedes Produkts.

## Übung 10 — Validieren, bevor du speicherst

**Auftrag:** „Ist das ein gültiges Maß? SUM(Sales[Amount])"
**Was passiert:** Der Assistent validiert und gibt „Valid" mit einem Beispielwert
zurück (22023). Erst dann erstellst du das Maß.

## Übung 11 — Linten

**Auftrag:** „Lint dieses DAX: SUM(a)/SUM(b)"
**Was passiert:** Der Linter flaggt den `/` und schlägt `DIVIDE()` vor, um
Division durch null sicher zu behandeln.

## Übung 12 — Dokumentieren

**Auftrag:** „Erzeuge ein Datenwörterbuch für das ganze Modell."
**Was passiert:** Der Assistent gibt ein Markdown-Wörterbuch zurück, das jede
Tabelle, ihren Typ und ihre Zeilenzahl sowie jedes Maß mit seinem Format und
Ausdruck auflistet.

## Das Muster in jeder Lösung

Schlicht fragen → der Assistent schreibt korrektes DAX → er wendet die Änderung
live an → er meldet genau, was er tat. Diese Schleife ist die ganze Fähigkeit.
Wenn sie sich natürlich anfühlt, hast du das Buch verinnerlicht.
