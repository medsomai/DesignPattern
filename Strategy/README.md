Le design pattern **Strategy** est un patron de conception comportemental qui permet de définir une famille d'algorithmes, de les encapsuler dans des classes séparées et de les rendre interchangeables. Cela permet à l'algorithme de varier indépendamment des clients qui l'utilisent.

### **Problème**  
Dans une application, il est courant d’avoir **plusieurs algorithmes similaires** qui doivent être sélectionnés dynamiquement en fonction du contexte.  

### **Exemple concret : Calcul des frais de livraison**
- Une boutique en ligne propose plusieurs **méthodes de livraison** :  
  - 🚚 **Standard** (livraison en 5 jours).  
  - 🚀 **Express** (livraison en 2 jours).  
  - 📦 **Retrait en magasin** (pas de livraison).  
- Le problème : **Si nous utilisons des `if/else` ou `switch` pour gérer cela, le code devient difficile à maintenir.**  
- **Solution** : Utiliser le **pattern Strategy** pour **encapsuler chaque méthode de livraison dans une classe distincte**, et la sélectionner dynamiquement.

### **Solution avec le Pattern Strategy**  
Le **pattern Strategy** permet de définir une famille d'algorithmes et de les rendre interchangeables sans modifier le client.  
- Chaque **algorithme** (ex: une méthode de livraison) est une **stratégie** séparée.  
- Le client peut **choisir dynamiquement** une stratégie sans modifier son code.  

### **Avantages**
**Séparation claire** des algorithmes dans des classes distinctes.  
**Extensibilité** : ajouter une nouvelle méthode de livraison est **facile**.  
**Découplage** : le client ne connaît pas les détails des stratégies.  
**Meilleure testabilité** : chaque stratégie peut être **testée indépendamment**.  

### **Inconvénients**
**Peut entraîner une explosion de classes** si trop de stratégies sont nécessaires.  
**Le client doit savoir quelle stratégie utiliser** (peut être automatisé avec un `Factory`).  


### **Conclusion**
Le **pattern Strategy** est parfait lorsque vous avez **plusieurs variantes d'un algorithme** et que vous voulez **éviter les `if/else` complexes**. Il rend votre code **plus propre, évolutif et maintenable**.