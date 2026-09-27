# 4. Les statistiques sans la douleur

Il ne faut pas beaucoup de statistiques pour être un bon analyste. Il faut une poignée d'idées, comprises en profondeur, et la sagesse de savoir quand elles vous trompent. Voici la trousse complète, en mots simples.

## Les trois moyennes : moyenne, médiane, mode

Les gens disent « la moyenne » comme s'il n'y en avait qu'une. Il y en a trois, et choisir la mauvaise peut mentir sans techniquement avoir tort.

- **La moyenne** — additionnez tout, divisez par le nombre. La moyenne classique.
- **La médiane** — la valeur du milieu quand vous les alignez toutes. La moitié au-dessus, la moitié en dessous.
- **Le mode** — la valeur la plus fréquente.

Pourquoi est-ce important ? Imaginez une petite entreprise. Dix employés gagnent 30 000 €, et le patron en gagne 500 000.

- Le **salaire moyen** est de 72 727 € — « on paie bien ! »
- Le **salaire médian** est de 30 000 € — la réalité du travailleur typique.

Un chiffre est « correct » et l'autre aussi, et ils racontent des histoires complètement différentes. Quand quelques valeurs extrêmes (des valeurs aberrantes) sont dans le lot, la **médiane** est généralement l'honnête. Quand quelqu'un cite une moyenne, demandez : *moyenne ou médiane ?*

## La dispersion : les choses sont-elles stables ou déréglées ?

Une moyenne cache à quel point les nombres sont étalés. Deux services de livraison ont tous deux une moyenne de 3 jours. L'un met toujours 3 jours. L'autre met 1 jour ou 5 jours au hasard. Même moyenne, expérience totalement différente.

La mesure de dispersion que vous utiliserez le plus est l'**écart-type** — en gros, « à quelle distance de la moyenne les choses se trouvent d'habitude ». Petit écart-type = stable, prévisible. Grand = déréglé, peu fiable. Les moyennes vous donnent le centre ; la dispersion vous donne le risque.

## La courbe en cloche (et pourquoi elle apparaît partout)

Beaucoup de choses réelles — les tailles, les notes d'examen, les erreurs de mesure — s'accumulent autour du milieu et s'amincissent aux extrémités, formant une cloche. C'est la **loi normale**, et elle est partout à cause d'un fait magnifique : quand beaucoup de petites influences aléatoires s'additionnent, le résultat tend vers une cloche. Vous n'avez pas besoin des maths. Vous avez besoin de l'instinct : la plupart des cas sont près du milieu, les extrêmes sont rares, et une valeur très loin dans la queue mérite qu'on s'y attarde.

## Les valeurs aberrantes : le nombre bizarre

Une **valeur aberrante** est une valeur loin des autres. Un client achète pour 50 000 € alors que tous les autres achètent pour 50 €. Une livraison met 30 jours alors que le reste en met 3. Les valeurs aberrantes peuvent être :
- **Des erreurs** — une faute de frappe, un enregistrement de test, une virgule mal placée.
- **Réelles mais rares** — un client baleine, une vraie catastrophe.

Regardez toujours les valeurs aberrantes avant de faire confiance à une moyenne. Un seul gros client peut faire paraître un mois entier formidable et cacher que les 200 autres clients s'en vont.

## Le grand piège : corrélation n'est pas causalité

C'est la phrase la plus importante de tout ce livre.

La **corrélation** veut dire que deux choses bougent ensemble. La **causalité** veut dire qu'une chose *cause* l'autre. Ce n'est pas la même chose, et les confondre engendre des bêtises coûteuses.

Exemple classique : **les ventes de glaces et les noyades augmentent ensemble** chaque été. Les glaces causent-elles les noyades ? Non. Une troisième chose — le temps chaud — pilote les deux. Quand vous voyez deux choses bouger ensemble, demandez toujours :
- Est-ce que A cause B ?
- Est-ce que B cause A ?
- Est-ce qu'un C caché cause les deux ?
- Est-ce juste une coïncidence ?

« Les clients qui utilisent plus notre appli sont plus heureux » pourrait vouloir dire que l'appli les rend heureux — ou que les clients déjà heureux l'utilisent plus. La corrélation vous met sur une piste. Elle ne vous donne pas la réponse.

## Une curiosité : le coefficient de corrélation

Les statisticiens résument « à quel point deux choses bougent ensemble » en un seul nombre allant de **-1 à +1**. +1 veut dire qu'elles montent parfaitement en cadence ; -1 veut dire que l'une monte pendant que l'autre descend ; 0 veut dire aucune relation. C'est un thermomètre utile pour une relation — mais rappelez-vous, même un +1 parfait n'est toujours pas une preuve de cause.

---

## Ce que vous garderez de ce chapitre

- Sachez quelle moyenne vous utilisez ; la médiane dit souvent la vérité.
- Les moyennes cachent la dispersion — surveillez l'écart-type.
- Les valeurs aberrantes peuvent falsifier toute une histoire ; regardez-les d'abord.
- La corrélation est une piste, jamais une preuve. Cherchez toujours la troisième chose cachée.

Suite : comment transformer une inquiétude floue en une question précise à laquelle on peut vraiment répondre avec des données.
