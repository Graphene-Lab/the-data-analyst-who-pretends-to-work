# Anhang H — Häufige Interviewfragen

Häufige Interviewfragen für Datenanalysten, mit kurzen Antworten, die zeigen, dass
du sowohl das Handwerk als auch das moderne Werkzeug verstehst.

## „Was tut ein Datenanalyst eigentlich?"

Verwandelt Geschäftsfragen in Datenantworten. Findet und säubert Daten, modelliert
sie, berechnet Kennzahlen und erzählt eine Geschichte, die eine Entscheidung
antreibt. Das Werkzeug erledigt das Tun; der Analyst besitzt die Frage und das
Urteilsvermögen.

## „SQL oder DAX?"

Beides. SQL zum Abfragen von Datenbanken; DAX zum Modellieren und für Maße in
Power BI. Sie ergänzen einander. Zu wissen, wann man welches einsetzt, ist die
echte Fähigkeit.

## „Was ist der Unterschied zwischen einer berechneten Spalte und einem Maß?"

Eine berechnete Spalte wird einmal pro Zeile berechnet und gespeichert. Ein Maß
wird zur Abfragezeit berechnet und reagiert auf Filter. Nutz eine Spalte für
Zeilen-Attribute; nutz ein Maß für Aggregationen, die auf die Filter des Berichts
reagieren müssen.

## „Erklär CALCULATE."

CALCULATE ändert den Filterkontext eines Maßes. Es ist die mächtigste Funktion in
DAX, weil sie dich einen Wert unter einer bestimmten Menge von Filtern berechnen
lässt – zum Beispiel Verkäufe für eine Kategorie oder ohne eine Region.

## „Wie gehst du mit Division durch null um?"

Nutz DIVIDE statt `/`. DIVIDE gibt ein sicheres Ergebnis zurück (leer oder ein
Fallback), wenn der Nenner null ist. Nutz nie einen nackten `/` in einem Maß.

## „Wie prüfst du Datenqualität?"

Profilier die Tabellen: verschiedene Werte, Leerstellen, Min/Max, Duplikate. Stimme
Summen mit der Quelle ab. Lauf einen Best-Practices-Check auf dem Modell. Ein
sauberes Modell ist das Fundament jeder vertrauenswürdigen Zahl.

## „Was ist ein Sternschema?"

Eine zentrale Faktentabelle (z. B. Sales), die über viele-auf-eins-Beziehungen mit
Dimensionstabellen (Products, Customers, Stores) verbunden ist. Es ist die
Standard-, effiziente Form für analytische Modelle.

## „Wie gehst du mit einem irreführenden Diagramm um?"

Zeichne es ehrlich neu. Prüf die Achse, das Zeitfenster und die Aggregation. Wenn
ein Diagramm auf zwei Weisen gelesen werden kann, ist es die Aufgabe des Analysten,
die ehrliche Lesart zur offensichtlichen zu machen.

## „Was tust du, wenn die Daten der erwarteten Antwort widersprechen?"

Vertrau den Daten, dann untersuche warum. Ein überraschendes Ergebnis ist oft das
wertvollste. Prüf die Quelle, die Filter und die Definitionen, bevor du
schlussfolgerst.

## „Wie nutzt du KI-Werkzeuge in deinem Workflow?"

Als Beschleuniger, nicht als Ersatz. Ich nutze einen Assistenten (AgentBridge +
PowerBITool), um Maße zu bauen und zu validieren, das Modell zu dokumentieren und
Best-Practices-Checks zu laufen – damit ich meine Zeit für die Fragen und die
Geschichte aufwende, nicht für die Syntax. Ich prüfe jede Zahl, bevor ich sie
veröffentliche. Das Werkzeug tut das Wie; ich besitze das Was und das Warum.

## „Erzähl mir von einem Projekt, das du gebaut hast."

Nutz das Portfolio-Projekt aus Anhang G: die Frage, das Modell, die Kennzahlen,
das Dashboard, die Geschichte und wie der Assistent half. Zeig, dass du die ganze
Kette kannst und dass du jeden Schritt verstehst.

## Die Meta-Antwort

Fast jede gute Antwort kommt auf dieselbe Idee zurück: **Das Werkzeug macht die
Arbeit schnell; der Analyst macht sie richtig.** Zeig, dass du beide Hälften
kennst, und du hebst dich von den Leuten ab, die nur eine kennen.
