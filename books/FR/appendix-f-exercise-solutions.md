# Annexe F — Corrigés des exercices

Corrigés des exercices guidés de l'Annexe E. Pour chacun, la demande en langage
courant et le DAX produit par l'assistant.

## Exercice 1 — Lire le modèle

**La demande :** « Lister chaque table avec son nombre de lignes. »
**Ce qui se passe :** l'assistant lit le modèle en direct et renvoie chaque table
avec son type, son nombre de lignes et son nombre de colonnes. Pas besoin de DAX —
c'est un appel d'exploration.

## Exercice 2 — Profiler une table

**La demande :** « Profiler la table Products. »
**Ce qui se passe :** l'assistant renvoie un tableau de profil avec les valeurs
Distinct, Blanks, Min, Max et Top pour chaque colonne. Le nombre de valeurs
distinctes de Category est 3 ; les valeurs vides s'affichent par colonne.

## Exercice 3 — Nettoyer du texte

**La demande :** « Ajouter une colonne avec la catégorie en majuscules. »
**DAX :** `UPPER(Products[Category])`
**Résultat :** une nouvelle colonne calculée `Products[CategoryUpper]`.

## Exercice 4 — Regrouper un nombre en tranches

**La demande :** « Regrouper les produits en tranches Haute / Moyenne / Basse selon
le prix. »
**DAX :**
```
SWITCH(TRUE(),
  Products[Price] >= 200, "High",
  Products[Price] >= 50, "Mid",
  "Low")
```
**Résultat :** une nouvelle colonne calculée `Products[PriceBand]`.

## Exercice 5 — Établir une relation

**La demande :** « Relier Sales à Products sur ProductID. »
**Résultat :** une relation plusieurs-à-un, active, à sens unique,
`Sales[ProductID] → Products[ProductID]`.

## Exercice 6 — Créer une mesure

**La demande :** « Créer une mesure Total Sales au format euro. »
**DAX :** `SUM(Sales[Amount])` avec le format `#,##0.00 €`.
**Résultat :** une nouvelle mesure `Sales[Total Sales]`.

## Exercice 7 — Filtrer une mesure

**La demande :** « Ne compter que les ventes supérieures à 300. »
**DAX :** `COUNTROWS(FILTER(Sales, Sales[Amount] > 300))`
**Résultat :** une nouvelle mesure `Sales[Big Sales Count]`.

## Exercice 8 — Part du total

**La demande :** « La part de chaque catégorie dans le total des ventes. »
**DAX :** `DIVIDE([Total Sales], CALCULATE([Total Sales], ALL(Sales)))`
**Résultat :** une nouvelle mesure `Sales[Pct Of Total]` au format pourcentage.

## Exercice 9 — Classer

**La demande :** « Classer les produits par ventes. »
**DAX :** `RANKX(ALL(Products), [Total Sales])`
**Résultat :** un classement avec le rang de chaque produit.

## Exercice 10 — Valider avant d'enregistrer

**La demande :** « Cette mesure est-elle valide ? SUM(Sales[Amount]) »
**Ce qui se passe :** l'assistant valide et renvoie « Valid » avec une valeur
d'exemple (22023). Ce n'est qu'ensuite que vous créez la mesure.

## Exercice 11 — Linter

**La demande :** « Linter ce DAX : SUM(a)/SUM(b) »
**Ce qui se passe :** le linter signale le `/` et suggère `DIVIDE()` pour gérer la
division par zéro en toute sécurité.

## Exercice 12 — Documenter

**La demande :** « Générer un dictionnaire de données pour l'ensemble du modèle. »
**Ce qui se passe :** l'assistant renvoie un dictionnaire markdown listant chaque
table, son type et son nombre de lignes, ainsi que chaque mesure avec son format et
son expression.

## Le schéma de chaque corrigé

Demander simplement → l'assistant écrit un DAX correct → il applique la
modification en direct → il rapporte exactement ce qu'il a fait. Cette boucle est
tout le métier. Quand elle devient naturelle, vous avez assimilé le livre.
