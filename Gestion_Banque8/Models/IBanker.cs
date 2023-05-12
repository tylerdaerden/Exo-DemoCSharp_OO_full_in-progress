using Gestion_Banque8.Models;
using gestionBanque8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBanque8.Interfaces
{
    public interface IBanker : ICustomer
    {

        Personne Titulaire { get; }
        string Numero { get; }
        void AppliquerInteret();
    }
}
