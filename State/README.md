L'**�tat** est un mod�le de conception comportementale qui permet � un objet de modifier son comportement lorsque son �tat interne change.

Le mod�le extrait les comportements li�s � l'�tat dans des classes d'�tat distinctes et force l'objet d'origine � d�l�guer le travail � une instance de ces classes, au lieu d'agir seul.

### **Probl�me**  
Lorsqu'un objet poss�de plusieurs **�tats internes** qui influencent son comportement, il peut �tre **difficile � g�rer** avec de simples conditions `if` ou `switch`.  

Par exemple, dans une **machine � distributeur de billets** :  
- Elle a diff�rents **�tats** : **Pr�t, Carte ins�r�e, Code saisi, Retrait en cours, �puis�**.  
- � chaque changement d'�tat, **les actions disponibles varient**.  
- G�rer tout cela avec des `if/else` peut rendre le code **complexe et difficile � maintenir**.  

### **Solution avec le Pattern State**  
Le **pattern State** permet de **remplacer des structures conditionnelles complexes** en encapsulant chaque **�tat** dans une classe distincte.  
- L'objet principal **(Contexte)** d�l�gue son comportement � des **classes d'�tat**.  
- Cela permet de **changer dynamiquement de comportement** sans modifier le contexte.  

### **Exemple en C# : Machine � Distributeur Automatique**  

Nous allons cr�er une machine ayant **trois �tats** :  
1. **Sans carte** ? L'utilisateur doit ins�rer une carte.  
2. **Carte ins�r�e** ? L'utilisateur doit entrer son code.  
3. **Code valid�** ? L'utilisateur peut retirer de l'argent.  

### **Avantages**
**Supprime les conditions complexes (`if/else`, `switch`)** et rend le code plus clair.  
**Facilite l'ajout de nouveaux �tats** sans modifier le contexte.  
**Encapsulation** : chaque �tat est une classe distincte avec son propre comportement.  

### **Inconv�nients**
**Peut entra�ner une explosion de classes** si de nombreux �tats sont n�cessaires.  
**La transition entre �tats doit �tre bien d�finie** pour �viter des incoh�rences.  

### **Cas d'utilisation du pattern State**
- **Distributeurs automatiques** (changement d��tat selon les actions de l�utilisateur).  
- **Machines � �tat** (ex: gestion des commandes dans un e-commerce).  
- **Jeux vid�o** (ex: changement d��tat d�un personnage : attaquer, d�fendre, courir).  
- **Workflow de documents** (ex: Brouillon ? En r�vision ? Approuv� ? Publi�).  

Ce pattern est **indispensable** pour g�rer des objets ayant **un comportement dynamique en fonction de leur �tat interne**.