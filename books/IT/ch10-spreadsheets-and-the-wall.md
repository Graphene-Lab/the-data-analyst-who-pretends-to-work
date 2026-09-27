# Fogli di calcolo, Excel e il muro contro cui sbattere

Nessun libro sull'analisi dei dati può saltare il foglio di calcolo. È dove quasi
tutti cominciano, e a ragion veduta: è geniale. Ma è anche dove la gente sbatte
contro un muro, e sapere dov'è quel muro ti dice quando andare oltre.

## Perché i fogli di calcolo hanno vinto

Il foglio di calcolo è uno dei software di maggior successo mai realizzati. Il suo
genio è che è **manipolazione diretta**: digiti un numero in una casella, e le
caselle che dipendono da esso si aggiornano all'istante. Niente codice, niente
compilazione, niente attesa. Vedi il tuo lavoro e il tuo risultato fianco a fianco.

I fogli di calcolo hanno dato alla gente comune il potere di modellare: budget,
previsioni, calendari, listini prezzi. Prima del foglio di calcolo, quel potere
viveva solo nei mainframe e solo con i programmatori. Dopo, chiunque avesse un PC
poteva farlo.

## La tabella pivot: analisi in una scatola

La **tabella pivot** è il superpotere del foglio di calcolo. Trascini qualche
campo e lei riassume migliaia di righe: vendite per mese, per prodotto, per
regione. Per una fetta enorme dell'analisi di business, una tabella pivot è tutto
il lavoro. Se sai fare una pivot, sai analizzare.

## Il muro

Ma i fogli di calcolo hanno un soffitto, e ogni analista prima o poi lo
raggiunge:

- **Dimensione** — oltre un milione di righe, Excel geme, rallenta e si
  schianta.
- **Fragilità** — una cella cancellata, una formula rotta, e l'intera cartella di
  lavoro è silenziosamente sbagliata. Non c'è rete di protezione.
- **Niente relazioni** — unire due tabelle significa VLOOKUP, e VLOOKUP si rompe
  nell'istante in cui i dati si muovono.
- **Caos di versioni** — "Budget_FINAL_v3_veramente_finale.xlsx" modificato da
  cinque persone, tutte in disaccordo.
- **Niente aggiornamento** — un report che si aggiorna con copia-incolla ogni
  lunedì è un report che è sbagliato ogni martedì.
- **Niente storia condivisa** — un foglio di calcolo è un file, non una dashboard
  viva che gli altri possano fidarsi di esplorare.

Se il tuo lunedì mattina è "apri il file, incolla i nuovi dati, trascina le
formule, ri-salva, mandalo via email", stai facendo a mano ciò che un modello
vero fa da solo.

## Il foglio di calcolo contro il modello

Ecco la differenza in una riga:

> Un foglio di calcolo conserva numeri nelle celle. Un modello conserva *logica* e
> calcola i numeri freschi ogni volta.

In un foglio di calcolo, il numero *è* la risposta, seduta in una cella, che
marcisce. In un modello, la risposta viene ricalcolata dai dati e dalle regole,
ogni volta che guardi, sempre aggiornata.

## La stessa domanda, in due modi

In Excel, "vendite totali" significa una formula SUM su una colonna, corretta solo
finché nessuno tocca le righe. In un modello, è una misura — `SUM(Sales[Amount])`
— che si ricalcola su richiesta e può essere affettata per qualsiasi dimensione
senza una singola nuova formula:

> "Qual è il totale della colonna Amount?"

![Totale Amount come misura](../../assets/examples/e021.png)

Stesso numero, ma ora vive in un modello che può rispondere "per regione", "per
mese", "per cliente" senza alcun lavoro extra: perché la logica è salvata, non il
risultato.

## Una curiosità: il foglio di calcolo che perse un miliardo

Nel 1998, un errore in un foglio di calcolo contribuì a causare una perdita di
1,2 miliardi di dollari in un grande fondo finanziario (LTCM), e innumerevoli
aziende si sono scottate per una singola cella sbagliata. Nel 2008, un famoso
paper di ricerca su debito e crescita fu scoperto avere un errore in un foglio di
calcolo: un insieme di righe escluso per sbaglio, che ribaltava la sua conclusione
e aveva influenzato politiche reali per anni. I fogli di calcolo sono potenti, ed
è esattamente per questo che i loro errori sono pericolosi. Un modello con logica
testata è più sicuro di un foglio di calcolo con un `+` nascosto dove dovrebbe
esserci un `-`.

## Quando restare, quando andare

Resta nel foglio di calcolo quando: i dati sono piccoli, il lavoro è una tantum,
stai facendo uno schizzo. Passa a un modello quando: i dati sono grandi, il report
si ripete, più di una persona ci mette le mani, o ti serve che sia *giusto* e
*aggiornato*. L'assistente e Power BI sono il modo per attraversare quel ponte
senza dolore.

---

## Cosa ti porti a casa da questo capitolo

- I fogli di calcolo sono geniali per lavoro piccolo, diretto, una tantum.
- La tabella pivot è un vero superpotere.
- Il muro: dimensione, fragilità, niente relazioni, caos di versioni, niente
  aggiornamento.
- Un modello conserva logica, non risultati congelati.
- Vai oltre quando il report si ripete o i dati crescono.

La Parte II è finita: sai da dove arrivano i dati, come pulirli, come cablarli e
come fare loro domande. Ora trasformiamo i dati in significato: le metriche e i
tipi di analisi che guidano le decisioni.
