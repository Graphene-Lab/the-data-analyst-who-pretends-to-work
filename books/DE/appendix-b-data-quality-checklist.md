# Anhang B — Checkliste für Datenqualität

Nutze das, bevor du irgendeiner Analyse traust. Jeden Punkt kannst du mit dem
Assistenten prüfen.

## Vollständigkeit

- [ ] Keine unerwarteten leeren Werte in Schlüsselspalten. *(Profilier die Tabelle;
      schau in die Spalte Blanks.)*
- [ ] Jede erwartete Zeile ist da (keine fehlenden Zeiträume, Regionen oder
      Produkte).
- [ ] Zeilenzahlen stimmen mit dem Quellsystem überein.

## Richtigkeit

- [ ] Summen stimmen mit der Quelle der Wahrheit überein.
- [ ] Zahlen sind in der richtigen Einheit (Euro vs. Cent, Stück vs. Kisten).
- [ ] Keine offensichtlich falschen Werte (negative Mengen, Daten in der Zukunft).

## Konsistenz

- [ ] Text ist standardisiert (kein „Milan" vs. „milan" vs. „MILAN"). *(Füge eine
      UPPER/LOWER-Spalte zum Prüfen hinzu.)*
- [ ] Dieselbe Entität hat überall denselben Namen.
- [ ] Codes stimmen über Tabellen hinweg überein (jede ProductID in Sales existiert
      in Products).

## Eindeutigkeit

- [ ] Schlüsselspalten sind eindeutig, wo sie es sein sollten (eine Zeile pro
      SaleId).
- [ ] Keine doppelten Kunden, Produkte oder Filialen.

## Gültigkeit

- [ ] Werte liegen in den erwarteten Bereichen (Preis > 0, Daten gültig).
- [ ] Kategorien stammen aus einer erlaubten Liste.
- [ ] Formate sind korrekt (Datumswerte sind Datum, kein Text).

## Aktualität

- [ ] Daten sind aktuell genug für die Entscheidung.
- [ ] Die Aktualisierung passierte, wann sie sollte.

## Integrität

- [ ] Beziehungen sind richtig verdrahtet (viele-auf-eins, aktiv).
- [ ] Keine verwaisten Zeilen (Verkäufe, die auf ein fehlendes Produkt zeigen).
- [ ] Das Modell besteht den Best-Practices-Check.

## Wie der Assistent hilft

- **Profilier** jede Tabelle, um verschiedene Werte, Leerstellen, Min/Max,
  Stichproben zu sehen.
- **Validier** Formeln, bevor du sie speicherst.
- **Lint** DAX, um riskante Muster zu fangen.
- **Best-Practices-Bericht**, um das ganze Modell auf einmal zu prüfen.

Ein sauberes Modell ist kein Nice-to-have. Jede Zahl flussabwärts erbt die Qualität
der Daten flussaufwärts. Prüf einmal, vertrau überall.
