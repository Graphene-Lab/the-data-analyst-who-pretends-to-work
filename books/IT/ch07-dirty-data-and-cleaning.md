# Dati sporchi e come pulirli

Ecco una verità che nessuno mette nella descrizione del lavoro: **la maggior parte
del tempo di un analista serve a pulire i dati.** I dati del mondo reale sono
disordinati: con errori di ortografia, duplicati, mancanti, incoerenti. Spazzatura
entra, spazzatura esce. Prima di poter trovare una qualsiasi verità, devi spazzare
il pavimento.

## Il solito pasticcio

Ogni analista incontra la stessa compagnia di problemi:

- **Testo incoerente** — "Milano", "milano", "MILANO", "Milano ". Quattro
  valori, una città.
- **Formati misti** — date come 03/04/2025 e 2025-04-03 nella stessa colonna.
- **Valori mancanti** — città vuote, categorie vuote, nessun numero di telefono.
- **Duplicati** — lo stesso cliente due volte con due email.
- **Tipi sbagliati** — un numero salvato come testo, quindi non si somma.
- **Valori fuori posto** — una vendita negativa che è in realtà un rimborso.

Nessuno di questi è drammatico. Tutti quanti rovineranno in silenzio un'analisi se
li ignori.

## Pulire con colonne calcolate

In Power BI, molta della pulizia si fa con **colonne calcolate**: nuove colonne che
crei con una formula che sistema o standardizza i dati esistenti. È esattamente
qui che l'assistente brilla: descrivi la correzione a parole, lui scrive la formula
e la applica in diretta.

**Standardizza il testo.** Una persona ha chiesto:

> "Aggiungi una colonna con la categoria in lettere maiuscole."

![Categoria in maiuscolo](../../assets/examples/e011.png)

Ora "kitchen", "Kitchen" e "KITCHEN" diventano tutti "KITCHEN" e si raggruppano.
Una piccola colonna, un'intera classe di problemi sparita.

**Trasforma un numero in una fascia utilizzabile.**

> "Raggruppa i prodotti in Alto / Medio / Basso per prezzo."

![Fascia di prezzo](../../assets/examples/e012.png)

Un prezzo grezzo di 249 € è difficile da raggruppare. Una fascia "Alto" è facile
da mettere in grafico e facile di cui parlare. Questo è uno dei trucchi più utili
dell'analisi: trasformare un numero continuo in una categoria amica.

Ed ecco cosa ti compra quella fascia: vendite raggruppate e tracciate per fascia di
prezzo:

![Vendite per fascia di prezzo — grafico a barre](../../assets/examples/chart-priceband.png)

**Combina campi in un'etichetta.**

> "Crea un'etichetta cliente tipo 'Nome (Città)'."

![Etichetta cliente](../../assets/examples/e013.png)

Ora ogni cliente ha un'unica etichetta di visualizzazione pulita, costruita da due
colonne, senza che nessuno digiti nulla.

## Controlla prima di impegnarti

Una buona abitudine: **valida la formula prima di salvarla.** L'assistente può
testare una formula e mostrarti un valore di esempio, così sai che funziona prima
che diventi parte del modello.

> "Controlla questa formula della fascia di prezzo prima che la salvi."

![Validazione della fascia di prezzo](../../assets/examples/e014.png)

Restituisce "Valid" con un valore di esempio. Niente sorprese dopo.

## Caccia ai vuoti

I valori mancanti sono killer silenziosi. Una città vuota significa che un cliente
scompare da ogni mappa. L'assistente può dar loro la caccia:

> "Ci sono città vuote nell'elenco clienti?"

![Controllo città vuote](../../assets/examples/e072.png)

Se il risultato è vuoto, sei a posto. Se no, sai esattamente dove sono i buchi
prima che traggano in inganno un grafico.

## Una curiosità: l'80/20 del lavoro

Chiedi a un analista esperto come si divide il suo tempo e sentirai una versione
della stessa battuta: **l'80% della data science è pulire i dati, e l'altro 20% è
lamentarsi di pulire i dati.** È un luogo comune perché è vero. Gli analisti bravi
a pulire valgono oro: perché un modello bellissimo costruito su dati sporchi è un
bellissimo modo di sbagliare.

## Quando pulire non basta mai

A volte i dati sono troppo compromessi: manca il 40% di un campo chiave, o due
sistemi che semplicemente non sono d'accordo. Un buon analista sa quando smettere
di pulire e passare la palla: *sistema questo alla fonte*, oppure *raccogli dati
migliori la prossima volta*. Pulire è uno strumento, non una religione.

---

## Cosa ti porti a casa da questo capitolo

- I dati reali sono sporchi; pulire è la maggior parte del lavoro.
- Le colonne calcolate sistemano il testo, mettono in fasce i numeri e creano
  etichette in pochi secondi.
- Valida una formula prima di impegnarla.
- Dai la caccia ai vuoti prima che traggano in inganno un grafico.
- Sappi quando smettere di pulire e sistemare la fonte.

Prossimo: come si collegano i pezzi di dati: tabelle, chiavi e relazioni, il
cablaggio che rende possibile l'analisi.
