# 17. Se connecter à ses données

Avant que l'assistant puisse faire quoi que ce soit avec Power BI, il doit s'y connecter. Ce chapitre parle de cette poignée de main — comment l'assistant trouve votre rapport ouvert, se connecte au modèle en direct, et sait exactement à qui il a affaire.

## La connexion locale

Voici l'essentiel à comprendre : Power BI Desktop, quand vous ouvrez un rapport, démarre un petit **moteur d'analyse** sur votre propre machine (un programme appelé `msmdsrv`). L'assistant se connecte *à ce* moteur, sur *votre* machine.

```
You  →  AgentBridge  →  PowerBITool  →  the engine inside your Power BI Desktop
```

Pas de cloud. Pas d'envoi. Les données ne quittent jamais votre ordinateur. L'assistant parle simplement au même moteur que Power BI lui-même, à travers une porte locale.

## Trouver ce qui est ouvert

L'assistant voit chaque rapport Power BI que vous avez ouvert, chacun avec son propre moteur et son propre port :

> « Quels rapports Power BI sont ouverts en ce moment ? »

![Rapports ouverts](../../assets/examples/e003.png)

Si vous n'avez qu'un rapport ouvert, il s'y connecte directement. Si vous en avez plusieurs, vous lui dites lequel par son nom. C'est ainsi qu'il reste bien pointé sur la bonne chose.

## Confirmer la connexion

Une fois connecté, vous pouvez toujours vérifier l'état :

> « Quel est l'état de la connexion ? »

![État de la connexion](../../assets/examples/e004.png)

Il vous dit sur quel modèle il se trouve et sur quel port local. C'est important, car toute modification ultérieure va vers *ce* modèle en direct. Savoir exactement à quoi on est connecté est la première règle d'une édition sûre.

## Ce que « en direct » veut vraiment dire

Quand l'assistant modifie le modèle, le changement se produit dans le **modèle en direct, en mémoire** de Power BI Desktop. Vous le voyez immédiatement — c'est la boucle de retour visuelle. Mais il y a un piège important dont l'outil vous rappelle toujours :

> Le changement est en direct mais **non enregistré dans le fichier**. Pour le conserver, vous appuyez sur **Ctrl+S** dans Power BI Desktop.

C'est une sécurité, pas un bug. Cela veut dire que chaque changement est réversible tant que vous ne choisissez pas d'enregistrer. Vous pouvez expérimenter librement ; rien n'est définitif tant que vous ne l'avez pas décidé.

## Une curiosité : le port est une porte secrète

Chaque instance de Power BI Desktop choisit un port réseau local au hasard pour son moteur — ce nombre dans la chaîne de connexion (comme `localhost:64431`). L'assistant découvre ce port automatiquement en trouvant le processus Power BI en cours d'exécution et son moteur enfant. Vous n'avez jamais besoin de connaître le numéro ; l'outil le trouve tout seul. C'est la même porte que Power BI utilise en interne — l'assistant a simplement appris à frapper.

## Reconnexion et sécurité

Si vous fermez le rapport et en ouvrez un autre, l'assistant remarque que le moteur a changé et vous demande de vous reconnecter — il n'écrira pas à l'aveugle sur le mauvais modèle. Cette sécurité de session est ce qui rend l'édition en direct fiable : l'outil vérifie que le moteur derrière la connexion est toujours celui auquel il s'était connecté avant de laisser passer un changement.

---

## Ce que vous garderez de ce chapitre

- L'assistant se connecte au moteur local à l'intérieur de votre Power BI Desktop.
- Pas de cloud, pas d'envoi — tout reste sur votre machine.
- Il découvre automatiquement les rapports ouverts et leurs ports.
- Les changements sont en direct mais non enregistrés tant que vous n'appuyez pas sur Ctrl+S.
- L'outil protège contre l'écriture sur le mauvais modèle.

Suite : la modélisation dans Power BI — l'assistant comme modélisateur soigneux et bien documenté.
