**Mediator** est un mod�le de conception comportemental qui r�duit le couplage entre les composants d'un programme en les faisant communiquer indirectement, via un objet m�diateur sp�cial.  

## **Probl�me**
Lorsque plusieurs objets interagissent directement entre eux, le code devient fortement coupl�, rendant difficile la maintenance et l'�volution du syst�me.  
Chaque objet doit conna�tre tous les autres avec lesquels il communique, ce qui entra�ne une **d�pendance enchev�tr�e**.  

**Exemple concret** :  
Un syst�me de **chat** o� plusieurs utilisateurs envoient des messages les uns aux autres.  
- Sans un m�diateur, chaque utilisateur devrait maintenir une liste de contacts et g�rer l�envoi des messages � chaque destinataire.  
- Cela complique le code et le rend peu �volutif.

## **Solution avec le Pattern Mediator**
Le **M�diateur** agit comme un hub central.  
- **Chaque objet communique uniquement avec le M�diateur**, qui relaie les messages aux destinataires appropri�s.  
- Cela r�duit le couplage entre objets et simplifie la communication.  

## **Impl�mentation en C# : Syst�me de Chat**
Nous allons cr�er :
1. **IMediator** : Interface du m�diateur.  
2. **ChatMediator** : Impl�mentation du m�diateur qui g�re les utilisateurs.  
3. **User (Colleague)** : Classe repr�sentant un utilisateur du chat.  
4. **Program (Client)** : Simulation du chat.

## **Analyse**
1. **Le M�diateur (ChatMediator) centralise la communication** entre utilisateurs.  
2. **Les utilisateurs (User) ne connaissent pas directement les autres utilisateurs**, ils passent toujours par le m�diateur.  
3. **Facilit� d�ajout de nouveaux utilisateurs** sans modifier l�existant.  

## **Avantages**
**D�couplage** : Les utilisateurs ne communiquent plus directement, ils passent par un m�diateur.  
**�volutivit�** : On peut facilement ajouter de nouvelles fonctionnalit�s (ex: filtrage, logs).  
**Lisibilit�** : La logique de communication est centralis�e.  

## **Inconv�nients**
**Point central de d�faillance** : Si le m�diateur devient trop complexe, il peut devenir difficile � maintenir.  
**Risque de surchargement** : Un m�diateur mal con�u peut �tre surcharg� si trop de logique y est ajout�e.  

## **Extensions possibles**
1. **Ajout de r�les** : Ex. utilisateurs normaux et administrateurs (AdminUser).  
2. **Filtres de messages** : Ex. emp�cher certains mots ou spam.  
3. **Historique des messages** : Enregistrer les messages envoy�s pour un journal de conversation.  

## **R�sum�**
Le **pattern Mediator** est une excellente solution pour **�viter le couplage excessif** entre objets qui doivent communiquer.  
Il est **id�al pour des syst�mes comme les chats, les notifications ou la gestion d'�v�nements** o� plusieurs �l�ments doivent interagir sans se conna�tre directement.