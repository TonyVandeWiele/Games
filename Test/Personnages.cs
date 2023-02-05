using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Personnages:Entité
    {
        private int nv;
        private int exp;

        public Personnages(string nom) : base(nom)
        {
            this.nom = nom;
            nv = 1;
            exp = 0;
        }

        public void gagnerExp(int montant)
        {
            this.exp += exp;
            while (this.exp>=expRequise())
            {
                nv += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bravo : Vous avez gagner un niveau (niveau "+nv+")");

                PV += 10;
                degatMin += 2;
                degatMax += 2;
            }
        }

        public double expRequise()
        {
            return Math.Round(4 * (Math.Pow(nv, 3) / 5));
        }

        public string Caracteristique()
        {
            return this.nom + "\n" +
                   "Points d e vie :" + PV + "\n" +
                   "Niveau :" + nv + "\n" +
                   "Points d'expérience : (" + exp + "/" + expRequise() +")"+ "\n" +
                   "Dégats : [" + degatMin + ";" + degatMax + "]";
        }
    }
}
