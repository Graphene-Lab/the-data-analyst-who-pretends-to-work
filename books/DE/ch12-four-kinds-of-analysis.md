# 12. Vier Arten der Analyse

Jede Analyse, die du je machen wirst, fällt in eine von vier Arten, geordnet danach,
wie viel sie von den Daten verlangt. Sie steigen eine Leiter hinauf: vom
Zurückschauen, zum Erklären warum, zum Vorhersagen, zum Empfehlen, was zu tun ist.
Zu wissen, welche Art du betreibst, sagt dir, wie viel du von den Daten verlangen
und wie sehr du der Antwort trauen sollst.

## 1. Deskriptiv – was ist passiert?

Die einfachste und häufigste. Du beschreibst die Vergangenheit. „Der Umsatz betrug
22.023 €. Der Norden machte 12.145 €." Keine Erklärung, keine Vorhersage – nur die
Fakten, klar.

> „Deskriptiv: Gesamtumsatz nach Region."

![Deskriptiv nach Region](../../assets/examples/e031.png)

Die meisten Dashboards sind deskriptiv. Sie beantworten „Wie geht's uns?" und sie
sind das Fundament, auf dem alles andere steht.

Die regionale Aufschlüsselung als Diagramm:

![Umsatz nach Region – Balkendiagramm](../../assets/examples/chart-region.png)

## 2. Diagnostisch – warum ist es passiert?

Jetzt gräbt man. Etwas hat sich geändert, und du willst die Ursache. Du
schneidest, vergleichst und kreuzreferenzierst, bis der Grund auftaucht.

> „Diagnostisch: Welche Kategorie verdient am meisten?"

![Diagnostisch nach Kategorie](../../assets/examples/e032.png)

> „Vergleich Nord gegen Mitte."

![Nord gegen Mitte](../../assets/examples/e033.png)

Diagnostische Arbeit ist, wo der Analyst sein Gehalt verdient. Deskriptiv sagt dir,
der Patient hat Fieber; diagnostisch findet die Infektion.

Dasselbe diagnostische Auge auf Filialen gerichtet:

![Umsatz nach Filiale – Balkendiagramm](../../assets/examples/chart-store.png)

## 3. Prädiktiv – was wird passieren?

Du nutzt die Vergangenheit, um die Zukunft zu raten. Nachfrage nächstes Quartal,
Abwanderung nächsten Monat, Umsatz zum Jahresende. Das braucht meist Statistik oder
maschinelles Lernen, und es kommt mit einer Konfidenzspanne – eine gute Vorhersage
sagt „etwa 11.000, mehr oder weniger".

> „Bester Monat insgesamt."

![Bester Monat](../../assets/examples/e076.png)

Eine Einzelzeitraum-Sicht wie diese ist der Rohstoff für Vorhersage: Man sieht das
Muster und projiziert es dann nach vorn.

## 4. Präskriptiv – was sollten wir tun?

Die Spitze der Leiter. Bei der gegebenen Vorhersage und den Randbedingungen, welche
Aktion maximiert das Ziel? Welcher Preis, welche Aktion, welcher Lagerbestand.
Präskriptive Analyse ist die seltenste und schwerste, und sie sitzt meist auf den
anderen drei oben.

## Die Leiter in einem Bild

| Art | Frage | Aufwand | Nötiges Vertrauen |
|---|---|---|---|
| Deskriptiv | Was ist passiert? | Niedrig | Hoch (es sind nur Fakten) |
| Diagnostisch | Warum? | Mittel | Mittel (acht vor falschen Ursachen) |
| Prädiktiv | Was als Nächstes? | Hoch | Niedriger (es ist ein Tipp mit einer Spanne) |
| Präskriptiv | Was tun? | Am höchsten | Am niedrigsten (es ist eine Empfehlung) |

Beachte das Muster: Je höher du kletterst, desto mehr Wert fügst du hinzu – und
desto unsicherer bist du. Ein guter Analyst ist ehrlich über diesen Trade-off.

## Rangieren: der Lieblingszug des Analysten

Rangieren macht aus einer flachen Liste eine Geschichte. Wer ist Erster, wer
Letzter, wer verbessert sich.

> „Rangiere Produkte nach Umsatz."

![Produkte rangieren](../../assets/examples/e034.png)

> „Durchschnittliche Menge pro Verkauf."

![Durchschnittliche Menge pro Verkauf](../../assets/examples/e059.png)

Rangieren ist deskriptiv, aber es weist die diagnostische Arbeit: Das Ende der Liste
ist, wo man zuerst nach einem Problem sucht.

## Eine Kuriosität: der Analytics-Reife-Mythos

Berater lieben es, ein „Reifemodell" zu verkaufen, in dem man von deskriptiv nach
präskriptiv klettern muss, sonst sei man ein Nachzügler. In Wirklichkeit **würden
die meisten Firmen schon enorm profitieren, wenn sie nur Deskriptiv und
Diagnostisch richtig hinbekämen.** Schäm dich nicht für ein gutes „was ist passiert
und warum" – dort liegt 90 % des Wertes. Die prädiktive und präskriptive Schicht
sind die Kirsche oben drauf, nicht der Kuchen.

---

## Was du aus diesem Kapitel mitnimmst

- Vier Arten: deskriptiv, diagnostisch, prädiktiv, präskriptiv.
- Wert und Unsicherheit steigen beide, je höher du kletterst.
- Der meiste Wert liegt in deskriptiv + diagnostisch.
- Rangieren ist der einfachste Weg zu finden, wo man hinschauen muss.
- Sei ehrlich, wie sehr man jeder Art trauen soll.

Als Nächstes: der Kunde – das wichtigste Analyseobjekt überhaupt.
