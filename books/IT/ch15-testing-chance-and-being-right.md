# Test, caso e avere ragione

Hai cambiato il sito web e le conversioni sono salite del 2%. Il tuo cambiamento ha
funzionato, o è stata solo fortuna? Questa è la domanda che separa la vera analisi
dal pensiero augurale, e la risposta vive nel mondo poco glamour dei test e del
caso. Non preoccuparti: la manterremo indolore.

## Il problema: è stato il cambiamento o la fortuna?

Qualsiasi numero può rimbalzare per caso. Se lanci una moneta 10 volte e ottieni 7
teste, non concludi che la moneta sia truccata. Lo stesso col business: se una
nuova pubblicità ottiene qualche clic in più, forse è migliore, o forse è rumore.
La domanda è: **quanto puoi essere sicuro che la differenza sia reale?**

## L'idea di un campione

Quasi non vedi mai l'intera popolazione: vedi un **campione**. 1.000 visitatori al
tuo sito, non tutte le persone che potrebbero mai visitarlo. Un campione è un
piccolo assaggio di una pentola molto più grande. Il trucco è che un piccolo
assaggio può dirti sulla pentola intera, *se* è abbastanza grande e senza distorsioni.

Campione grande + selezione casuale = affidabile. Campione minuscolo o scelto a
pisoli = pericoloso. I test A/B funzionano perché dividono i visitatori a caso in
due gruppi e confrontano.

## Il test A/B: l'esperimento onesto

Lo standard aureo per "funziona o no?":

1. Dividi il tuo pubblico **a caso** in due gruppi.
2. Il gruppo A vede la vecchia versione; il gruppo B vede la nuova.
3. Misura il risultato in entrambi.
4. Confronta. Se B batte A di più di quanto il caso spieghi, il cambiamento è
   reale.

La casualità è tutto il trucco. Rende i due gruppi identici tranne che per la
singola cosa che hai cambiato, quindi ogni differenza deve essere il cambiamento.

## Significatività: la differenza è reale?

Gli statistici usano un **p-value** per rispondere "potrebbe essere il caso?". Un
p-value sotto 0,05 è l'asticella usuale: significa "se non ci fosse davvero
nessuna differenza, vedremmo qualcosa di così estremo meno del 5% delle volte".
Sotto l'asticella la chiami **statisticamente significativa**: probabilmente reale.
Sopra, alzi le spalle e dici "non ci sono prove sufficienti".

Non devi calcolare i p-value a mano. Ti serve l'istinto: **una piccola differenza
su un campione piccolo è probabilmente rumore; una differenza netta su un campione
grande è probabilmente reale.**

## I due modi di sbagliare

- **Errore di tipo I (falso positivo):** dici che il cambiamento ha funzionato
  quando non ha funzionato. Rilasci un cambiamento inutile. L'asticella del 5%
  controlla questo.
- **Errore di tipo II (falso negativo):** dici che il cambiamento non ha funzionato
  quando ha funzionato. Butti via una buona idea. Di solito causato da un campione
  troppo piccolo.

Entrambi succedono. Un buon test li bilancia: abbastanza dati da cogliere effetti
veri, un'asticella abbastanza severa da evitare di inseguire fantasmi.

## Confrontare due gruppi, dal vivo

Non ti serve un laboratorio per vedere la forma di un confronto. L'assistente può
mettere due gruppi fianco a fianco in una sola query:

> "Confronta vendite Nord contro Centro."

![Confronta due gruppi](../../assets/examples/e033.png)

Scala questo su con assegnazione casuale e un campione grande, e hai un test A/B.
La logica è identica: due gruppi, una differenza, misura e confronta.

## Una curiosità: il cookie che fregò tutti

Un'azienda fece un test A/B, vide un grande rialzo, e festeggiò. La fregatura: i
due gruppi non erano davvero casuali: un bug aveva messo tutti gli utenti mobile in
un gruppo. Il "successo" era davvero solo utenti mobile che si comportavano
diversamente. Il test era sano in teoria e rotto nella pratica. **La
randomizzazione è tutto.** Un test vale quanto la divisione che c'è dietro.

## Quando non ti serve un test formale

Non ogni decisione ha bisogno di un p-value. Se cambi il prezzo di un articolo e
guardi una settimana di vendite, non stai facendo un esperimento: stai osservando.
Il test formale è per le decisioni che contano e che si possono condurre per bene.
Per tutto il resto, sii onesto sul fatto che stai indovinando, e tieni la decisione
reversibile.

---

## Cosa ti porti a casa da questo capitolo

- Una differenza può essere fortuna; chiedi quanto sei sicuro.
- I campioni fanno sì che un piccolo assaggio ti dica sulla pentola intera, se sono
  grandi e casuali.
- Test A/B = divisione casuale, cambia una cosa sola, confronta.
- "Significativo" significa "improbabile che sia puro caso".
- La randomizzazione è tutto; una divisione sbagliata simula un successo.

La Parte III è finita: sai costruire metriche, distinguere i tipi di analisi,
conoscere i tuoi clienti, leggere le tendenze e distinguere il reale dal rumore.
Ora rendiamo tutto visibile: Power BI e l'arte di mostrare i tuoi dati.
