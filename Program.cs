using System.Xml.Linq;

namespace exercice
{
    internal class Program
    {
        /*
        static int Multiplier(int a , int b )
        {
            return a * b;
        }
        static int Multiplier(int a , int b , int c )
        {
            return a * b * c;
        }

        static int Multiplier(int[] tableau)
        {
            int produit = 1;
            foreach (int n in tableau)
            {
                produit = n * produit;
            }
            return produit;
        }*//*

        static void Main(string[] args)
        {
            Console.WriteLine($"{Multiplier(2, 3)}");
            Console.WriteLine($"{Multiplier(2, 3, 4)}");
            int[] tableauOriginal = { 10, 12, 15, 14 };
            Console.WriteLine($"{Multiplier(tableauOriginal)}");
        }
    }
};
*/
        // Exercice 5 : Static ou instance ?
        /*        void BonjourPersonnalise(string nom)
                    {
                        Console.WriteLine($"Bonjour {nom}");
                    }
                    static void BonjourGlobal()
                    {
                        Console.WriteLine("Bonjour les gens");
                    }
                    static void Main(string[] args)
                    {
                        Program.BonjourGlobal();
                        Program program = new Program();
                        program.BonjourPersonnalise("Alice");
                    }
                }
            };*/

        // Exercice 2 : Fonction avec paramètres et retour
        /*internal class Program
        {
            static int Additionner(int a, int b)
            {
                int resultat = a + b;
                return resultat;
            }

            static bool EstPair(int nombre)
            {
                return (nombre % 2 == 0);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Saisissez la 1ère valeur");

                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Saisissez la 2nd valeur");

                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($" résultat :{Additionner(a, b)}");
                Console.WriteLine($"Le résultat est pair:{EstPair(Additionner(a, b))}");
            }

        };*/

        /*       static void Main(string[] args)
               {
                   int[] tableau = new int[] { 5, 8, 13 };

                   AnalyseNombres(tableau);
               }

               static void AnalyseNombres(int[] tableau)
               {

                   bool EstPair(int x)
                   {
                       return x % 2 == 0;
                   }

                   foreach (int nombre in tableau)
                   {

                       if (EstPair(nombre))
                       {
                           Console.WriteLine($"{nombre} est pair");
                       }
                       else
                       {
                           Console.WriteLine($"{nombre} est impair");
                       }


                   }

               }
           }
       };*/

        static void Main(string[] args)
        {
        }
    }
};