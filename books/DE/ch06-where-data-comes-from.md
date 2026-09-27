# 6. Woher Daten kommen

Bevor du irgendetwas analysieren kannst, brauchst du Daten – und du musst wissen,
in welcher Verfassung sie sind. Dieses Kapitel handelt vom Rohstoff: woher er
kommt, welche Formen er annimmt, und wie man ihm die Temperatur nimmt, bevor man
irgendetwas baut.

## Drei Arten von Daten

Alles, was du je analysieren wirst, fällt in drei Eimer:

- **Strukturiert** – saubere Zeilen und Spalten. Eine Verkaufstabelle, eine
  Kundenliste, ein Kontoauszug. Leicht für Computer zu lesen. Das ist dein
  Brot-und-Butter-Geschäft.
- **Halbstrukturiert** – hat eine gewisse Ordnung, aber kein sauberes Raster. Ein
  Web-Log, eine JSON-Datei aus einer App, eine E-Mail mit Feldern. Braucht etwas
  Zurichtung.
- **Unstrukturiert** – keine eingebaute Ordnung. Textdokumente, Bilder, Videos, die
  Freitext-Beschwerde eines Kunden. Am schwersten zu analysieren, und wo KI
  überraschend gut wird.

Die meiste Geschäftsanalyse lebt in der strukturierten Welt. Das ist die gute
Nachricht: Es ist die Art, auf die man ein Werkzeug richten und schnell Antworten
bekommen kann.

## Die üblichen Verdächtigen: Wo Geschäftsdaten sich verstecken

- **Das ERP-/Managementsystem** – Aufträge, Rechnungen, Lager, Kunden.
- **Das CRM** – Leads, Verkaufschancen, Kontakte, Vertriebs-Pipeline.
- **Tabellenkalkulationen** – der universelle Rückgriff, im Guten wie im Schlechten.
- **Datenbanken** – SQL-Server, die die Aufzeichnungen der Firma enthalten.
- **Web- und App-Logs** – jeder Klick, jeder Seitenaufruf, jedes Ereignis.
- **CSV-/Excel-Exporte** – Daten, die aus irgendeinem System in eine Datei gezogen
  werden.
- **APIs** – Live-Daten, die von einem Dienst gestreamt werden (Wetter, Versand,
  Zahlungen).
- **IoT-Sensoren** – Temperatur, Maschinenstatus, Kundenfrequenzzähler.

Eine echte Analyse näht oft mehrere davon zusammen. Der erste Zug des Analysten
ist, die Daten zu finden und ihre Form zu verstehen.

## Die Temperatur nehmen: Profiling

Bevor du einer Tabelle traust, **profilierst** du sie: wie viele Zeilen, welche
Spalten, wie viele verschiedene Werte, wie viele leere, das Minimum und Maximum,
die häufigsten Werte. Profiling ist ein Gesundheitscheck, der dir sagt, mit was du
es zu tun hast, bevor du ein einziges Diagramm baust.

Hier ein echtes. Jemand bat den Assistenten, die Produkttabelle zu profilieren:

> „Erstelle ein Profil der Products-Tabelle."

![Profil der Products-Tabelle](../../assets/examples/e006.png)

Auf einen Schlag siehst du: 8 Produkte, 3 Kategorien (Kitchen 4, Furniture 3,
Stationery 1), Preise von 12 € bis 349 € und ein paar Beispielzeilen. Kein Raten.
Die Form der Daten ist jetzt offensichtlich.

Dasselbe geht bei Kunden:

> „Erstelle ein Profil der Customers-Tabelle."

![Profil der Customers-Tabelle](../../assets/examples/e007.png)

Zwölf Kunden über vier Städte und drei Segmente. Man sieht die Geschichte sich
formen schon – Mailand und Rom sind die größten, die Segmente sind ausgewogen.

## Die Spalten klar sehen

Manchmal will man nur die Struktur – die Spalten und ihre Typen. Der Assistent
liest das Schema direkt:

> „Zeig mir das Schema der Sales-Tabelle."

![Schema der Sales-Tabelle](../../assets/examples/e008.png)

Jede Spalte, ihr Typ und die bereits angehängten Maße. Das ist die Karte, die du in
jede spätere Frage trägst.

## Eine Kuriosität: die „fünfte Art" von Daten

Unter Analysten kursiert der Witz, die fünfte Art von Daten sei **Daten, von denen
man nicht wusste, dass man sie hat** – die Metadaten. Wann hat sich jeder
Datensatz geändert? Wer hat ihn angefasst? Wie oft wurde eine Seite aufgerufen?
Metadaten sind die Daten *über* deine Daten, und sie enthalten oft die
interessantesten Antworten von allen.

---

## Probier es selbst

> „Wie viele verschiedene Kategorien gibt es?"

![Anzahl verschiedener Kategorien](../../assets/examples/e071.png)

Eine einzeilige Frage, eine einzeilige Antwort, direkt aus dem Live-Modell.

## Was du aus diesem Kapitel mitnimmst

- Daten kommen in drei Formen: strukturiert, halbstrukturiert, unstrukturiert.
- Geschäftsdaten verstecken sich in ERP, CRM, Datenbanken, Tabellenkalkulationen,
  Logs und APIs.
- Immer **profilieren**, bevor man baut – die Form und die Lücken kennen.
- Die Metadaten nicht vergessen: die Daten über deine Daten.

Als Nächstes: die unspektakuläre, essenzielle Arbeit, schmutzige Daten zu
säubern – und wie ein paar berechnete Spalten ein Chaos in Sekunden beheben.
