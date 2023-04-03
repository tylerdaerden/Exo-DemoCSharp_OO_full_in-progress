using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_demo_03042023.Models
{
    public enum Genres // bien penser à mettre les enum en public (sinon par défaut elles vont se mettre en internal) => prendre cette habitude
    {
        Homme,
        Femme,
        Autre

    }
    public class Personne
    {

        public string Name { get; set; }
        public Genres Genre { get; set; }
    }
}
