# Annexe B — Liste de contrôle de la qualité des données

À utiliser avant de faire confiance à la moindre analyse. Chaque point peut être vérifié avec l'assistant.

## Complétude

- [ ] Aucune valeur vide inattendue dans les colonnes clés. *(Profilez la table ; regardez la colonne Blanks.)*
- [ ] Chaque ligne attendue est présente (aucune période, région ou produit manquant).
- [ ] Le nombre de lignes correspond au système source.

## Exactitude

- [ ] Les totaux se raccordent à la source de vérité.
- [ ] Les nombres sont dans la bonne unité (euros contre centimes, unités contre caisses).
- [ ] Aucune valeur manifestement fausse (quantités négatives, dates dans le futur).

## Cohérence

- [ ] Le texte est normalisé (pas de « Milan » contre « milan » contre « MILAN »). *(Ajoutez une colonne UPPER/LOWER pour vérifier.)*
- [ ] Une même entité porte le même nom partout.
- [ ] Les codes correspondent d'une table à l'autre (chaque ProductID des Ventes existe dans Produits).

## Unicité

- [ ] Les colonnes clés sont uniques là où elles doivent l'être (une ligne par SaleId).
- [ ] Pas de clients, produits ou magasins en double.

## Validité

- [ ] Les valeurs tombent dans les plages attendues (prix > 0, dates valides).
- [ ] Les catégories proviennent d'une liste autorisée.
- [ ] Les formats sont corrects (les dates sont des dates, pas du texte).

## Actualité

- [ ] Les données sont assez à jour pour la décision.
- [ ] Le rafraîchissement a eu lieu quand il le fallait.

## Intégrité

- [ ] Les relations sont correctement câblées (plusieurs-à-un, actives).
- [ ] Aucune ligne orpheline (des ventes pointant vers un produit manquant).
- [ ] Le modèle réussit le contrôle des bonnes pratiques.

## Comment l'assistant aide

- **Profilage** de chaque table pour voir les valeurs distinctes, les valeurs vides, les min/max et des échantillons.
- **Validation** des formules avant de les enregistrer.
- **Passage du DAX au lint** pour repérer les schémas risqués.
- **Un rapport de bonnes pratiques** pour vérifier tout le modèle d'un coup.

Un modèle propre n'est pas un simple bonus. Chaque chiffre en aval hérite de la qualité des données en amont. Vérifiez-le une fois, faites-lui confiance partout.
