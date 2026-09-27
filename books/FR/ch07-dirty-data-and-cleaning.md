# 7. Les données sales et comment les nettoyer

Voici une vérité que personne ne met dans la fiche de poste : **la plupart du temps d'un analyste passe à nettoyer des données.** Les données du monde réel sont désordonnées — mal orthographiées, dupliquées, manquantes, incohérentes. Poubelle dedans, poubelle dehors. Avant de pouvoir trouver la moindre vérité, il faut balayer le sol.

## Le désordre habituel

Chaque analyste rencontre la même distribution de problèmes :

- **Texte incohérent** — « Milan », « milan », « MILANO », « Milano ». Quatre valeurs, une seule ville.
- **Formats mélangés** — des dates en 03/04/2025 et 2025-04-03 dans la même colonne.
- **Valeurs manquantes** — des villes vides, des catégories vides, pas de numéro de téléphone.
- **Doublons** — le même client deux fois sous deux e-mails.
- **Mauvais types** — un nombre stocké en texte, du coup il ne s'additionne pas.
- **Valeurs mal placées** — une vente négative qui est en fait un remboursement.

Rien de tout cela n'est dramatique. Tous ruineront en silence une analyse si vous les ignorez.

## Nettoyer avec des colonnes calculées

Dans Power BI, beaucoup de nettoyage se fait avec des **colonnes calculées** — de nouvelles colonnes que vous créez avec une formule qui corrige ou standardise les données existantes. C'est exactement là que l'assistant brille : vous décrivez la correction en mots simples, il écrit la formule et l'applique en direct.

**Standardiser le texte.** Quelqu'un a demandé :

> « Ajoute une colonne avec la catégorie en majuscules. »

![Catégorie en majuscules](../../assets/examples/e011.png)

Maintenant « kitchen », « Kitchen » et « KITCHEN » deviennent tous « KITCHEN » et se regroupent ensemble. Une petite colonne, toute une classe de problème disparue.

**Transformer un nombre en une tranche exploitable.**

> « Regroupe les produits en Élevé / Moyen / Bas selon le prix. »

![Tranche de prix](../../assets/examples/e012.png)

Un prix brut de 249 € est difficile à regrouper. Une tranche « Élevé » est facile à mettre en graphique et facile à évoquer. C'est l'une des astuces les plus utiles de l'analyse : transformer un nombre continu en une catégorie sympathique.

Et voici ce que cette tranche vous offre — les ventes regroupées et tracées par tranche de prix :

![Ventes par tranche de prix — histogramme](../../assets/examples/chart-priceband.png)

**Combiner des champs en une étiquette.**

> « Fabrique une étiquette client du genre "Nom (Ville)". »

![Étiquette client](../../assets/examples/e013.png)

Maintenant chaque client a une seule étiquette d'affichage propre, construite à partir de deux colonnes, sans que personne ne tape quoi que ce soit.

## Vérifier avant de se lancer

Une bonne habitude : **validez la formule avant de l'enregistrer.** L'assistant peut tester une formule et vous montrer une valeur d'exemple, pour que vous sachiez qu'elle marche avant qu'elle ne fasse partie du modèle.

> « Vérifie cette formule de tranche de prix avant que je l'enregistre. »

![Valider la tranche de prix](../../assets/examples/e014.png)

Elle renvoie « Valide » avec une valeur d'exemple. Pas de surprise plus tard.

## Traquer les vides

Les valeurs manquantes sont des tueuses silencieuses. Une ville vide veut dire qu'un client disparaît de toutes les cartes. L'assistant peut les traquer :

> « Des villes vides dans la liste des clients ? »

![Vérification des villes vides](../../assets/examples/e072.png)

Si le résultat est vide, vous êtes propre. Sinon, vous savez exactement où sont les trous avant qu'ils ne trompent un graphique.

## Une curiosité : le 80/20 du métier

Demandez à un analyste expérimenté comment se répartit son temps, et vous entendrez une version de la même blague : **80 % de la data science consiste à nettoyer des données, et les 20 % restants à se plaindre de les avoir nettoyées.** C'est un cliché parce que c'est vrai. Les analystes qui sont bons en nettoyage valent de l'or — parce qu'un beau modèle construit sur des données sales est une belle façon d'avoir tort.

## Quand le nettoyage ne suffit jamais

Parfois les données sont trop fichues — 40 % d'un champ clé manquant, ou deux systèmes qui tout simplement ne sont pas d'accord. Un bon analyste sait quand arrêter de nettoyer et remonter : *réparez ça à la source*, ou *collectez de meilleures données la prochaine fois*. Le nettoyage est un outil, pas une religion.

---

## Ce que vous garderez de ce chapitre

- Les données réelles sont sales ; le nettoyage est la majeure partie du travail.
- Les colonnes calculées réparent le texte, tranchent les nombres et fabriquent des étiquettes en quelques secondes.
- Validez une formule avant de vous y engager.
- Traquez les vides avant qu'ils ne trompent un graphique.
- Sachez quand arrêter de nettoyer et réparer la source.

Suite : comment les morceaux de données se connectent — tables, clés et relations — le câblage qui rend l'analyse possible.
