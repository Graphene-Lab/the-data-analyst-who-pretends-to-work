# Annexe G — Un modèle de projet pour le portfolio

Un portfolio prouve que vous savez faire le métier. Ce modèle vous propose un
projet à construire, documenter et montrer. Faites-en un ou deux, et vous aurez
quelque chose à montrer en entretien.

## Le projet : un tableau de bord d'analyse des ventes

Réalisez une petite analyse de bout en bout sur un jeu de données de ventes
d'exemple (la même structure que celle utilisée tout au long du livre : Sales,
Products, Customers, Stores).

### Étape 1 — Comprendre les données

- Profiler chaque table.
- Noter les valeurs distinctes, les valeurs vides et les plages.
- Écrire une phrase par table : ce qu'elle contient.

### Étape 2 — Nettoyer et modéliser

- Standardiser le texte désordonné (colonnes UPPER/LOWER).
- Regrouper les nombres en tranches (tranches de prix).
- Établir les relations (Sales → Products, Customers, Stores).

### Étape 3 — Construire les indicateurs

- Ventes totales, quantité totale, commandes.
- Panier moyen, ventes par client.
- Une mesure de marge (chiffre d'affaires moins coûts).
- Une mesure de part du total.

### Étape 4 — Segmenter

- Les meilleurs clients par dépense.
- Ventes par segment (Détail / Entreprises / En ligne).
- Ventes par région et par mois.

### Étape 5 — Valider et documenter

- Valider chaque mesure avant de l'enregistrer.
- Linter le DAX pour repérer les anti-modèles.
- Générer le dictionnaire de données.
- Lancer le rapport de bonnes pratiques.

### Étape 6 — Visualiser

- Une rangée de cartes KPI (ventes totales, commandes, panier moyen).
- Un graphique en barres des ventes par catégorie.
- Un graphique en courbes de la tendance mensuelle.
- Un classement des meilleurs produits.

## Que montrer dans le portfolio

Pour chaque projet, présentez :

1. **La question.** Le problème métier que vous résolviez.
2. **Le modèle.** Une capture d'écran des tables et des relations.
3. **Les indicateurs.** Les mesures que vous avez créées, avec leur DAX.
4. **Le tableau de bord.** Les visuels finaux.
5. **L'histoire.** Ce que vous avez découvert et ce qu'il faudrait en faire.
6. **Les outils.** Une note précisant que vous l'avez construit avec AgentBridge +
   PowerBITool, et comment l'assistant a aidé (validation, documentation, bonnes
   pratiques).

## Pourquoi ça marche

Un recruteur se fiche que l'outil ait été rapide. Ce qui l'intéresse, c'est que
vous sachiez : cadrer un problème, construire un modèle propre, valider votre
travail, le documenter et raconter une histoire. Ce projet fait travailler les six
à la fois. L'outil est un bonus qui montre que vous êtes à la page — pas un
raccourci qui remplace la réflexion.

## Appropriez-vous le projet

Remplacez les données d'exemple par un jeu de données qui vous tient à cœur — un
loisir, un jeu de données public, un projet perso. Plus le sujet vous passionne,
meilleures seront les questions que vous poserez, et plus le portfolio sera beau.
Le schéma reste le même ; le choix des données vous appartient.
