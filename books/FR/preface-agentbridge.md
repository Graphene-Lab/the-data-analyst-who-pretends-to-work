# Une note sur l'outil derrière ce livre

Ce livre parle d'un métier : l'analyste de données. Il parle de ce qu'est vraiment
ce métier, d'où il vient et où il va. Il utilise des mots simples. Vous n'avez pas
besoin d'un diplôme en mathématiques ou en informatique pour le suivre. Si vous
dirigez une petite entreprise, tenez vous-même vos chiffres, ou aimez simplement
comprendre comment les choses fonctionnent, ce livre est pour vous.

Voici la partie honnête. Chaque exemple que vous verrez dans ce livre — chaque
tableau, chaque mesure, chaque graphique, chaque moment « regardez bien » — a été
fait avec un vrai outil, pas tapé à la main. Cet outil, c'est **PowerBITool**, qui
fonctionne dans **AgentBridge**.

## Que sont AgentBridge et PowerBITool ?

**AgentBridge** est un assistant d'IA qui tourne sur votre propre ordinateur. Vous
lui parlez comme vous parleriez à un collègue : en phrases ordinaires. Il écoute,
il réfléchit, et il fait le travail.

**PowerBITool** est un plugin qui donne à AgentBridge des mains dans
**Microsoft Power BI Desktop** — le programme populaire qu'on utilise pour créer
tableaux de bord et rapports. Avec PowerBITool, l'assistant peut ouvrir votre
modèle de données, ajouter des tables, créer des mesures, relier des tables entre
elles, exécuter des requêtes, vérifier votre travail et faire une capture d'écran
de ce qu'il a produit — pendant que vous le voyez se dérouler sur votre propre
écran.

Pas de cloud. Pas d'envoi des données de votre entreprise sur le serveur d'un
inconnu. Ça fonctionne avec le Power BI Desktop déjà installé sur votre machine.

```
You  →  AgentBridge  →  PowerBITool  →  your Power BI Desktop (on your PC)
```

## Comment l'obtenir (c'est gratuit)

PowerBITool est gratuit et ouvert. Pour l'essayer vous-même :

1. Installez **AgentBridge** (gratuit) depuis la page GitHub ci-dessous.
2. Ajoutez-lui le plugin **PowerBITool**.
3. Ouvrez un rapport dans **Power BI Desktop**.
4. Mettez-vous à parler à votre assistant.

Scannez ce code avec l'appareil photo de votre téléphone pour ouvrir la page
PowerBITool, où vous trouverez le téléchargement et des instructions
d'installation simples, étape par étape :

![PowerBITool sur GitHub](../../assets/qr-powerbitool-repo.png)

**github.com/Graphene-Lab/PowerBITool**

Vous pouvez aussi simplement taper cette adresse dans un navigateur.

## Bloqué ? De vraies personnes répondent en 24 heures — gratuitement

Voici une chose dont nous sommes fiers. PowerBITool est gratuit, et l'aide qui
l'accompagne aussi. Si quelque chose ne marche pas, si vous voulez une fonctionnalité,
ou si vous avez simplement trouvé un bug, vous ouvrez une **issue** sur la même page
GitHub et nos techniciens répondent — généralement en **24 heures**, et avec un vrai
correctif, pas une réponse type.

Scannez ce code pour atteindre la page des issues et voir comment ça marche :

![Signaler un problème à PowerBITool](../../assets/qr-powerbitool-issues.png)

**github.com/Graphene-Lab/PowerBITool/issues**

C'est toute la promesse : un outil gratuit, une aide gratuite, de vraies personnes,
des réponses rapides.

## Comment lire ce livre

Vous n'avez rien à installer pour profiter de ce livre. Lisez-le comme une histoire
si vous voulez. Mais si vous souhaitez essayer les choses au fil de la lecture — et
nous l'espérons — chaque exemple pratique montre deux choses :

- **Ce qu'une personne a tapé** à l'assistant (une ou deux phrases ordinaires).
- **Ce qui est revenu** (le vrai résultat, du vrai outil).

Les images de ce livre montrent cet échange : la question à droite, la réponse de
PowerBITool à gauche, exactement telle qu'elle apparaît dans AgentBridge.

## À propos des images de ce livre

Vous verrez deux types d'images.

**Les panneaux de chat** montrent l'échange lui-même : ce qu'une personne a tapé,
et le vrai résultat que PowerBITool a renvoyé du modèle en direct.

**Les images de graphiques** montrent ces mêmes données réelles *visualisées* — des
graphiques en barres, en courbes et en anneaux dessinés à partir des vrais chiffres
renvoyés par l'outil (ventes par catégorie, meilleurs clients, tendance mensuelle,
etc.). Ce sont des visualisations rendues à partir de la vraie sortie capturée, pour
que vous puissiez voir les données en image, pas seulement en texte.

Une note honnête sur Power BI Desktop lui-même. Power BI affiche ces mêmes données
sur son propre canevas de rapport, et l'outil peut capturer ce canevas en PNG
(`CaptureReportScreenshot`, via le Power BI Desktop Bridge). Cette capture exige un
rapport avec des visuels déjà construits dans la fenêtre Power BI Desktop. Ce livre a
été produit dans un environnement sans rapport construit dans l'interface graphique,
alors les images de graphiques ici sont rendues à partir des vraies données plutôt
que capturées à l'écran depuis Power BI. La procédure pour capturer de vraies captures
d'écran de Power BI Desktop est fournie avec l'outil, et vous pouvez déposer ces
captures directement aux mêmes endroits.

Commençons par le métier lui-même.

*— Graphene Lab*
