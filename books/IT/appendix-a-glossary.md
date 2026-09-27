# Appendice A — Glossario dei termini

Definizioni in linguaggio semplice dei termini usati in questo libro.

**Agente / agentico.** Software che compie *azioni* verso un obiettivo, non solo
risponde a domande. Un agente chiude il cerchio dall'intenzione al risultato.

**AgentBridge.** L'assistente AI locale, in linguaggio semplice, che pianifica e
agisce attraverso gli strumenti. Il "cervello" in questo libro.

**PowerBITool.** Il plugin di AgentBridge che aziona Microsoft Power BI Desktop.
Le "mani" in questo libro.

**Power BI Desktop.** Lo strumento di Microsoft per costruire modelli di dati e
report.

**Modello.** L'insieme di tabelle, colonne, misure e relazioni che Power BI usa
per rispondere a domande.

**Tabella.** Un insieme di righe e colonne. Il contenitore base per i dati.

**Colonna.** Un singolo campo in una tabella, con un tipo di dato (testo, numero,
data).

**Misura.** Un valore calcolato (di solito un aggregato come una somma o una media)
che risponde ai filtri in un report.

**Colonna calcolata.** Una nuova colonna aggiunta a una tabella, calcolata con una
formula per ogni riga.

**Tabella calcolata.** Una nuova tabella creata da una formula, calcolata al
volo.

**Relazione.** Un collegamento tra due tabelle (per es. Sales → Products) perché i
dati fluiscano tra loro.

**Cardinalità.** La natura "uno-a-molti" o "molti-a-uno" di una relazione.

**DAX.** Data Analysis Expressions: il linguaggio di formule di Power BI.

**SQL.** Structured Query Language: il linguaggio standard per interrogare i
database.

**SUM / AVERAGE / COUNT.** Aggregati di base: totale, media e conteggio.

**DISTINCTCOUNT.** Conteggio dei valori univoci.

**CALCULATE.** Una funzione DAX che cambia il contesto di filtro di una
misura.

**FILTER.** Una funzione DAX che tiene le righe che corrispondono a una
condizione.

**RELATED.** Una funzione DAX che tira un valore da una tabella correlata.

**DIVIDE.** Una funzione di divisione sicura che gestisce la divisione per
zero.

**ALL.** Una funzione DAX che rimuove i filtri (spesso usata per "% del
totale").

**RANKX.** Una funzione DAX che classifica le righe per un valore.

**TOPN.** Una funzione DAX che restituisce le prime N righe.

**Contesto di filtro.** L'insieme di filtri attualmente applicati quando una misura
si calcola.

**Contesto di riga.** La "riga corrente" quando una colonna calcolata o un
iteratore si calcola.

**Iteratore.** Una funzione DAX (SUMX, AVERAGEX) che valuta riga per riga.

**Dizionario dei dati.** Documentazione di ogni tabella, colonna e misura in un
modello.

**Profilazione.** Ispezionare i valori distinti di una tabella, i vuoti, il
min/max e i campioni.

**Linting.** Controlli statici che segnalano pattern rischiosi (per es. `/` invece
di `DIVIDE`).

**Best practice.** Un check-up del modello contro noti buoni pattern.

**Guardia fail-closed.** Una regola di sicurezza che blocca qualsiasi cosa non
chiaramente consentita.

**Qualità dei dati.** Quanto i dati sono puliti, completi e degni di fiducia.

**Segmentazione.** Dividere clienti o dati in gruppi per l'analisi.

**Stagionalità.** Pattern regolari e ripetenti nel tempo.

**KPI.** Key Performance Indicator: una metrica che conta per il business.

**Dashboard.** Una vista dei KPI chiave, di solito su una schermata.

**Report.** Un insieme dettagliato e interattivo di visual costruito su un
modello.

**Governance dei dati.** Le regole, la proprietà e i controlli attorno a un bene di
dati.

**Paradosso di Jevons.** Quando qualcosa diventa più economico, ne usiamo di più,
non di meno.
