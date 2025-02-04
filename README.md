![image](https://github.com/user-attachments/assets/4963873d-fc44-42aa-84e1-d0bb1cf3b5dc)

Les **design patterns** sont des solutions éprouvées pour des problèmes courants en développement logiciel. Ils sont classés en **trois catégories** :  

- **Créationnels** → Gèrent la création des objets.  
- **Structurels** → Organisent les relations entre objets.  
- **Comportementaux** → Gèrent la communication et les interactions entre objets.  

## **1️⃣ Design Patterns Créationnels** 🏗️ (Gestion de la création des objets)  

| **Pattern**  | **Problème** | **Solution** | **Utilisation** |
|-------------|-------------|-------------|----------------|
| **Factory Method** 🏭 | Quand il faut instancier des objets sans exposer leur logique de création | Définit une interface pour créer des objets, mais laisse les sous-classes décider quel type d’objet créer | Création d’objets sans dépendance forte entre classes |
| **Abstract Factory** 🏭🏭 | Quand on a plusieurs familles d’objets liés à créer | Définit une fabrique qui retourne des objets dépendants les uns des autres | Interfaces graphiques multi-thèmes, bases de données interchangeables |
| **Builder** 🏗️ | Quand un objet complexe doit être créé étape par étape | Sépare la construction de l’objet de sa représentation finale | Génération de documents, configuration complexe d'objets |
| **Prototype** 🧬 | Quand il faut dupliquer des objets sans dépendre de leur classe | Permet de cloner un objet en copiant ses attributs | Création d’objets coûteux à instancier, jeux vidéo (clonage d’ennemis) |
| **Singleton** 🔄 | Quand un objet unique doit exister dans le programme | Garantit qu’une seule instance est créée et accessible globalement | Gestion des logs, accès à la base de données, gestion de configuration |

## **2️⃣ Design Patterns Structurels** 🏛️ (Organisation et relation entre objets)  

| **Pattern** | **Problème** | **Solution** | **Utilisation** |
|------------|-------------|-------------|----------------|
| **Adapter** 🔌 | Quand une interface incompatible doit être utilisée | Crée une classe intermédiaire pour adapter une interface existante | Connexion entre APIs, adapter un ancien système à un nouveau |
| **Bridge** 🌉 | Quand il faut séparer l’abstraction et l’implémentation pour éviter une explosion de classes | Sépare les interfaces des implémentations pour les faire évoluer indépendamment | Interfaces graphiques multi-plateformes, gestion de pilotes matériels |
| **Composite** 🌳 | Quand une structure hiérarchique doit être traitée de manière uniforme | Permet de traiter les objets individuels et les collections de la même manière | Structures arborescentes (systèmes de fichiers, interface graphique) |
| **Decorator** 🎭 | Quand il faut ajouter dynamiquement des fonctionnalités à un objet | Permet d’envelopper un objet dans un autre pour ajouter des comportements | Extensions de fonctionnalités (filtres graphiques, chiffrement de données) |
| **Facade** 🏠 | Quand un système complexe doit être simplifié pour l’utilisateur | Fournit une interface unique pour cacher la complexité interne | Interfaces simplifiées pour API, bibliothèques complexes |
| **Flyweight** 🦋 | Quand un grand nombre d’objets consomment trop de mémoire | Partage d’instances communes pour réduire l’utilisation mémoire | Optimisation graphique (gestion des pixels, polices de caractères) |
| **Proxy** 🕵️ | Quand un accès indirect à un objet est nécessaire | Fournit un intermédiaire pour contrôler l’accès à un objet | Gestion des droits d’accès, chargement différé (lazy loading) |

## **3️⃣ Design Patterns Comportementaux** 🤝 (Gestion des interactions entre objets)  

| **Pattern** | **Problème** | **Solution** | **Utilisation** |
|------------|-------------|-------------|----------------|
| **Chain of Responsibility** 🔗 | Quand plusieurs objets peuvent gérer une requête, sans savoir lequel le fera | Passe la requête à travers une chaîne d’objets jusqu’à ce que l’un la traite | Gestion des logs, validation de requêtes, gestion des événements |
| **Command** 🎮 | Quand il faut encapsuler une action en tant qu’objet | Permet de découpler l’émetteur et le récepteur d’une action | Historique d’actions (undo/redo), contrôleurs de jeux vidéo |
| **Iterator** 🔄 | Quand il faut parcourir des objets sans exposer leur structure interne | Fournit une interface standard pour parcourir une collection | Parcours d’arbres, gestion de collections hétérogènes |
| **Mediator** 🏢 | Quand plusieurs objets communiquent entre eux de manière compliquée | Un objet centralise la communication entre les objets | Systèmes de chat, gestion des avions dans une tour de contrôle |
| **Memento** 📜 | Quand il faut sauvegarder et restaurer l’état d’un objet | Stocke l’état interne d’un objet sans violer son encapsulation | Systèmes de sauvegarde, annulation (Undo/Redo) |
| **Observer** 👀 | Quand plusieurs objets doivent être notifiés des changements d’un autre objet | Permet à un objet d’avoir plusieurs abonnés qui réagissent à ses changements | Notifications (événements UI, modèles MVC) |
| **State** 🚦 | Quand un objet doit changer son comportement selon son état | Permet à un objet de modifier son comportement dynamiquement | Automates, gestion des sessions utilisateurs |
| **Strategy** 🎭 | Quand plusieurs algorithmes doivent être interchangeables | Définit une famille d’algorithmes et permet de les interchanger | Moteurs de calcul, algorithmes de tri |
| **Template Method** 📋 | Quand un algorithme est commun à plusieurs classes mais a des étapes variables | Définit un modèle d’algorithme avec certaines étapes abstraites | Traitement de commandes, génération de rapports |
| **Visitor** 🚶‍♂️ | Quand il faut ajouter de nouvelles opérations à une structure d’objets sans la modifier | Permet d’ajouter des opérations sans toucher à la hiérarchie des classes | Analyse syntaxique, export de données |

### **🎯 Comment choisir le bon Design Pattern ?**  

1️⃣ **Si vous avez un problème de création d’objets :**  
- **Factory Method** : Si vous avez besoin d’une **méthode générique** pour créer des objets.  
- **Abstract Factory** : Si vous avez plusieurs familles d’objets à créer.  
- **Builder** : Si votre objet a **beaucoup de paramètres** et doit être construit étape par étape.  
- **Prototype** : Si vous devez **cloner** des objets.  
- **Singleton** : Si vous devez garantir **une seule instance**.  

2️⃣ **Si vous avez un problème de structure entre objets :**  
- **Adapter** : Si vous avez des **interfaces incompatibles** à connecter.  
- **Bridge** : Si vous voulez **séparer abstraction et implémentation**.  
- **Composite** : Si vous avez une **hiérarchie d’objets** (ex: système de fichiers).  
- **Decorator** : Si vous devez **ajouter dynamiquement des fonctionnalités**.  
- **Facade** : Si vous voulez **simplifier un système complexe**.  
- **Flyweight** : Si vous devez **réduire la consommation mémoire**.  
- **Proxy** : Si vous voulez **contrôler l’accès à un objet**.  

3️⃣ **Si vous avez un problème d’interaction entre objets :**  
- **Chain of Responsibility** : Si plusieurs objets peuvent **gérer une requête en cascade**.  
- **Command** : Si vous voulez **encapsuler des actions en objets**.  
- **Iterator** : Si vous voulez **parcourir une collection sans exposer sa structure**.  
- **Mediator** : Si vous voulez **éviter des communications complexes** entre objets.  
- **Memento** : Si vous devez **sauvegarder/restaurer un état**.  
- **Observer** : Si **plusieurs objets doivent réagir aux changements** d’un autre objet.  
- **State** : Si un objet **change de comportement selon son état**.  
- **Strategy** : Si vous avez **plusieurs algorithmes interchangeables**.  
- **Template Method** : Si **l’algorithme est commun mais certaines étapes varient**.  
- **Visitor** : Si vous voulez **ajouter des opérations sans modifier les classes**.  

### **🚀 Conclusion**
Les design patterns sont des outils **puissants** pour structurer et optimiser votre code. Choisissez **le bon pattern** en fonction du **problème que vous souhaitez résoudre** ! 🎯

---
### Pour aller plus loin : https://refactoring.guru/fr/design-patterns/catalog
