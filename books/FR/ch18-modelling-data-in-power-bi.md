# 18. Modéliser les données dans Power BI

La modélisation, c'est là que l'analyse se gagne ou se perd. Un bon modèle rend chaque question facile ; un mauvais modèle fait de chaque question une bataille. Ce chapitre montre l'assistant en modélisateur soigneux — un modélisateur qui non seulement construit le modèle, mais le documente et le confronte aux bonnes pratiques.

## À quoi ressemble un bon modèle

Vous avez rencontré le schéma en étoile au chapitre 8. Dans Power BI, un bon modèle veut dire :

- Une **table de faits** propre (les chiffres : ventes, transactions).
- Des **tables de dimensions** bien rangées (les descriptions : produits, clients, dates).
- Des **relations** câblées correctement (plusieurs-à-un, sans ambiguïté).
- Des **mesures** aux noms, formats et descriptions clairs.
- Une **documentation** pour que la personne d'après (ou vous, dans six mois) s'y retrouve.

L'assistant aide sur tout ça, en direct.

## Documenter au fil de l'eau

Les bons modèles sont des modèles documentés. L'assistant peut ajouter des descriptions aux tables et aux colonnes sur demande :

> « Ajoute une description à la table Sales. »

![Description de table](../../assets/examples/e046.png)

> « Décris la colonne Amount. »

![Description de colonne](../../assets/examples/e047.png)

Ces petites notes apparaissent dans le modèle et dans le dictionnaire de données. Elles font la différence entre un modèle qui est une boîte noire et un qui est un bien commun.

> « Mets une description sur la table Products. »

![Description de Products](../../assets/examples/e080.png)

## Le dictionnaire de données, table par table

Vous pouvez documenter tout le modèle ou une seule table :

> « Génère un dictionnaire de données pour Products uniquement. »

![Dictionnaire de Products](../../assets/examples/e045.png)

Un dictionnaire ciblé pour une seule table — pratique quand vous confiez un morceau du modèle à un collègue.

## Le bilan de santé : les bonnes pratiques

C'est l'un des coups les plus précieux de l'assistant. Il balaie tout le modèle et signale les problèmes et les conseils :

> « Vérifie le modèle par rapport aux bonnes pratiques. »

![Rapport de bonnes pratiques](../../assets/examples/e048.png)

Il signale les mesures sans chaîne de format, les tables sans description, les tables déconnectées — les petits péchés qui rendent un modèle difficile à utiliser. C'est comme un linter pour votre modèle de données : ça ne vous empêche pas de travailler, mais ça vous dit où le modèle est en désordre avant que le désordre ne morde.

## Revérifier après les changements

À mesure que vous construisez, le modèle dérive. Relancer le bilan le garde honnête :

> « Bonnes pratiques après avoir ajouté des mesures. »

![Bonnes pratiques après changements](../../assets/examples/e093.png)

Un rapide nouveau balayage montre ce qu'ont introduit vos derniers changements. Construire, vérifier, corriger, recommencer — le rythme d'un modèle propre.

## Une curiosité : le facteur bus

Il existe une métrique dans les équipes logicielle appelée le **facteur bus** : combien de personnes devraient être « percutées par un bus » avant qu'un projet soit bloqué parce qu'une seule personne le comprend. Un modèle sans documentation a un facteur bus de un — terrifiant. Chaque description et chaque entrée de dictionnaire que l'assistant écrit fait monter ce chiffre. Vous ne faites pas que ranger ; vous rendez le modèle survivable.

## Pourquoi l'assistant est un bon modélisateur

Un modélisateur humain sous pression de deadline saute la documentation et les bonnes pratiques. L'assistant, lui, ne se fatigue pas, ne saute pas d'étapes, et vérifie tout. Associez le jugement humain sur *quoi* modéliser à la rigueur de l'assistant pour *documenter et vérifier*, et vous obtenez des modèles qui restent propres.

---

## Ce que vous garderez de ce chapitre

- Un bon modèle : faits propres + dimensions, bien câblé, documenté.
- Ajoutez des descriptions aux tables, colonnes et mesures au fil de l'eau.
- Générez des dictionnaires de données pour documenter tout le modèle ou une table.
- Lancez le bilan des bonnes pratiques comme un linter — souvent.
- La documentation fait monter le facteur bus ; elle rend le modèle survivable.

Suite : DAX, le langage derrière les chiffres — et pourquoi vous n'avez pas à l'écrire.
