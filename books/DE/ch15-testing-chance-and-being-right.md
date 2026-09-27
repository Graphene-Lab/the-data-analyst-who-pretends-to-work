# 15. Testen, Zufall und Recht haben

Du hast die Website geändert, und die Conversions sind um 2 % gestiegen. Hat deine
Änderung gewirkt, oder war es nur Glück? Das ist die Frage, die echte Analyse von
Wunschdenken trennt, und die Antwort lebt in der unspektakulären Welt des Testens
und Zufalls. Keine Sorge – wir halten es schmerzfrei.

## Das Problem: War es die Änderung oder das Glück?

Jede Zahl kann durch Zufall umherspringen. Wenn du eine Münze 10 Mal wirfst und 7
Mal Kopf bekommst, schließt du nicht, dass die Münze manipuliert ist. Genauso im
Geschäft: Wenn eine neue Anzeige ein paar Klicks mehr holt, ist sie vielleicht
besser, oder es ist vielleicht Rauschen. Die Frage ist: **Wie sicher kannst du dir
sein, dass der Unterschied echt ist?**

## Die Idee der Stichprobe

Die ganze Grundgesamtheit siehst du fast nie – du siehst eine **Stichprobe**.
1.000 Besucher deiner Seite, nicht alle Leute, die je kommen könnten. Eine
Stichprobe ist ein kleiner Schluck aus einem viel größeren Topf. Der Trick ist,
dass ein kleiner Schluck etwas über den ganzen Topf sagen kann – *wenn* er groß
genug und unverzerrt ist.

Große Stichprobe + zufällige Auswahl = vertrauenswürdig. Winzige Stichprobe oder
Cherry-Picking = gefährlich. A/B-Tests funktionieren, weil sie Besucher zufällig in
zwei Gruppen teilen und vergleichen.

## Der A/B-Test: das ehrliche Experiment

Der Goldstandard für „Funktioniert das?":

1. Teile dein Publikum **zufällig** in zwei Gruppen.
2. Gruppe A sieht die alte Version; Gruppe B sieht die neue Version.
3. Miss das Ergebnis in beiden.
4. Vergleiche. Wenn B die A um mehr schlägt, als der Zufall erklärt, ist die
   Änderung echt.

Zufälligkeit ist der ganze Trick. Sie macht die zwei Gruppen identisch außer dem
einen Ding, das du geändert hast, also muss jeder Unterschied die Änderung sein.

## Signifikanz: Ist der Unterschied echt?

Statistiker nutzen einen **p-Wert**, um zu antworten „Könnte das Zufall sein?". Ein
p-Wert unter 0,05 ist die übliche Latte: Er heißt „wenn es wirklich keinen
Unterschied gäbe, würden wir so etwas Extremes weniger als 5 % der Zeit sehen."
Unter der Latte nennst du es **statistisch signifikant** – wahrscheinlich echt.
Darüber zuckst du mit den Achseln und sagst „nicht genug Evidenz."

Du musst p-Werte nicht von Hand rechnen. Du brauchst den Instinkt: **ein kleiner
Unterschied auf einer kleinen Stichprobe ist wahrscheinlich Rauschen; ein klarer
Unterschied auf einer großen Stichprobe ist wahrscheinlich echt.**

## Die zwei Arten, falsch zu liegen

- **Fehler 1. Art (falsch Positiv):** Du sagst, die Änderung hat gewirkt, als sie
  es nicht hat. Du lieferst eine nutzlose Änderung aus. Die 5-%-Latte kontrolliert
  das.
- **Fehler 2. Art (falsch Negativ):** Du sagst, die Änderung hat nicht gewirkt, als
  sie es hat. Du wirfst eine gute Idee weg. Meist verursacht durch eine zu kleine
  Stichprobe.

Beides passiert. Gutes Testen balanciert sie: genug Daten, um echte Effekte zu
fangen, eine streng genug Latte, um keine Geister zu jagen.

## Zwei Gruppen live vergleichen

Du brauchst kein Labor, um die Form eines Vergleichs zu sehen. Der Assistent kann
zwei Gruppen in einer Abfrage Seite an Seite stellen:

> „Vergleich Nord gegen Mitte."

![Zwei Gruppen vergleichen](../../assets/examples/e033.png)

Skalier das mit zufälliger Zuteilung und einer großen Stichprobe, und du hast einen
A/B-Test. Die Logik ist identisch: zwei Gruppen, ein Unterschied, messen und
vergleichen.

## Eine Kuriosität: der Cookie, der alle hereinlegte

Eine Firma machte einen A/B-Test, sah einen großen Anstieg und feierte. Der Haken:
Die zwei Gruppen waren gar nicht zufällig – ein Bug steckte alle Mobile-Nutzer in
eine Gruppe. Der „Sieg" war in Wahrheit nur, dass Mobile-Nutzer sich anders
verhielten. Der Test war in der Theorie solide und in der Praxis kaputt.
**Randomisierung ist alles.** Ein Test ist nur so gut wie die Aufteilung dahinter.

## Wann du keinen formellen Test brauchst

Nicht jede Entscheidung braucht einen p-Wert. Wenn du den Preis eines Artikels
änderst und eine Woche Umsatz beobachtest, machst du kein Experiment – du
beobachtest. Formelles Testen ist für die Entscheidungen, die zählen und richtig
durchführbar sind. Für alles andere sei ehrlich, dass du rätst, und halte die
Entscheidung umkehrbar.

---

## Was du aus diesem Kapitel mitnimmst

- Ein Unterschied kann Glück sein; frag, wie sicher du dir bist.
- Stichproben lassen einen kleinen Schluck etwas über den ganzen Topf sagen – wenn
  sie groß und zufällig sind.
- A/B-Test = zufällige Aufteilung, ein Ding ändern, vergleichen.
- „Signifikant" heißt „unwahrscheinlich, dass es purer Zufall ist".
- Randomisierung ist alles; eine schlechte Aufteilung fälscht einen Sieg.

Teil III ist geschafft – du kannst Kennzahlen bauen, die Analysearten unterscheiden,
deine Kunden kennen, Trends lesen und Echt von Rauschen trennen. Als Nächstes machen
wir das alles sichtbar: Power BI und die Kunst, deine Daten zu zeigen.
