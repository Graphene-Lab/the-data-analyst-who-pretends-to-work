# Una nota sullo strumento dietro questo libro

Questo libro parla di un lavoro: il data analyst. Parla di cosa sia davvero quel
lavoro, da dove viene e dove sta andando. Usa parole semplici. Non serve una
laurea in matematica o in informatica per seguirlo. Se gestisci una piccola
impresa, tieni da conto i tuoi numeri, o semplicemente ti piace capire come
funzionano le cose, questo libro è per te.

Ecco la parte onesta. Ogni singolo esempio che vedrai in questo libro — ogni
tabella, ogni misura, ogni grafico, ogni momento "guarda un po'" — è stato creato
con un vero strumento, non scritto a mano. Quello strumento è **PowerBITool**, che
gira dentro **AgentBridge**.

## Cosa sono AgentBridge e PowerBITool?

**AgentBridge** è un assistente AI che gira sul tuo computer. Ci parli come
parleresti a un collega: in frasi normali. Lui ascolta, ragiona e fa il lavoro.

**PowerBITool** è un plugin che dà ad AgentBridge delle mani dentro
**Microsoft Power BI Desktop** — il programma diffuso che si usa per creare
dashboard e report. Con PowerBITool, l'assistente può aprire il tuo modello di
dati, aggiungere tabelle, creare misure, collegare le tabelle tra loro, eseguire
query, controllare il tuo lavoro e fare uno screenshot di ciò che ha prodotto, il
tutto mentre lo guardi accadere sul tuo schermo.

Niente cloud. Niente caricamento dei dati della tua azienda sul server di
qualcun altro. Funziona con il Power BI Desktop che hai già sul tuo computer.

```
Tu  →  AgentBridge  →  PowerBITool  →  il tuo Power BI Desktop (sul tuo PC)
```

## Come ottenerlo (è gratis)

PowerBITool è gratuito e aperto. Per provarlo tu:

1. Installa **AgentBridge** (gratis) dalla pagina GitHub qui sotto.
2. Aggiungici il plugin **PowerBITool**.
3. Apri un report in **Power BI Desktop**.
4. Mettiti a parlare con il tuo assistente.

Inquadra questo codice con la fotocamera del telefono per aprire la pagina di
PowerBITool, dove troverai il download e istruzioni di installazione semplici,
passo per passo:

![PowerBITool su GitHub](../../assets/qr-powerbitool-repo.png)

**github.com/Graphene-Lab/PowerBITool**

Puoi anche semplicemente digitare quell'indirizzo in un browser.

## Sei in difficoltà? Persone vere rispondono in 24 ore, gratis

Ecco una cosa di cui andiamo fieri. PowerBITool è gratis, e gratis è anche l'aiuto
che lo accompagna. Se qualcosa non funziona, se vuoi una funzionalità, o se hai
semplicemente trovato un bug, apri una **issue** sulla stessa pagina GitHub e i
nostri tecnici rispondono, di solito entro **24 ore**, e con una vera soluzione,
non con una risposta preconfezionata.

Inquadra questo codice per raggiungere la pagina delle issue e vedere come funziona:

![Segnala un problema a PowerBITool](../../assets/qr-powerbitool-issues.png)

**github.com/Graphene-Lab/PowerBITool/issues**

Questa è tutta la promessa: uno strumento gratis, supporto gratis, persone vere,
risposte rapide.

## Come leggere questo libro

Non devi installare nulla per goderti questo libro. Leggilo come una storia, se
vuoi. Ma se vuoi provare le cose mentre procedi, e speriamo che tu lo faccia, ogni
esempio pratico mostra due cose:

- **Cosa ha scritto** una persona all'assistente (una o due frasi ordinarie).
- **Cosa è arrivato indietro** (il risultato vero, dallo strumento vero).

Le immagini in questo libro mostrano proprio questo scambio: la domanda a destra,
la risposta di PowerBITool a sinistra, esattamente come appare in AgentBridge.

## Le immagini in questo libro

Vedrai due tipi di immagini.

**I pannelli di chat** mostrano lo scambio in sé: cosa ha scritto una persona, e
il risultato vero che PowerBITool ha restituito dal modello in esecuzione.

**Le immagini dei grafici** mostrano quegli stessi dati reali *visualizzati*:
grafici a barre, a linee e a ciambella disegnati dai numeri effettivi restituiti
dallo strumento (vendite per categoria, migliori clienti, l'andamento mensile, e
così via). Sono visualizzazioni renderizzate del vero output catturato, così puoi
vedere i dati come un'immagine, e non solo come testo.

Una nota onesta su Power BI Desktop stesso. Power BI renderizza gli stessi dati
sulla propria tela di report, e lo strumento può catturare quella tela come PNG
(`CaptureReportScreenshot`, attraverso il Power BI Desktop Bridge). Quella
cattura richiede un report con visual già costruiti nella finestra di Power BI
Desktop. Questo libro è stato prodotto in un ambiente senza un report costruito via
interfaccia grafica, quindi le immagini dei grafici qui sono renderizzate dai dati
reali anziché catturate dallo schermo di Power BI. La procedura per catturare
screenshot autentici di Power BI Desktop è inclusa nello strumento, e puoi
inserire quelle catture direttamente negli stessi punti.

Cominciamo dal lavoro in sé.

*— Graphene Lab*
