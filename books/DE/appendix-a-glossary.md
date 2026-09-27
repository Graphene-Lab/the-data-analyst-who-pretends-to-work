# Anhang A — Glossar der Begriffe

Einfache Erklärungen der Begriffe, die in diesem Buch verwendet werden.

**Agent / agentisch.** Software, die *Aktionen* auf ein Ziel hin unternimmt, nicht
nur Fragen beantwortet. Ein Agent schließt die Schleife von Absicht zu Ergebnis.

**AgentBridge.** Der lokale KI-Assistent in normaler Sprache, der über Werkzeuge
hinweg plant und handelt. Das „Gehirn" in diesem Buch.

**PowerBITool.** Das AgentBridge-Plugin, das Microsoft Power BI Desktop bedient.
Die „Hände" in diesem Buch.

**Power BI Desktop.** Microsofts Werkzeug zum Bauen von Datenmodellen und Berichten.

**Modell.** Die Menge aus Tabellen, Spalten, Maßen und Beziehungen, die Power BI
nutzt, um Fragen zu beantworten.

**Tabelle.** Eine Menge aus Zeilen und Spalten. Der Grundbehälter für Daten.

**Spalte.** Ein einzelnes Feld in einer Tabelle, mit einem Datentyp (Text, Zahl,
Datum).

**Maß.** Ein berechneter Wert (meist eine Aggregation wie eine Summe oder ein
Durchschnitt), der auf Filter in einem Bericht reagiert.

**Berechnete Spalte.** Eine neue Spalte, die zu einer Tabelle hinzugefügt und mit
einer Formel für jede Zeile berechnet wird.

**Berechnete Tabelle.** Eine neue Tabelle, die aus einer Formel erstellt und im
Vorbeigehen berechnet wird.

**Beziehung.** Eine Verbindung zwischen zwei Tabellen (z. B. Sales → Products), damit
Daten zwischen ihnen fließen.

**Kardinalität.** Die „eins-auf-viele"- oder „viele-auf-eins"-Natur einer Beziehung.

**DAX.** Data Analysis Expressions – die Formelsprache von Power BI.

**SQL.** Structured Query Language – die Standardsprache zum Abfragen von
Datenbanken.

**SUM / AVERAGE / COUNT.** Grundlegende Aggregationen: Summe, Mittelwert und
Anzahl.

**DISTINCTCOUNT.** Anzahl der eindeutigen Werte.

**CALCULATE.** Eine DAX-Funktion, die den Filterkontext eines Maßes ändert.

**FILTER.** Eine DAX-Funktion, die Zeilen behält, die einer Bedingung entsprechen.

**RELATED.** Eine DAX-Funktion, die einen Wert aus einer verwandten Tabelle zieht.

**DIVIDE.** Eine sichere Divisionsfunktion, die Division durch null behandelt.

**ALL.** Eine DAX-Funktion, die Filter entfernt (oft für „% vom Ganzen" verwendet).

**RANKX.** Eine DAX-Funktion, die Zeilen nach einem Wert rangiert.

**TOPN.** Eine DAX-Funktion, die die obersten N Zeilen zurückgibt.

**Filterkontext.** Die Menge der Filter, die gerade angewandt sind, wenn ein Maß
berechnet wird.

**Zeilenkontext.** Die „aktuelle Zeile", wenn eine berechnete Spalte oder ein
Iterator berechnet.

**Iterator.** Eine DAX-Funktion (SUMX, AVERAGEX), die Zeile für Zeile auswertet.

**Datenwörterbuch.** Dokumentation jeder Tabelle, Spalte und jedes Maßes in einem
Modell.

**Profiling.** Das Prüfen der verschiedenen Werte, Leerstellen, Min/Max und
Stichproben einer Tabelle.

**Linting.** Statische Checks, die riskante Muster flaggen (z. B. `/` statt
`DIVIDE`).

**Best Practices.** Ein Gesundheitscheck des Modells gegen bekannte gute Muster.

**Fail-Closed-Schutzvorrichtung.** Eine Sicherheitsregel, die alles blockiert, was
nicht klar erlaubt ist.

**Datenqualität.** Wie sauber, vollständig und vertrauenswürdig die Daten sind.

**Segmentierung.** Das Aufteilen von Kunden oder Daten in Gruppen für die Analyse.

**Saisonalität.** Regelmäßige, sich wiederholende Muster über die Zeit.

**KPI.** Key Performance Indicator – eine Kennzahl, die für das Geschäft zählt.

**Dashboard.** Eine Sicht auf die wichtigsten KPIs, meist auf einem Bildschirm.

**Bericht.** Ein detailliertes, interaktives Set aus Visuals, gebaut auf einem
Modell.

**Data Governance.** Die Regeln, die Besitzverhältnisse und die Kontrollen um ein
Datengut.

**Jevons-Paradox.** Wenn etwas billiger wird, nutzen wir mehr davon, nicht weniger.
