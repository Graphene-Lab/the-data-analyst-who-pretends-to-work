# Statistica senza dolore

Non ti serve molta statistica per essere un buon analista. Ti serve un pugno di
idee, capite a fondo, e la saggezza di sapere quando ti ingannano. Ecco tutta la
cassetta degli attrezzi, in parole semplici.

## Le tre medie: media, mediana, moda

La gente dice "media" come se ce ne fosse una sola. Ce ne sono tre, e scegliere
quella sbagliata può mentire senza tecnicamente sbagliare.

- **Media** — somma tutto, dividi per il numero dei casi. La media classica.
- **Mediana** — il valore centrale quando li metti tutti in fila. Metà sopra, metà
  sotto.
- **Moda** — il valore più frequente.

Perché conta? Immagina una piccola azienda. Dieci dipendenti guadagnano 30.000 €,
e il capo guadagna 500.000 €.

- La **media** degli stipendi è 72.727 €: "paghiamo bene!"
- La **mediana** degli stipendi è 30.000 €: la realtà del lavoratore tipico.

Un numero è "corretto" e l'altro è "corretto", e raccontano storie completamente
diverse. Quando ci sono di mezzo pochi valori estremi (outlier), la **mediana** di
solito è quella onesta. Quando qualcuno cita una media, chiedi: *media o mediana?*

## Dispersione: le cose sono stabili o selvagge?

Una media nasconde quanto i numeri siano sparpagliati. Due servizi di consegna
hanno entrambi una media di 3 giorni. Uno impiega sempre 3 giorni. L'altro impiega
1 giorno o 5 giorni a caso. Stessa media, esperienza totalmente diversa.

La misura di dispersione che userai di più è la **deviazione standard**: in
pratica, "quanto lontano dalla media stanno di solito le cose". Deviazione standard
piccola = stabile, prevedibile. Grande = selvaggia, inaffidabile. Le medie ti
dicono il centro; la dispersione ti dice il rischio.

## La curva a campana (e perché salta fuori ovunque)

Molte cose reali, altezze, punteggi dei test, errori di misura, si accumulano
attorno al centro e si diradano alle estremità, formando una forma a campana.
Questa è la **distribuzione normale**, ed è ovunque per una ragione bellissima:
quando tante piccole influenze casuali si sommano, il risultato tende a una
campana. Non ti serve la matematica. Ti serve l'istinto: la maggior parte dei casi
è vicino al centro, gli estremi sono rari, e un valore molto lontano nella coda
merita di essere indagato.

## Outlier: l'unico numero strano

Un **outlier** è un valore lontano dagli altri. Un cliente compra 50.000 € mentre
tutti gli altri comprano 50 €. Una consegna impiega 30 giorni mentre le altre
impiegano 3. Gli outlier possono essere:
- **Errori** — un refuso, un record di prova, una virgola decimale spostata.
- **Reali ma rari** — un cliente balena, un disastro genuino.

Guarda sempre gli outlier prima di fidarti di una media. Un singolo cliente grosso
può far sembrare ottimo un mese intero e nascondere che gli altri 200 clienti se
ne stanno andando.

## La grande trappola: correlazione non è causalità

Questa è la frase più importante di tutto il libro.

**Correlazione** significa che due cose si muovono insieme. **Causalità** significa
che una cosa *causa* l'altra. Non sono la stessa cosa, e confonderle provoca
sciocchezze costose.

Esempio classico: **le vendite di gelato e le morti per annegamento salgono
insieme** ogni estate. Il gelato causa l'annegamento? No. Una terza cosa, il caldo,
guida entrambe. Quando vedi due cose muoversi insieme, chiedi sempre:
- A causa B?
- B causa A?
- Una C nascosta causa entrambe?
- È solo una coincidenza?

"I clienti che usano di più la nostra app sono più felici" potrebbe significare che
l'app li rende felici, o che i clienti già felici la usano di più. La
correlazione ti indica un indizio. Non ti mette in mano la risposta.

## Una curiosità: il coefficiente di correlazione

Gli statistici strizzano "quanto fortemente due cose si muovono insieme" in un
numero da **-1 a +1**. +1 significa che salgono in perfetto sincronismo; -1
significa che una sale mentre l'altra scende; 0 significa nessuna relazione. È un
termometro utile per una relazione, ma ricorda: anche un +1 perfetto non è ancora
una prova di causa.

---

## Cosa ti porti a casa da questo capitolo

- Sappi quale media stai usando; la mediana spesso dice la verità.
- Le medie nascondono la dispersione: tieni d'occhio la deviazione standard.
- Gli outlier possono falsificare un'intera storia; guarda loro per primi.
- La correlazione è un indizio, mai una prova. Caccia sempre la terza cosa
  nascosta.

Prossimo: come trasformare una vaga preoccupazione di business in una domanda
affilata a cui puoi davvero rispondere con i dati.
