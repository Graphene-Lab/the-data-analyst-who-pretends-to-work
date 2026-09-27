# Appendice F — Soluzioni degli esercizi

Soluzioni agli esercizi guidati dell'Appendice E. Ognuna mostra la richiesta in
linguaggio semplice e il DAX che l'assistente produce.

## Esercizio 1 — Leggi il modello

**Richiesta:** "Elenca ogni tabella con il suo conteggio di righe."
**Cosa succede:** l'assistente legge il modello vivo e restituisce ogni tabella con
il suo tipo, conteggio di righe e conteggio di colonne. Non serve DAX: è una
chiamata di scoperta.

## Esercizio 2 — Profila una tabella

**Richiesta:** "Profila la tabella Products."
**Cosa succede:** l'assistente restituisce una tabella di profilo con Distinct,
Blanks, Min, Max e Top values per colonna. Il conteggio distinto di Category è 3;
i vuoti si vedono per colonna.

## Esercizio 3 — Pulisci il testo

**Richiesta:** "Aggiungi una colonna con la categoria in lettere maiuscole."
**DAX:** `UPPER(Products[Category])`
**Risultato:** una nuova colonna calcolata `Products[CategoryUpper]`.

## Esercizio 4 — Metti in fascia un numero

**Richiesta:** "Raggruppa i prodotti in Alto / Medio / Basso per prezzo."
**DAX:**
```
SWITCH(TRUE(),
  Products[Price] >= 200, "High",
  Products[Price] >= 50, "Mid",
  "Low")
```
**Risultato:** una nuova colonna calcolata `Products[PriceBand]`.

## Esercizio 5 — Cabla una relazione

**Richiesta:** "Collega Sales a Products su ProductID."
**Risultato:** una relazione molti-a-uno, a singola direzione, attiva
`Sales[ProductID] → Products[ProductID]`.

## Esercizio 6 — Costruisci una misura

**Richiesta:** "Crea una misura Vendite Totali con formato euro."
**DAX:** `SUM(Sales[Amount])` con formato `#,##0.00 €`.
**Risultato:** una nuova misura `Sales[Total Sales]`.

## Esercizio 7 — Filtra una misura

**Richiesta:** "Conta solo le vendite sopra 300."
**DAX:** `COUNTROWS(FILTER(Sales, Sales[Amount] > 300))`
**Risultato:** una nuova misura `Sales[Big Sales Count]`.

## Esercizio 8 — Quota del totale

**Richiesta:** "La quota di ogni categoria sulle vendite totali."
**DAX:** `DIVIDE([Total Sales], CALCULATE([Total Sales], ALL(Sales)))`
**Risultato:** una nuova misura `Sales[Pct Of Total]` con formato
percentuale.

## Esercizio 9 — Classifica

**Richiesta:** "Classifica i prodotti per vendite."
**DAX:** `RANKX(ALL(Products), [Total Sales])`
**Risultato:** una classifica con la posizione di ogni prodotto.

## Esercizio 10 — Valida prima di salvare

**Richiesta:** "È una misura valida? SUM(Sales[Amount])"
**Cosa succede:** l'assistente valida e restituisce "Valid" con un valore di
esempio (22023). Solo allora crei la misura.

## Esercizio 11 — Lint

**Richiesta:** "Fai il lint di questo DAX: SUM(a)/SUM(b)"
**Cosa succede:** il linter segnala la `/` e suggerisce `DIVIDE()` per gestire la
divisione per zero in sicurezza.

## Esercizio 12 — Documenta

**Richiesta:** "Genera un dizionario dei dati per tutto il modello."
**Cosa succede:** l'assistente restituisce un dizionario markdown che elenca ogni
tabella, il suo tipo e conteggio di righe, e ogni misura con il suo formato ed
espressione.

## Lo schema in ogni soluzione

Chiedi semplicemente → l'assistente scrive DAX corretto → applica la modifica dal
vivo → riporta esattamente cosa ha fatto. Quel ciclo è tutta la competenza. Una
volta che sembra naturale, hai interiorizzato il libro.
