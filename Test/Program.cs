using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnages monPersonnages)
        {
            Monstre monstre = new Monstre("Loup");
            bool victoire = true;
            bool suivant = false;

            while (!monstre.EstMort())
            {
                //Tour du monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPersonnages);
                Console.WriteLine();
                Console.ReadKey(true);

                if (monPersonnages.EstMort())
                {
                    victoire=false;
                    break;
                }

                //Tour du Perso
                Console.ForegroundColor = ConsoleColor.Green;
                monPersonnages.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);
            }

            if (victoire)
            {
                monPersonnages.gagnerExp(5);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine(monPersonnages.Caracteristique());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Salle suivante ? (o/n)");
                    string saisie = Console.ReadLine().ToLower();
                    if (saisie == "o")
                    {
                        suivant = true;
                        Jouer(monPersonnages);
                    }
                    else if (saisie == "n")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Vous avez perdu");
                Console.ReadKey();
            }
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Le jeu");
            Console.WriteLine();
            Console.WriteLine("Choisr ta classe : ");
            Console.WriteLine("1. Guerrier ");
            Console.WriteLine("2. Soricer ");
            Console.WriteLine("3. Arhcer ");
            Console.WriteLine("4 Quitter ");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis Guerrier ");
                    Console.WriteLine();

                    Console.WriteLine("Veuillez introduire votre nom :");
                    Jouer(new Guerrier(Console.ReadLine()));
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisis Sorcier ");
                    Console.WriteLine();

                    Console.WriteLine("Veuillez introduire votre nom :");
                    Jouer(new Sorcier(Console.ReadLine()));
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisis Archer ");
                    Console.WriteLine();

                    Console.WriteLine("Veuillez introduire votre nom :");
                    Jouer(new Archer(Console.ReadLine()));
                    break;
                case "4":
                    break;
            }
        }
    }
}

