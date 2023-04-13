using Gestion_Banque6.Models;

#region 1.1 Abstract Done ! 

//1.Définir la classe « Compte » comme étant abstraite. 


Personne client1 = new Personne()
{
    Nom = "Doe",
    Prenom = "John",
    DateNaiss = new DateTime(1900,12,31),
};


Banque sympalestaux = new Banque()
{
    Nom = "TauxSympas",
};



#endregion

#region 1.2 Interet : Done ! 

//2.Ajouter une méthode abstraite « protected » à la classe « Compte » appelée « CalculInteret » ayant pour prototype « double CalculInteret »
//en sachant que pour un livret d’épargne le taux est toujours de 4.5% tandis que pour le compte courant si le solde est positif le taux sera de 3%
//sinon de 9.75%.

Courant courant1 = new Courant()
{
    Titulaire = client1,
    Numero = "0123456789",
    LignedeCredit = 250,
};

Epargne epargne1 = new Epargne()
{
    Numero = "9876543210",
    Titulaire = client1,
};

#endregion



#region Appliquer Interets : Done ! 

//3.Ajouter une méthode « public » à la classe « Compte » appelée « AppliquerInteret » qui additionnera le solde avec le retour de la méthode
//« CalculInteret ». 

courant1.Depot(10000);
Console.WriteLine($"le solde du compte courant {courant1.Numero} est de {courant1.Solde} ");

courant1.AppliquerInteret();

Console.WriteLine($"le solde du compte courant {courant1.Numero} après application des intérêts est de {courant1.Solde} ");


epargne1.Depot(20000);
Console.WriteLine($"le solde du compte épargne {epargne1.Numero} est de {epargne1.Solde} ");

epargne1.AppliquerInteret();
Console.WriteLine($"le solde du compte épargne {epargne1.Numero} après application des intérêts est de {epargne1.Solde} ");






#endregion
