using Gestion_Banque8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque8.Interfaces
{
    internal interface IBanker : ICustomer
    {
        Personne Titulaire { get; }

        string Numero { get; }

        void AppliquerInteret();


    }
}
