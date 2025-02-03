L'**état** est un modèle de conception comportementale qui permet à un objet de modifier son comportement lorsque son état interne change.

Le modèle extrait les comportements liés à l'état dans des classes d'état distinctes et force l'objet d'origine à déléguer le travail à une instance de ces classes, au lieu d'agir seul.

### **Problème**  
Lorsqu'un objet possède plusieurs **états internes** qui influencent son comportement, il peut être **difficile à gérer** avec de simples conditions `if` ou `switch`.  

Par exemple, dans une **machine à distributeur de billets** :  
- Elle a différents **états** : **Prêt, Carte insérée, Code saisi, Retrait en cours, Épuisé**.  
- À chaque changement d'état, **les actions disponibles varient**.  
- Gérer tout cela avec des `if/else` peut rendre le code **complexe et difficile à maintenir**.  

### **Solution avec le Pattern State**  
Le **pattern State** permet de **remplacer des structures conditionnelles complexes** en encapsulant chaque **état** dans une classe distincte.  
- L'objet principal **(Contexte)** délègue son comportement à des **classes d'état**.  
- Cela permet de **changer dynamiquement de comportement** sans modifier le contexte.  

### **Exemple en C# : Machine à Distributeur Automatique**  

Nous allons créer une machine ayant **trois états** :  
1. **Sans carte** ? L'utilisateur doit insérer une carte.  
2. **Carte insérée** ? L'utilisateur doit entrer son code.  
3. **Code validé** ? L'utilisateur peut retirer de l'argent.  

### **Avantages**
**Supprime les conditions complexes (`if/else`, `switch`)** et rend le code plus clair.  
**Facilite l'ajout de nouveaux états** sans modifier le contexte.  
**Encapsulation** : chaque état est une classe distincte avec son propre comportement.  

### **Inconvénients**
**Peut entraîner une explosion de classes** si de nombreux états sont nécessaires.  
**La transition entre états doit être bien définie** pour éviter des incohérences.  

### **Cas d'utilisation du pattern State**
- **Distributeurs automatiques** (changement d’état selon les actions de l’utilisateur).  
- **Machines à état** (ex: gestion des commandes dans un e-commerce).  
- **Jeux vidéo** (ex: changement d’état d’un personnage : attaquer, défendre, courir).  
- **Workflow de documents** (ex: Brouillon ? En révision ? Approuvé ? Publié).  

Ce pattern est **indispensable** pour gérer des objets ayant **un comportement dynamique en fonction de leur état interne**.