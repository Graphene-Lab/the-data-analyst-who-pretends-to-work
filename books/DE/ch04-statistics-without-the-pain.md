# 4. Statistik ohne Schmerzen

Du brauchst nicht viel Statistik, um ein guter Analyst zu sein. Du brauchst ein
paar Ideen, tief verstanden, und die Klugheit zu wissen, wann sie dich hereinlegen.
Hier ist der ganze Werkzeugkasten, in einfachen Worten.

## Die drei Mittelwerte: Mean, Median, Modus

Die Leute sagen „Durchschnitt", als gäbe es nur einen. Es gibt drei, und den
falschen zu wählen, kann lügen, ohne technisch falsch zu sein.

- **Mean (arithmetisches Mittel)** – alles addieren, durch die Anzahl teilen. Der
  klassische Durchschnitt.
- **Median** – der mittlere Wert, wenn man alle der Reihe nach aufstellt. Die
  Hälfte liegt darüber, die Hälfte darunter.
- **Modus** – der häufigste Wert.

Warum ist das wichtig? Stell eine kleine Firma vor. Zehn Mitarbeiter verdienen
30.000 €, und der Chef verdient 500.000 €.

- Der **Mean** liegt bei 72.727 € – „wir zahlen gut!"
- Der **Median** liegt bei 30.000 € – die Realität der normalen Belegschaft.

Die eine Zahl ist „korrekt" und die andere ist „korrekt", und sie erzählen völlig
verschiedene Geschichten. Wenn ein paar extreme Werte (Ausreißer) im Spiel sind,
ist der **Median** meist der ehrliche. Wenn jemand einen Durchschnitt zitiert,
frag: *Mean oder Median?*

## Streuung: Sind die Dinge gleichmäßig oder wild?

Ein Durchschnitt verbirgt, wie weit die Zahlen auseinanderliegen. Zwei
Lieferdienste haben beide im Schnitt 3 Tage. Der eine braucht immer 3 Tage. Der
andere braucht mal 1 Tag, mal 5 Tage, ganz zufällig. Gleicher Durchschnitt, völlig
anderes Erlebnis.

Das Streuungsmaß, das du am meisten nutzen wirst, ist die **Standardabweichung** –
grob: „wie weit die Dinge normalerweise vom Durchschnitt entfernt sind." Kleine
Standardabweichung = gleichmäßig, vorhersagbar. Große = wild, unzuverlässig.
Durchschnitte sagen dir die Mitte; die Streuung sagt dir das Risiko.

## Die Glockenkurve (und warum sie überall auftaucht)

Viele echte Dinge – Körpergrößen, Testergebnisse, Messfehler – türmen sich um die
Mitte und werden zu den Enden hin dünner, und bilden eine Glockenform. Das ist die
**Normalverteilung**, und sie ist überall wegen einer schönen Tatsache: Wenn viele
kleine Zufallseinflüsse zusammenkommen, neigt das Ergebnis zu einer Glocke. Du
brauchst nicht die Mathe. Du brauchst den Instinkt: die meisten Fälle liegen nahe
der Mitte, Extreme sind selten, und ein Wert weit draußen im Randbereich ist es
wert, untersucht zu werden.

## Ausreißer: die eine komische Zahl

Ein **Ausreißer** ist ein Wert weit von den anderen entfernt. Ein Kunde kauft für
50.000 €, während alle anderen für 50 € kaufen. Eine Lieferung dauert 30 Tage,
während die restlichen 3 brauchen. Ausreißer können sein:

- **Fehler** – ein Tippfehler, ein Testdatensatz, ein verrutschtes Komma.
- **Echt, aber selten** – ein Großkunde (Whale), eine echte Katastrophe.

Schau dir immer die Ausreißer an, bevor du einem Durchschnitt traust. Ein
einzelner fetter Kunde kann einen ganzen Monat großartig aussehen lassen und
verbergen, dass die anderen 200 Kunden gehen.

## Die große Falle: Korrelation ist nicht Kausalität

Das ist der wichtigste Satz in diesem Buch.

**Korrelation** heißt, zwei Dinge bewegen sich zusammen. **Kausalität** heißt, das
eine *verursacht* das andere. Das ist nicht dasselbe, und sie zu verwechseln,
verursacht teuren Unsinn.

Klassisches Beispiel: **Eisverkäufe und Ertrinkungstode steigen jeden Sommer
zusammen.** Verursacht Eis das Ertrinken? Nein. Ein drittes Ding – heißes Wetter –
treibt beide. Wenn du siehst, dass zwei Dinge sich zusammen bewegen, frag immer:

- Verursacht A das B?
- Verursacht B das A?
- Verursacht ein verstecktes C beide?
- Ist es nur Zufall?

„Kunden, die unsere App mehr nutzen, sind glücklicher" könnte heißen, dass die App
sie glücklich macht – oder dass bereits glückliche Kunden sie mehr nutzen.
Korrelation zeigt dir auf eine Spur. Sie liefert dir nicht die Antwort.

## Eine Kuriosität: der Korrelationskoeffizient

Statistiker pressen „wie stark zwei Dinge zusammenhängen" in eine Zahl von
**-1 bis +1**. +1 heißt, sie steigen in perfektem Gleichschritt; -1 heißt, das eine
steigt, während das andere fällt; 0 heißt, kein Zusammenhang. Er ist ein nützliches
Thermometer für eine Beziehung – aber denk dran: selbst ein perfektes +1 ist noch
kein Beweis für eine Ursache.

---

## Was du aus diesem Kapitel mitnimmst

- Weiß, welchen Durchschnitt du benutzt; der Median sagt oft die Wahrheit.
- Durchschnitte verbergen die Streuung – beobachte die Standardabweichung.
- Ausreißer können die ganze Geschichte fälschen; schau sie dir zuerst an.
- Korrelation ist eine Spur, nie ein Beweis. Such immer nach dem versteckten
  dritten Ding.

Als Nächstes: wie man aus einer vagen Geschäftssorge eine scharfe Frage macht, die
man tatsächlich mit Daten beantworten kann.
