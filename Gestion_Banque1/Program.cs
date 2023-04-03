#region Exos

#region 1.1 Personne

//1 .Créer une classe « Personne » qui devra implémenter
//Les propriétés publiques :
//Nom(string)
//Prenom(string)
//DateNaiss(DateTime) - date de naissance

using Gestion_Banque1.Models;
using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;

Personne Client1 = new Personne();
Client1.Nom = "Doe";
Client1.Prenom = "John";
Client1.DateNaiss = new DateTime(1900, 01, 01);
Console.WriteLine(Client1.Prenom);
Console.WriteLine(Client1.Nom);
Console.WriteLine(Client1.DateNaiss);

Personne Client2 = new Personne() // autre méthode pour instancier (plus rapide)
{
    Nom = "Doe2",
    Prenom = "John2",
    DateNaiss = new DateTime(1900, 12, 31)
};

Personne Client3 = new(); // marche aussi, pas top 

Console.WriteLine("________________________");

#endregion

#region 1.2 Courant

//2. Créer une classe « Courant » permettant la gestion d’un compte courant qui devra implémenter
//Les propriétés publiques :
//Numéro(string)
//Solde(double) - Lecture seule
//LigneDeCredit(double) - représentant la limite négative du compte strictement supérieur ou égale à 0
//Titulaire (Personne)
//Les méthodes publiques :
//void Retrait(double Montant)
//void Depot(double Montant)

Console.WriteLine("Exo 1.2");


Courant courant = new Courant();

courant.Numero = "0123456789";
courant._Solde = 100;
courant.LignedeCredit = 100;
courant.Titulaire = Client1;

Console.WriteLine($"le titulaire du compte {courant.Numero} est {courant.Titulaire.Nom} {courant.Titulaire.Prenom} né le {courant.Titulaire.DateNaiss} ");

Console.WriteLine($"Solde avant depot = {courant.Solde}");
courant.Depot(100);
Console.WriteLine($"Solde après depot = {courant.Solde}");
courant.Retrait(150);
Console.WriteLine($"Solde après retrait = {courant.Solde}");


Courant courant2 = new Courant() // autre méthode instanciation
{
    Numero = "1",
    LignedeCredit = 100,
    Titulaire = new Personne()
    {
        Nom = "Bean",
        Prenom = "Mister",
        DateNaiss = new DateTime(1900 , 01 , 01)

    }
};


Console.WriteLine("______________________________________");







#endregion






















#endregion