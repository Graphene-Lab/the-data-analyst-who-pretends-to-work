# 24. Automatiser la journée de l'analyste

Passons une journée dans le travail de l'analyste et regardons l'assistant s'en occuper. Ce chapitre relie les exemples comme se déroule une vraie journée de travail : construire, valider, documenter, vérifier, terminer. Chaque image est une vraie action sur un modèle en direct.

## Matin : construire les briques du reporting

La journée commence en transformant des tables brutes en briques de reporting. Au lieu de cliquer pendant une heure, vous demandez ce dont le tableau de bord a besoin.

> « Construis une table de performance par catégorie avec les ventes et le nombre de produits. »

![Table de performance par catégorie](../../assets/examples/e065.png)

Une demande, une nouvelle table — ventes et nombre de produits par catégorie, calculés et en direct.

Puis les KPI dont le tableau de bord a besoin :

> « Crée un jeu de mesures KPI pour le tableau de bord. »

![Jeu de mesures KPI](../../assets/examples/e066.png)

Une mesure de chiffre d'affaires par client, créée et appliquée. Le genre de petite métrique qui prenait autrefois une minute soignée arrive désormais en une phrase.

## Avant la réunion : tout valider

Avant de construire le rapport, vous vérifiez que les chiffres sont justes. L'assistant valide tout un lot d'un coup :

> « Valide un lot de mesures avant que je construise le rapport. »

![Validation par lot](../../assets/examples/e067.png)

Chaque mesure renvoie OK avec sa valeur. Pas de surprise devant le patron.

## Milieu de matinée : repérer les manques

Un bon analyste cherche ce qui *manque*, pas seulement ce qui est là :

> « Quels produits ne se sont jamais vendus ? »

![Produits jamais vendus](../../assets/examples/e070.png)

La requête s'exécute et ne renvoie aucune ligne — chaque produit s'est vendu au moins une fois. C'est aussi une réponse utile : pas de stock dormant caché dans le catalogue.

## Fin de matinée : le comportement du modèle

Vous voulez signaler un comportement récurrent sans étiqueter les lignes à la main :

> « Crée un indicateur de client fidèle. »

![Indicateur de client fidèle](../../assets/examples/e085.png)

Une colonne booléenne qui marque chaque vente comme récurrente ou non — calculée sur toute la table d'un seul coup.

Et le meilleur vendeur :

> « Donne-moi le meilleur magasin en ventes. »

![Meilleur magasin en ventes](../../assets/examples/e087.png)

Milan Central mène. Le classement qui exigeait autrefois un tableau croisé et un tri tient maintenant en une seule question.

## Après-midi : le ciblage

L'équipe marketing veut les clients à haute valeur :

> « Crée une mesure de client à haute valeur. »

![Mesure de client à haute valeur](../../assets/examples/e095.png)

Un indicateur pour les clients au-dessus d'un seuil de dépense, en direct dans le modèle, prêt à filtrer.

Et pour voir comment se comportent les tranches de prix faites plus tôt :

> « Ventes par tranche de prix. »

![Ventes par tranche de prix](../../assets/examples/e097.png)

High, Mid, Low — la colonne de tranche du chapitre 7 pilote maintenant une vraie ventilation. C'est la récompense de construire des petites briques : elles se combinent plus tard.

## Fin de journée : documenter et vérifier

Avant de fermer, vous documentez le travail et vérifiez sa santé. L'assistant écrit le dictionnaire de tout le modèle :

> « Documente le modèle final. »

![Dictionnaire de données final](../../assets/examples/e099.png)

Chaque table, chaque mesure, avec son format et son expression — une documentation que vous n'auriez jamais écrite à la main, faite pour vous.

Puis le contrôle de santé :

> « Contrôle de santé final de tout le modèle. »

![Contrôle de santé final](../../assets/examples/e100.png)

Zéro avertissement. Les deux notes « info » ne sont que des tables de synthèse déconnectées, ce qui est normal. Le modèle est propre.

## Clôture : le modèle terminé

À la fin de la journée, vous regardez ce que vous avez construit :

> « Montre la liste finale des tables. »

![Liste finale des tables](../../assets/examples/e102.png)

Six tables, quatorze mesures, trois relations — un modèle analytique fonctionnel, construit et documenté en une seule journée de demandes en langage courant.

## Ce que montre la journée

Une journée de travail entière — construire, valider, repérer les manques, modéliser le comportement, cibler, documenter, vérifier — faite en décrivant chaque étape. Les mains de l'analyste n'ont fait aucun des clics. Sa tête a pris toutes les décisions.

C'est l'échange que ce livre ne cesse de faire : **vous gardez le jugement, l'outil prend la corvée.**

---

## Ce que vous garderez de ce chapitre

- Une journée entière de travail d'analyste correspond à une suite de demandes en langage courant.
- Construisez les briques (tables, mesures), validez-les, repérez les manques, documentez, vérifiez.
- Les petites briques se combinent plus tard (la tranche de prix pilote une ventilation).
- Le modèle finit propre, documenté et prêt — sans aucun des clics manuels.

Suite : le storytelling, l'éthique et la gouvernance — la partie que l'outil ne peut pas faire à votre place.
