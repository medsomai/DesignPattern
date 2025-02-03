Le design pattern **Visitor** est un patron de conception comportemental qui permet de séparer les algorithmes des objets sur lesquels ils opèrent. Cela permet d'ajouter de nouvelles opérations à un ensemble d'objets sans modifier leurs classes. Ce pattern est particulièrement utile lorsque vous avez une structure d'objets complexe (comme une arborescence ou un graphe) et que vous souhaitez appliquer différentes opérations sur ces objets.

### Problème
Imaginons que vous développez une application qui manipule une structure d'objets complexes, comme une arborescence de nœuds représentant un document (par exemple, des paragraphes, des images, des tableaux). Vous souhaitez implémenter différentes opérations sur ces nœuds, comme l'export en HTML, la génération de statistiques ou la validation. Sans le pattern Visitor, vous pourriez être tenté d'ajouter ces opérations directement dans les classes des nœuds, ce qui violerait le principe de responsabilité unique et rendrait le code difficile à maintenir et à étendre.

### Solution
Le pattern Visitor propose de déplacer les opérations dans des classes séparées appelées **visiteurs**. Chaque visiteur implémente une opération spécifique pour chaque type de nœud. Les nœuds acceptent un visiteur et lui délèguent l'exécution de l'opération. Cela permet d'ajouter de nouvelles opérations sans modifier les classes des nœuds.

### Explication

1. **IElement** : C'est l'interface des éléments visitables. Elle définit une méthode `Accept` qui prend un visiteur en paramètre.

2. **Paragraph** et **Image** : Ce sont des classes concrètes qui implémentent `IElement`. Elles représentent des éléments d'un document (paragraphe et image). Chaque élément accepte un visiteur et lui délègue l'exécution de l'opération.

3. **IVisitor** : C'est l'interface des visiteurs. Elle définit une méthode pour chaque type d'élément visitable (`VisitParagraph` et `VisitImage`).

4. **HtmlExportVisitor** et **StatisticsVisitor** : Ce sont des visiteurs concrets qui implémentent `IVisitor`. Ils définissent des opérations spécifiques pour chaque type d'élément (export en HTML et génération de statistiques).

5. **Document** : C'est une structure de données qui contient une collection d'éléments. Elle accepte un visiteur et lui délègue l'exécution de l'opération sur chaque élément.

6. **Program** : C'est le client qui utilise les visiteurs et la structure de données. Il crée un document, ajoute des éléments, puis applique les visiteurs pour effectuer des opérations sur les éléments.

### Avantages

- **Séparation des responsabilités** : Les opérations sont séparées des objets sur lesquels elles opèrent, ce qui respecte le principe de responsabilité unique.
- **Extensibilité** : Vous pouvez ajouter de nouvelles opérations en créant de nouveaux visiteurs sans modifier les classes des éléments.
- **Flexibilité** : Les visiteurs peuvent être utilisés pour appliquer des opérations sur des structures d'objets complexes sans altérer leur structure.

### Cas d'utilisation
Le pattern Visitor est particulièrement utile dans les situations suivantes :

- **Traitement d'arbres ou de graphes** : Par exemple, un arbre syntaxique abstrait (AST) où chaque nœud doit être traité différemment.
- **Export de données** : Par exemple, exporter des données dans différents formats (HTML, JSON, XML).
- **Analyse de données** : Par exemple, calculer des statistiques ou valider des données.

Ce pattern est puissant, mais il peut introduire une complexité supplémentaire. Il est donc recommandé de l'utiliser lorsque la séparation des opérations et des objets est vraiment nécessaire.