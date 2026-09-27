# 9. Fragen stellen mit SQL und DAX

Sind die Daten drin und verdrahtet, stellst du ihnen Fragen. Es gibt zwei Sprachen,
die du erkennen solltest: **SQL** für Datenbanken und **DAX** für Power BI. Du musst
sie nicht mehr von Hand schreiben – der Assistent tut das –, aber du solltest
verstehen, was sie tun, damit du gut fragen und die Antworten lesen kannst.

## SQL: die Sprache der Datenbanken

**SQL** (Structured Query Language) ist seit den 1970ern der Weg, mit Datenbanken
zu reden. Es liest sich fast wie Englisch:

- `SELECT` – welche Spalten du willst
- `FROM` – aus welcher Tabelle
- `WHERE` – welche Zeilen bleiben
- `GROUP BY` – wie man bündelt und aufsummiert

Ein Klassiker: *„Gesamtumsatz pro Region"* ist ein SELECT, ein JOIN auf die
Regionstabelle und ein GROUP BY. SQL ist überall – wenn deine Firma eine Datenbank
hat, liest du sie mit SQL.

## DAX: die Sprache von Power BI

**DAX** (Data Analysis Expressions) ist die Sprache in Power BI. Sie sieht anders
aus als SQL, macht aber denselben Job: nach einer Zahl fragen, eine Zahl bekommen.
DAX ist um **Maße** herum gebaut – benannte Berechnungen, die man wiederverwenden
kann. `SUM`, `AVERAGE`, `COUNT`, `CALCULATE` sind seine Zugpferde.

Das Schöne: Du musst kein DAX tippen. Du beschreibst die Antwort, die du willst,
und der Assistent schreibt und ausführt das DAX für dich. Schauen wir zu.

## Zählen und Summieren

> „Wie viele Zeilen hat Sales?"

![Zeilen zählen](../../assets/examples/e020.png)

Sechzig Verkaufsdatensätze. Einfach, sofort.

> „Wie hoch ist die Summe der Spalte Amount?"

![Summe des Betrags](../../assets/examples/e021.png)

22.023 € Gesamtumsatz. So eine Zahl bedeutete früher eine Pivot-Tabelle und zehn
Minuten; jetzt ist sie ein Satz.

## Rangieren und Filtern

> „Top 3 Produkte nach Gesamtumsatz."

![Top-Produkte](../../assets/examples/e022.png)

Der Assistent rangiert sie für dich. (Beachte, wie er das komplette Ranking
zurückgibt, damit du das ganze Bild siehst, nicht nur die oberste Scheibe.)

> „Zeig mir Verkäufe größer als 500."

![Verkäufe über 500](../../assets/examples/e023.png)

Ein Filter, live ausgeführt, der jeden großen Verkauf zurückgibt. So findest du die
Ausreißer und die Wale.

## Gruppieren über eine Beziehung hinweg

> „Gesamtumsatz nach Stadt der Filiale."

![Umsatz nach Stadt](../../assets/examples/e024.png)

Das ist der Moment, in dem sich das Modell auszahlt: Der Assistent greift über die
Sales→Stores-Beziehung und summiert nach Stadt, ganz ohne manuelles Zusammenführen.

## Einen verwandten Wert ziehen

> „Zeig für jeden Verkauf den Produktnamen."

![Verwandter Produktname](../../assets/examples/e025.png)

Mit `RELATED` zieht der Assistent den Produktnamen auf jeden Verkauf – so ein Ding
bedeutet in Excel ein VLOOKUP und ein Gebet.

## Noch ein paar, weil sie leicht sind

> „Insgesamt verkaufte Menge."

![Gesamtmenge](../../assets/examples/e074.png)

> „Zähle Verkäufe mit Menge über 3."

![Verkäufe mit großer Menge zählen](../../assets/examples/e088.png)

Jeder ein schlichter Satz, jeder eine echte DAX-Abfrage gegen das Live-Modell.

## Eine Kuriosität: Der schlechte Ruf von DAX

DAX hat den Ruf, schwer zu sein. Es ist nicht schwer zu *benutzen* – schwer ist,
*den Filterkontext zu beherrschen*, die subtile Regel darüber, welche Daten eine
Berechnung in jedem Moment sieht. Aber hier ist das Geheimnis dieses Buches: Du
musst es nicht beherrschen. Du beschreibst die Antwort; der Assistent schreibt das
DAX und kümmert sich um den Kontext. Die Schwierigkeit wandert von deinen Schultern
auf die des Werkzeugs.

---

## Was du aus diesem Kapitel mitnimmst

- SQL redet mit Datenbanken; DAX redet mit Power BI.
- Beide lesen sich nah am Englischen: select, filter, group, total.
- Du beschreibst die Antwort; der Assistent schreibt und ausführt die Abfrage.
- Beziehungen machen tabellenübergreifende Fragen trivial.
- Der schwere Teil von DAX ist jetzt das Problem des Werkzeugs, nicht deins.

Als Nächstes: die Tabellenkalkulation – wo fast jeder anfängt, und die Wand, an der
jeder etwas mehr braucht.
