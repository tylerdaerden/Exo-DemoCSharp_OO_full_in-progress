using Gestion_Banque4.Models;
using System.Data;

#region Exos Héritge et surcharge méthodes




#region Exo 1.1 DONE ! 
//Exo 1.1
//Créer une classe « Epargne » permettant la gestion d’un carnet d’épargne qui devra implémenter
//Les propriétés publiques :
//Numéro(string)
//Solde(double) - Lecture seule
//DateDernierRetrait (DateTime) -représentant la date du dernier retrait sur le carnet
//Titulaire (Personne)
//Les méthodes publiques :
//void Retrait(double Montant)
//void Depot(double Montant)  


Personne client1 = new Personne()
{
    Nom="Doe",
    Prenom="John",
    DateNaiss=new DateTime(1900 , 12 , 31)
    
};

Personne client2 = new Personne()
{
    Nom = "Durden",
    Prenom="Tyler",
    DateNaiss=new DateTime(1999 , 12 , 31)

};

Epargne Epargne1 = new Epargne()
{
    Numero = "0123456789",
    Titulaire = client1  

};

Epargne1.Depot(100000);
Console.WriteLine($"le solde du compte épargne de {Epargne1.Titulaire.Nom} est de {Epargne1.Solde} ");
Epargne1.Retrait (50000);
Console.WriteLine($"le nouveau solde du compte épargne de {Epargne1.Titulaire.Nom} est de {Epargne1.Solde} , retrait effectué le {Epargne1.Datedernierretrait} ");









#endregion

#region Exo 1.2 DONE (à moitié , faudra trouver alternative à protected pour que EPARGNE RETRAIT MARCHE)
//Exo 1.2
//2.Définir la classe « Compte » reprenant les parties commune aux classes « Courant » et « Epargne » en utilisant les concepts d’héritage, de
//redéfinition de méthodes et si besoin, de surcharge de méthodes et d’encapsulation.
//Attention le niveau d’accessibilité du mutateur de la propriété Solde doit rester « private ». 











#endregion
#endregion