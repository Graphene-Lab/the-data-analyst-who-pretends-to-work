# Appendice G — Un modello di progetto per il portfolio

Un portfolio prova che sai fare il lavoro. Questo modello ti dà un progetto da
costruire, documentare e mostrare. Fanne uno o due e avrai qualcosa da indicare in
un colloquio.

## Il progetto: una dashboard di analisi vendite

Costruisci una piccola analisi end-to-end su un dataset di vendite di esempio (la
stessa forma usata in tutto questo libro: Sales, Products, Customers, Stores).

### Passo 1 — Capisci i dati

- Profila ogni tabella.
- Annota valori distinti, vuoti e intervalli.
- Scrivi una frase per tabella: cosa contiene.

### Passo 2 — Pulisci e modella

- Standardizza il testo disordinato (colonne UPPER/LOWER).
- Metti in fascia i numeri (fasce di prezzo).
- Cabla le relazioni (Sales → Products, Customers, Stores).

### Passo 3 — Costruisci le metriche

- Vendite Totali, Quantità Totale, Ordini.
- Valore Medio dell'Ordine, Vendite per Cliente.
- Una misura di margine (ricavi meno costo).
- Una misura quota-del-totale.

### Passo 4 — Segmenta

- Top clienti per spesa.
- Vendite per segmento (Retail / Business / Online).
- Vendite per regione e per mese.

### Passo 5 — Valida e documenta

- Valida ogni misura prima di salvare.
- Fai il lint del DAX per gli anti-pattern.
- Genera il dizionario dei dati.
- Esegui il report best practice.

### Passo 6 — Visualizza

- Una riga di card KPI (vendite totali, ordini, ordine medio).
- Un grafico a barre delle vendite per categoria.
- Un grafico a linee dell'andamento mensile.
- Una classifica dei top prodotti.

## Cosa mostrare nel portfolio

Per ogni progetto, presenta:

1. **La domanda.** Quale problema di business stavi risolvendo.
2. **Il modello.** Uno screenshot delle tabelle e delle relazioni.
3. **Le metriche.** Le misure che hai costruito, con il loro DAX.
4. **La dashboard.** Le visual finali.
5. **La storia.** Cosa hai trovato e cosa ne faresti.
6. **Gli strumenti.** Una nota che l'hai costruito con AgentBridge + PowerBITool,
   e come l'assistente ha aiutato (validazione, documentazione, best
   practice).

## Perché funziona

A un intervistatore non importa che lo strumento l'abbia fatto in fretta. Gli
importa che tu sappia: inquadrare un problema, costruire un modello pulito,
validare il tuo lavoro, documentarlo e raccontare una storia. Questo progetto
esercita tutti e sei. Lo strumento è un bonus che mostra che sei al passo, non una
scorciatoia che sostituisce il pensiero.

## Rendilo tuo

Sostituisci i dati di esempio con un dataset a cui tieni: un hobby, un dataset
pubblico, un progetto parallelo. Più tieni all'argomento, migliori saranno le
domande che farai, e meglio sembrerà il portfolio. Lo schema è lo stesso; i dati
sono tuoi da scegliere.
