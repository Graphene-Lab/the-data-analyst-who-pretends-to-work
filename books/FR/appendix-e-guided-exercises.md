# Annexe E — Exercices guidés

Entraînez-vous au modèle agentique. Chaque exercice vous donne un objectif et une
piste. Essayez d'abord par vous-même ; les corrigés se trouvent dans l'Annexe F.

## Exercice 1 — Lire le modèle

**Objectif :** se connecter à un rapport Power BI et lister chaque table avec son
nombre de lignes.
**Piste :** demander les tables et leurs lignes en une seule phrase.
**Ce que vous apprendrez :** la connexion et l'exploration.

## Exercice 2 — Profiler une table

**Objectif :** déterminer combien de catégories distinctes existent et si certaines
colonnes contiennent des valeurs vides.
**Piste :** profiler la table et lire les colonnes Distinct et Blanks.
**Ce que vous apprendrez :** la qualité des données en un coup d'œil.

## Exercice 3 — Nettoyer du texte

**Objectif :** ajouter une colonne qui met un champ texte en majuscules pour qu'il
se regroupe proprement.
**Piste :** demander une colonne calculée de type UPPER.
**Ce que vous apprendrez :** standardiser des données désordonnées.

## Exercice 4 — Regrouper un nombre en tranches

**Objectif :** transformer une colonne de prix en tranches Haute / Moyenne / Basse.
**Piste :** demander une colonne calculée avec une règle de seuil.
**Ce que vous apprendrez :** transformer un nombre en catégorie exploitable.

## Exercice 5 — Établir une relation

**Objectif :** relier une table de ventes à une table de produits via l'identifiant
commun.
**Piste :** demander une relation plusieurs-à-un sur la colonne correspondante.
**Ce que vous apprendrez :** le câblage qui laisse circuler les données.

## Exercice 6 — Créer une mesure

**Objectif :** créer une mesure de total des ventes au format euro.
**Piste :** demander une mesure SUM avec un format monétaire.
**Ce que vous apprendrez :** la mesure la plus simple et la plus importante.

## Exercice 7 — Filtrer une mesure

**Objectif :** créer une mesure qui ne compte que les ventes au-dessus d'un seuil.
**Piste :** utiliser CALCULATE avec une condition de filtre.
**Ce que vous apprendrez :** l'agrégation conditionnelle.

## Exercice 8 — Part du total

**Objectif :** créer une mesure affichant la part de chaque catégorie dans le total
des ventes.
**Piste :** diviser le total filtré par le total ALL().
**Ce que vous apprendrez :** la part par rapport au tout.

## Exercice 9 — Classer

**Objectif :** établir un classement des produits par ventes.
**Piste :** demander un classement avec RANKX.
**Ce que vous apprendrez :** ordonner selon une métrique.

## Exercice 10 — Valider avant d'enregistrer

**Objectif :** vérifier qu'une formule est valide avant de créer la mesure.
**Piste :** valider d'abord le DAX, créer la mesure ensuite.
**Ce que vous apprendrez :** le bon ordre des opérations.

## Exercice 11 — Linter

**Objectif :** repérer une division risquée dans une formule.
**Piste :** linter une formule qui utilise `/` au lieu de DIVIDE.
**Ce que vous apprendrez :** détecter les anti-modèles.

## Exercice 12 — Documenter

**Objectif :** générer un dictionnaire de données pour l'ensemble du modèle.
**Piste :** demander le dictionnaire et lire ce qu'il renvoie.
**Ce que vous apprendrez :** la documentation réduite à une seule phrase.

Faites-les dans l'ordre. Chacun est une vraie action sur un modèle en conditions
réelles — du même type que celles vues dans les chapitres. Quand vous saurez faire
les douze, vous saurez faire le métier.
