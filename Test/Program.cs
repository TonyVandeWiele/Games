using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        public static int etage = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                MenuPrincipale();
            }
        }

        static void Jouer(Personnages monPersonnages)
        {
            Console.Clear();
            if (etage == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine(monPersonnages.Caracteristique());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n\nVous entrer dans le donjon !");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nVous etes à l'étage " + etage);
            int lvl = (etage / 6) + 1;
            Monstre monstre = new Monstre("Loup", lvl, 5, 3, 35);

            switch (etage%5)
            {
                case 1: monstre = new Monstre("Loup", lvl,5,3,35);
                    break;
                case 2: monstre = new Monstre("Gobelin", lvl,6,4,40);
                    break;
                case 3: monstre = new Monstre("Kobolt", lvl,7,5,50);
                    break;
                case 4: monstre = new Monstre("Orc", lvl,7,6,60);
                    break;
                case 0: monstre = new Monstre("Seigneur Gobelin", lvl, 10, 7, 120);
                    break;
            }
            
            bool victoire = true;
            bool suivant = false;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nUn " + monstre.Nom + " vous attaque !\n");
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
                Console.Clear();
                monPersonnages.gagnerExpOr(etage * monstre.Lvl ,2 * monstre.Lvl);

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
                        etage++;
                        suivant = true;
                        Jouer(monPersonnages);
                    }
                    else if (saisie == "n")
                    {
                        return ;
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

        static void MenuPrincipale()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Donjon's Games");
            Console.WriteLine();
            Console.WriteLine("1. Donjon");
            Console.WriteLine("2. House");

            switch (Console.ReadLine())
            {
                case "1":
                    
                    MenuSecondaireClasse(); 
                    break;
                case "2":
                    
                    MenuSecondaireMaison();
                    break;
            }
        }
        static void MenuSecondaireClasse()
        {
            Console.Clear();
            Console.WriteLine("Choisis une classe : ");
            Console.WriteLine("1. Guerrier ");
            Console.WriteLine("2. Sorcier ");
            Console.WriteLine("3. Archer ");
            Console.WriteLine("4 Quitter ");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Vous avez choisis Guerrier ");
                    Console.WriteLine();

                    Console.WriteLine("Veuillez introduire votre nom :");
                    Jouer(new Guerrier(Console.ReadLine(), 1, 14, 10, 100));
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Vous avez choisis Sorcier ");
                    Console.WriteLine();

                    Console.WriteLine("Veuillez introduire votre nom :");
                    Jouer(new Sorcier(Console.ReadLine(), 1, 20, 8, 75));
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Vous avez choisis Archer ");
                    Console.WriteLine();

                    Console.WriteLine("Veuillez introduire votre nom :");
                    Jouer(new Archer(Console.ReadLine(), 1, 18, 12, 65));
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }

            
        }
        static void MenuSecondaireMaison()
        {
            Console.Clear();
            Console.WriteLine("test");
            //Maison.AfficheMaison();
            Console.ReadKey(true);
        }
    }
}





