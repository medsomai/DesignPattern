Le **design pattern Fabrique (Factory)** est un patron de conception utilis� pour cr�er des objets sans sp�cifier leur classe concr�te. Il repose sur une m�thode qui retourne des instances d'une classe bas�e sur certaines conditions ou param�tres.

### **Probl�me**
Supposons que vous d�veloppiez une application qui g�n�re des documents de diff�rents types (par exemple, PDF, Word, et Excel). Le processus de cr�ation de ces documents peut varier selon le type, et vous ne voulez pas que le code client connaisse ou manipule directement les classes sp�cifiques. Cela rendra l'application difficile � maintenir ou � �tendre lorsqu'un nouveau type de document est ajout�.

### **Solution avec le Design Pattern Fabrique**
Le **Pattern Fabrique** propose d'utiliser une m�thode ou une classe d�di�e pour encapsuler la logique de cr�ation d'objets.

### **Analyse**

1. **Probl�me R�solu** :
   - Le code client (`Main`) ne conna�t pas les d�tails des classes concr�tes (`PdfDocument`, `WordDocument`, etc.). Il utilise seulement l'interface commune `IDocument`.
   - Ajout d'un nouveau type de document (par exemple, "PowerPoint") : il suffit d'ajouter une nouvelle classe et de modifier l�g�rement la m�thode `CreateDocument` dans `DocumentFactory`.

2. **Avantages** :
   - **Encapsulation** : La logique de cr�ation d'objet est centralis�e.
   - **Extensibilit�** : Ajout facile de nouveaux types de documents.
   - **Coh�rence** : Le client travaille avec une interface commune.

3. **Limitation** :
   - Si de nouveaux types de documents sont ajout�s fr�quemment, cela peut entra�ner une surcharge de la m�thode `CreateDocument`. Dans ce cas, il serait pr�f�rable d'utiliser le **Pattern Fabrique Abstraite (Abstract Factory)** pour une plus grande flexibilit�.

Ce design pattern est particuli�rement utile lorsque vous souhaitez d�coupler la cr�ation d'objets de leur utilisation tout en maintenant une architecture flexible et modulaire.