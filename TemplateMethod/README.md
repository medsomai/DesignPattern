Le design pattern **Template Method** est un patron de conception comportemental qui définit le squelette d'un algorithme dans une méthode, en déléguant certaines étapes à des sous-classes. Cela permet aux sous-classes de redéfinir certaines étapes de l'algorithme sans en changer la structure globale.

### **Problème**  
Lorsqu’on a plusieurs classes qui partagent une structure algorithmique commune, mais avec **quelques étapes spécifiques** qui varient d'une implémentation à l’autre, on risque :  
- De **dupliquer** du code si chaque classe implémente la même logique.  
- De **rendre le code difficile à maintenir** si l’algorithme doit être modifié.  

### **Exemple concret : Processus de commande**  
Imaginons un **système de commande en ligne** :  
1. Un client passe une commande.  
2. Le paiement est traité.  
3. La commande est expédiée.  

**Problème** : Certaines étapes sont communes, mais la manière de traiter le paiement **(carte bancaire, PayPal, crypto-monnaie, etc.)** varie selon le type de commande.  

### **Solution avec le Pattern Template Method**  
Le **pattern Template Method** permet de **définir une structure d’algorithme** dans une classe de base et de laisser les sous-classes personnaliser certaines étapes **sans modifier la structure globale**.  

**Évite la duplication** du code.  
**Encapsule la structure de l’algorithme** dans une classe de base.  
**Permet d’ajouter facilement de nouvelles variantes** sans toucher au reste du code.  

### **Avantages**
**Encapsulation de la structure de l’algorithme** → La classe de base définit la logique globale.  
**Facilité d'ajout de nouvelles variantes** → Ajouter un nouveau mode de paiement sans modifier `ProcessOrder()`.  
**Évite la duplication de code** → Réutilisation du code commun.  

### **Inconvénients**
**Les sous-classes doivent respecter la structure imposée** par la classe de base.  
**Difficile à modifier si le modèle de l’algorithme change fréquemment**.  

### **Cas d'utilisation du pattern Template Method**
**Traitement des commandes** (différents moyens de paiement).  
**Systèmes de rendu** (différents moteurs graphiques).  
**Gestion des sauvegardes** (sauvegarde locale, cloud, FTP).  
**Conversion de fichiers** (CSV, JSON, XML).  

### **Conclusion**
Le **pattern Template Method** est **idéal** lorsque vous avez un **algorithme global avec certaines étapes variables**. Il permet de **réutiliser du code commun** tout en offrant **de la flexibilité aux sous-classes** pour des comportements spécifiques.