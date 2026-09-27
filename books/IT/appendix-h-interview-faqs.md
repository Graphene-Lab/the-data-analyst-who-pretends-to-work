# Appendice H — Domande frequenti dei colloqui

Domande comuni dei colloqui per data analyst, con risposte brevi che mostrano che
capisci sia il mestiere sia gli strumenti moderni.

## "Cosa fa davvero un data analyst?"

Trasforma domande di business in risposte sui dati. Trova e pulisce i dati, li
modella, calcola metriche, e racconta una storia che guida una decisione. Lo
strumento gestisce il fare; l'analista possiede la domanda e il giudizio.

## "SQL o DAX?"

Entrambi. SQL per interrogare i database; DAX per modellare e per le misure in
Power BI. Si completano a vicenda. Sapere quando usare quale è la vera
competenza.

## "Qual è la differenza tra una colonna calcolata e una misura?"

Una colonna calcolata è calcolata una volta per riga e salvata. Una misura è
calcolata al momento della query, rispondendo ai filtri. Usa una colonna per
attributi a livello di riga; usa una misura per aggregazioni che devono reagire ai
filtri del report.

## "Spiega CALCULATE."

CALCULATE cambia il contesto di filtro di una misura. È la funzione più potente in
DAX perché ti permette di calcolare un valore sotto un insieme specifico di filtri:
per esempio, le vendite di una categoria, o escludendo una regione.

## "Come gestisci la divisione per zero?"

Usa DIVIDE invece di `/`. DIVIDE restituisce un risultato sicuro (vuoto o un
valore di ripiego) quando il denominatore è zero. Non usare mai `/` grezzo in una
misura.

## "Come controlli la qualità dei dati?"

Profila le tabelle: valori distinti, vuoti, min/max, duplicati. Riconcilia i
totali con la fonte. Esegui un controllo best practice sul modello. Un modello
pulito è la fondazione di ogni numero degno di fiducia.

## "Cos'è uno schema a stella?"

Una tabella dei fatti centrale (per es. Sales) collegata a tabelle di dimensione
(Products, Customers, Stores) con relazioni molti-a-uno. È la forma standard ed
efficiente per i modelli analitici.

## "Come te la cavi con un grafico fuorviante?"

Redisegnalo onestamente. Controlla l'asse, la finestra temporale e
l'aggregazione. Se un grafico si può leggere in due modi, il compito
dell'analista è rendere la lettura onesta quella ovvia.

## "Cosa fai quando i dati contraddicono la risposta attesa?"

Fidati dei dati, poi indaga perché. Un risultato sorprendente è spesso il più
prezioso. Controlla la fonte, i filtri e le definizioni prima di
concludere.

## "Come usi gli strumenti AI nel tuo flusso di lavoro?"

Come acceleratore, non come sostituto. Uso un assistente (AgentBridge +
PowerBITool) per costruire e validare misure, documentare il modello ed eseguire
controlli best practice, così passo il mio tempo sulle domande e sulla storia, non
sulla sintassi. Controllo ogni numero prima di pubblicarlo. Lo strumento fa il
come; io possiedo il cosa e il perché.

## "Parlami di un progetto che hai costruito."

Usa il progetto portfolio dell'Appendice G: la domanda, il modello, le metriche,
la dashboard, la storia, e come l'assistente ha aiutato. Mostra che sai fare tutta
la catena e che capisci ogni passo.

## La meta-risposta

Quasi ogni buona risposta torna alla stessa idea: **lo strumento rende il lavoro
veloce; l'analista lo rende giusto.** Mostra che conosci entrambe le metà e ti
distingui da chi ne conosce solo una.
