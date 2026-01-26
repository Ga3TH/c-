using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    internal class ClasseMatrice
    {
        int[,] coefficients;
        int ordre;

        public ClasseMatrice(int pOrdre, int pMin, int pMax)
        {
            Random rand = new Random();
            int ordre = pOrdre;
            for (int i = 0; i <= ordre; i++)
            {
                for (int j = 0; j <= ordre; j++)
                {
                    coefficients[i,j] = rand.Next(pMin, pMax);
                }
            }
        }
        public ClasseMatrice(int[,] pTableau)
        {
            coefficients = pTableau;
        }
        public ClasseMatrice MultiplierParScalaire(int scalaire)
        {
            int[,] tabScalaire = new int[ordre, ordre];
            for (int i = 0; i < ordre; i++) 
            { 
                for (int j = 0;j < ordre; j++) 
                {
                    tabScalaire[i,j] = coefficients[i,j] * scalaire;
                    
                }
            }
            
            return new ClasseMatrice(tabScalaire);
        }
        public ClasseMatrice Addition(ClasseMatrice m)
        {

            int[,] tabScalaire = new int[ordre, ordre];
            for (int i = 0; i < ordre; i++)
            {
                for (int j = 0; j < ordre; j++)
                {
                    tabScalaire[i, j] = coefficients[i, j] + m;
                }
            }
            return new ClasseMatrice(tabScalaire);
        }
    }   
}
