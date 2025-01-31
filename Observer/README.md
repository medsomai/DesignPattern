**Observer** est un modèle de conception comportementale qui permet à certains objets d'informer d'autres objets des changements de leur état.

Le modèle Observer fournit un moyen de s'abonner et de se désabonner de ces événements pour tout objet qui implémente une interface d'abonné.

### **Problème**
Dans de nombreuses applications, un **objet doit notifier automatiquement plusieurs autres objets** lorsqu'il change d'état.  

Par exemple :  
- Une **application météo** où plusieurs **écrans** doivent être mis à jour lorsque la température change.  
- Un **système de notifications** où plusieurs abonnés reçoivent des alertes en temps réel.  
- Un **modèle MVC**, où la **vue** doit être mise à jour lorsqu'un **modèle** change.  

Dans une approche naïve, nous pourrions appeler directement les objets concernés, mais cela **crée un couplage fort** et **rend le code difficile à maintenir**.

### **Solution avec le Pattern Observer**
Le **pattern Observer** définit une relation **un-à-plusieurs** entre des objets.  
- L’**objet observé (Subject)** maintient une liste d’observateurs (Observers).  
- Les **Observateurs** sont **notifiés** automatiquement lorsque l’état du **Subject** change.  
- Cela permet **un découplage**, car le **Subject** ne connaît pas les détails des Observers.

### **Avantages**
**Découplage** entre l’objet observé et les observateurs.  
**Facilité d’extension**, on peut ajouter des observateurs sans modifier le sujet.  
**Notification automatique** de tous les abonnés lorsque l’état change.  

### **Inconvénients**
**Risque de fuite mémoire** si les observateurs ne sont pas correctement détachés.  
**Problème de performance** si trop d’observateurs sont notifiés simultanément.  

### **Cas d'utilisation du pattern Observer**
- **Systèmes de notifications** (emails, push notifications, événements).  
- **Modèle MVC** (vue mise à jour automatiquement).  
- **Systèmes financiers** (mise à jour en temps réel des prix d’actions).  
- **Jeux vidéo** (système d’événements et d’abonnements).  

Ce pattern est **indispensable** dans les applications nécessitant un mécanisme de **pub-sub (publication-abonnement)**.