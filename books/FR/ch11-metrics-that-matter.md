# 11. Les indicateurs qui comptent

Un indicateur est un nombre que vous surveillez pour savoir comment va l'entreprise.
Choisissez les bons et vous pouvez piloter. Choisissez les mauvais et vous pouvez
fondre droit dans le précipice pendant que le tableau de bord reste vert. Ce
chapitre parle de sélectionner les chiffres qui comptent vraiment — et de les
construire avec l'assistant.

## Ce qui rend un indicateur digne d'être surveillé

Un bon indicateur passe trois tests :

1. **Il bouge quand l'entreprise bouge.** Si l'entreprise va moins bien, le nombre doit se dégrader.
2. **Vous pouvez agir dessus.** Un nombre que vous ne pouvez qu'admirer est un décor.
3. **Il est honnête.** On ne peut pas le truquer pour qu'il ait l'air bien pendant que tout pourrit.

Un **indicateur de vanité** échoue à ces tests. « Nombre total d'utilisateurs
inscrits depuis 2010 » ne fait que monter. Ça fait du bien et ça ne veut rien dire.
Surveillez des taux et des variations, pas des totaux qui grossissent sans fin.

## Les indicateurs clés des ventes

Toute entreprise qui vend quelque chose surveille un ensemble similaire :

- **Total des ventes** — le chiffre d'affaires principal.
- **Unités vendues** — combien de marchandise a bougé.
- **Commandes** — combien de transactions.
- **Panier moyen** — le chiffre d'affaires par commande.
- **Clients actifs** — combien de gens ont réellement acheté.
- **Plus grosse vente** — la plus grande ligne individuelle (pour repérer les gros poissons).

L'assistant construit chacun de ces indicateurs à partir d'une simple demande.
Regardez un ensemble apparaître :

> « Crée une mesure Total des ventes au format euro. »

![Mesure Total des ventes](../../assets/examples/e026.png)

> « Crée une mesure pour les unités vendues. »

![Mesure Unités vendues](../../assets/examples/e027.png)

> « Crée une mesure de panier moyen. »

![Panier moyen](../../assets/examples/e028.png)

Remarquez que le panier moyen utilise `DIVIDE`, et non une barre de division. C'est
volontaire — `DIVIDE` gère le cas où le dénominateur est zéro sans planter. Une
petite habitude de sécurité qui vous épargne des erreurs `#DIV/0!` plus tard.

> « Combien avons-nous de clients actifs ? »

![Clients actifs](../../assets/examples/e029.png)

> « Quelle est la plus grosse vente individuelle ? »

![Plus grosse vente](../../assets/examples/e030.png)

En quelques phrases, tout le jeu de KPI clés existe, vivant dans le modèle.

## Les indicateurs d'argent : marge et part

Le chiffre d'affaires est vanité ; le profit est bon sens. Pour savoir ce que vous
*gardez*, il vous faut le coût :

> « Ajoute une colonne de coût et une mesure de marge. »

![Colonne de coût](../../assets/examples/e056.png)

> « Marge totale sur l'ensemble des ventes. »

![Marge totale](../../assets/examples/e057.png)

Et pour voir comment une tranche se compare au tout :

> « Part du total des ventes, en pourcentage. »

![Pourcentage du total](../../assets/examples/e058.png)

Le pourcentage du total est l'un des indicateurs les plus utilisés en reporting — il
transforme n'importe quel nombre en « est-ce que c'est gros par rapport à tout le
reste ? »

## Encore quelques-uns, rapidement

> « Prix unitaire moyen payé. »

![Prix unitaire moyen](../../assets/examples/e075.png)

> « Total des ventes hors une catégorie. »

![Ventes hors une catégorie](../../assets/examples/e089.png)

Chacun une phrase toute simple, chacun une vraie mesure dans le modèle en direct.

## Une curiosité : l'indicateur qui s'est retourné

Quand l'Union soviétique mesurait la production de clous par la **quantité**, les
usines fabriquaient des minuscules clous inutiles par million. Quand elles sont
passées à une mesure par le **poids**, elles ont fabriqué quelques clous énormes.
Même objectif, indicateur différent, absurdité différente. La leçon que tout analyste
doit retenir : **on obtient ce que l'on mesure**, alors mesurez avec soin — idéalement
un indicateur qui ne peut s'améliorer que si l'entreprise s'améliore vraiment.

---

## Ce que vous garderez de ce chapitre

- Choisissez des indicateurs qui bougent avec l'entreprise, sur lesquels vous pouvez agir, et qu'on ne peut pas truquer.
- Évitez les indicateurs de vanité (les totaux qui grossissent sans fin).
- Le jeu clé des ventes : chiffre d'affaires, unités, commandes, panier moyen, clients actifs.
- La marge et la part du total transforment le chiffre d'affaires en sens.
- On obtient ce que l'on mesure — mesurez avec sagesse.

Suite : les quatre types d'analyse, depuis « que s'est-il passé » jusqu'à « que
devrions-nous faire ».
