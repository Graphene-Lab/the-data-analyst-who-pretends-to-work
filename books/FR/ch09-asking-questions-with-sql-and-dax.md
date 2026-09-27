# 9. Poser des questions avec SQL et DAX

Une fois les données chargées et reliées entre elles, vous pouvez les interroger.
Deux langages méritent d'être reconnus : **SQL** pour les bases de données, et
**DAX** pour Power BI. Vous n'avez plus besoin de les écrire à la main —
l'assistant s'en charge — mais il faut comprendre ce qu'ils font, pour bien poser
vos questions et savoir lire les réponses.

## SQL : le langage des bases de données

**SQL** (Structured Query Language) est la façon de parler aux bases de données
depuis les années 1970. Il se lit presque comme de l'anglais :

- `SELECT` — les colonnes que vous voulez
- `FROM` — la table concernée
- `WHERE` — les lignes à conserver
- `GROUP BY` — comment regrouper et totaliser

Un grand classique : *« total des ventes par région »*, c'est un SELECT, une
jointure (JOIN) vers la table des régions, et un GROUP BY. SQL est partout — si
votre entreprise a une base de données, SQL est la façon de la lire.

## DAX : le langage de Power BI

**DAX** (Data Analysis Expressions) est le langage interne de Power BI. Il a une
autre tête que SQL, mais il fait le même travail : demander un nombre, obtenir un
nombre. DAX s'articule autour des **mesures** — des calculs nommés que vous pouvez
réutiliser. `SUM`, `AVERAGE`, `COUNT`, `CALCULATE` sont ses chevaux de trait.

La belle nouvelle : vous n'avez pas à taper de DAX. Vous décrivez la réponse
souhaitée, et l'assistant écrit et exécute le DAX pour vous. Regardez.

## Compter et additionner

> « Combien de lignes dans Sales ? »

![Compter les lignes](../../assets/examples/e020.png)

Soixante enregistrements de ventes. Simple, immédiat.

> « Quel est le total de la colonne Amount ? »

![Somme des montants](../../assets/examples/e021.png)

22 023 € de ventes au total. Le genre de chiffre qui, avant, signifiait un tableau
croisé dynamique et dix minutes de travail ; maintenant, c'est une phrase.

## Classer et filtrer

> « Les 3 meilleurs produits par total des ventes. »

![Meilleurs produits](../../assets/examples/e022.png)

L'assistant les classe pour vous. (Remarquez qu'il renvoie le classement complet,
pour que vous voyiez l'ensemble du tableau, pas seulement la tête.)

> « Montre-moi les ventes supérieures à 500. »

![Ventes au-dessus de 500](../../assets/examples/e023.png)

Un filtre, exécuté en direct, qui renvoie chaque grosse vente. C'est ainsi qu'on
déniche les valeurs aberrantes et les gros poissons.

## Regrouper à travers une relation

> « Total des ventes par ville du magasin. »

![Ventes par ville](../../assets/examples/e024.png)

C'est le moment où le modèle porte ses fruits : l'assistant traverse la relation
Sales→Stores et totalise par ville, sans fusion manuelle.

## Aller chercher une valeur liée

> « Pour chaque vente, affiche le nom du produit. »

![Nom du produit lié](../../assets/examples/e025.png)

Avec `RELATED`, l'assistant ramène le nom du produit sur chaque vente — le genre de
chose qui, dans Excel, veut dire un RECHERCHEV et une prière.

## Encore quelques-unes, parce que c'est facile

> « Quantité totale vendue, dans l'ensemble. »

![Quantité totale](../../assets/examples/e074.png)

> « Compte les ventes dont la quantité dépasse 3. »

![Compter les grosses quantités](../../assets/examples/e088.png)

Chacune une phrase toute simple, chacune une vraie requête DAX exécutée sur le
modèle en direct.

## Une curiosité : la réputation effrayante du DAX

Le DAX a la réputation d'être difficile. Il n'est pas difficile à *utiliser* — il
est difficile de *maîtriser le contexte de filtre*, cette règle subtile sur ce que
voit un calcul à un instant donné. Mais voici le secret de ce livre : vous n'avez
pas à le maîtriser. Vous décrivez la réponse ; l'assistant écrit le DAX et gère le
contexte. La difficulté passe de vos épaules à celles de l'outil.

---

## Ce que vous garderez de ce chapitre

- SQL parle aux bases de données ; DAX parle à Power BI.
- Les deux se lisent presque comme de l'anglais : sélectionner, filtrer, regrouper, totaliser.
- Vous décrivez la réponse ; l'assistant écrit et exécute la requête.
- Les relations rendent triviales les questions entre plusieurs tables.
- La partie difficile du DAX est désormais le problème de l'outil, pas le vôtre.

Suite : le tableur — là où tout le monde commence, et le mur où tout le monde finit
par avoir besoin de mieux.
