Le **pattern Flyweight** est un patron de conception structurel qui vise à réduire la consommation de mémoire en partageant autant que possible les données entre les objets similaires. Ce pattern est particulièrement utile lorsqu'un grand nombre d'objets similaires est créé.

### **Problème**
Supposons que vous développez un éditeur graphique. Vous devez dessiner des milliers de formes, comme des cercles ou des rectangles, sur un canevas. Chaque forme a des attributs comme la couleur, la taille, la position, etc.

Si chaque forme conserve toutes ses données (y compris celles qui sont partagées par d'autres formes, comme la couleur ou la taille), cela peut entraîner une consommation excessive de mémoire, surtout si certaines propriétés sont répétées.

### **Solution**
Le **pattern Flyweight** suggère de diviser les propriétés des objets en deux catégories :
- **Partagées (invariantes)** : Les données qui sont communes à plusieurs objets (par exemple, la couleur ou la taille d'une forme).
- **Non-partagées (variables)** : Les données spécifiques à chaque instance (par exemple, la position).

En partageant les données invariantes entre les objets similaires, on peut considérablement réduire la consommation de mémoire.

### **Analyse**

1. **Problème Résolu** :
   - Le pattern Flyweight réduit la consommation de mémoire en partageant les données communes (`ShapeType`).
   - Les données spécifiques à chaque instance (`X`, `Y`) sont conservées séparément, sans surcharge excessive.

2. **Structure** :
   - **Flyweight (`ShapeType`)** : Contient les données partagées entre les objets (par exemple, la forme et la couleur).
   - **Flyweight Factory (`ShapeFactory`)** : Gère la création et le partage des objets Flyweight.
   - **Client (`Shape`)** : Contient les données spécifiques (position) et référence un Flyweight partagé.

3. **Avantages** :
   - **Efficacité Mémoire** : Les objets partagent les données communes, ce qui réduit la consommation de mémoire.
   - **Extensibilité** : De nouveaux Flyweights peuvent être ajoutés dynamiquement sans affecter le code client.

4. **Inconvénients** :
   - Complexité accrue pour différencier les données partagées et non partagées.
   - Nécessite une gestion minutieuse pour éviter des erreurs de partage.

### **Extensions**
1. **Combinaison avec d'autres Patterns** : Utiliser le Flyweight avec des patterns comme Factory ou Singleton pour gérer les instances.
2. **Optimisation** : Mesurer l'utilisation réelle de la mémoire pour justifier l'application du pattern.
3. **Cache Éviction** : Implémenter une stratégie de suppression dans la fabrique pour limiter le nombre d'objets partagés en mémoire.

### **Résumé**
Le **pattern Flyweight** est idéal pour optimiser la mémoire dans des systèmes où de nombreux objets similaires sont créés. Il divise les données entre celles qui peuvent être partagées et celles qui sont spécifiques à chaque instance, offrant une solution élégante pour réduire les coûts mémoire et améliorer les performances.