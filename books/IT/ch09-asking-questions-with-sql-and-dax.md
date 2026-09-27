# Fare domande con SQL e DAX

Una volta che i dati sono dentro e cablati, fai loro domande. Ci sono due linguaggi
che dovresti riconoscere: **SQL** per i database, e **DAX** per Power BI. Non devi
più scriverli a mano: lo fa l'assistente. Ma dovresti capire cosa fanno, così da
saper chiedere bene e leggere le risposte.

## SQL: il linguaggio dei database

**SQL** (Structured Query Language) è il modo di parlare con i database dagli anni
'70. Si legge quasi come l'inglese:

- `SELECT` — quali colonne vuoi
- `FROM` — da quale tabella
- `WHERE` — quali righe tenere
- `GROUP BY` — come raggruppare e totalizzare

Un classico: *"vendite totali per regione"* è un SELECT, un JOIN alla tabella
delle regioni e un GROUP BY. SQL è ovunque: se la tua azienda ha un database, SQL
è come lo leggi.

## DAX: il linguaggio di Power BI

**DAX** (Data Analysis Expressions) è il linguaggio dentro Power BI. Sembra
diverso da SQL ma fa lo stesso lavoro: chiedi un numero, ottieni un numero. DAX è
costruito attorno alle **misure**: calcoli con un nome che puoi riutilizzare.
`SUM`, `AVERAGE`, `COUNT`, `CALCULATE` sono i suoi cavalli da lavoro.

La cosa bella: non devi digitare DAX. Descrivi la risposta che vuoi, e
l'assistente scrive ed esegue il DAX per te. Guardiamo.

## Contare e sommare

> "Quante righe ci sono in Sales?"

![Conteggio righe](../../assets/examples/e020.png)

Sessanta record di vendita. Semplice, istantaneo.

> "Qual è il totale della colonna Amount?"

![Somma Amount](../../assets/examples/e021.png)

22.023 € di vendite totali. Il tipo di numero che una volta significava una tabella
pivot e dieci minuti; ora è una frase.

## Classificare e filtrare

> "Top 3 prodotti per vendite totali."

![Top prodotti](../../assets/examples/e022.png)

L'assistente li classifica per te. (Nota come restituisce la classifica completa,
così vedi il quadro intero, non solo la fetta in cima.)

> "Mostrami vendite più grandi di 500."

![Vendite sopra 500](../../assets/examples/e023.png)

Un filtro, eseguito dal vivo, che restituisce ogni vendita grossa. È così che trovi
gli outlier e le balene.

## Raggruppare attraverso una relazione

> "Vendite totali per città del negozio."

![Vendite per città](../../assets/examples/e024.png)

Questo è il momento in cui il modello paga: l'assistente si protende attraverso la
relazione Sales→Stores e totalizza per città, senza unione manuale.

## Tirare fuori un valore correlato

> "Per ogni vendita, mostra il nome del prodotto."

![Nome prodotto correlato](../../assets/examples/e025.png)

Usando `RELATED`, l'assistente tira il nome del prodotto su ogni vendita: il tipo
di cosa che in Excel significa un VLOOKUP e una preghiera.

## Qualcuna in più, perché è facile

> "Quantità totale venduta complessivamente."

![Quantità totale](../../assets/examples/e074.png)

> "Conta le vendite con quantità sopra 3."

![Conteggio vendite con grande quantità](../../assets/examples/e088.png)

Ognuna una frase semplice, ognuna una vera query DAX eseguita sul modello in
esecuzione.

## Una curiosità: la nomea spaventosa di DAX

DAX ha la nomea di essere difficile. Non è difficile da *usare*: è difficile
*padroneggiare il contesto di filtro*, la regola sottile su quali dati un calcolo
vede in ogni momento. Ma ecco il segreto di questo libro: non devi padroneggiarlo.
Descrivi la risposta; l'assistente scrive il DAX e gestisce il contesto. La
difficoltà passa dalle tue spalle a quelle dello strumento.

---

## Cosa ti porti a casa da questo capitolo

- SQL parla ai database; DAX parla a Power BI.
- Entrambi si leggono vicino all'inglese: seleziona, filtra, raggruppa, totalizza.
- Tu descrivi la risposta; l'assistente scrive ed esegue la query.
- Le relazioni rendono banali le domande tra tabelle.
- La parte difficile di DAX ora è un problema dello strumento, non tuo.

Prossimo: il foglio di calcolo, dove tutti cominciano, e il muro dove tutti hanno
bisogno di qualcosa di più.
