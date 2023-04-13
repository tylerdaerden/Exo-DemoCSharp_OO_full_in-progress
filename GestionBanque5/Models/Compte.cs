using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque5.Models
{
    public class Compte
    {
        #region Attributs

        private string _Numero;
        private double _Solde;
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
            private set { _Solde = value; }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }

        #endregion

        public virtual void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant trop faible pour un retrait");
                return;

            }
            _Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant trop faible pour un retrait");
                return;

            }
            if (Solde - montant < 0) 
            {
                Console.WriteLine("opération impossible , solde insuffisant");
                return;
            }
            _Solde -= montant;
        }

        public static double operator +(double solde, Compte compte)
        {
            //if (c.Solde < 0)
            //{
            //    return solde + 0.0;
            //}

            //else
            //{
            //    return solde + c.Solde;
            //}

            //ternaire
            return solde + ((compte.Solde < 0.0) ? 0.0 : compte.Solde);

        }

    }
}
