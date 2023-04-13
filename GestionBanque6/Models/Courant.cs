using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque6.Models
{
    public class Courant : Compte
    {

        #region Attributs

        public double _Solde; // on peut passer par un decimal (reccommandé)
        private double _LignedeCredit; // on peut passer par un decimal (reccommandé)

        #endregion

        #region Props


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


        #endregion

        #region Methodes

        /// <summary>
        /// (Ma petite méthode) retire un montant au solde
        /// </summary>
        /// <param name="montant"> el famoso montant, comme dit Yves</param>

        public override void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("montant trop faible");
                return;
            }
            else if (Solde - montant <= -LignedeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }
            else
            {
                Solde -= montant;
            }
        }

        public override void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant trop faible pour un retrait");
                return;

            }
            _Solde += montant;
        }



        public static double operator +(double solde, Courant c)
        {
            return solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }

        protected override double CalculInteret()
        {
            // pour le compte courant si le solde est positif le taux sera de 3% sinon de 9.75 %.

            // en ternaire (tips de thierry je peux mettre le "solde *" devant la vérification du solde pour raccourcir encore 
            return Solde * ((Solde <= 0) ?  0.0975 :  0.03);
        }

        public override void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        #endregion

    }
}
