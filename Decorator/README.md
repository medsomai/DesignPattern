Le **pattern Decorator** est un patron de conception structurel qui permet d�ajouter dynamiquement des comportements ou des responsabilit�s suppl�mentaires � un objet sans modifier son code. Il est souvent utilis� pour �viter un exc�s de sous-classes en apportant des fonctionnalit�s flexibles et r�utilisables.

### **Probl�me**
Supposons que vous d�veloppez une application de messagerie o� les messages peuvent �tre envoy�s dans leur format brut ou avec des fonctionnalit�s suppl�mentaires, telles que :
- La compression du contenu.
- L�ajout d�une signature.
- Le chiffrement.

Chaque fonctionnalit� doit pouvoir �tre combin�e dynamiquement (par exemple, un message compress� et chiffr�). Si vous g�rez chaque combinaison avec une classe sp�cifique, le syst�me devient difficile � maintenir � mesure que les combinaisons augmentent.

### **Solution**
Le **pattern Decorator** r�sout ce probl�me en encapsulant l�objet de base dans des "d�corateurs". Chaque d�corateur ajoute une responsabilit� sp�cifique, tout en restant compatible avec l�interface de l�objet de base.

### **Analyse**

1. **Probl�me R�solu** :
   - Ajout dynamique de comportements (compression, chiffrement, signature) � un objet sans modifier son code.
   - R�duction de la prolif�ration de sous-classes (pas besoin de `CompressedAndEncryptedMessage`, `SignedAndEncryptedMessage`, etc.).

2. **Structure Flexible** :
   - **Interface de Base (`IMessage`)** : D�clare la m�thode commune � tous les objets (message brut et d�corateurs).
   - **Composant Concret (`PlainMessage`)** : Fournit une impl�mentation simple de l�interface.
   - **D�corateurs** : �tendent dynamiquement les fonctionnalit�s en encapsulant un autre objet.

3. **Avantages** :
   - **Extensibilit�** : Facile d�ajouter de nouveaux comportements sans modifier le code existant.
   - **Combinaison Dynamique** : Permet de composer des fonctionnalit�s � la vol�e.
   - **Respect du SRP (Single Responsibility Principle)** : Chaque d�corateur a une responsabilit� sp�cifique.

4. **Inconv�nients** :
   - Peut rendre le syst�me plus complexe, surtout avec de nombreux d�corateurs imbriqu�s.
   - La gestion de l'ordre des d�corateurs peut devenir d�licate si les comportements sont interd�pendants.

### **R�sum�**
Le **pattern Decorator** est une solution �l�gante pour ajouter ou modifier dynamiquement des fonctionnalit�s � un objet sans recourir � l�h�ritage. Il est utile dans les cas o� les combinaisons de comportements doivent �tre flexibles et extensibles.