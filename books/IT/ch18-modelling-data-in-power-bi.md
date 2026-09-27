# Modellare i dati in Power BI

La modellazione è dove l'analisi si vince o si perde. Un buon modello rende facile
ogni domanda; un modello cattivo rende ogni domanda una lotta. Questo capitolo
mostra l'assistente come modellatore attento: uno che non solo costruisce il
modello, ma lo documenta e lo verifica contro le best practice.

## Che aspetto ha un buon modello

Hai incontrato lo schema a stella nel Capitolo 8. In Power BI, un buon modello
significa:

- Una pulita **tabella dei fatti** (i numeri: vendite, transazioni).
- Ordinate **tabelle di dimensione** (le descrizioni: prodotti, clienti, date).
- **Relazioni** cablate correttamente (molti-a-uno, nessuna ambiguità).
- **Misure** con nomi, formati e descrizioni chiari.
- **Documentazione** perché la persona successiva (o tu, fra sei mesi) lo capisca.

L'assistente aiuta con tutto questo, dal vivo.

## Documentare mentre procedi

I buoni modelli sono modelli documentati. L'assistente può aggiungere descrizioni a
tabelle e colonne su richiesta:

> "Aggiungi una descrizione alla tabella Sales."

![Descrizione della tabella](../../assets/examples/e046.png)

> "Descrivi la colonna Amount."

![Descrizione della colonna](../../assets/examples/e047.png)

Queste piccole note compaiono nel modello e nel dizionario dei dati. Sono la
differenza tra un modello che è una scatola nera e uno che è un bene condiviso.

> "Metti una descrizione sulla tabella Products."

![Descrizione di Products](../../assets/examples/e080.png)

## Il dizionario dei dati, tabella per tabella

Puoi documentare tutto il modello o una singola tabella:

> "Genera un dizionario dei dati solo per Products."

![Dizionario di Products](../../assets/examples/e045.png)

Un dizionario mirato per una tabella: comodo quando consegni un pezzo del modello a
un collega.

## Il check-up: le best practice

Questa è una delle mosse più preziose dell'assistente. Scansiona tutto il modello e
riporta problemi e suggerimenti:

> "Controlla il modello contro le best practice."

![Report best practice](../../assets/examples/e048.png)

Segnala misure senza stringa di formato, tabelle senza descrizione, tabelle
disconnesse: i piccoli peccati che rendono un modello difficile da usare. È come
un linter per il tuo modello di dati: non ti impedisce di lavorare, ma ti dice dove
il modello è disordinato prima che il disordine ti morda.

## Ricontrollare dopo le modifiche

Mentre costruisci, il modello deriva. Rieseguire il controllo lo tiene onesto:

> "Best practice dopo aver aggiunto misure."

![Best practice dopo le modifiche](../../assets/examples/e093.png)

Una rapida ri-scansione mostra cosa hanno introdotto le tue ultime modifiche.
Costruisci, controlla, sistema, ripeti: il ritmo di un modello pulito.

## Una curiosità: il bus factor

C'è una metrica nei team software chiamata **bus factor**: quante persone
dovrebbero essere "investite da un bus" prima che un progetto sia bloccato perché
solo una persona lo capisce. Un modello senza documentazione ha un bus factor di
uno: terrificante. Ogni descrizione e ogni voce di dizionario che l'assistente
scrive alza quel numero. Non stai solo riordinando; stai rendendo il modello
sopravvivibile.

## Perché l'assistente è un buon modellatore

Un modellatore umano sotto pressione di scadenza salta la documentazione e le best
practice. L'assistente non si stanca, non salta passi, e controlla tutto. Unisci il
giudizio umano su *cosa* modellare con la diligenza dell'assistente nel
*documentare e verificare*, e ottieni modelli che restano puliti.

---

## Cosa ti porti a casa da questo capitolo

- Un buon modello: fatti + dimensioni puliti, cablati bene, documentati.
- Aggiungi descrizioni a tabelle, colonne e misure mentre procedi.
- Genera dizionari dei dati per documentare tutto il modello o una tabella.
- Esegui il controllo best practice come un linter: spesso.
- La documentazione alza il bus factor; rende il modello sopravvivibile.

Prossimo: DAX, il linguaggio dietro i numeri, e come non devi scriverlo tu.
