# 15. Tests, hasard et avoir raison

Vous avez modifié le site web et les conversions ont augmenté de 2 %. Votre changement a-t-il vraiment fonctionné, ou est-ce un simple coup de chance ? C'est la question qui sépare la vraie analyse du simple souhait, et la réponse se trouve dans le monde peu glamour des tests et du hasard. Pas de panique — on va rester doux.

## Le problème : le changement ou la chance ?

N'importe quel nombre peut fluctuer par hasard. Si vous lancez une pièce 10 fois et obtenez 7 fois face, vous n'en concluez pas que la pièce est truquée. Idem dans le business : si une nouvelle pub récolte quelques clics de plus, elle est peut-être meilleure, ou peut-être que ce n'est que du bruit. La question est : **à quel point pouvez-vous être sûr que la différence est réelle ?**

## La notion d'échantillon

Vous ne voyez presque jamais la population entière — vous voyez un **échantillon**. 1 000 visiteurs sur votre site, pas tous ceux qui pourraient un jour le visiter. Un échantillon, c'est une petite cuillerée d'une bien plus grande marmite. L'astuce, c'est qu'une petite cuillerée peut vous renseigner sur toute la marmite — *à condition* qu'elle soit assez grande et impartiale.

Gros échantillon + sélection aléatoire = fiable. Tout petit échantillon ou échantillon choisi à la tête du client = dangereux. Les tests A/B fonctionnent parce qu'ils répartissent les visiteurs au hasard en deux groupes, puis comparent.

## Le test A/B : l'expérience honnête

L'étalon-or pour « est-ce que ça marche ? » :

1. Répartissez votre audience **au hasard** en deux groupes.
2. Le groupe A voit l'ancienne version ; le groupe B voit la nouvelle.
3. Mesurez le résultat dans les deux.
4. Comparez. Si B bat A de plus que ce que le hasard explique, le changement est réel.

Le hasard est toute l'astuce. Il rend les deux groupes identiques, sauf pour la seule chose que vous avez changée — donc toute différence ne peut venir que de ce changement.

## La signification : la différence est-elle réelle ?

Les statisticiens utilisent une **p-valeur** pour répondre à « et si c'était le hasard ? ». Une p-valeur inférieure à 0,05 est le seuil habituel : elle signifie « s'il n'y avait vraiment aucune différence, on verrait quelque chose d'aussi extrême moins de 5 % du temps ». Sous le seuil, on parle de **différence statistiquement significative** — probablement réelle. Au-dessus, on hausse les épaules et on dit « pas assez de preuves ».

Pas besoin de calculer les p-valeurs à la main. Il faut surtout le réflexe : **une petite différence sur un petit échantillon est probablement du bruit ; une différence nette sur un gros échantillon est probablement réelle.**

## Les deux façons de se tromper

- **Erreur de type I (faux positif) :** vous dites que le changement a fonctionné alors que non. Vous déployez un changement inutile. Le seuil de 5 % contrôle ce risque.
- **Erreur de type II (faux négatif) :** vous dites que le changement n'a pas fonctionné alors que si. Vous jetez une bonne idée. Causée en général par un échantillon trop petit.

Les deux arrivent. Un bon test trouve l'équilibre : assez de données pour attraper les effets réels, un seuil assez strict pour ne pas courir après des fantômes.

## Comparer deux groupes, en direct

Pas besoin d'un labo pour voir la forme d'une comparaison. L'assistant peut mettre deux groupes côte à côte en une seule requête :

> « Comparez les ventes du Nord et du Centre. »

![Comparer deux groupes](../../assets/examples/e033.png)

Passez à l'échelle supérieure avec une attribution aléatoire et un gros échantillon, et vous tenez un test A/B. La logique est identique : deux groupes, une différence, mesurer et comparer.

## Une curiosité : le cookie qui a dupé tout le monde

Une entreprise a lancé un test A/B, a vu une forte hausse, et a fait la fête. Le piège : les deux groupes n'étaient pas vraiment aléatoires — un bug avait mis tous les utilisateurs mobiles dans un seul groupe. La « victoire » n'était en fait que les utilisateurs mobiles qui se comportaient différemment. Le test était solide en théorie et cassé en pratique. **La randomisation est tout.** Un test ne vaut que par la répartition qui le sous-tend.

## Quand le test formel n'est pas nécessaire

Toutes les décisions n'ont pas besoin d'une p-valeur. Si vous changez le prix d'un article et regardez une semaine de ventes, vous ne menez pas une expérience — vous observez. Le test formel est réservé aux décisions qui comptent et qui peuvent être menées correctement. Pour tout le reste, soyez honnête : vous êtes dans l'à-peu-près, et gardez la décision réversible.

---

## Ce que vous garderez de ce chapitre

- Une différence peut être de la chance ; demandez-vous à quel point vous êtes sûr.
- Les échantillons permettent à une petite cuillerée de renseigner sur toute la marmite — s'ils sont grands et aléatoires.
- Test A/B = répartition aléatoire, on change une seule chose, on compare.
- « Significatif » veut dire « peu probable que ce soit du pur hasard ».
- La randomisation est tout ; une mauvaise répartition fabrique une fausse victoire.

La partie III est terminée — vous savez construire des indicateurs, distinguer les types d'analyse, connaître vos clients, lire les tendances et séparer le vrai du bruit. Maintenant, on rend tout ça visible : Power BI et l'art de montrer ses données.
