using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque1.Models
{
    internal class Courant
    {

        #region Attributs

        public string _Numero;
        public double _Solde;
        private double _LignedeCredit;
        private Personne _Titulaire;

        #endregion

        #region Props

        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            set { _Solde = value; }
        }

        public double LignedeCredit
        {
            get { return _LignedeCredit; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Ligne de Crédit insuffisante");
                return;
            }
        }


        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }

        #endregion

        #region Methodes


        public void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("montant trop faible");
                return;
            }
            else if (_Solde - montant <= -_LignedeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }
            else
            {
                _Solde = _Solde - montant;
            }

        }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant trop faible pour un retrait");
                return;

            }

            _Solde = _Solde + montant;
        }

        #endregion

    }
}
