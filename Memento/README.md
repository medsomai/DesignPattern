**Memento** est un mod�le de conception comportementale qui permet de prendre des instantan�s de l��tat d�un objet et de le restaurer ult�rieurement.

Le Memento ne compromet pas la structure interne de l�objet avec lequel il fonctionne, ainsi que les donn�es conserv�es dans les instantan�s.

## **Probl�me**  
Lorsqu'on travaille avec des objets qui subissent des modifications fr�quentes, il peut �tre n�cessaire de **r�tablir une version pr�c�dente** en cas d'erreur ou d'annulation.  

Par exemple, dans un �diteur de texte :  
- Un utilisateur peut vouloir **annuler** les modifications et revenir � un �tat pr�c�dent.  
- Stocker directement toutes les versions compl�tes peut **consommer trop de m�moire**.  

## **Solution avec le Pattern Memento**  
Le **Memento** permet de capturer et restaurer l'�tat d'un objet sans violer son **encapsulation**.  
- L'**origine (Originator)** cr�e un **instantan� (Memento)** de son �tat.  
- Un **gardien (Caretaker)** stocke ces instantan�s pour permettre un retour en arri�re.  

## **Avantages**
Permet de **r�tablir un �tat pr�c�dent** sans modifier directement l�objet.  
Garde l�**encapsulation** de l�objet (le Caretaker ne conna�t pas les d�tails internes).  
Fonctionne bien pour les **syst�mes d�annulation** et **gestion des historiques**.  

## **Inconv�nients**
Peut **consommer beaucoup de m�moire** si les mementos sont volumineux.  
La **gestion de l�historique** peut devenir complexe si mal impl�ment�e.  

## **Cas d'utilisation du pattern Memento**
**�diteurs de texte** (annuler/r�tablir).  
**Jeux vid�o** (sauvegarde d��tat).  
**Formulaires complexes** (retour en arri�re).  
**Base de donn�es** (revenir � une version pr�c�dente des donn�es).  

Ce pattern est tr�s utile dans les applications n�cessitant **un suivi de l�historique et la possibilit� d�annuler des actions**.