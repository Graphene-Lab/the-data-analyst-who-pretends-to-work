# Connettersi ai propri dati

Prima che l'assistente possa fare qualsiasi cosa con Power BI, si deve connettere.
Questo capitolo parla di quella stretta di mano: come l'assistente trova il tuo
report aperto, si connette al modello in esecuzione, e sa esattamente con chi sta
parlando.

## La connessione locale

Ecco la cosa chiave da capire: Power BI Desktop, quando apri un report, avvia un
piccolo **motore di analisi** sulla tua macchina (un programma chiamato
`msmdsrv`). L'assistente si connette a *quel* motore, sulla *tua* macchina.

```
Tu  →  AgentBridge  →  PowerBITool  →  il motore dentro il tuo Power BI Desktop
```

Niente cloud. Niente upload. I dati non lasciano mai il tuo computer.
L'assistente sta semplicemente parlando allo stesso motore che Power BI stesso
usa, attraverso una porta locale.

## Trovare cosa è aperto

L'assistente può vedere ogni report Power BI che hai aperto, ognuno con il suo
motore e la sua porta:

> "Quali report Power BI sono aperti adesso?"

![Report aperti](../../assets/examples/e003.png)

Se hai un solo report aperto, si connette a quello direttamente. Se ne hai parecchi,
gli dici quale per nome. È così che resta puntato sulla cosa giusta.

## Confermare la connessione

Una volta connesso, puoi sempre controllare lo stato:

> "Qual è lo stato della connessione?"

![Stato della connessione](../../assets/examples/e004.png)

Ti dice su quale modello sei e su quale porta locale. Questo conta perché ogni
modifica successiva va a *questo* modello vivo. Sapere esattamente a cosa sei
connesso è la prima regola di una modifica sicura.

## Cosa significa davvero "vivo"

Quando l'assistente modifica il modello, la modifica avviene nel **modello vivo, in
memoria** dentro Power BI Desktop. La vedi immediatamente: è il ciclo di feedback
visivo. Ma c'è una fregatura importante di cui lo strumento ti avvisa sempre:

> La modifica è viva ma **non salvata nel file**. Per conservarla, premi **Ctrl+S**
> in Power BI Desktop.

Questa è una funzione di sicurezza, non un bug. Significa che ogni modifica è
reversibile finché non scegli di salvare. Puoi sperimentare liberamente; niente è
permanente finché non decidi.

## Una curiosità: la porta è una porta segreta

Ogni istanza di Power BI Desktop sceglie una porta di rete locale casuale per il suo
motore: quel numero nella stringa di connessione (tipo `localhost:64431`).
L'assistente scopre questa porta automaticamente trovando il processo Power BI in
esecuzione e il suo motore figlio. Non devi mai sapere il numero; lo capisce lo
strumento. È la stessa porta che Power BI usa internamente: l'assistente ha solo
imparato a bussare.

## Riconnessione e sicurezza

Se chiudi il report e ne apri un altro, l'assistente nota che il motore è cambiato
e ti chiede di riconnetterti: non scriverà alla cieca sul modello sbagliato. Questa
sicurezza di sessione è ciò che rende affidabile la modifica dal vivo: lo strumento
controlla che il motore dietro la connessione sia ancora quello a cui si era
connesso prima di lasciar passare una modifica.

---

## Cosa ti porti a casa da questo capitolo

- L'assistente si connette al motore locale dentro il tuo Power BI Desktop.
- Niente cloud, niente upload: tutto resta sulla tua macchina.
- Scopre automaticamente i report aperti e le loro porte.
- Le modifiche sono vive ma non salvate finché non premi Ctrl+S.
- Lo strumento protegge dallo scrivere sul modello sbagliato.

Prossimo: modellare in Power BI: l'assistente come modellatore attento e ben
documentato.
