# 19. DAX : le langage derrière les chiffres

DAX est le langage de calcul à l'intérieur de Power BI. Il a la réputation d'être effrayant. Ce chapitre explique pourquoi il compte, et pourquoi — avec l'assistant — vous pouvez l'utiliser sans jamais vous friter avec lui.

## À quoi sert DAX

DAX (Data Analysis Expressions) calcule les chiffres de vos rapports : totaux, moyennes, pourcentages, comparaisons année sur année, cumuls, classements. Chaque mesure que vous voyez sur un tableau de bord Power BI est du DAX sous le capot.

Les fonctions de base sont simples : `SUM`, `AVERAGE`, `COUNT`, `MIN`, `MAX`, et la toute-puissante `CALCULATE`, qui permet de calculer un nombre *sous un filtre précis*.

## L'assistant l'écrit ; vous le lisez

Vous ne tapez pas de DAX. Vous décrivez le nombre que vous voulez, et l'assistant écrit le DAX et crée la mesure en direct. Mais vous devriez pouvoir *lire* ce qu'il a produit, pour lui faire confiance.

> « Crée une mesure de ventes uniquement pour Milan. »

![Mesure de ventes Milan](../../assets/examples/e053.png)

Sous le capot, c'est `CALCULATE([Total Sales], Stores[City] = "Milan")` — le total des ventes, mais seulement là où la ville est Milan. Une fois qu'on a vu le schéma, le DAX cesse d'être de la magie.

## Valider avant de faire confiance

L'assistant peut tester une formule sans rien créer :

> « Cette mesure est-elle valide ? SUM(Sales[Amount]) »

![Valider une bonne mesure](../../assets/examples/e049.png)

> « Vérifie cette formule cassée : SUMX(Sales[Amount]) »

![Valider une mesure cassée](../../assets/examples/e050.png)

L'une passe, l'autre échoue — et vous apprenez ce qui ne va pas *avant* que ça devienne une mesure cassée dans le modèle. Cette habitude de « vérifier d'abord » fait gagner des heures de débogage.

> « Valide une mesure CALCULATE. »

![Valider CALCULATE](../../assets/examples/e081.png)

> « Valide une mesure de pourcentage. »

![Valider un pourcentage](../../assets/examples/e094.png)

## Le linter : le gardien du style pour DAX

Au-delà de « est-ce que ça tourne ? », l'assistant peut vérifier « est-ce que c'est *bien écrit* ? » — un processus appelé **linting**. Il repère les erreurs courantes et les schémas risqués.

> « Linte ce DAX : SUM(a)/SUM(b) »

![Linter une division par barre oblique](../../assets/examples/e051.png)

Il avertit : n'utilisez pas un `/` tout simple — utilisez `DIVIDE`, qui gère la division par zéro en toute sécurité. Une petite pichenette qui prévient toute une classe d'erreurs `#DIV/0!`.

> « Linte ce DAX propre avec DIVIDE. »

![Linter un DAX propre](../../assets/examples/e052.png)

La version propre passe. On apprend le bon schéma en le voyant récompensé.

> « Linte une mesure qui utilise IFERROR. »

![Linter IFERROR](../../assets/examples/e082.png)

Il signale `IFERROR` comme une mauvaise odeur — envelopper les erreurs peut cacher de vrais bugs au lieu de les corriger. Le linter apprend les bonnes habitudes, un avertissement à la fois.

## Modifier les mesures

Les mesures évoluent. L'assistant peut les mettre à jour et les supprimer :

> « Change le format de Total Sales en euros entiers. »

![Mettre à jour le format](../../assets/examples/e054.png)

> « Supprime la mesure Milan Sales. »

![Supprimer une mesure](../../assets/examples/e055.png)

Renommer, reformater, retirer — tout en direct, tout réversible tant que vous n'enregistrez pas.

## Une curiosité : la bête du contexte de filtre

Si DAX est réputé difficile, c'est à cause d'un seul concept : le **contexte de filtre** — l'ensemble invisible de filtres qu'un calcul voit à un instant donné (la ligne courante, la sélection courante du segment, la visuelle courante). Maîtrisez-le et DAX devient votre ami ; comprenez-le de travers et les chiffres paraissent faux de façons difficiles à retracer. Voici la vérité libératrice de ce livre : **vous décrivez la réponse, et l'assistant gère le contexte de filtre.** La bête devient le problème de l'outil, pas le vôtre.

---

## Ce que vous garderez de ce chapitre

- DAX calcule les chiffres ; `CALCULATE` est son mot le plus puissant.
- Vous décrivez la réponse ; l'assistant écrit le DAX.
- Validez une formule avant de la créer.
- Lintez pour repérer les mauvais schémas (`/` tout simple, `IFERROR` qui cache des bugs).
- La partie difficile — le contexte de filtre — est désormais le job de l'outil.

Suite : voir, c'est croire — comment choisir le bon graphique et ne pas mentir avec les visuelles.
