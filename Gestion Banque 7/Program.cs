using Gestion_Banque7.Models;
using System.Net;
using System.Threading.Channels;

#region Exo 1

//Ajoutez, dans la classe « Compte », deux constructeurs prenant en paramètre :
//1.Le numéro et le titulaire
//2.Le numéro, le titulaire et le solde (pour le cas d’une base de données)

Personne personne1 = new Personne("Jhon", "Doe", new DateTime(1980, 05, 15));

Courant courant1 = new Courant("0000000001", personne1);

courant1.Depot(1500);
Console.WriteLine($"le solde de courant 1 est de {courant1.Solde} " );

courant1.Retrait(1600);
Console.WriteLine($"solde courant 1 = {courant1.Solde}");


Epargne epargne1 = new Epargne("0000000002", 2000, personne1, new DateTime());

epargne1.Retrait(1000);

#endregion

#region Exo 2

//2. Le cas échéant, ajoutez le ou les constructeurs aux classes « Courant » et « Epargne ».



#endregion



#region Exo 3

//3. Ajouter à la classe « Courant » un constructeur recevant en paramètre le numéro, le titulaire et la ligne de crédit.



#endregion




#region Exo 4

//4. Changer l’encapsulation des propriétés des classes « Personne », « Compte » et « Epargne » afin de spécifier leur mutateur en « private ».



#endregion


#region Exo 5

//5.Définir ce qu’il manque pour que le programme continue à tourner.




#endregion