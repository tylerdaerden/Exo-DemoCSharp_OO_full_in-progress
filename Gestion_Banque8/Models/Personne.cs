using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque8.Models
{
    public class Personne
    {
        #region Attributs
        private string _Nom;
        private string _Prenom;
        private DateTime _DateNaiss;
        #endregion

        #region Prop's
        public string Nom
        {
            get { return _Nom; }
            private set { _Nom = value; }
        }

        public string Prenom
        {
            get { return _Prenom; }
            private set { _Prenom = value; }
        }

        public DateTime DateNaiss
        {
            get { return _DateNaiss; }
            private set { _DateNaiss = value; }
        }

        #endregion

        #region Contructeurs

        public Personne(string nom, string prenom, DateTime datenaiss)
        {
            _Nom = nom;
            _Prenom = prenom;
            _DateNaiss = datenaiss;
        }

        #endregion
    }
}
