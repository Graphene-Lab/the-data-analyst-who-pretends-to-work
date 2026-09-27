# 18. Datenmodellierung in Power BI

Beim Modellieren wird die Analyse gewonnen oder verloren. Ein gutes Modell macht
jede Frage leicht; ein schlechtes Modell macht jede Frage zum Kampf. Dieses Kapitel
zeigt den Assistenten als sorgfältigen Modellierer – einen, der das Modell nicht nur
baut, sondern es dokumentiert und gegen Best Practices prüft.

## Wie ein gutes Modell aussieht

Das Sternschema hast du in Kapitel 8 kennengelernt. In Power BI heißt ein gutes
Modell:

- Eine saubere **Faktentabelle** (die Zahlen: Verkäufe, Transaktionen).
- Ordentliche **Dimensionstabellen** (die Beschreibungen: Produkte, Kunden, Daten).
- **Beziehungen** richtig verdrahtet (viele-auf-eins, keine Mehrdeutigkeit).
- **Maße** mit klaren Namen, Formaten und Beschreibungen.
- **Dokumentation**, damit der Nächste (oder du in sechs Monaten) es versteht.

Bei all dem hilft der Assistent, live.

## Dokumentieren beim Arbeiten

Gute Modelle sind dokumentierte Modelle. Der Assistent kann auf Zuruf
Beschreibungen zu Tabellen und Spalten hinzufügen:

> „Füge eine Beschreibung zur Sales-Tabelle hinzu."

![Tabellenbeschreibung](../../assets/examples/e046.png)

> „Beschreibe die Amount-Spalte."

![Spaltenbeschreibung](../../assets/examples/e047.png)

Diese kleinen Notizen erscheinen im Modell und im Datenwörterbuch. Sie sind der
Unterschied zwischen einem Modell, das eine Blackbox ist, und einem, das ein
gemeinsames Gut ist.

> „Setze eine Beschreibung auf die Products-Tabelle."

![Products-Beschreibung](../../assets/examples/e080.png)

## Das Datenwörterbuch, Tabelle für Tabelle

Du kannst das ganze Modell oder eine einzelne Tabelle dokumentieren:

> „Erzeuge ein Datenwörterbuch nur für Products."

![Products-Wörterbuch](../../assets/examples/e045.png)

Ein fokussiertes Wörterbuch für eine Tabelle – praktisch, wenn du einem Kollegen ein
Stück des Modells übergibst.

## Der Gesundheitscheck: Best Practices

Das ist einer der wertvollsten Züge des Assistenten. Er scannt das ganze Modell und
meldet Probleme und Tipps:

> „Prüf das Modell gegen Best Practices."

![Best-Practices-Bericht](../../assets/examples/e048.png)

Er flaggt Maße ohne Formatstring, Tabellen ohne Beschreibung, nicht verbundene
Tabellen – die kleinen Sünden, die ein Modell schwer benutzbar machen. Das ist wie
ein Linter für dein Datenmodell: Er hindert dich nicht am Arbeiten, aber er sagt
dir, wo das Modell unordentlich ist, bevor dich das Chaos beißt.

## Nach Änderungen erneut prüfen

Beim Bauen driftet das Modell. Den Check erneut laufen zu lassen hält es ehrlich:

> „Best Practices nach dem Hinzufügen von Maßen."

![Best Practices nach Änderungen](../../assets/examples/e093.png)

Ein schneller Re-Scan zeigt, was deine letzten Änderungen eingeführt haben. Bauen,
prüfen, beheben, wiederholen – der Rhythmus eines sauberen Modells.

## Eine Kuriosität: der Bus-Faktor

In Software-Teams gibt es eine Metrik namens **Bus-Faktor**: wie viele Leute „vom
Bus erfasst" werden müssten, bevor ein Projekt feststeckt, weil es nur einer
versteht. Ein Modell ohne Dokumentation hat einen Bus-Faktor von eins –
furchteinflößend. Jede Beschreibung und jeder Wörterbucheintrag, den der Assistent
schreibt, hebt diese Zahl. Du räumst nicht nur auf; du machst das Modell
überlebensfähig.

## Warum der Assistent ein guter Modellierer ist

Ein menschlicher Modellierer unter Deadline-Druck überspringt Dokumentation und
Best Practices. Der Assistent wird nicht müde, überspringt keine Schritte und prüft
alles. Koppel das Urteilsvermögen eines Menschen darüber, *was* man modelliert, mit
der Sorgfalt des Assistenten beim *Dokumentieren und Prüfen*, und du bekommst
Modelle, die sauber bleiben.

---

## Was du aus diesem Kapitel mitnimmst

- Ein gutes Modell: saubere Fakt + Dimensionen, richtig verdrahtet, dokumentiert.
- Füge Beschreibungen zu Tabellen, Spalten und Maßen hinzu, während du arbeitest.
- Erzeuge Datenwörterbücher, um das ganze Modell oder eine Tabelle zu dokumentieren.
- Lauf den Best-Practices-Check wie einen Linter – oft.
- Dokumentation hebt den Bus-Faktor; sie macht das Modell überlebensfähig.

Als Nächstes: DAX, die Sprache hinter den Zahlen – und wie du sie nicht schreiben
musst.
