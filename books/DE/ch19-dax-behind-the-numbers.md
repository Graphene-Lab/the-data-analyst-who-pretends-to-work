# 19. DAX: Die Sprache hinter den Zahlen

DAX ist die Berechnungssprache in Power BI. Sie hat den Ruf, angsteinflößend zu
sein. Dieses Kapitel handelt davon, warum sie zählt, und warum du sie – mit dem
Assistenten – benutzen kannst, ohne je gegen sie zu kämpfen.

## Wofür DAX da ist

DAX (Data Analysis Expressions) berechnet die Zahlen in deinen Berichten: Summen,
Durchschnitte, Prozentzahlen, Jahr-für-Jahr, laufende Summen, Ranglisten. Jedes
Maß, das du auf einem Power-BI-Dashboard siehst, ist im Kern DAX.

Die Kernfunktionen sind einfach: `SUM`, `AVERAGE`, `COUNT`, `MIN`, `MAX`, und das
mächtige `CALCULATE`, mit dem du eine Zahl *unter einem bestimmten Filter*
berechnen kannst.

## Der Assistent schreibt sie; du liest sie

Du tippst kein DAX. Du beschreibst die Zahl, die du willst, und der Assistent
schreibt das DAX und erstellt das Maß live. Aber du solltest *lesen* können, was er
gemacht hat, damit du ihm traust.

> „Erstelle ein Umsatzmaß nur für Mailand."

![Mailand-Umsatz-Maß](../../assets/examples/e053.png)

Im Kern ist das `CALCULATE([Total Sales], Stores[City] = "Milan")` – der
Gesamtumsatz, aber nur wo die Stadt Mailand ist. Hat man das Muster einmal gesehen,
hört DAX auf, Magie zu sein.

## Validieren, bevor du traust

Der Assistent kann eine Formel testen, ohne etwas zu erstellen:

> „Ist das ein gültiges Maß? SUM(Sales[Amount])"

![Gültiges Maß validieren](../../assets/examples/e049.png)

> „Prüf diese kaputte Formel: SUMX(Sales[Amount])"

![Kaputtes Maß validieren](../../assets/examples/e050.png)

Eine besteht, eine fällt durch – und du lernst, was falsch ist, *bevor* sie ein
kaputtes Maß im Modell wird. Diese „erst prüfen"-Angewohnheit spart Stunden
Debugging.

> „Validiere ein CALCULATE-Maß."

![CALCULATE validieren](../../assets/examples/e081.png)

> „Validiere ein Prozent-Maß."

![Prozent validieren](../../assets/examples/e094.png)

## Linting: der Style-Cop für DAX

Über „läuft es?" hinaus kann der Assistent prüfen „ist es *gut geschrieben*?" – ein
Prozess namens **Linting**. Er spotet häufige Fehler und riskante Muster.

> „Lint dieses DAX: SUM(a)/SUM(b)"

![Schrägstrich-Division linten](../../assets/examples/e051.png)

Er warnt: Benutz keinen nackten `/` – benutz `DIVIDE`, das Division durch null
sicher behandelt. Ein kleiner Stups, der eine ganze Klasse `#DIV/0!`-Fehler
verhindert.

> „Lint dieses saubere DAX mit DIVIDE."

![Sauberes DAX linten](../../assets/examples/e052.png)

Die saubere Version besteht. Man lernt das gute Muster, indem man sieht, wie es
belohnt wird.

> „Lint ein Maß, das IFERROR nutzt."

![IFERROR linten](../../assets/examples/e082.png)

Er flaggt `IFERROR` als Warnsignal – Fehler einzupacken, kann echte Bugs
verstecken, statt sie zu beheben. Der Linter bringt gute Angewohnheiten bei, einen
Warnhinweis nach dem anderen.

## Maße bearbeiten

Maße entwickeln sich. Der Assistent kann sie aktualisieren und löschen:

> „Ändere das Format von Total Sales auf ganze Euro."

![Format aktualisieren](../../assets/examples/e054.png)

> „Lösche das Maß Milan Sales."

![Maß löschen](../../assets/examples/e055.png)

Umbenennen, neu formatieren, entfernen – alles live, alles umkehrbar, bis du
speicherst.

## Eine Kuriosität: das Biest Filterkontext

Der Grund, warum DAX schwer heißt, ist ein Konzept: **Filterkontext** – die
unsichtbare Menge an Filtern, die eine Berechnung in jedem Moment sieht (die
aktuelle Zeile, die aktuelle Slicer-Auswahl, das aktuelle Visual). Beherrschst du
es, ist DAX dein Freund; missverstehst du es, sehen Zahlen auf schwer
nachvollziehbare Weise falsch aus. Hier ist die befreiende Wahrheit dieses Buches:
**Du beschreibst die Antwort, und der Assistent kümmert sich um den Filterkontext.**
Das Biest wird zum Problem des Werkzeugs, nicht zu deinem.

---

## Was du aus diesem Kapitel mitnimmst

- DAX berechnet die Zahlen; `CALCULATE` ist sein mächtigstes Wort.
- Du beschreibst die Antwort; der Assistent schreibt das DAX.
- Validiere eine Formel, bevor du sie erstellst.
- Lint, um schlechte Muster zu fangen (nackter `/`, `IFERROR` versteckt Bugs).
- Der schwere Teil – der Filterkontext – ist jetzt die Aufgabe des Werkzeugs.

Als Nächstes: Sehen heißt Glauben – wie man das richtige Diagramm wählt und nicht
mit Visuals lügt.
