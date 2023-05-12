using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque8.Models
{
	public class Epargne : Compte
	{
		#region Attributs

		private DateTime _Datedernierretrait;
		private double _SoldeEpargne;

		#endregion

		#region Props

		public double SoldeEpargne

		{
			get { return _SoldeEpargne; }
			private set { _SoldeEpargne = value; }
			//lecture seule
		}

		public DateTime Datedernierretrait
		{
			get { return _Datedernierretrait; }
			private set { _Datedernierretrait = value; }
		}

        #endregion

        #region Constructeurs
        public Epargne(string numero, double solde, Personne titulaire, DateTime Dernierretrait) : base(numero, solde, titulaire)
        {
            this.Datedernierretrait = Dernierretrait;
        }

        public Epargne(string numero, Personne titulaire) : this(numero, 0 , titulaire , DateTime.Now)
        {
            // la construction est gerée au niveau du compte (constructeurs parent), récupère les infos parents
        }
        #endregion


        #region Methodes

        public override void Retrait (double montant)
		{
            if (montant <= 0)
            {
                Console.WriteLine("montant trop faible");
                return;
            }
            if (_SoldeEpargne - montant <= 0)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }                  
                _SoldeEpargne -= montant;
				//je set ma date retrait 👇
				_Datedernierretrait = DateTime.Now;  
            
        }

        protected override double CalculInteret()
        {
            // pour un livret d’épargne le taux est toujours de 4.5%
            return Solde * 0.045;
        }



        #endregion

    }
}
