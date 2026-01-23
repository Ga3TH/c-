using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp20._2._2
{
    public class Entree
    {
        private string cle;
        private object valeur;

        public Entree(string pCle, object pValeur)
        {
            cle = pCle;
            valeur = pValeur;
        }
        public string GetCle()
        {
            return cle;
        }

        public object GetValeur()
        {
            return valeur;
        }

        public override string ToString()
        {
            string chaine = "";
            chaine = " la clé :" + cle.ToString() + " , la valeur :" + valeur.ToString();
            return chaine;
        }
    }
}
