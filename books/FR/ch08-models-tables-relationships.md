# 8. Modèles, tables et relations

Un tas de tables n'est pas un modèle. Un **modèle**, c'est ce que vous obtenez quand vous dites à l'ordinateur comment les tables *se rapportent* les unes aux autres. Ces connexions — le câblage — sont ce qui vous permet de poser une question à un endroit et d'obtenir une réponse qui traverse plusieurs tables. Ce chapitre parle de ce câblage.

## Tables, lignes et clés

Chaque table a des **lignes** (un enregistrement chacune) et des **colonnes** (un attribut chacune). La magie est dans la **clé** — une colonne qui identifie de façon unique chaque ligne. Un identifiant client, un code produit, un numéro de commande. Les clés sont la façon dont les tables se reconnaissent entre elles.

- Une **clé primaire** est l'identifiant unique dans une table (une ligne par client).
- Une **clé étrangère** est une colonne dans une autre table qui pointe vers cet identifiant (chaque vente stocke l'identifiant du client).

## La relation : comment deux tables se parlent

Une **relation** relie une clé étrangère à une clé primaire. Une fois connectées, l'ordinateur peut répondre à des questions qui traversent les tables : « quel produit était dans cette vente ? » « dans quelle ville habitait ce client ? » — sans que vous ayez jamais à fusionner des fichiers à la main.

Le genre le plus courant est le **plusieurs-à-un** : beaucoup de ventes pointent vers un produit. Chaque vente a un identifiant produit ; la table des produits a une ligne par produit. Beaucoup de ventes, un produit. C'est l'épine dorsale de presque tous les modèles d'entreprise.

## Le câblage, en direct

Voici l'assistant en train de créer une relation à partir d'une simple requête :

> « Relie Sales à Products sur ProductID. »

![Relation de Sales à Products](../../assets/examples/e015.png)

L'outil indique la direction (Plusieurs→Un) et confirme qu'elle est active dans Power BI Desktop. Puis le lien client :

> « Relie Sales à Customers sur CustomerID. »

![Relation de Sales à Customers](../../assets/examples/e016.png)

Et le lien magasin :

> « Relie Sales à Stores sur StoreID. »

![Relation de Sales à Stores](../../assets/examples/e017.png)

Trois phrases, et le modèle a maintenant une colonne vertébrale. Toute question ultérieure sur « les ventes par produit », « les ventes par client », « les ventes par magasin » fonctionne grâce à ces trois lignes.

## Voir tout le câblage

> « Montre toutes les relations du modèle. »

![Toutes les relations](../../assets/examples/e018.png)

Trois relations Plusieurs→Un bien nettes, toutes actives. C'est le schéma de câblage — ce que vous vérifiez en premier quand un chiffre a l'air faux.

## Le schéma en étoile : la forme que vous voulez

Rassemblez le tout et vous obtenez la forme la plus célèbre de la donnée d'entreprise : le **schéma en étoile**. Une table de faits au centre (Sales), entourée de tables de dimension (Products, Customers, Stores, Date). La table de faits contient les nombres ; les dimensions contiennent le détail descriptif. Dessiné, cela ressemble à une étoile.

Pourquoi est-il tellement aimé ? Parce qu'il est simple, rapide, et correspond à la façon dont les gens posent des questions. « Les ventes par catégorie », c'est juste la table de faits qui se penche vers la dimension produit. Presque tout bon modèle de BI est une étoile, ou un champ d'étoiles.

## Une table calculée : résumer à la volée

Parfois vous voulez un petit tableau de synthèse construit à partir du modèle lui-même :

> « Construis un petit tableau des ventes totales par catégorie. »

![Tableau des ventes par catégorie](../../assets/examples/e019.png)

Une nouvelle table, calculée en direct, qui fait remonter le détail en une synthèse soignée. Pratique pour un rapport rapide ou un instantané.

## Une curiosité : le piège du plusieurs-à-plusieurs

La relation la plus dangereuse est le **plusieurs-à-plusieurs** fait sans soin — beaucoup de produits dans beaucoup de promotions, beaucoup d'étudiants dans beaucoup de classes. Si vous le ratez, vos totaux comptent en double ou disparaissent. La réparation est une table « pont » au milieu. Si vos chiffres semblent soudain gonflés, un plusieurs-à-plusieurs bâclé est le premier suspect.

---

## Essayez :

> « Combien de relations maintenant ? »

![Compter les relations](../../assets/examples/e073.png)

Une vérification rapide que tout le câblage est bien là.

## Ce que vous garderez de ce chapitre

- Un modèle, ce sont des tables plus les relations entre elles.
- Les clés (primaires et étrangères) sont la façon dont les tables se reconnaissent.
- Le plusieurs-à-un est l'épine dorsale de la donnée d'entreprise.
- Le schéma en étoile est la forme que vous voulez d'habitude.
- Méfiez-vous du plusieurs-à-plusieurs bâclé — il gonfle les totaux.

Suite : interroger les données directement — SQL et DAX, les deux langues pour obtenir des réponses.
