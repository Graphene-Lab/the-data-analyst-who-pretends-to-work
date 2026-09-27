# 24. Den Alltag des Analysten automatisieren

Verbringen wir einen Tag in der Arbeit des Analysten und sehen zu, wie der Assistent
sie schultert. Dieses Kapitel reiht die Beispiele so aneinander, wie ein echter
Arbeitstag läuft: bauen, validieren, dokumentieren, prüfen, fertig. Jedes Bild ist
eine echte Aktion auf einem Live-Modell.

## Morgen: die Berichts-Bausteine

Der Tag beginnt damit, rohe Tabellen in Berichts-Bausteine zu verwandeln. Statt
eine Stunde zu klicken, bittest du um das, was das Dashboard braucht.

> „Bau eine Kategorie-Performance-Tabelle mit Umsatz und Produktanzahl."

![Kategorie-Performance-Tabelle](../../assets/examples/e065.png)

Ein Auftrag, eine neue Tabelle – Umsatz und Produktanzahl pro Kategorie, berechnet
und live.

Dann die KPIs, die das Dashboard braucht:

> „Erstelle ein KPI-Maß-Set für das Dashboard."

![KPI-Maß-Set](../../assets/examples/e066.png)

Ein Maß für Umsatz pro Kunde, erstellt und angewendet. Die Art kleiner Kennzahl,
die früher eine sorgfältige Minute pro Stück brauchte, kommt jetzt in einem Satz.

## Vor dem Meeting: alles validieren

Bevor du den Bericht baust, prüfst du, ob die Zahlen stimmen. Der Assistent
validiert gleich eine ganze Charge:

> „Validiere ein Batch von Maßen, bevor ich den Bericht baue."

![Batch-Validierung](../../assets/examples/e067.png)

Jedes Maß kommt mit OK und seinem Wert. Keine Überraschungen vor dem Chef.

## Später am Vormittag: die Lücken fangen

Ein guter Analyst schaut nach dem, was *fehlt*, nicht nur nach dem, was da ist:

> „Welche Produkte haben sich nie verkauft?"

![Produkte, die sich nie verkauften](../../assets/examples/e070.png)

Die Abfrage läuft und liefert null Zeilen – jedes Produkt verkaufte sich mindestens
einmal. Das ist auch eine nützliche Antwort: kein toter Bestand, der sich im Katalog
versteckt.

## Später am Vormittag: Modellverhalten

Du willst Wiederholungsverhalten markieren, ohne Zeilen von Hand zu taggen:

> „Erstelle ein Wiederkäufer-Flag."

![Wiederkäufer-Flag](../../assets/examples/e085.png)

Eine Boolean-Spalte, die jeden Verkauf als Wiederholung oder nicht markiert – in
einem Rutsch über die ganze Tabelle berechnet.

Und die beste Performerin:

> „Gib mir die Top-Filiale nach Umsatz."

![Top-Filiale nach Umsatz](../../assets/examples/e087.png)

Mailand Central führt. Das Ranking, das früher eine Pivot und eine Sortierung
brauchte, ist jetzt eine einzige Frage.

## Nachmittag: Targeting

Das Marketing-Team will Kunden mit hohem Wert:

> „Erstelle ein Maß für Kunden mit hohem Wert."

![Maß für Kunden mit hohem Wert](../../assets/examples/e095.png)

Ein Flag für Kunden über einer Ausgabenschwelle, live im Modell, bereit zum Filtern.

Und um zu sehen, wie die Preisbänder, die wir vorher gemacht haben, performen:

> „Umsatz nach Preisband."

![Umsatz nach Preisband](../../assets/examples/e097.png)

High, Mid, Low – die Bandspalte aus Kapitel 7 treibt jetzt eine echte
Aufschlüsselung. Das ist der Lohn dafür, kleine Bausteine zu bauen: Sie kombinieren
sich später.

## Tagesende: dokumentieren und prüfen

Bevor du zumachst, dokumentierst du die Arbeit und prüfst ihre Gesundheit. Der
Assistent schreibt das Wörterbuch für das ganze Modell:

> „Dokumentiere das finale Modell."

![Finales Datenwörterbuch](../../assets/examples/e099.png)

Jede Tabelle, jedes Maß, mit seinem Format und seinem Ausdruck – Dokumentation, die
du von Hand nie geschrieben hättest, für dich erledigt.

Dann der Gesundheitscheck:

> „Finaler Gesundheitscheck des ganzen Modells."

![Finaler Gesundheitscheck](../../assets/examples/e100.png)

Null Warnungen. Die zwei „Info"-Hinweise sind nur nicht verbundene
Zusammenfassungstabellen, was zu erwarten ist. Das Modell ist sauber.

## Abschluss: das fertige Modell

Am Ende des Tages siehst du, was du gebaut hast:

> „Zeig die finale Liste der Tabellen."

![Finale Liste der Tabellen](../../assets/examples/e102.png)

Sechs Tabellen, vierzehn Maße, drei Beziehungen – ein funktionierendes
analytisches Modell, gebaut und dokumentiert an einem einzigen Tag
normalsprachiger Aufträge.

## Was der Tag zeigt

Ein ganzer Arbeitstag – bauen, validieren, Lücken fangen, Modellverhalten,
targeten, dokumentieren, prüfen –, erledigt, indem jeder Schritt beschrieben wird.
Die Hände des Analysten taten kein einziges Klicken. Der Kopf des Analysten tat
alles Entscheiden.

Das ist der Tausch, den dieses Buch immer wieder macht: **Du behältst das
Urteilsvermögen, das Werkzeug nimmt die Plackerei.**

---

## Was du aus diesem Kapitel mitnimmst

- Ein ganzer Tag Analystenarbeit bildet eine Folge normalsprachiger Aufträge ab.
- Bausteine bauen (Tabellen, Maße), sie validieren, Lücken fangen, dokumentieren,
  prüfen.
- Kleine Bausteine kombinieren sich später (das Preisband treibt eine
  Aufschlüsselung).
- Das Modell endet sauber, dokumentiert und bereit – ohne das ganze manuelle Klicken.

Als Nächstes: Storytelling, Ethik und Governance – der Teil, den das Werkzeug nicht
für dich tun kann.
