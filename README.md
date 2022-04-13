Les web services sont des composants web basés sur internet (HTTP), ils permettent aux applications de faire appel à des fonctionnalités à distance et de dialoguer à travers le réseau indépendament de leurs plate-forme d'éxécution et de leurs langage d'implémentation.

Dans cette activité pratique nous avons met en place un web service qui permet de définir quelque fonctionnalités qu'on peut appliqué sur un compte telque la conversion d'un montant de l'euro en DH, consulter un compte selon le code du compte et renvoyer une liste des comptes.

Après avoir créer notre web service (BanqueWS) en utilisant les annotations JaxWS, nous avons le déployer avec un simple Serveur JaxWS :

![image](https://user-images.githubusercontent.com/101976300/163058150-3fac633d-2736-4048-a5f3-65b72ba198e9.png)

En démarant le serveur on peut consulter et analyser le WSDL avec un Browser HTTP afin de récupérer la description au format xml de web service qui contient les méthodes pouvant être invoquées et leurs signatures :

![fichier_wsdl](https://user-images.githubusercontent.com/101976300/163059662-4c3a7f91-be86-4f70-9099-aa61f0bc8f19.PNG)

On peut également tester les opérations de web service en utilisant un outil telque SoapUI :

1- Tester la méthode conversionEuroToDH :

![teste_conversionEuroToDH_WS_SOAPUI](https://user-images.githubusercontent.com/101976300/163062621-0e8d1b7d-d914-42ec-ae0b-ec52d7133cec.PNG)

2- Tester la méthode getCompte :

![teste_getCompte_WS_SOAPUI](https://user-images.githubusercontent.com/101976300/163062747-840c8f61-ece3-48e4-9e07-f5382da6a51e.PNG)

3- Tester la méthode listComptes :

![teste_getListeComptes_WS_SOAPUI](https://user-images.githubusercontent.com/101976300/163063531-a68bf733-05a8-431e-8761-6b340289f5ef.PNG)

Qelques annotations JaxB :

JaxB offre beaucoup de flexibilité lors de l’interaction avec votre modèle objet :

=> Utiliser l'annotation @XmlRootElement(name = "compte") pour mapper la classe à un élément XML.
=> Utiliser l'annotation @XmlTransient pour indiquer que l'attribut n'est pas sérialisable.

![XmlTransient sur dateCreation)](https://user-images.githubusercontent.com/101976300/163066086-b2974c1f-d01d-422e-ac68-34266883217b.PNG)   
En utilisant SoapUI :
![teste_xmltransient_soapUI](https://user-images.githubusercontent.com/101976300/163066491-76f7956f-f52e-4ff8-99a4-e01c77ac19d9.PNG)

=> Utiliser l'annotation @XmlAccessorType(XmlAccessType.FIELD) pour utiliser les annotations sur les attributs. 

Par la suite nous avons crées un Client Soap Java, pour consommer le web service il faut tout d'abord générer le proxy à partir le WSDL : 

![generate java_code from wsdl](https://user-images.githubusercontent.com/101976300/163069673-cd701bb0-5326-4d22-ab6b-6f952eb2611e.PNG)

Après nous avons pu invoquer les méthodes de web service grâce au proxy généré :

![image](https://user-images.githubusercontent.com/101976300/163069342-bea09210-3ada-45ed-b1e8-ef23952423f0.png)

Vous pouvez Egalement générer le proxy en ligne de commande ou lieu d'utiliser un outil de IntelliJ ou d'autre IDE juste en tapant la ligne suivante au niveau de terminale :

![image](https://user-images.githubusercontent.com/101976300/163070283-6b5a2629-83fe-4a7e-ba54-95d0fefce55f.png)

De la meme façon qu'on a créer un client java on peut créer des clients avec d'autre langage telque c# :

![image](https://user-images.githubusercontent.com/101976300/163070557-d992200e-dffb-4bf7-98a3-2785c9506727.png)



