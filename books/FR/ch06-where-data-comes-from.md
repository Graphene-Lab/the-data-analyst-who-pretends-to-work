# 6. D'où viennent les données

Avant de pouvoir analyser quoi que ce soit, il vous faut des données — et il faut savoir dans quel état elles sont. Ce chapitre parle de la matière première : d'où elle vient, les formes qu'elle prend, et comment prendre sa température avant de construire quoi que ce soit.

## Trois sortes de données

Tout ce que vous analyserez un jour tombe dans trois cases :

- **Structurées** — des lignes et des colonnes bien rangées. Un tableau de ventes, une liste de clients, un relevé bancaire. Facile à lire pour un ordinateur. C'est votre pain quotidien.
- **Semi-structurées** — un certain ordre, mais pas une grille nette. Un journal web, un fichier JSON d'une appli, un e-mail avec des champs. Demande un peu de mise en forme.
- **Non structurées** — aucun ordre intégré. Documents texte, images, vidéos, la réclamation en texte libre d'un client. Le plus dur à analyser, et là où l'IA devient étonnamment bonne.

La plupart des analyses d'entreprise vivent dans le monde structuré. C'est la bonne nouvelle : c'est le genre sur lequel on peut pointer un outil et obtenir des réponses vite.

## Les habitués : où se cache la donnée d'entreprise

- **L'ERP / le système de gestion** — commandes, factures, stock, clients.
- **Le CRM** — prospects, opportunités, contacts, pipeline de ventes.
- **Les tableurs** — le recours universel, pour le meilleur et pour le pire.
- **Les bases de données** — des serveurs SQL qui gardent les enregistrements de l'entreprise.
- **Les journaux web et appli** — chaque clic, chaque page vue, chaque événement.
- **Les exports CSV / Excel** — des données tirées de n'importe quel système dans un fichier.
- **Les API** — des données en direct diffusées par un service (météo, livraison, paiements).
- **Les capteurs IoT** — température, état des machines, compteurs de passage.

Une vraie analyse assemble souvent plusieurs de ces sources. Le premier mouvement de l'analyste est de trouver les données et de comprendre leur forme.

## Prendre la température : le profilage

Avant de faire confiance à un tableau, vous le **profilez** : combien de lignes, quelles colonnes, combien de valeurs distinctes, combien de vides, le minimum et le maximum, les valeurs les plus fréquentes. Le profilage est une visite de santé qui vous dit à quoi vous avez affaire avant de construire le moindre graphique.

En voici un vrai. Quelqu'un a demandé à l'assistant de profiler la table des produits :

> « Profile la table Products. »

![Profiler la table Products](../../assets/examples/e006.png)

D'un seul coup vous voyez : 8 produits, 3 catégories (Cuisine 4, Mobilier 3, Papeterie 1), des prix de 12 € à 349 €, et quelques lignes d'exemple. Pas de devinette. La forme des données est maintenant évidente.

La même chose marche pour les clients :

> « Profile la table Customers. »

![Profiler la table Customers](../../assets/examples/e007.png)

Douze clients répartis sur quatre villes et trois segments. Vous voyez déjà l'histoire se dessiner — Milan et Rome sont les plus gros, les segments sont équilibrés.

## Voir les colonnes clairement

Parfois vous voulez juste la structure — les colonnes et leurs types. L'assistant lit le schéma directement :

> « Montre-moi le schéma de la table Sales. »

![Schéma de la table Sales](../../assets/examples/e008.png)

Chaque colonne, son type, et les mesures déjà rattachées. C'est la carte que vous emportez dans chaque question ultérieure.

## Une curiosité : la « cinquième sorte » de donnée

Il circule une blague chez les analystes : la cinquième sorte de donnée, c'est **la donnée dont vous ne saviez pas que vous l'aviez** — les métadonnées. Quand chaque enregistrement a-t-il changé ? Qui y a touché ? Combien de fois une page a-t-elle été vue ? Les métadonnées sont la donnée *à propos* de vos données, et elles recèlent souvent les réponses les plus intéressantes de toutes.

---

## Essayez :

> « Combien y a-t-il de catégories distinctes ? »

![Compter les catégories distinctes](../../assets/examples/e071.png)

Une question en une ligne, une réponse en une ligne, directement depuis le modèle en direct.

## Ce que vous garderez de ce chapitre

- Les données viennent en trois formes : structurées, semi-structurées, non structurées.
- La donnée d'entreprise se cache dans l'ERP, le CRM, les bases de données, les tableurs, les journaux et les API.
- Toujours **profiler** avant de construire — connaissez la forme et les manques.
- N'oubliez pas les métadonnées : la donnée à propos de vos données.

Suite : le travail ingrat et essentiel du nettoyage des données sales — et comment quelques colonnes calculées règlent un désordre en quelques secondes.
