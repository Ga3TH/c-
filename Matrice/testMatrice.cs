using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    internal class testMatrice
    {
        static void main()
        {
            Console.WriteLine("1 - multiplier par scalaire");
            Console.WriteLine("2 - Additionner");
            Console.WriteLine("3 - Soustraction");
            Console.WriteLine("4 - multiplication");
            Console.WriteLine("5 - Transposer");
            int choix = int.Parse(Console.ReadLine());
            switch (choix) { 
                case 1:
                    
                    ClasseMatrice M = new ClasseMatrice(3,2,-1);
                    ClasseMatrice B = new ClasseMatrice(3, 2, -1);
                    Console.WriteLine(M.Addition(B));
                    break;
            }
            
        }

    }
}
