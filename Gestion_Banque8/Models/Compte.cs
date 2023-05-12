using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque8.Models
{
    public abstract class Compte
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
            private set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            private set { _Titulaire = value; }
        }

        #endregion



        #region Constructeurs

        public Compte(string numero, double solde, Personne titulaire)
        {
            _Numero = numero;
            _Solde = solde;
            _Titulaire = titulaire;
        }
        public Compte(string numero,  Personne titulaire ) : this(numero, 0, titulaire)
        {
           // déja présent dans le constructeur frère/soeur 
        }
        #endregion



        #region Methodes

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

        protected abstract double CalculInteret();

        public virtual void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        #endregion


    }
}
