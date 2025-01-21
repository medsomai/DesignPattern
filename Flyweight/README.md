Le **pattern Flyweight** est un patron de conception structurel qui vise � r�duire la consommation de m�moire en partageant autant que possible les donn�es entre les objets similaires. Ce pattern est particuli�rement utile lorsqu'un grand nombre d'objets similaires est cr��.

### **Probl�me**
Supposons que vous d�veloppez un �diteur graphique. Vous devez dessiner des milliers de formes, comme des cercles ou des rectangles, sur un canevas. Chaque forme a des attributs comme la couleur, la taille, la position, etc.

Si chaque forme conserve toutes ses donn�es (y compris celles qui sont partag�es par d'autres formes, comme la couleur ou la taille), cela peut entra�ner une consommation excessive de m�moire, surtout si certaines propri�t�s sont r�p�t�es.

### **Solution**
Le **pattern Flyweight** sugg�re de diviser les propri�t�s des objets en deux cat�gories :
- **Partag�es (invariantes)** : Les donn�es qui sont communes � plusieurs objets (par exemple, la couleur ou la taille d'une forme).
- **Non-partag�es (variables)** : Les donn�es sp�cifiques � chaque instance (par exemple, la position).

En partageant les donn�es invariantes entre les objets similaires, on peut consid�rablement r�duire la consommation de m�moire.

### **Analyse**

1. **Probl�me R�solu** :
   - Le pattern Flyweight r�duit la consommation de m�moire en partageant les donn�es communes (`ShapeType`).
   - Les donn�es sp�cifiques � chaque instance (`X`, `Y`) sont conserv�es s�par�ment, sans surcharge excessive.

2. **Structure** :
   - **Flyweight (`ShapeType`)** : Contient les donn�es partag�es entre les objets (par exemple, la forme et la couleur).
   - **Flyweight Factory (`ShapeFactory`)** : G�re la cr�ation et le partage des objets Flyweight.
   - **Client (`Shape`)** : Contient les donn�es sp�cifiques (position) et r�f�rence un Flyweight partag�.

3. **Avantages** :
   - **Efficacit� M�moire** : Les objets partagent les donn�es communes, ce qui r�duit la consommation de m�moire.
   - **Extensibilit�** : De nouveaux Flyweights peuvent �tre ajout�s dynamiquement sans affecter le code client.

4. **Inconv�nients** :
   - Complexit� accrue pour diff�rencier les donn�es partag�es et non partag�es.
   - N�cessite une gestion minutieuse pour �viter des erreurs de partage.

### **Extensions**
1. **Combinaison avec d'autres Patterns** : Utiliser le Flyweight avec des patterns comme Factory ou Singleton pour g�rer les instances.
2. **Optimisation** : Mesurer l'utilisation r�elle de la m�moire pour justifier l'application du pattern.
3. **Cache �viction** : Impl�menter une strat�gie de suppression dans la fabrique pour limiter le nombre d'objets partag�s en m�moire.

### **R�sum�**
Le **pattern Flyweight** est id�al pour optimiser la m�moire dans des syst�mes o� de nombreux objets similaires sont cr��s. Il divise les donn�es entre celles qui peuvent �tre partag�es et celles qui sont sp�cifiques � chaque instance, offrant une solution �l�gante pour r�duire les co�ts m�moire et am�liorer les performances.