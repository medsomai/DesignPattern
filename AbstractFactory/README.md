Le **Pattern Fabrique Abstraite (Abstract Factory)** est une extension du pattern Fabrique. Il permet de cr�er des familles d'objets li�s sans sp�cifier leurs classes concr�tes. Chaque "fabrique" concr�te est responsable de la cr�ation de variantes sp�cifiques d'objets.

### **Probl�me**
Vous souhaitez ajouter des documents qui supportent des modes de rendu diff�rents (par exemple, un rendu rapide et un rendu haute qualit�). Cela introduit une famille de documents avec des variantes bas�es sur le mode de rendu. Le pattern **Fabrique Abstraite** facilite la gestion de ces familles.

### **Solution**
Nous allons utiliser le pattern Fabrique Abstraite pour g�rer les diff�rentes variantes des documents.

### **Analyse**

1. **Probl�me R�solu** :
   - Vous g�rez une **famille d'objets** li�s (documents haute qualit� et documents rapides).
   - Le code client ne manipule que les interfaces (`IDocumentFactory` et `IDocument`), ce qui permet de facilement remplacer une famille de documents par une autre.

2. **Avantages** :
   - **Coh�rence** : Garantit que tous les documents cr��s appartiennent � la m�me famille (par exemple, tous "haute qualit�").
   - **Extensibilit�** : Ajout de nouvelles familles (par exemple, "documents compress�s") en cr�ant une nouvelle fabrique concr�te.
   - **D�couplage** : Le client ne conna�t pas les classes concr�tes des documents ou des fabriques.

3. **Limitation** :
   - Le nombre de fabriques peut augmenter si vous avez de nombreuses variantes, ce qui peut complexifier le code.

Le **Pattern Fabrique Abstraite** est id�al pour des syst�mes n�cessitant une extensibilit� pour g�rer plusieurs familles d'objets tout en maintenant un haut niveau de coh�sion et un faible couplage.