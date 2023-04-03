using Gestion_Banque2.Models;
#region Exo 1.1

// 1.1 Créer une classe « Banque » qui gérera les comptes de la banque
//Cette classe devra implémenter :
// Les propriétés :
// Comptes(KeyValuePair<string, Courant>[ ]) – Lecture seule
// Nom (string) -Nom de la banque
// Un indexeur retournant un compte sur base de son numéro.
// Les méthodes :
// void Ajouter(Courant compte)
// void Supprimer(string Numero)

Personne client1 = new Personne()
{

    Nom = "Doe",
    Prenom = "John",
    DateNaiss = new DateTime(1986, 02,17)
};

Personne client2 = new Personne()
{
    Nom = "Bar",
    Prenom = "Lenny",
    DateNaiss = new DateTime (1969 , 05 , 12)
};

Courant compte1 = new Courant()
{
    Numero = "0123456789",
    Solde = 10000,
    LignedeCredit = 250,
    Titulaire = client1
};

Courant compte2 = new Courant()
{
    Numero = "9876543210",
    Solde = 50000,
    LignedeCredit = 500,
    Titulaire = client2
};


Banque Arnaque = new Banque()
{
    Nom = "Bancarnaque" 

};

Arnaque.Ajouter(compte1);
Arnaque.Ajouter(compte2);

compte2.Depot(1000000);
compte1.Retrait(10000);

Console.WriteLine($"la Banque {Arnaque.Nom} gère {Arnaque.Comptes.Length} compte : dont le compte du cèlèbre {compte2.Titulaire.Prenom} {compte2.Titulaire.Nom} dont le compte est crédité à hauteur de {compte2.Solde}euros , tandis que ce clodo de {compte1.Titulaire.Prenom} {compte1.Titulaire.Nom} n'a que {compte1.Solde} balles "  );

Console.ReadLine();









#endregion