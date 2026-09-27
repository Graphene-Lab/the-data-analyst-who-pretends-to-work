# Le metriche che contano

Una metrica è un numero che osservi per sapere come sta andando il business.
Scegli quelle giuste e puoi governare. Scegli quelle sbagliate e puoi finire giù da
un precipizio mentre la dashboard splende di verde. Questo capitolo parla di
scegliere i numeri che contano davvero, e di costruirli con l'assistente.

## Cosa rende una metrica degna di essere osservata

Una buona metrica supera tre prove:

1. **Si muove quando il business si muove.** Se il business peggiora, il numero
   dovrebbe peggiorare.
2. **Puoi agirci sopra.** Un numero che puoi solo ammirare è decorazione.
3. **È onesta.** Non può essere barata per sembrare buona mentre le cose marciscono.

Una **vanity metric** le fallisce. "Utenti registrati totali dal 2010" sale e basta.
Fa un figurone e non significa niente. Osserva tassi e variazioni, non totali che
crescono per sempre.

## Le metriche chiave delle vendite

Ogni azienda che vende cose osserva un set simile:

- **Vendite totali** — il fatturato principale.
- **Unità vendute** — quanta roba si è mossa.
- **Ordini** — quante transazioni.
- **Valore medio dell'ordine** — fatturato per ordine.
- **Clienti attivi** — quante persone hanno davvero comprato.
- **Vendita più grande** — la riga singola più grossa (per scovare le balene).

L'assistente costruisce ognuna di queste da una richiesta semplice. Guarda un set
comparire:

> "Crea una misura Vendite Totali con formato euro."

![Misura Vendite Totali](../../assets/examples/e026.png)

> "Crea una misura per le unità vendute."

![Misura Unità Vendute](../../assets/examples/e027.png)

> "Crea una misura di valore medio dell'ordine."

![Valore medio dell'ordine](../../assets/examples/e028.png)

Nota che il valore medio dell'ordine usa `DIVIDE`, non una barra. È deliberato:
`DIVIDE` gestisce il caso in cui il denominatore è zero senza schiantarsi. Una
piccola abitudine di sicurezza che ti salva da errori `#DIV/0!` più tardi.

> "Quanti clienti attivi abbiamo?"

![Clienti attivi](../../assets/examples/e029.png)

> "Qual è la vendita singola più grande?"

![Vendita più grande](../../assets/examples/e030.png)

In un pugno di frasi, tutto il set centrale di KPI esiste, vivo nel modello.

## Metriche di denaro: margine e quota

Il fatturato è vanità; il profitto è sanità. Per sapere cosa *trattieni*, ti serve
il costo:

> "Aggiungi una colonna di costo e una misura di margine."

![Colonna costo](../../assets/examples/e056.png)

> "Margine totale su tutte le vendite."

![Margine totale](../../assets/examples/e057.png)

E per vedere come una fetta si confronta con il tutto:

> "Quota delle vendite totali, in percentuale."

![Percentuale del totale](../../assets/examples/e058.png)

Una percentuale-del-totale è una delle metriche più usate nei report: trasforma
qualsiasi numero in "quanto è grande questo rispetto a tutto?".

## Qualche altra rapida

> "Prezzo unitario medio pagato."

![Prezzo unitario medio](../../assets/examples/e075.png)

> "Vendite totali escluse una categoria."

![Vendite escluse una categoria](../../assets/examples/e089.png)

Ognuna è una frase semplice, ognuna è una vera misura nel modello in esecuzione.

## Una curiosità: la metrica che si ritorse contro

Quando l'Unione Sovietica misurava la produzione di chiodi per **quantità**, le
fabbriche facevano chiodini minuscoli e inutili a milioni. Quando passarono a
misurare per **peso**, fecero pochi chiodi enormi. Stesso obiettivo, metrica
diversa, assurdità diversa. La lezione che ogni analista deve imparare: **ottieni
ciò che misuri**, quindi misura con cura: idealmente una metrica che può migliorare
solo se il business migliora davvero.

---

## Cosa ti porti a casa da questo capitolo

- Scegli metriche che si muovono con il business, su cui puoi agire, che non
  possono essere barate.
- Evita le vanity metric (totali che crescono per sempre).
- Il set centrale delle vendite: fatturato, unità, ordini, ordine medio, clienti
  attivi.
- Margine e quota-del-totale trasformano il fatturato in significato.
- Ottieni ciò che misuri: misura con saggezza.

Prossimo: i quattro tipi di analisi, da "cosa è successo" fino a "cosa dovremmo
fare".
