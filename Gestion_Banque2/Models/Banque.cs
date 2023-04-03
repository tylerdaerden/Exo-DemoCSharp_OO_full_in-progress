using Gestion_Banque2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque2.Models
{
    public class Banque
    {
        #region Attributs

        private string _Nom;

        public Dictionary<string, Courant> _Comptes = new Dictionary<string, Courant>();

        #endregion

        #region prop's

        public Courant this[string numero]
        {
            get
            {
                Courant c = new Courant();
                _Comptes.TryGetValue(numero, out c);
                return c;
            }
        }

        public KeyValuePair<string, Courant>[] Comptes
        {
            get { return _Comptes.ToArray(); }
        }
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }


        #region Methodes





        #endregion







        #endregion






        #region Props





        #endregion



        #region Methodes




        #endregion

    }
}
