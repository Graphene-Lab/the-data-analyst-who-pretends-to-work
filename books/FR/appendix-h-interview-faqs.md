# Annexe H — Questions fréquentes d'entretien

Questions d'entretien classiques pour analyste de données, avec des réponses
courtes qui montrent que vous maîtrisez à la fois le métier et les outils modernes.

## « Que fait concrètement un analyste de données ? »

Il transforme des questions métier en réponses fondées sur les données. Il trouve
et nettoie les données, les modélise, calcule des indicateurs et raconte une
histoire qui pousse à une décision. L'outil s'occupe de l'exécution ; l'analyste
garde la question et le jugement.

## « SQL ou DAX ? »

Les deux. SQL pour interroger les bases de données ; DAX pour la modélisation et
les mesures dans Power BI. Ils se complètent. Savoir lequel employer et quand,
voilà le vrai savoir-faire.

## « Quelle différence entre une colonne calculée et une mesure ? »

Une colonne calculée est calculée une fois par ligne puis stockée. Une mesure est
calculée au moment de la requête, en fonction des filtres. Utilisez une colonne
pour les attributs au niveau de la ligne ; utilisez une mesure pour les agrégations
qui doivent réagir aux filtres du rapport.

## « Expliquez CALCULATE. »

CALCULATE modifie le contexte de filtre d'une mesure. C'est la fonction la plus
puissante de DAX, car elle permet de calculer une valeur sous un jeu de filtres
précis — par exemple, les ventes d'une seule catégorie, ou en excluant une région.

## « Comment gérez-vous la division par zéro ? »

Utilisez DIVIDE au lieu de `/`. DIVIDE renvoie un résultat sûr (vide ou une valeur
de repli) quand le dénominateur est zéro. N'utilisez jamais un `/` brut dans une
mesure.

## « Comment vérifiez-vous la qualité des données ? »

Profilez les tables : valeurs distinctes, valeurs vides, min/max, doublons.
Rapprochez les totaux de la source. Lancez un contrôle de bonnes pratiques sur le
modèle. Un modèle propre est le socle de tout chiffre fiable.

## « Qu'est-ce qu'un schéma en étoile ? »

Une table de faits centrale (par exemple Sales) reliée à des tables de dimension
(Products, Customers, Stores) par des relations plusieurs-à-un. C'est la forme
standard et efficace des modèles analytiques.

## « Comment réagissez-vous face à un graphique trompeur ? »

Redessinez-le honnêtement. Vérifiez les axes, la fenêtre temporelle et
l'agrégation. Si un graphique peut se lire de deux façons, le travail de l'analyste
est de faire en sorte que la lecture honnête soit la plus évidente.

## « Que faites-vous quand les données contredisent la réponse attendue ? »

Faire confiance aux données, puis chercher pourquoi. Un résultat surprenant est
souvent le plus précieux. Vérifiez la source, les filtres et les définitions avant
de conclure.

## « Comment utilisez-vous les outils d'IA dans votre flux de travail ? »

Comme un accélérateur, pas un substitut. J'utilise un assistant (AgentBridge +
PowerBITool) pour créer et valider les mesures, documenter le modèle et lancer des
contrôles de bonnes pratiques — ainsi je passe mon temps sur les questions et
l'histoire, pas sur la syntaxe. Je vérifie chaque chiffre avant de le publier.
L'outil gère le comment ; je garde le quoi et le pourquoi.

## « Parlez-moi d'un projet que vous avez réalisé. »

Reprenez le projet portfolio de l'Annexe G : la question, le modèle, les
indicateurs, le tableau de bord, l'histoire, et comment l'assistant a aidé. Montrez
que vous savez parcourir toute la chaîne et que vous comprenez chaque étape.

## La méta-réponse

Presque toute bonne réponse revient à la même idée : **l'outil rend le travail
rapide ; l'analyste le rend juste.** Montrez que vous connaissez les deux volets,
et vous vous distinguerez de ceux qui n'en connaissent qu'un.
