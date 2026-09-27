# 10. Tabellenkalkulation, Excel und die Wand

Kein Buch über Datenanalyse kann die Tabellenkalkulation auslassen. Sie ist der
Ort, wo fast jeder anfängt, und das aus gutem Grund – sie ist brillant. Aber sie
ist auch der Ort, wo man gegen eine Wand läuft, und zu wissen, wo diese Wand ist,
sagt dir, wann du weiterziehen musst.

## Warum die Tabellenkalkulation gewonnen hat

Die Tabellenkalkulation ist eine der erfolgreichsten Software-Erfindungen aller
Zeiten. Ihr Geniestreich ist, dass sie **direkte Manipulation** ist: Du tippst eine
Zahl in einen Kasten, und die Kästen, die davon abhängen, aktualisieren sich
sofort. Kein Code, kein Kompilieren, kein Warten. Du siehst deine Arbeit und dein
Ergebnis Seite an Seite.

Tabellenkalkulationen gaben ganz normalen Menschen die Macht zu modellieren:
Budgets, Prognosen, Zeitpläne, Preislisten. Vor der Tabellenkalkulation lebte diese
Macht nur auf Mainframes und nur mit Programmierern. Nach ihr konnte es jeder mit
einem PC.

## Die Pivot-Tabelle: Analyse im Kasten

Die **Pivot-Tabelle** ist die Superkraft der Tabellenkalkulation. Zieh ein paar
Felder, und sie fasst tausende Zeilen zusammen: Umsatz nach Monat, nach Produkt,
nach Region. Für einen riesigen Teil der Geschäftsanalyse ist eine Pivot-Tabelle
der ganze Job. Wenn du pivotieren kannst, kannst du analysieren.

## Die Wand

Aber Tabellenkalkulationen haben eine Obergrenze, und jeder Analyst läuft irgendwann
dagegen:

- **Größe** – jenseits einer Million Zeilen stöhnt Excel, wird langsam und stürzt
  ab.
- **Brüchigkeit** – eine gelöschte Zelle, eine kaputte Formel, und die ganze
  Arbeitsmappe ist leise falsch. Es gibt kein Auffangnetz.
- **Keine Beziehungen** – zwei Tabellen zu verbinden heißt VLOOKUP, und VLOOKUP
  bricht in dem Moment, in dem sich Daten bewegen.
- **Versions-Chaos** – „Budget_FINAL_v3_wirklich_final.xlsx", bearbeitet von fünf
  Leuten, die sich alle uneins sind.
- **Kein Aktualisieren** – ein Bericht, der jeden Montag per Kopieren-Einfügen
  aktualisiert wird, ist ein Bericht, der jeden Dienstag falsch ist.
- **Keine geteilte Geschichte** – eine Tabellenkalkulation ist eine Datei, kein
  Live-Dashboard, dem andere vertrauen und das sie erkunden können.

Wenn dein Montagmorgen heißt „Datei öffnen, die neuen Daten einfügen, die Formeln
ziehen, neu speichern, mailen" – dann tust du von Hand, was ein richtiges Modell
von allein macht.

## Die Tabellenkalkulation vs. das Modell

Hier der Unterschied in einer Zeile:

> Eine Tabellenkalkulation speichert Zahlen in Zellen. Ein Modell speichert *Logik*
> und berechnet die Zahlen jedes Mal neu.

In einer Tabellenkalkulation *ist* die Zahl die Antwort, die in einer Zelle sitzt
und vor sich hin fault. In einem Modell wird die Antwort aus den Daten und den
Regeln neu berechnet, jedes Mal wenn du hinschaust, immer aktuell.

## Dieselbe Frage, zwei Wege

In Excel heißt „Gesamtumsatz" eine SUM-Formel über einer Spalte, korrekt nur,
solange niemand die Zeilen anfasst. In einem Modell ist es ein Maß –
`SUM(Sales[Amount])` –, das auf Anfrage neu berechnet wird und von jeder Dimension
aufgeschnitten werden kann, ohne eine einzige neue Formel:

> „Wie hoch ist die Summe der Spalte Amount?"

![Gesamtsumme des Betrags als Maß](../../assets/examples/e021.png)

Dieselbe Zahl, aber jetzt lebt sie in einem Modell, das „nach Region", „nach Monat",
„nach Kunde" beantworten kann, ohne jede Zusatzarbeit – weil die Logik gespeichert
ist, nicht das Ergebnis.

## Eine Kuriosität: die Tabellenkalkulation, die eine Milliarde verlor

1998 trug ein Tabellenkalkulationsfehler zu einem Verlust von 1,2 Milliarden Dollar
bei einem großen Finanzfonds bei (LTCM), und unzählige Firmen wurden von einer
einzigen falschen Zelle verbrannt. 2008 fand man in einer berühmten
Forschungsarbeit über Schulden und Wachstum einen Tabellenkalkulationsfehler – ein
versehentlich ausgeschlossener Satz Zeilen –, der ihre Schlussfolgerung umdrehte und
jahrelang echte Politik beeinflusst hatte. Tabellenkalkulationen sind mächtig, und
genau deshalb sind ihre Fehler gefährlich. Ein Modell mit getesteter Logik ist
sicherer als eine Tabellenkalkulation mit einem versteckten `+`, wo ein `-`
hingehört.

## Bleiben oder gehen

Bleib in der Tabellenkalkulation, wenn: die Daten klein sind, der Job einmalig ist,
du nur skizzierst. Geh zum Modell, wenn: die Daten groß sind, der Bericht sich
wiederholt, mehr als eine Person ihn anfasst, oder du willst, dass er *richtig* und
*aktuell* ist. Der Assistent und Power BI sind der Weg, diese Brücke ohne Schmerz zu
überqueren.

---

## Was du aus diesem Kapitel mitnimmst

- Tabellenkalkulationen sind brillant für kleine, direkte, einmalige Arbeit.
- Die Pivot-Tabelle ist eine echte Superkraft.
- Die Wand: Größe, Brüchigkeit, keine Beziehungen, Versions-Chaos, kein
  Aktualisieren.
- Ein Modell speichert Logik, keine eingefrorenen Ergebnisse.
- Zieh weiter, wenn der Bericht sich wiederholt oder die Daten wachsen.

Teil II ist geschafft – du weißt, woher Daten kommen, wie man sie säubert, wie man
sie verdrahtet und wie man sie befragt. Als Nächstes verwandeln wir Daten in
Bedeutung: die Kennzahlen und Analysearten, die Entscheidungen antreiben.
