**Memento** est un modèle de conception comportementale qui permet de prendre des instantanés de l’état d’un objet et de le restaurer ultérieurement.

Le Memento ne compromet pas la structure interne de l’objet avec lequel il fonctionne, ainsi que les données conservées dans les instantanés.

## **Problème**  
Lorsqu'on travaille avec des objets qui subissent des modifications fréquentes, il peut être nécessaire de **rétablir une version précédente** en cas d'erreur ou d'annulation.  

Par exemple, dans un éditeur de texte :  
- Un utilisateur peut vouloir **annuler** les modifications et revenir à un état précédent.  
- Stocker directement toutes les versions complètes peut **consommer trop de mémoire**.  

## **Solution avec le Pattern Memento**  
Le **Memento** permet de capturer et restaurer l'état d'un objet sans violer son **encapsulation**.  
- L'**origine (Originator)** crée un **instantané (Memento)** de son état.  
- Un **gardien (Caretaker)** stocke ces instantanés pour permettre un retour en arrière.  

## **Avantages**
Permet de **rétablir un état précédent** sans modifier directement l’objet.  
Garde l’**encapsulation** de l’objet (le Caretaker ne connaît pas les détails internes).  
Fonctionne bien pour les **systèmes d’annulation** et **gestion des historiques**.  

## **Inconvénients**
Peut **consommer beaucoup de mémoire** si les mementos sont volumineux.  
La **gestion de l’historique** peut devenir complexe si mal implémentée.  

## **Cas d'utilisation du pattern Memento**
**Éditeurs de texte** (annuler/rétablir).  
**Jeux vidéo** (sauvegarde d’état).  
**Formulaires complexes** (retour en arrière).  
**Base de données** (revenir à une version précédente des données).  

Ce pattern est très utile dans les applications nécessitant **un suivi de l’historique et la possibilité d’annuler des actions**.