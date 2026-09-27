# Modelli, tabelle e relazioni

Un mucchio di tabelle non è un modello. Un **modello** è ciò che ottieni quando
dici al computer come le tabelle *si relazionano* tra loro. Quelle connessioni, il
cablaggio, sono ciò che ti permette di fare una domanda in un punto e ottenere una
risposta che attraversa molte tabelle. Questo capitolo parla di quel cablaggio.

## Tabelle, righe e chiavi

Ogni tabella ha **righe** (un record ciascuna) e **colonne** (un attributo
ciascuna). La magia sta nella **chiave**: una colonna che identifica in modo unico
ogni riga. Un ID cliente, un codice prodotto, un numero d'ordine. Le chiavi sono
il modo in cui le tabelle si riconoscono tra loro.

- Una **chiave primaria** è l'ID univoco in una tabella (una riga per cliente).
- Una **chiave esterna** è una colonna in un'altra tabella che punta a quell'ID
  (ogni vendita conserva l'ID del cliente).

## La relazione: come due tabelle parlano

Una **relazione** collega una chiave esterna a una chiave primaria. Una volta
collegate, il computer può rispondere a domande che attraversano le tabelle:
"quale prodotto c'era in questa vendita?" "in quale città viveva questo cliente?",
senza che tu debba mai unire file a mano.

Il tipo più comune è **molti-a-uno**: molte vendite puntano a un prodotto. Ogni
vendita ha un ID prodotto; la tabella dei prodotti ha una riga per prodotto. Molte
vendite, un prodotto. Questa è la spina dorsale di quasi ogni modello di business.

## Cablare dal vivo

Ecco l'assistente che crea una relazione da una richiesta semplice:

> "Collega Sales a Products su ProductID."

![Relazione da Sales a Products](../../assets/examples/e015.png)

Lo strumento riporta la direzione (Many→One) e conferma che è attiva in Power BI
Desktop. Poi il collegamento dei clienti:

> "Collega Sales a Customers su CustomerID."

![Relazione da Sales a Customers](../../assets/examples/e016.png)

E il collegamento dei negozi:

> "Collega Sales a Stores su StoreID."

![Relazione da Sales a Stores](../../assets/examples/e017.png)

Tre frasi, e il modello ora ha una spina dorsale. Ogni domanda successiva su
"vendite per prodotto", "vendite per cliente", "vendite per negozio" funziona
grazie a queste tre righe.

## Vedere tutto il cablaggio

> "Mostra tutte le relazioni nel modello."

![Tutte le relazioni](../../assets/examples/e018.png)

Tre pulite relazioni Many→One, tutte attive. Questo è lo schema del cablaggio: la
cosa che controlli per prima quando un numero sembra sbagliato.

## Lo schema a stella: la forma che vuoi

Metti tutto insieme e ottieni la forma più famosa dei dati di business: lo **schema
a stella**. Una tabella dei fatti al centro (Sales), circondata da tabelle di
dimensione (Products, Customers, Stores, Date). La tabella dei fatti contiene i
numeri; le dimensioni contengono il dettaglio descrittivo. Disegnato, sembra una
stella.

Perché è così amato? Perché è semplice, veloce e combacia con il modo in cui le
persone fanno le domande. "Vendite per categoria" è solo la tabella dei fatti che
si protende verso la dimensione dei prodotti. Quasi ogni buon modello BI è una
stella, o un campo di stelle.

## Una tabella calcolata: riassumere al volo

A volte vuoi una piccola tabella riassuntiva costruita dal modello stesso:

> "Costruisci una piccola tabella di vendite totali per categoria."

![Tabella vendite per categoria](../../assets/examples/e019.png)

Una nuova tabella, calcolata dal vivo, che arrotola il dettaglio in un riassunto
ordinato. Comoda per un report rapido o un'istantanea.

## Una curiosità: la trappola molti-a-molti

La relazione più pericolosa è la **molti-a-molti** fatta senza cura: molti
prodotti in molte promozioni, molti studenti in molte classi. Se sbagli, i tuoi
totali contano doppio o spariscono. Il rimedio è una tabella "ponte" nel mezzo. Se
i tuoi numeri di colpo sembrano gonfi, una molti-a-molti approssimativa è la prima
sospettata.

---

## Prova tu

> "Quante relazioni ci sono ora?"

![Conteggio delle relazioni](../../assets/examples/e073.png)

Un rapido controllo che il cablaggio sia tutto presente.

## Cosa ti porti a casa da questo capitolo

- Un modello è tabelle più le relazioni tra loro.
- Le chiavi (primarie ed esterne) sono il modo in cui le tabelle si riconoscono.
- Molti-a-uno è la spina dorsale dei dati di business.
- Lo schema a stella è la forma che di solito vuoi.
- Diffida delle molti-a-molti approssimative: gonfiano i totali.

Prossimo: fare domande direttamente ai dati: SQL e DAX, i due linguaggi per
ottenere risposte.
