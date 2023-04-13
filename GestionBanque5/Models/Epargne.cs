using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque5.Models
{
	public class Epargne : Compte
	{
		#region Attributs

		//private Personne _Titulaire = new Personne();
		private DateTime _Datedernierretrait;
		//private string _Numero;
		private double _SoldeEpargne;

		#endregion

		#region Props

		public double SoldeEpargne

		{
			get { return _SoldeEpargne; }
			private set { _SoldeEpargne = value; }
			//lecture seule
		}
		//public string Numero
		//{
		//	get { return _Numero; }
		//	set { _Numero = value; }
		//}
		public DateTime Datedernierretrait
		{
			get { return _Datedernierretrait; }
			private set { _Datedernierretrait = value; }
		}
        //public Personne Titulaire
        //{
        //    get { return _Titulaire; }
        //    set { _Titulaire = value; }
        //}

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

		//public override void Depot(double montant)
		//{
		//	if (montant <= 0)
		//	{
		//		Console.WriteLine("montant trop faible");
		//		return;
		//	}
		//	SoldeEpargne += montant;

		//}

		#endregion

	}
}
