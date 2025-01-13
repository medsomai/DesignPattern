Le **pattern Builder** (Constructeur) est un patron de conception utilisé pour construire des objets complexes étape par étape. Contrairement au pattern Fabrique, qui retourne un objet en une seule méthode, le Builder permet de créer un objet en configurant progressivement ses différents aspects.

### **Problème**
Vous devez créer un objet complexe ayant de nombreuses propriétés, mais toutes les propriétés ne sont pas obligatoires, et leur configuration peut varier selon les besoins. Par exemple, dans une application de gestion de commandes, une commande peut inclure plusieurs attributs comme l’adresse de livraison, les articles, le mode de paiement, etc. Configurer un tel objet en utilisant un constructeur avec beaucoup de paramètres peut rendre le code peu lisible et difficile à maintenir.

### **Solution**
Le **pattern Builder** permet de créer un objet complexe en séparant la construction de ses différentes parties. Chaque partie peut être configurée indépendamment, et le Builder garantit que l’objet final est complet et cohérent.

### **Analyse**

1. **Problème Résolu** :
   - Éviter un constructeur avec un nombre excessif de paramètres, rendant le code difficile à lire.
   - Permettre une configuration flexible et progressive de l'objet `Order`.
   - Fournir un mécanisme pour valider l'objet final avant qu'il ne soit retourné.

2. **Avantages** :
   - **Lisibilité** : Le processus de création est clair et lisible grâce à la méthode "en chaîne" (chaining).
   - **Flexibilité** : Vous pouvez configurer uniquement les parties de l'objet dont vous avez besoin.
   - **Validation** : Le Builder peut effectuer une validation avant de créer l'objet final.

3. **Limitations** :
   - Le pattern ajoute de la complexité si l'objet à construire est simple.
   - La classe Builder doit être maintenue séparément.

4. **Extensions possibles** :
   - Ajouter des sous-classes pour des variantes spécifiques de `Order`.
   - Supporter des pré-configurations communes en fournissant des méthodes spécifiques (par exemple, `SetStandardDelivery()`).

Le **pattern Builder** est particulièrement utile pour les objets complexes avec beaucoup d'attributs facultatifs ou qui nécessitent des étapes spécifiques pour leur construction.