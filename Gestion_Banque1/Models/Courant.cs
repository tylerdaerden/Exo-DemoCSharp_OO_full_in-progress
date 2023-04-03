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
        public double _Solde; // on peut passer par un decimal (reccommandé)
        private double _LignedeCredit; // on peut passer par un decimal (reccommandé)
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
                {
                    Console.WriteLine("Ligne de Crédit ne peut être négative");
                    return;
                }
                else
                    _LignedeCredit = value;
            }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }
        #endregion

        #region Methodes


        /// <summary>
        /// (Ma petite méthode) retire un montant au solde
        /// </summary>
        /// <param name="montant"> el famoso montant, comme dit Yves</param>

        public void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("montant trop faible");
                return;
            }
            else if ( Solde - montant <= -LignedeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }
            else
            {
                Solde -= montant;
            }
        }

        /// <summary>
        /// (ma 2ème petite methode) ajoute un montant au solde 
        /// </summary>
        /// <param name="montant"></param>

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant trop faible pour un retrait");
                return;

            }
            _Solde += montant;
        }

        #endregion

    }
}
