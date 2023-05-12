namespace Gestion_Banque8.Models
{
    public interface ICustomer
    {
        double Solde { get; }

        void Depot(double montant);
        void Retrait(double montant);
    }
}