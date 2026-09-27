# 7. Schmutzige Daten und wie man sie säubert

Hier eine Wahrheit, die niemand ins Stellenprofil schreibt: **Die meiste Zeit eines
Analysten geht fürs Säubern von Daten drauf.** Echte Daten sind unordentlich –
falsch geschrieben, dupliziert, fehlend, inkonsistent. Müll rein, Müll raus. Bevor
du irgendeine Wahrheit findest, musst du den Boden fegen.

## Das übliche Chaos

Jeder Analyst trifft dieselbe Besetzung an Problemen:

- **Inkonsistenter Text** – „Milan", „milan", „MILANO", „Milano ". Vier Werte,
  eine Stadt.
- **Gemischte Formate** – Daten als 03/04/2025 und 2025-04-03 in derselben Spalte.
- **Fehlende Werte** – leere Städte, leere Kategorien, keine Telefonnummer.
- **Duplikate** – derselbe Kunde zweimal unter zwei E-Mails.
- **Falsche Typen** – eine Zahl als Text gespeichert, also addiert sie sich nicht.
- **Deplatzierte Werte** – ein negativer Verkauf, der eigentlich eine Erstattung
  ist.

Keins davon ist dramatisch. Alle werden eine Analyse leise ruinieren, wenn du sie
ignorierst.

## Säubern mit berechneten Spalten

In Power BI wird viel Säubern mit **berechneten Spalten** gemacht – neue Spalten,
die man mit einer Formel erstellt, die vorhandene Daten korrigiert oder
standardisiert. Genau hier glänzt der Assistent: Du beschreibst die Korrektur in
einfachen Worten, er schreibt die Formel und wendet sie live an.

**Text standardisieren.** Jemand fragte:

> „Füge eine Spalte hinzu mit der Kategorie in Großbuchstaben."

![Kategorie in Großbuchstaben](../../assets/examples/e011.png)

Jetzt werden „kitchen", „Kitchen" und „KITCHEN" alle zu „KITCHEN" und gruppieren
sich zusammen. Eine kleine Spalte, eine ganze Problemklasse weg.

**Aus einer Zahl ein brauchbares Band machen.**

> „Sortiere die Produkte nach Preis in High / Mid / Low."

![Preisband](../../assets/examples/e012.png)

Ein roher Preis von 249 € ist schwer zu gruppieren. Ein Band wie „High" ist leicht
zu diagrammieren und leicht zu besprechen. Das ist einer der nützlichsten Tricks in
der Analyse: aus einer kontinuierlichen Zahl eine freundliche Kategorie machen.

Und das kauft dir dieses Band – nach Preisband gruppierte und diagrammierte
Umsätze:

![Umsatz nach Preisband – Balkendiagramm](../../assets/examples/chart-priceband.png)

**Felder zu einer Bezeichnung kombinieren.**

> „Mach eine Kundenbezeichnung wie 'Name (Stadt)'."

![Kundenbezeichnung](../../assets/examples/e013.png)

Jetzt hat jeder Kunde eine saubere Anzeigebezeichnung, gebaut aus zwei Spalten,
ohne dass auch nur jemand etwas tippt.

## Prüfen, bevor du dich festlegst

Eine gute Angewohnheit: **Validiere die Formel, bevor du sie speicherst.** Der
Assistent kann eine Formel testen und dir einen Beispielwert zeigen, damit du
weißt, dass sie funktioniert, bevor sie Teil des Modells wird.

> „Prüf diese Preisband-Formel, bevor ich sie speichere."

![Preisband validieren](../../assets/examples/e014.png)

Sie liefert „Valid" mit einem Beispielwert. Keine Überraschungen später.

## Den Lücken hinterherjagen

Fehlende Werte sind stille Killer. Eine leere Stadt bedeutet, dass ein Kunde von
jeder Karte verschwindet. Der Assistent kann sie aufspüren:

> „Gibt es leere Städte in der Kundenliste?"

![Check auf leere Städte](../../assets/examples/e072.png)

Wenn das Ergebnis leer ist, bist du sauber. Wenn nicht, weißt du genau, wo die
Löcher sind, bevor sie ein Diagramm in die Irre führen.

## Eine Kuriosität: 80/20 des Jobs

Frag jeden erfahrenen Analysten, wie sich seine Zeit aufteilt, und du hörst eine
Version desselben Witzes: **80 % der Data Science ist Daten säubern, und die
anderen 20 % sind Jammern übers Daten säubern.** Es ist eine Floskel, weil es
stimmt. Die Analysten, die gut im Säubern sind, sind ihr Gewicht wert – denn ein
schönes Modell auf schmutzigen Daten ist eine schöne Art, falsch zu liegen.

## Wenn Säubern nie reicht

Manchmal sind die Daten zu im Argen – 40 % eines Schlüsselfelds fehlen, oder zwei
Systeme, die sich schlicht nicht einig sind. Ein guter Analyst weiß, wann er mit
dem Säubern aufhören und eskalieren soll: *behebt das an der Quelle*, oder
*sammelt beim nächsten Mal bessere Daten*. Säubern ist ein Werkzeug, keine
Religion.

---

## Was du aus diesem Kapitel mitnimmst

- Echte Daten sind schmutzig; Säubern ist der Großteil der Arbeit.
- Berechnete Spalten beheben Text, bändigen Zahlen und bauen Bezeichnungen in
  Sekunden.
- Validiere eine Formel, bevor du sie festlegst.
- Jag den Lücken hinterher, bevor sie ein Diagramm in die Irre führen.
- Weiß, wann du mit dem Säubern aufhören und die Quelle beheben sollst.

Als Nächstes: wie die Datenteile zusammenhängen – Tabellen, Schlüssel und
Beziehungen –, die Verdrahtung, die Analyse erst möglich macht.
