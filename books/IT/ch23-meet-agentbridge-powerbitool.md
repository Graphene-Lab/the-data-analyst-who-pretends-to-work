# Conosci AgentBridge e PowerBITool

Ogni esempio in questo libro è stato fatto con due strumenti che lavorano insieme.
Questo capitolo li presenta per bene: cos'è ciascuno, come si incastrano, e cosa
possono fare.

## AgentBridge: l'assistente

**AgentBridge** è un assistente AI che gira sul tuo computer. Ci parli in parole
semplici, e lui fa lavoro attraverso i tuoi strumenti. Non è un chatbot che solo
parla: agisce. Può scrivere documenti, costruire fogli di calcolo, mandare email,
ricercare sul web, e, con il plugin giusto, azionare Power BI.

Le proprietà chiave:

- **Locale.** Gira sulla tua macchina. I tuoi dati restano con te.
- **In linguaggio semplice.** Descrivi cosa vuoi; non scrivi codice.
- **Estensibile.** I plugin gli danno nuove abilità. PowerBITool è uno di
  questi.

## PowerBITool: le mani dentro Power BI

**PowerBITool** è il plugin che dà ad AgentBridge le mani dentro Microsoft Power
BI Desktop. Attraverso di esso, l'assistente può:

- **Connettersi** al modello vivo di un report aperto.
- **Ispezionare**: riepilogo del modello, tabelle, schema, misure, relazioni.
- **Modificare il modello**: creare e cancellare tabelle, colonne, misure,
  relazioni; impostare descrizioni.
- **Eseguere e validare DAX**: con una guardia di sicurezza che blocca qualsiasi
  cosa pericolosa.
- **Profilare e documentare**: profilare tabelle, generare un dizionario dei dati,
  fare il lint per le best practice.

Ecco l'assistente che si presenta a un modello:

> "Presenta PowerBITool: cosa puoi fare con il mio modello?"

![Presentazione di PowerBITool](../../assets/examples/e064.png)

Il riepilogo che restituisce è tutta la superficie: tabelle, misure, relazioni,
conteggi di righe: tutto ciò che può vedere e su cui può lavorare.

## Come si incastrano

```
Tu  →  AgentBridge (il cervello)  →  PowerBITool (le mani)  →  Power BI Desktop (il modello)
```

AgentBridge capisce le tue parole e pianifica l'azione. PowerBITool esegue
quell'azione sul modello Power BI vivo. Vedi il risultato immediatamente in Power
BI Desktop. Il ciclo è: chiedi → pensa → agisci → vedi.

## La guardia di sicurezza

Una cosa che vale la pena sottolineare: PowerBITool fa passare il DAX attraverso una
**guardia fail-closed**. Consente query di solo lettura (`EVALUATE`, viste di
sistema) e blocca qualsiasi cosa che possa modificare il modello attraverso la
porta delle query: niente `DROP`, niente `INSERT`, niente `DELETE`, niente trucchi
a istruzioni multiple. Se una query non è chiaramente sicura, viene rifiutata.
Questo è ciò che rende responsabile lasciar toccare un modello vivo a
un'AI.

## Gratis, e supportato da persone vere

Entrambi gli strumenti sono gratis. PowerBITool è aperto su GitHub, e, come la
prefazione prometteva, anche il supporto è gratis: apri una issue e un tecnico vero
risponde entro circa 24 ore con una vera soluzione. Quella combinazione (strumento
gratis, supporto umano gratis, risposte rapide) è la promessa dietro ogni esempio
che hai visto.

## Una curiosità: il modello a plugin

PowerBITool non è compilato dentro AgentBridge. È un **plugin** calato in una
cartella `Tools`, scoperto all'avvio. Questo significa che le abilità
dell'assistente possono crescere senza cambiare il nucleo: oggi Power BI, domani
altri strumenti. Il modello a plugin è il motivo per cui l'assistente può
continuare ad acquisire nuove "mani" senza gonfiarsi.

## Cosa puoi farci, insieme

Tutto ciò che c'è in questo libro, e di più: connetterti a un report, capire il
modello, pulire dati con colonne calcolate, costruire misure, cablare relazioni,
validare e fare il lint del DAX, generare documentazione, e controllare le best
practice, il tutto parlando.

---

## Cosa ti porti a casa da questo capitolo

- AgentBridge è l'assistente locale, in linguaggio semplice (il cervello).
- PowerBITool è il plugin che aziona Power BI Desktop (le mani).
- Il ciclo: chiedi → pensa → agisci → vedi, tutto locale.
- Una guardia fail-closed tiene al sicuro il modello vivo.
- Strumento gratis, supporto gratis, persone vere, risposte rapide.

Prossimo: un'intera giornata del lavoro dell'analista, automatizzata.
