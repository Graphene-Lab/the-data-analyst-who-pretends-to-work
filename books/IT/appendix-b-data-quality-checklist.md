# Appendice B — Checklist della qualità dei dati

Usala prima di fidarti di qualsiasi analisi. Ogni voce si può controllare con
l'assistente.

## Completezza

- [ ] Nessun valore vuoto inatteso nelle colonne chiave. *(Profila la tabella;
      guarda la colonna Blanks.)*
- [ ] Ogni riga attesa è presente (nessun periodo, regione o prodotto
      mancante).
- [ ] I conteggi di righe corrispondono al sistema di origine.

## Accuratezza

- [ ] I totali si riconciliano con la fonte di verità.
- [ ] I numeri sono nell'unità giusta (euro vs centesimi, unità vs
      casse).
- [ ] Nessun valore ovviamente sbagliato (quantità negative, date nel
      futuro).

## Coerenza

- [ ] Il testo è standardizzato (niente "Milano" vs "milano" vs "MILANO").
      *(Aggiungi una colonna UPPER/LOWER per controllare.)*
- [ ] La stessa entità ha lo stesso nome ovunque.
- [ ] I codici corrispondono tra tabelle (ogni ProductID in Sales esiste in
      Products).

## Univocità

- [ ] Le colonne chiave sono univoche dove devono esserlo (una riga per
      SaleId).
- [ ] Nessun cliente, prodotto o negozio duplicato.

## Validità

- [ ] I valori cadono entro intervalli attesi (prezzo > 0, date valide).
- [ ] Le categorie vengono da una lista consentita.
- [ ] I formati sono corretti (le date sono date, non testo).

## Tempestività

- [ ] I dati sono abbastanza attuali per la decisione.
- [ ] L'aggiornamento è avvenuto quando doveva.

## Integrità

- [ ] Le relazioni sono cablate correttamente (molti-a-uno, attive).
- [ ] Nessuna riga orfana (vendite che puntano a un prodotto
      mancante).
- [ ] Il modello passa il controllo best practice.

## Come aiuta l'assistente

- **Profila** ogni tabella per vedere valori distinti, vuoti, min/max,
  campioni.
- **Valida** le formule prima di salvarle.
- **Fai il lint** del DAX per cogliere pattern rischiosi.
- **Report best practice** per controllare tutto il modello in una
  volta.

Un modello pulito non è un optional. Ogni numero a valle eredita la qualità dei
dati a monte. Controllala una volta, fidatene ovunque.
