**Mediator** est un modèle de conception comportemental qui réduit le couplage entre les composants d'un programme en les faisant communiquer indirectement, via un objet médiateur spécial.  

## **Problème**
Lorsque plusieurs objets interagissent directement entre eux, le code devient fortement couplé, rendant difficile la maintenance et l'évolution du système.  
Chaque objet doit connaître tous les autres avec lesquels il communique, ce qui entraîne une **dépendance enchevêtrée**.  

**Exemple concret** :  
Un système de **chat** où plusieurs utilisateurs envoient des messages les uns aux autres.  
- Sans un médiateur, chaque utilisateur devrait maintenir une liste de contacts et gérer l’envoi des messages à chaque destinataire.  
- Cela complique le code et le rend peu évolutif.

## **Solution avec le Pattern Mediator**
Le **Médiateur** agit comme un hub central.  
- **Chaque objet communique uniquement avec le Médiateur**, qui relaie les messages aux destinataires appropriés.  
- Cela réduit le couplage entre objets et simplifie la communication.  

## **Implémentation en C# : Système de Chat**
Nous allons créer :
1. **IMediator** : Interface du médiateur.  
2. **ChatMediator** : Implémentation du médiateur qui gère les utilisateurs.  
3. **User (Colleague)** : Classe représentant un utilisateur du chat.  
4. **Program (Client)** : Simulation du chat.

## **Analyse**
1. **Le Médiateur (ChatMediator) centralise la communication** entre utilisateurs.  
2. **Les utilisateurs (User) ne connaissent pas directement les autres utilisateurs**, ils passent toujours par le médiateur.  
3. **Facilité d’ajout de nouveaux utilisateurs** sans modifier l’existant.  

## **Avantages**
**Découplage** : Les utilisateurs ne communiquent plus directement, ils passent par un médiateur.  
**Évolutivité** : On peut facilement ajouter de nouvelles fonctionnalités (ex: filtrage, logs).  
**Lisibilité** : La logique de communication est centralisée.  

## **Inconvénients**
**Point central de défaillance** : Si le médiateur devient trop complexe, il peut devenir difficile à maintenir.  
**Risque de surchargement** : Un médiateur mal conçu peut être surchargé si trop de logique y est ajoutée.  

## **Extensions possibles**
1. **Ajout de rôles** : Ex. utilisateurs normaux et administrateurs (AdminUser).  
2. **Filtres de messages** : Ex. empêcher certains mots ou spam.  
3. **Historique des messages** : Enregistrer les messages envoyés pour un journal de conversation.  

## **Résumé**
Le **pattern Mediator** est une excellente solution pour **éviter le couplage excessif** entre objets qui doivent communiquer.  
Il est **idéal pour des systèmes comme les chats, les notifications ou la gestion d'événements** où plusieurs éléments doivent interagir sans se connaître directement.