# Annexe A — Glossaire des termes

Définitions en langage simple des termes utilisés dans ce livre.

**Agent / agentique.** Logiciel qui accomplit des *actions* en direction d'un objectif, et pas seulement des réponses à des questions. Un agent ferme la boucle, de l'intention au résultat.

**AgentBridge.** L'assistant IA local qui, en langage courant, planifie et agit à travers plusieurs outils. Le « cerveau » de ce livre.

**PowerBITool.** Le plugin d'AgentBridge qui pilote Microsoft Power BI Desktop. Les « mains » de ce livre.

**Power BI Desktop.** L'outil de Microsoft pour créer des modèles de données et des rapports.

**Modèle.** L'ensemble des tables, colonnes, mesures et relations que Power BI utilise pour répondre à des questions.

**Table.** Un ensemble de lignes et de colonnes. Le contenant de base des données.

**Colonne.** Un seul champ dans une table, avec un type de données (texte, nombre, date).

**Mesure.** Une valeur calculée (en général une agrégation comme une somme ou une moyenne) qui réagit aux filtres d'un rapport.

**Colonne calculée.** Une nouvelle colonne ajoutée à une table, calculée par une formule pour chaque ligne.

**Table calculée.** Une nouvelle table créée à partir d'une formule, calculée à la volée.

**Relation.** Un lien entre deux tables (par ex. Ventes → Produits) pour que les données circulent entre elles.

**Cardinalité.** Le caractère « un-à-plusieurs » ou « plusieurs-à-un » d'une relation.

**DAX.** Data Analysis Expressions — le langage de formules de Power BI.

**SQL.** Structured Query Language — le langage standard pour interroger des bases de données.

**SUM / AVERAGE / COUNT.** Agrégations de base : total, moyenne et nombre.

**DISTINCTCOUNT.** Nombre de valeurs uniques.

**CALCULATE.** Fonction DAX qui modifie le contexte de filtre d'une mesure.

**FILTER.** Fonction DAX qui conserve les lignes répondant à une condition.

**RELATED.** Fonction DAX qui va chercher une valeur dans une table liée.

**DIVIDE.** Fonction de division sûre qui gère la division par zéro.

**ALL.** Fonction DAX qui supprime les filtres (souvent utilisée pour le « % du total »).

**RANKX.** Fonction DAX qui classe les lignes selon une valeur.

**TOPN.** Fonction DAX qui renvoie les N premières lignes.

**Contexte de filtre.** L'ensemble des filtres appliqués au moment où une mesure se calcule.

**Contexte de ligne.** La « ligne courante » lorsqu'une colonne calculée ou un itérateur se calcule.

**Itérateur.** Fonction DAX (SUMX, AVERAGEX) qui évalue ligne par ligne.

**Dictionnaire de données.** Documentation de chaque table, colonne et mesure d'un modèle.

**Profilage.** Inspection des valeurs distinctes, des valeurs vides, des min/max et d'échantillons d'une table.

**Linting.** Contrôles statiques qui signalent les schémas risqués (par ex. `/` au lieu de `DIVIDE`).

**Bonnes pratiques.** Un bilan de santé du modèle face aux bons schémas connus.

**Garde fail-closed.** Règle de sécurité qui bloque tout ce qui n'est pas clairement autorisé.

**Qualité des données.** À quel point les données sont propres, complètes et dignes de confiance.

**Segmentation.** Répartition des clients ou des données en groupes pour l'analyse.

**Saisonnalité.** Motifs réguliers et répétitifs dans le temps.

**KPI.** Key Performance Indicator — un indicateur qui compte pour l'entreprise.

**Tableau de bord.** Vue des principaux KPI, généralement sur un seul écran.

**Rapport.** Ensemble détaillé et interactif de visuels construits sur un modèle.

**Gouvernance des données.** Les règles, la responsabilité et les contrôles autour d'un actif de données.

**Paradoxe de Jevons.** Quand quelque chose devient moins cher, on en utilise davantage, et non moins.
