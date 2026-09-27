# Da dove arrivano i dati

Prima di poter analizzare qualsiasi cosa, ti servono i dati, e devi sapere in che
forma sono. Questo capitolo parla della materia prima: da dove arriva, le forme che
assume, e come prenderne la temperatura prima di costruire qualsiasi cosa.

## Tre tipi di dati

Tutto ciò che analizzerai mai ricade in tre categorie:

- **Strutturati** — righe e colonne in ordine. Una tabella di vendite, un elenco
  clienti, un estratto conto. Facili da leggere per i computer. Questo è il tuo
  pane quotidiano.
- **Semi-strutturati** — hanno un certo ordine ma non una griglia pulita. Un log
  web, un file JSON di un'app, un'email con campi. Richiedono un po' di
  sistemazione.
- **Non strutturati** — nessun ordine incorporato. Documenti di testo, immagini,
  video, il reclamo a testo libero di un cliente. I più difficili da analizzare, e
  dove l'AI sta diventando sorprendentemente brava.

La maggior parte dell'analisi di business vive nel mondo strutturato. Questa è la
buona notizia: è il tipo su cui puoi puntare uno strumento e ottenere risposte
veloci.

## I soliti sospetti: dove si nascondono i dati aziendali

- **L'ERP / sistema gestionale** — ordini, fatture, magazzino, clienti.
- **Il CRM** — lead, opportunità, contatti, pipeline di vendita.
- **I fogli di calcolo** — il ripiego universale, nel bene e nel male.
- **I database** — server SQL che custodiscono i registri aziendali.
- **I log web e delle app** — ogni clic, ogni visualizzazione di pagina, ogni
  evento.
- **Esportazioni CSV / Excel** — dati estratti da un qualsiasi sistema in un file.
- **Le API** — dati in diretta trasmessi da un servizio (meteo, spedizioni,
  pagamenti).
- **Sensori IoT** — temperatura, stato delle macchine, contatori di affluenza.

Una vera analisi spesso cuce insieme parecchi di questi. La prima mossa
dell'analista è trovare i dati e capirne la forma.

## Prendere la temperatura: la profilazione

Prima di fidarti di una tabella, la **profilazione**: quante righe, quali colonne,
quanti valori distinti, quanti vuoti, il minimo e il massimo, i valori più
frequenti. La profilazione è un check-up che ti dice con cosa hai a che fare prima
di costruire un singolo grafico.

Ecco una vera. Una persona ha chiesto all'assistente di profilare la tabella dei
prodotti:

> "Profila la tabella Products."

![Profilazione della tabella Products](../../assets/examples/e006.png)

In un colpo solo vedi: 8 prodotti, 3 categorie (Kitchen 4, Furniture 3,
Stationery 1), prezzi da 12 € a 349 €, e qualche riga di esempio. Niente
indovinare. La forma dei dati ora è ovvia.

Lo stesso vale per i clienti:

> "Profila la tabella Customers."

![Profilazione della tabella Customers](../../assets/examples/e007.png)

Dodici clienti in quattro città e tre segmenti. Vedi già la storia che si forma:
Milano e Roma sono le più grandi, i segmenti sono equilibrati.

## Vedere le colonne con chiarezza

A volte vuoi solo la struttura: le colonne e i loro tipi. L'assistente legge lo
schema direttamente:

> "Mostrami lo schema della tabella Sales."

![Schema della tabella Sales](../../assets/examples/e008.png)

Ogni colonna, il suo tipo, e le misure già collegate. Questa è la mappa che ti
porti dentro ogni domanda successiva.

## Una curiosità: il "quinto tipo" di dati

Tra gli analisti gira la battuta che il quinto tipo di dato sia **il dato che non
sapevi di avere**: i metadati. Quando è cambiato ogni record? Chi l'ha toccato?
Quante volte è stata vista una pagina? I metadati sono i dati *riguardo* ai tuoi
dati, e spesso custodiscono le risposte più interessanti di tutte.

---

## Prova tu

> "Quante categorie distinte ci sono?"

![Conteggio delle categorie distinte](../../assets/examples/e071.png)

Una domanda di una riga, una risposta di una riga, dritta dal modello in
esecuzione.

## Cosa ti porti a casa da questo capitolo

- I dati arrivano in tre forme: strutturati, semi-strutturati, non strutturati.
- I dati aziendali si nascondono in ERP, CRM, database, fogli di calcolo, log e
  API.
- **Profila** sempre prima di costruire: conosci la forma e le lacune.
- Non dimenticare i metadati: i dati sui tuoi dati.

Prossimo: il lavoro poco glamour ma essenziale di pulire i dati sporchi, e come
qualche colonna calcolata sistema un pasticcio in pochi secondi.
