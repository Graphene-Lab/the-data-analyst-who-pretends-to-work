# 16. Power BI en langage clair

Vous avez déjà entendu le nom. Ce chapitre réduit Power BI à ce qu'il est vraiment, sans le brouillard marketing — et montre comment l'assistant lui parle directement.

## Ce qu'est vraiment Power BI

Power BI, c'est l'outil de Microsoft pour transformer des données en **tableaux de bord et rapports** que les gens peuvent regarder, cliquer et explorer. Il a trois grandes parties :

- **Power BI Desktop** — le programme gratuit sur votre PC, où vous construisez le modèle et le rapport. C'est là que travaille l'assistant.
- **Power BI Service** — l'endroit en ligne où vous publiez les tableaux de bord pour que d'autres les voient dans un navigateur ou sur leur téléphone.
- **Power BI Mobile** — l'application pour consulter les tableaux de bord en déplacement.

On construit dans Desktop. On partage via le Service. C'est toute l'image.

## Les trois couches à l'intérieur

Tout projet Power BI a trois couches, et il est utile d'en connaître les noms :

1. **Données** — ce à quoi vous vous connectez (une base de données, un fichier, une source web).
2. **Modèle** — les tables, les relations et les mesures que vous construisez par-dessus les données.
3. **Rapport** — les pages visuelles que les gens regardent réellement.

L'assistant travaille presque entièrement dans la couche **modèle** — les tables, les mesures et les relations. La couche rapport (les jolies visuelles), c'est là qu'un humain dispose les choses sur le canevas. Le modèle est le moteur ; le rapport est le tableau de bord.

## Voir le modèle, en direct

L'assistant peut lire tout le modèle et vous le restituer :

> « Donne-moi un résumé du modèle. »

![Résumé du modèle](../../assets/examples/e002.png)

Tables, mesures, relations, nombre de lignes — tout le moteur dans une seule vue. C'est la première chose à faire quand on ouvre un projet Power BI : comprendre le modèle.

> « Liste chaque table avec son nombre de lignes. »

![Liste des tables](../../assets/examples/e005.png)

Les briques de base, comptées et prêtes.

## Le dictionnaire de données : de la documentation gratuite

L'un des tours les plus utiles de l'assistant, c'est d'écrire un **dictionnaire de données** — un document qui recense chaque table, chaque colonne et chaque mesure avec ce qu'elles signifient.

> « Génère un dictionnaire de données pour tout le modèle. »

![Dictionnaire de données](../../assets/examples/e044.png)

Une documentation qui prendrait un après-midi entier à un analyste apparaît en une seconde. Ce n'est pas rien : une bonne documentation fait la différence entre un modèle dont une équipe peut se fier et un modèle qu'une seule personne comprend.

## Voir les mesures

> « Quelles mesures existent dans Sales ? »

![Mesures dans Sales](../../assets/examples/e079.png)

Chaque mesure avec sa formule et son format. Quand quelqu'un demande « comment est calculé Total Sales ? », la réponse est juste là.

## Une curiosité : l'ascension improbable de Power BI

Power BI a démarré en 2015 comme une petite extension et a foncé vers le sommet du monde de l'analytics, en grande partie parce que Microsoft le regroupait avec des outils que les entreprises avaient déjà et l'a vendu assez peu cher pour que presque n'importe qui puisse l'essayer. Son superpouvoir discret, c'est qu'il siège au cœur de l'écosystème Microsoft — Excel, Azure, Office — si bien que pour des millions d'entreprises, c'était le chemin du moindre effort. Le meilleur outil n'est souvent pas le meilleur outil ; c'est celui qui est déjà là.

## Pourquoi l'assistant compte ici

Power BI est puissant mais a une courbe d'apprentissage — DAX, la vue modèle, la ribambelle de boutons dans le ruban. L'assistant supprime cette courbe pour le travail sur le modèle : vous décrivez ce que vous voulez, il modifie le modèle en direct. Les visuelles, vous les arrangez toujours vous-même, mais la partie difficile — les mesures et le câblage — devient une conversation.

---

## Ce que vous garderez de ce chapitre

- Power BI = Desktop (construire), Service (partager), Mobile (consulter).
- Trois couches : données, modèle, rapport.
- L'assistant travaille dans la couche modèle.
- Il peut résumer, lister et documenter le modèle à la demande.
- L'assistant supprime la courbe d'apprentissage sur la partie difficile.

Suite : comment l'assistant trouve et se connecte à votre Power BI Desktop — le moment où les deux se rencontrent.
