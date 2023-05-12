using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque8.Interfaces
{
    public interface ICustomer
    {
        double Solde { get; }
        
        void Depot(double montant);

        void Retrait (double montant);

    }
}
