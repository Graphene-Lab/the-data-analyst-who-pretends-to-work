# Ein Hinweis zum Werkzeug hinter diesem Buch

Dieses Buch handelt von einem Beruf: dem Datenanalysten. Es geht darum, was dieser
Beruf wirklich ist, woher er kommt und wohin er sich entwickelt. Es ist in
einfachen Worten geschrieben. Du brauchst keinen Abschluss in Mathematik oder
Informatik, um ihm zu folgen. Wenn du ein kleines Unternehmen führst, deine
eigenen Zahlen im Blick behältst oder einfach gerne verstehst, wie Dinge
funktionieren, dann ist dieses Buch für dich.

Und jetzt der ehrliche Teil. Jedes einzelne Beispiel in diesem Buch – jede
Tabelle, jedes Maß, jedes Diagramm, jeder „Schau mal"-Moment – wurde mit einem
echten Werkzeug erstellt und nicht von Hand getippt. Dieses Werkzeug ist
**PowerBITool**, ausgeführt in **AgentBridge**.

## Was sind AgentBridge und PowerBITool?

**AgentBridge** ist ein KI-Assistent, der auf deinem eigenen Computer läuft. Du
sprichst mit ihm, wie du mit einem Kollegen sprechen würdest: in ganz normalen
Sätzen. Er hört zu, er denkt nach und er erledigt die Arbeit.

**PowerBITool** ist ein Plugin, das AgentBridge Hände in **Microsoft Power BI
Desktop** gibt – dem beliebten Programm, mit dem Leute Dashboards und Berichte
bauen. Mit PowerBITool kann der Assistent dein Datenmodell öffnen, Tabellen
hinzufügen, Maße erstellen, Tabellen miteinander verbinden, Abfragen ausführen,
deine Arbeit prüfen und einen Screenshot von seinem Ergebnis machen – und du
siehst alles live auf deinem eigenen Bildschirm.

Keine Cloud. Keine Firmendaten auf dem Server eines Fremden. Es läuft mit dem
Power BI Desktop, der schon auf deinem Rechner ist.

```
You  →  AgentBridge  →  PowerBITool  →  your Power BI Desktop (on your PC)
```

## So bekommst du es (es ist kostenlos)

PowerBITool ist kostenlos und offen. So probierst du es selbst:

1. Installiere **AgentBridge** (kostenlos) von der GitHub-Seite unten.
2. Füge das Plugin **PowerBITool** hinzu.
3. Öffne einen Bericht in **Power BI Desktop**.
4. Fang an, mit deinem Assistenten zu sprechen.

Scan diesen Code mit der Handykamera, um die PowerBITool-Seite zu öffnen. Dort
findest du den Download und eine einfache Schritt-für-Schritt-Anleitung zur
Installation:

![PowerBITool auf GitHub](../../assets/qr-powerbitool-repo.png)

**github.com/Graphene-Lab/PowerBITool**

Du kannst die Adresse auch einfach in einen Browser tippen.

## Festgefahren? Echte Menschen antworten innerhalb von 24 Stunden – kostenlos

Das hier sind wir stolz drauf. PowerBITool ist kostenlos, und die Hilfe dazu auch.
Wenn etwas nicht funktioniert, du dir eine Funktion wünschst oder einfach einen
Fehler gefunden hast, eröffnest du ein **Issue** auf derselben GitHub-Seite, und
unsere Techniker antworten – meist innerhalb von **24 Stunden**, und mit einer
echten Lösung, nicht mit einer Standardsantwort.

Scan diesen Code, um die Issue-Seite zu erreichen und zu sehen, wie es läuft:

![Ein Issue für PowerBITool melden](../../assets/qr-powerbitool-issues.png)

**github.com/Graphene-Lab/PowerBITool/issues**

Das ist das ganze Versprechen: ein kostenloses Werkzeug, kostenlose Unterstützung,
echte Menschen, schnelle Antworten.

## Wie du dieses Buch liest

Du musst nichts installieren, um dieses Buch zu genießen. Lies es wie eine
Geschichte, wenn du magst. Aber wenn du die Dinge gleich beim Lesen ausprobieren
willst – und wir hoffen, dass du das tust –, dann zeigt dir jedes Praxisbeispiel
zwei Dinge:

- **Was ein Mensch** dem Assistenten getippt hat (ein, zwei ganz normale Sätze).
- **Was zurückkam** (das echte Ergebnis, vom echten Werkzeug).

Die Bilder in diesem Buch zeigen genau diesen Austausch: die Frage rechts, die
Antwort von PowerBITool links, genau so, wie sie in AgentBridge erscheint.

## Über die Bilder in diesem Buch

Du wirst zwei Arten von Bildern sehen.

**Chat-Panels** zeigen den Austausch selbst: was ein Mensch getippt hat und das
echte Ergebnis, das PowerBITool aus dem Live-Modell zurückgegeben hat.

**Diagramm-Bilder** zeigen dieselben echten Daten *visualisiert* – Balken-,
Linien- und Donut-Diagramme, gezeichnet aus den tatsächlichen Zahlen, die das
Werkzeug zurückgegeben hat (Umsatz nach Kategorie, Top-Kunden, der Monatstrend
und so weiter). Es sind gerenderte Visualisierungen der real erfassten Ausgabe,
damit du die Daten als Bild siehst und nicht nur als Text.

Noch ein ehrlicher Hinweis zu Power BI Desktop selbst. Power BI stellt dieselben
Daten auf seiner eigenen Berichtsoberfläche (Canvas) dar, und das Werkzeug kann
dieses Canvas als PNG erfassen (`CaptureReportScreenshot`, über die Power BI
Desktop Bridge). Diese Aufnahme braucht einen Bericht, in dem in Power BI Desktop
schon Visuals gebaut sind. Dieses Buch wurde in einer Umgebung ohne GUI-Report
erstellt, deshalb sind die Diagramm-Bilder hier aus den echten Daten gerendert und
nicht als Screenshot aus Power BI erfasst. Die Anleitung, um echte
Power-BI-Desktop-Screenshots aufzunehmen, kommt mit dem Werkzeug, und du kannst
diese Aufnahmen genau an dieselben Stellen einfügen.

Fangen wir mit dem Beruf selbst an.

*— Graphene Lab*
