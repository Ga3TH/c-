using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp20._2._2;
namespace prtout
{
    internal class Test
    {
        static void Main()
        {
            Collection MaCollection;
            MaCollection = new Collection();
            Console.WriteLine(MaCollection.Ajouter("22", new String("212h1jgh"))); // retourne True
            Console.WriteLine(MaCollection.Ajouter("35", "Ille Et Vilaine")); // retourne True
            Console.WriteLine(MaCollection.Ajouter("29", "Finistère")); // retourne True
            Console.WriteLine(MaCollection.Ajouter("56", "Morbihan")); // retourne True
            Console.WriteLine(MaCollection.Retourner("29"));
            Console.WriteLine(MaCollection.ToString());
            Console.WriteLine(MaCollection.NombreDElements());
            Console.WriteLine(MaCollection.Existe("35"));
            Console.WriteLine(MaCollection.Supprimer("22")); // retourne True
            Console.WriteLine(MaCollection.Supprimer("29")); // retourne True
            Console.WriteLine(MaCollection.ToString());

            Console.ReadLine();   
        }
    }
}