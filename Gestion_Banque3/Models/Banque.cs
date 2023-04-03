﻿using Gestion_Banque3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque3.Models
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

        public void Ajouter(Courant c)
        {
            _Comptes.Add(c.Numero, c);
        }

        public void Supprimer(string numero)
        {
            _Comptes.Remove(numero);
        }




        #endregion

        #endregion






        #region Props





        #endregion



        #region Methodes

        public double AvoirdesComptes(Personne p)
        {
            double avoir = 0;
            foreach (KeyValuePair<string, Courant> kvp in Comptes)
            {

                if (kvp.Value.Titulaire == p)
                {
                    avoir += kvp.Value;
                }
            }
                return avoir;


        }




        #endregion

    }
}
