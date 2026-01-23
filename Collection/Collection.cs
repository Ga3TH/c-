using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tp20._2._2
{
    internal class Collection
    {
        private const int MAX = 10;
        private Entree[] tabCollection = new Entree[MAX];
        private int pos_Libre;

        public Collection()
        {
            pos_Libre = 0;
        }

        public bool Ajouter(string cle, object valeur)
        {
            if (pos_Libre <= MAX)
            {
                tabCollection[pos_Libre] = new Entree(cle, valeur);
                pos_Libre++;
                return true;
            }
            return false;
        }

        public object Retourner(string pCle)
        {
            for (int i =0; i< pos_Libre; i++) 
            {
                if (tabCollection[i].GetCle() == pCle) {
                    return tabCollection[i].GetValeur();
                }
            }
            return null;
        }

        public bool Supprimer(string cle)
        {
            for (int i = 0; i < pos_Libre; i++)
            {
                if (tabCollection[i].GetCle() == cle)
                {
                    for (int k = i; k <= pos_Libre; k++)
                    {
                        tabCollection[k] = tabCollection[k + 1];
                    }
                }
                pos_Libre--;
                return true;
            }
            return false;
        }

        public bool Existe(string cle)
        {
            for (int i = 0; i < pos_Libre; i++)
            {
                if (tabCollection[i].GetCle() == cle)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Vide()
        {
            pos_Libre = 0;
            return true;
        }

        public int NombreDElements()
        {
            return pos_Libre;
        }

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < pos_Libre; i++)
            {
                result = result + tabCollection[i].ToString() + "\n" ;
            }
            return result;
        }
    }
}

