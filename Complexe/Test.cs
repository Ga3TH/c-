using System;
using static TP20.Program;
namespace TP20
{
    internal class Test
    {
        static void Main()
        {
            int choix;
            int val1, val2;
            bool continuer;
            Complexe[] Tab = new Complexe[10];
            int posLibre = 0;

            do
            {
                Console.WriteLine("1. Afficher la somme de deux nombres complexes saisis par l’utilisateur");
                Console.WriteLine("2. Afficher la soustraction de deux nombres complexes saisis par l’utilisateur");
                Console.WriteLine("3. Afficher le produit de deux nombres complexes saisis par l’utilisateur");
                Console.WriteLine("4. Afficher l’inverse d’un nombre complexe saisi par l’utilisateur");
                Console.WriteLine("5. Afficher le module d’un nombre complexe saisi par l’utilisateur");
                Console.WriteLine("6. Ajouter un Complexe dans un tableau");
                Console.WriteLine("7. Faire la somme des nombres complexes du tableau");
                Console.WriteLine("8. Quitter");
                Console.WriteLine("Votre choix : ");
                choix = int.Parse(Console.ReadLine());
                continuer = true;


                switch (choix)
                {

                    case 1:
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe add1 = new Complexe(val1, val2);
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe add2 = new Complexe(val1, val2);
                        Console.WriteLine(add1.Addition(add2));

                        break;

                    case 2:
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe sous1 = new Complexe(val1, val2);
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe sous2 = new Complexe(val1, val2);
                        Console.WriteLine(sous1.Soustraction(sous2));
                        break;

                    case 3:
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe mul1 = new Complexe(val1, val2);
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe mul2 = new Complexe(val1, val2);
                        Console.WriteLine(mul1.Produit(mul2));
                        break;

                    case 4:
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe inv = new Complexe(val1, val2);
                        Console.WriteLine(inv.Inverse());
                        break;

                    case 5:
                        Console.WriteLine("Partie réelle ?");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Partie imaginaire ?");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe rac = new Complexe(val1, val2);
                        Console.WriteLine(rac.GetModule());
                        break;

                    case 6:
                        if (posLibre < Tab.Length)
                        {
                            Console.WriteLine("Partie réelle ?");
                            val1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Partie imaginaire ?");
                            val2 = int.Parse(Console.ReadLine());

                            Tab[posLibre] = new Complexe(val1, val2);
                            posLibre += 1;

                            Console.WriteLine("Complexe ajouté au tableau.");
                        }
                        else
                        {
                            Console.WriteLine("Le tableau est plein !");
                        }
                        break;

                    case 7:
                        if (posLibre == 0)
                        {
                            Console.WriteLine("Le tableau est vide !");
                        }
                        else
                        {
                            Complexe somme = new Complexe(0, 0);
                            for (int i = 0; i < posLibre; i++)
                            {
                                somme = somme.Addition(Tab[i]);
                            }
                            Console.WriteLine("Somme des complexes du tableau :");
                            Console.WriteLine(somme);
                        }
                        break;

                    case 8:
                        Console.WriteLine("Au revoir !");
                        continuer = false;
                        break;

                    default:
                        Console.WriteLine("Choix invalide !");
                        break;
                }

            } while (continuer);
        }
    }
}