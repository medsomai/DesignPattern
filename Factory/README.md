Le **design pattern Fabrique (Factory)** est un patron de conception utilisé pour créer des objets sans spécifier leur classe concrète. Il repose sur une méthode qui retourne des instances d'une classe basée sur certaines conditions ou paramètres.

### **Problème**
Supposons que vous développiez une application qui génère des documents de différents types (par exemple, PDF, Word, et Excel). Le processus de création de ces documents peut varier selon le type, et vous ne voulez pas que le code client connaisse ou manipule directement les classes spécifiques. Cela rendra l'application difficile à maintenir ou à étendre lorsqu'un nouveau type de document est ajouté.

### **Solution avec le Design Pattern Fabrique**
Le **Pattern Fabrique** propose d'utiliser une méthode ou une classe dédiée pour encapsuler la logique de création d'objets.

### **Analyse**

1. **Problème Résolu** :
   - Le code client (`Main`) ne connaît pas les détails des classes concrètes (`PdfDocument`, `WordDocument`, etc.). Il utilise seulement l'interface commune `IDocument`.
   - Ajout d'un nouveau type de document (par exemple, "PowerPoint") : il suffit d'ajouter une nouvelle classe et de modifier légèrement la méthode `CreateDocument` dans `DocumentFactory`.

2. **Avantages** :
   - **Encapsulation** : La logique de création d'objet est centralisée.
   - **Extensibilité** : Ajout facile de nouveaux types de documents.
   - **Cohérence** : Le client travaille avec une interface commune.

3. **Limitation** :
   - Si de nouveaux types de documents sont ajoutés fréquemment, cela peut entraîner une surcharge de la méthode `CreateDocument`. Dans ce cas, il serait préférable d'utiliser le **Pattern Fabrique Abstraite (Abstract Factory)** pour une plus grande flexibilité.

Ce design pattern est particulièrement utile lorsque vous souhaitez découpler la création d'objets de leur utilisation tout en maintenant une architecture flexible et modulaire.