# 17. Verbindung zu deinen Daten herstellen

Bevor der Assistent etwas mit Power BI tun kann, muss er sich damit verbinden.
Dieses Kapitel handelt von diesem Händedruck – wie der Assistent deinen offenen
Bericht findet, sich mit dem Live-Modell verbindet und genau weiß, mit was er redet.

## Die lokale Verbindung

Hier das Entscheidende zum Verstehen: Power BI Desktop startet, wenn du einen
Bericht öffnest, eine kleine **Analyse-Engine** auf deinem eigenen Rechner (ein
Programm namens `msmdsrv`). Der Assistent verbindet sich mit *dieser* Engine, auf
*deinem* Rechner.

```
You  →  AgentBridge  →  PowerBITool  →  the engine inside your Power BI Desktop
```

Keine Cloud. Kein Upload. Die Daten verlassen deinen Computer nie. Der Assistent
redet einfach mit derselben Engine, die Power BI selbst nutzt, durch eine lokale
Tür.

## Finden, was offen ist

Der Assistent sieht jeden Power-BI-Bericht, den du offen hast, jeden mit seiner
eigenen Engine und seinem eigenen Port:

> „Welche Power-BI-Berichte sind gerade offen?"

![Offene Berichte](../../assets/examples/e003.png)

Wenn du einen Bericht offen hast, verbindet er sich direkt damit. Wenn du mehrere
hast, sagst du ihm welchen beim Namen. So bleibt er auf das richtige Ding gerichtet.

## Die Verbindung bestätigen

Ist er verbunden, kannst du jederzeit den Status prüfen:

> „Wie ist der Verbindungsstatus?"

![Verbindungsstatus](../../assets/examples/e004.png)

Er sagt dir, auf welchem Modell er ist und auf welchem lokalen Port. Das ist
wichtig, weil jede spätere Änderung in *dieses* Live-Modell geht. Genau zu wissen,
womit du verbunden bist, ist die erste Regel des sicheren Bearbeitens.

## Was „live" wirklich heißt

Wenn der Assistent das Modell ändert, passiert die Änderung im **live im Speicher
liegenden Modell** in Power BI Desktop. Du siehst sie sofort – das ist die
visuelle Rückkopplungsschleife. Aber da ist ein wichtiger Haken, an den das
Werkzeug dich immer erinnert:

> Die Änderung ist live, aber **nicht in die Datei gespeichert**. Um sie zu
> behalten, drückst du **Strg+S** in Power BI Desktop.

Das ist eine Sicherheitsfunktion, kein Bug. Es heißt, jede Änderung ist umkehrbar,
bis du dich zum Speichern entscheidest. Du kannst frei experimentieren; nichts ist
dauerhaft, bis du es beschließt.

## Eine Kuriosität: Der Port ist eine Geheimtür

Jede Power-BI-Desktop-Instanz wählt einen zufälligen lokalen Netzwerkport für ihre
Engine – diese Zahl in der Verbindungszeichenfolge (wie `localhost:64431`). Der
Assistent entdeckt diesen Port automatisch, indem er den laufenden Power-BI-Prozess
und seine Kind-Engine findet. Du musst die Zahl nie kennen; das Werkzeug knackt sie.
Es ist dieselbe Tür, die Power BI intern nutzt – der Assistent hat einfach gelernt,
wie man anklopft.

## Neuverbinden und Sicherheit

Wenn du den Bericht schließt und einen anderen öffnest, merkt der Assistent, dass
sich die Engine geändert hat, und bittet dich, dich neu zu verbinden – er schreibt
nicht blind ins falsche Modell. Diese Sitzungs-Sicherheit macht das Live-Bearbeiten
vertrauenswürdig: Das Werkzeug prüft, dass die Engine hinter der Verbindung noch
dieselbe ist, mit der es sich verbunden hat, bevor es eine Änderung durchlässt.

---

## Was du aus diesem Kapitel mitnimmst

- Der Assistent verbindet sich mit der lokalen Engine in deinem Power BI Desktop.
- Keine Cloud, kein Upload – alles bleibt auf deinem Rechner.
- Er entdeckt offene Berichte und ihre Ports automatisch.
- Änderungen sind live, aber nicht gespeichert, bis du Strg+S drückst.
- Das Werkzeug schützt davor, ins falsche Modell zu schreiben.

Als Nächstes: Modellieren in Power BI – der Assistent als sorgfältiger, gut
dokumentierter Modellierer.
