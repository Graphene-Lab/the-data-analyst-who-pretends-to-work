# Quattro tipi di analisi

Ogni analisi che farai mai ricade in uno di quattro tipi, ordinati per quanto
chiedono ai dati. Salgono una scala: dal guardare indietro, allo spiegare perché, al
indovinare in avanti, al raccomandare cosa fare. Sapere quale tipo stai facendo ti
dice quanto spingere e di quanto fidarti della risposta.

## 1. Descrittiva: cosa è successo?

La più semplice e la più comune. Descrivi il passato. "Le vendite sono state
22.023 €. Il Nord ha fatto 12.145 €." Nessuna spiegazione, nessuna previsione:
solo i fatti, con chiarezza.

> "Descrittiva: vendite totali per regione."

![Descrittiva per regione](../../assets/examples/e031.png)

La maggior parte delle dashboard è descrittiva. Rispondono a "come stiamo andando?"
e sono la fondazione su cui tutto il resto poggia.

La suddivisione regionale, come grafico:

![Vendite per regione — grafico a barre](../../assets/examples/chart-region.png)

## 2. Diagnostica: perché è successo?

Ora scavi. Qualcosa è cambiato, e tu vuoi la causa. Affetti, confronti e
incroci dati finché la ragione non affiora.

> "Diagnostica: quale categoria guadagna di più?"

![Diagnostica per categoria](../../assets/examples/e032.png)

> "Confronta vendite Nord contro Centro."

![Nord contro Centro](../../assets/examples/e033.png)

Il lavoro diagnostico è dove l'analista guadagna lo stipendio. La descrittiva ti
dice che il paziente ha la febbre; la diagnostica trova l'infezione.

Lo stesso occhio diagnostico puntato sui negozi:

![Vendite per negozio — grafico a barre](../../assets/examples/chart-store.png)

## 3. Predittiva: cosa succederà?

Usi il passato per indovinare il futuro. Domanda il prossimo trimestre, abbandoni
il prossimo mese, vendite a fine anno. Di solito servono statistica o machine
learning, e viene con un intervallo di confidenza: una buona previsione dice
"circa 11.000, più o meno".

> "Il mese migliore in assoluto."

![Mese migliore](../../assets/examples/e076.png)

Una vista a singolo periodo come questa è la materia prima per la previsione: vedi
il pattern, poi lo proietti in avanti.

## 4. Prescrittiva: cosa dovremmo fare?

La cima della scala. Data la previsione e i vincoli, quale azione massimizza
l'obiettivo? Quale prezzo, quale promozione, quale livello di magazzino.
L'analisi prescrittiva è la più rara e la più difficile, e di solito siede sopra
gli altri tre.

## La scala in un'immagine

| Tipo | Domanda | Sforzo | Fiducia richiesta |
|---|---|---|---|
| Descrittiva | Cosa è successo? | Basso | Alta (sono solo fatti) |
| Diagnostica | Perché? | Medio | Media (attento alle false cause) |
| Predittiva | Cosa dopo? | Alto | Più bassa (è un'ipotesi con un intervallo) |
| Prescrittiva | Cosa fare? | Massimo | La più bassa (è una raccomandazione) |

Nota il pattern: più sali in alto, più valore aggiungi, e meno sei certo. Un buon
analista è onesto su questo scambio.

## Classificare: la mossa preferita dell'analista

Classificare trasforma una lista piatta in una storia. Chi è primo, chi è ultimo,
chi sta migliorando.

> "Classifica i prodotti per vendite."

![Classifica prodotti](../../assets/examples/e034.png)

> "Quantità media per vendita."

![Quantità media per vendita](../../assets/examples/e059.png)

Classificare è descrittivo, ma orienta il lavoro diagnostico: il fondo della lista
è dove guardi per primo per trovare un problema.

## Una curiosità: il mito della maturità analitica

Ai consulenti piace vendere un "modello di maturità" in cui devi salire dalla
descrittiva alla prescrittiva o sei un ritardatario. In realtà, **alla maggior
parte delle aziende basterebbe essere trasformata già solo facendo bene descrittiva
e diagnostica.** Non vergognarti di un buon "cosa è successo e perché": è lì che
vive il 90% del valore. Gli strati predittivo e prescrittivo sono la ciliegina sulla
torta, non la torta.

---

## Cosa ti porti a casa da questo capitolo

- Quattro tipi: descrittiva, diagnostica, predittiva, prescrittiva.
- Valore e incertezza salgono entrambi man mano che sali.
- La maggior parte del valore vive in descrittiva + diagnostica.
- Classificare è il modo più semplice di capire dove guardare.
- Sii onesto su quanto fidarti di ciascun tipo.

Prossimo: il cliente, il soggetto di analisi più importante che ci sia.
