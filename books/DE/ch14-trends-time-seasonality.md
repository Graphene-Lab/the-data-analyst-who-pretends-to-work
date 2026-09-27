# 14. Trends, Zeit und Saisonalität

Eine Zahl ist eine Momentaufnahme. Füge Zeit hinzu, und sie wird eine Geschichte.
Ein Umsatz von 11.000 € bedeutet wenig, bis du weißt, ob das rauf oder runter ist,
und ob es für diese Jahreszeit normal ist. Zeit ist die Dimension, die aus einem
Foto einen Film macht, und fast jede wichtige Geschäftfrage lebt in ihr.

## Warum Zeit besonders ist

Zeit ist die eine Dimension, an der du nicht vorbeikommst. Jeder Verkauf, jeder
Klick, jeder Datensatz passiert *zu* einem Moment. Und Zeit hat eine Eigenschaft,
die andere Dimensionen nicht haben: **Dinge wiederholen sich.** Eis verkauft sich
im Sommer. Der Einzelhandel schießt zu Weihnachten in die Höhe. Steuersoftware
brüllt im April. Diese Wiederholung ist **Saisonalität**, und sie zu erkennen,
hindert dich daran, über einen „Einbruch" in Panik zu geraten, der jeden einzelnen
Januar passiert.

## Das Datum in brauchbare Stücke bringen

Rohe Daten sind unhandlich. Um Zeit zu analysieren, brichst du das Datum in Stücke
– Jahr, Monat, Tag – als Spalten, nach denen du gruppieren kannst:

> „Füge eine Year-Spalte aus dem Datum hinzu."

![Year-Spalte](../../assets/examples/e039.png)

> „Füge eine Month-Spalte aus dem Datum hinzu."

![Month-Spalte](../../assets/examples/e040.png)

Jetzt kannst du nach Jahr oder Monat gruppieren und die Form der Zeit sehen.

## Die Jahr-für-Jahr-Sicht

> „Gesamtumsatz pro Jahr."

![Umsatz pro Jahr](../../assets/examples/e041.png)

Zwei Jahre, Seite an Seite. Ist 2025 besser als 2024? Der Vergleich ist die ganze
Sache – ein einzelnes Jahr sagt dir nichts, aber zwei Jahre sagen dir die Richtung.

Der Jahr-für-Jahr-Vergleich als Diagramm:

![Umsatz pro Jahr – Balkendiagramm](../../assets/examples/chart-yearly.png)

## Der Monatstrend

> „Gesamtumsatz pro Monat."

![Umsatz pro Monat](../../assets/examples/e042.png)

Zwölf Monate Daten. Man sieht die Höhen und Tiefen – die geschäftigen Monate und
die ruhigen. Das ist die rohe Form des Herzschlags deines Geschäfts.

Der monatliche Herzschlag als Linie gezeichnet:

![Umsatz pro Monat – Liniendiagramm](../../assets/examples/chart-monthly.png)

## Einen Zeitraum filtern

> „Nur Umsatz 2025."

![Umsatz 2025](../../assets/examples/e043.png)

> „Umsatz für die erste Jahreshälfte."

![Erste Jahreshälfte 2025](../../assets/examples/e078.png)

Ein bestimmtes Zeitfenster zu schneiden, ist, wie du „Wie lief letztes Quartal?" in
einem Satz beantwortest.

## Die langsame Phase finden

> „Monat mit den wenigsten Verkäufen."

![Monat mit wenigsten Verkäufen](../../assets/examples/e091.png)

Den langsamsten Monat zu kennen, ist so nützlich wie den geschäftigsten – dann
planst du Aktionen, legst Wartungen fest oder stellst dich auf eine ruhige Phase ein.

## Gleitende Durchschnitte: den Lärm glätten

Monatszahlen sind holprig. Ein **gleitender Durchschnitt** (sagen wir, der
Durchschnitt der letzten 3 Monate) glättet die Dellen, sodass der zugrunde
liegende Trend durchscheint. Das ist der Unterschied zwischen einer wackeligen
Handkamera und einer geschmeidigen Steadicam-Einstellung. Der Trend ist, was du
sehen willst; der gleitende Durchschnitt enthüllt ihn.

## Eine Kuriosität: der „Januar-Effekt", der keiner ist

Ein Manager sieht die Januar-Umsätze 30 % im Minus und beruft eine Krisensitzung
ein. Aber Januar ist *immer* runter nach dem Dezember-Weihnachtstrubel. Ohne
Vergleich mit dem letzten Januar ist der Rückgang bedeutungslos – es ist die
Jahreszeit, kein Problem. Deshalb vergleichen Analysten **Jahr für Jahr** (dieser
Januar gegen letzten Januar) statt **Monat für Monat** (Januar gegen Dezember). Der
richtige Vergleich macht aus einem falschen Alarm ein Nicht-Ereignis.

---

## Was du aus diesem Kapitel mitnimmst

- Zeit macht aus einer Momentaufnahme eine Geschichte.
- Brich Daten in Jahr/Monat/Tag auf, um zu gruppieren und Trends zu sehen.
- Saisonalität heißt: Dinge wiederholen sich – gerat nicht beim erwarteten Einbruch
  in Panik.
- Vergleiche Jahr für Jahr, nicht nur Monat für Monat.
- Gleitende Durchschnitte glätten den Lärm, um den Trend zu zeigen.

Als Nächstes: Woher weißt du, dass ein Unterschied echt ist und nicht nur Glück?
Eine sanfte Tour durch Testen und Zufall.
