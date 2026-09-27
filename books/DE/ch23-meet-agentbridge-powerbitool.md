# 23. Lerne AgentBridge und PowerBITool kennen

Jedes Beispiel in diesem Buch entstand mit zwei zusammenarbeitenden Werkzeugen.
Dieses Kapitel stellt sie richtig vor – was jedes ist, wie sie zusammenpassen und
was sie können.

## AgentBridge: der Assistent

**AgentBridge** ist ein KI-Assistent, der auf deinem eigenen Computer läuft. Du
redest in einfachen Worten mit ihm, und er arbeitet über deine Werkzeuge hinweg. Er
ist kein Chatbot, der nur redet – er handelt. Er kann Dokumente schreiben,
Tabellenkalkulationen bauen, E-Mails senden, das Web recherchieren und mit dem
richtigen Plugin Power BI bedienen.

Die Schlüsseleigenschaften:

- **Lokal.** Er läuft auf deinem Rechner. Deine Daten bleiben bei dir.
- **Normale Sprache.** Du beschreibst, was du willst; du schreibst keinen Code.
- **Erweiterbar.** Plugins geben ihm neue Fähigkeiten. PowerBITool ist eines davon.

## PowerBITool: die Hände in Power BI

**PowerBITool** ist das Plugin, das AgentBridge Hände in Microsoft Power BI Desktop
gibt. Durch es kann der Assistent:

- **Verbinden** mit dem Live-Modell eines offenen Berichts.
- **Inspektieren** – Modellzusammenfassung, Tabellen, Schema, Maße, Beziehungen.
- **Das Modell bearbeiten** – Tabellen, Spalten, Maße, Beziehungen erstellen und
  löschen; Beschreibungen setzen.
- **DAX ausführen und validieren** – mit einer Schutzvorrichtung, die alles
  Gefährliche blockiert.
- **Profilieren und dokumentieren** – Tabellen profilieren, ein Datenwörterbuch
  erzeugen, gegen Best Practices linten.

Hier stellt sich der Assistent einem Modell vor:

> „Lerne PowerBITool kennen: Was kannst du mit meinem Modell tun?"

![PowerBITool kennenlernen](../../assets/examples/e064.png)

Die Zusammenfassung, die er zurückgibt, ist die ganze Oberfläche: Tabellen, Maße,
Beziehungen, Zeilenzahlen – alles, was er sehen und bearbeiten kann.

## Wie sie zusammenpassen

```
You  →  AgentBridge (the brain)  →  PowerBITool (the hands)  →  Power BI Desktop (the model)
```

AgentBridge versteht deine Worte und plant die Aktion. PowerBITool führt diese
Aktion auf dem Live-Power-BI-Modell aus. Du siehst das Ergebnis sofort in Power BI
Desktop. Die Schleife ist: fragen → denken → handeln → sehen.

## Die Schutzvorrichtung

Eine Sache, die es hervorzuheben gilt: PowerBITool schickt DAX durch eine
**Fail-Closed-Schutzvorrichtung**. Er erlaubt schreibgeschützte Abfragen
(`EVALUATE`, System-Views) und blockiert alles, was das Modell durch die
Abfragetür ändern könnte – kein `DROP`, kein `INSERT`, kein `DELETE`, keine
Multi-Statement-Tricks. Ist eine Abfrage nicht klar sicher, wird sie abgelehnt. Das
macht es verantwortungsvoll, eine KI ein Live-Modell anfassen zu lassen.

## Kostenlos, und unterstützt von echten Menschen

Beide Werkzeuge sind kostenlos. PowerBITool ist offen auf GitHub, und – wie das
Vorwort versprach – die Unterstützung ist auch kostenlos: eröffne ein Issue, und ein
echter Techniker antwortet innerhalb von etwa 24 Stunden mit einer echten Lösung.
Diese Kombination (kostenloses Werkzeug, kostenlose menschliche Unterstützung,
schnelle Antworten) ist das Versprechen hinter jedem Beispiel, das du gesehen hast.

## Eine Kuriosität: das Plugin-Modell

PowerBITool ist nicht in AgentBridge einkompiliert. Es ist ein **Plugin**, das in
einen `Tools`-Ordner gelegt und beim Start entdeckt wird. Das heißt, die Fähigkeiten
des Assistenten können wachsen, ohne den Kern zu ändern – heute Power BI, morgen
andere Werkzeuge. Das Plugin-Modell ist der Grund, warum der Assistent immer neue
„Hände" gewinnen kann, ohne aufzublähen.

## Was du mit ihnen zusammen tun kannst

Alles in diesem Buch und mehr: dich mit einem Bericht verbinden, das Modell
verstehen, Daten mit berechneten Spalten säubern, Maße bauen, Beziehungen
verdrahten, DAX validieren und linten, Dokumentation erzeugen und Best Practices
prüfen – alles durch Reden.

---

## Was du aus diesem Kapitel mitnimmst

- AgentBridge ist der lokale, normalsprachige Assistent (das Gehirn).
- PowerBITool ist das Plugin, das Power BI Desktop bedient (die Hände).
- Die Schleife: fragen → denken → handeln → sehen, alles lokal.
- Eine Fail-Closed-Schutzvorrichtung hält das Live-Modell sicher.
- Kostenloses Werkzeug, kostenlose Unterstützung, echte Menschen, schnelle Antworten.

Als Nächstes: ein ganzer Tag der Arbeit des Analysten, automatisiert.
