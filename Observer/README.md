**Observer** est un mod�le de conception comportementale qui permet � certains objets d'informer d'autres objets des changements de leur �tat.

Le mod�le Observer fournit un moyen de s'abonner et de se d�sabonner de ces �v�nements pour tout objet qui impl�mente une interface d'abonn�.

### **Probl�me**
Dans de nombreuses applications, un **objet doit notifier automatiquement plusieurs autres objets** lorsqu'il change d'�tat.  

Par exemple :  
- Une **application m�t�o** o� plusieurs **�crans** doivent �tre mis � jour lorsque la temp�rature change.  
- Un **syst�me de notifications** o� plusieurs abonn�s re�oivent des alertes en temps r�el.  
- Un **mod�le MVC**, o� la **vue** doit �tre mise � jour lorsqu'un **mod�le** change.  

Dans une approche na�ve, nous pourrions appeler directement les objets concern�s, mais cela **cr�e un couplage fort** et **rend le code difficile � maintenir**.

### **Solution avec le Pattern Observer**
Le **pattern Observer** d�finit une relation **un-�-plusieurs** entre des objets.  
- L�**objet observ� (Subject)** maintient une liste d�observateurs (Observers).  
- Les **Observateurs** sont **notifi�s** automatiquement lorsque l��tat du **Subject** change.  
- Cela permet **un d�couplage**, car le **Subject** ne conna�t pas les d�tails des Observers.

### **Avantages**
**D�couplage** entre l�objet observ� et les observateurs.  
**Facilit� d�extension**, on peut ajouter des observateurs sans modifier le sujet.  
**Notification automatique** de tous les abonn�s lorsque l��tat change.  

### **Inconv�nients**
**Risque de fuite m�moire** si les observateurs ne sont pas correctement d�tach�s.  
**Probl�me de performance** si trop d�observateurs sont notifi�s simultan�ment.  

### **Cas d'utilisation du pattern Observer**
- **Syst�mes de notifications** (emails, push notifications, �v�nements).  
- **Mod�le MVC** (vue mise � jour automatiquement).  
- **Syst�mes financiers** (mise � jour en temps r�el des prix d�actions).  
- **Jeux vid�o** (syst�me d��v�nements et d�abonnements).  

Ce pattern est **indispensable** dans les applications n�cessitant un m�canisme de **pub-sub (publication-abonnement)**.