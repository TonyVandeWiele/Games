using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Personnages:Entité
    {
        private int exp;
        private int pvmax;
        private int pieceOr;

        public Personnages(string nom, int lvl, int degatMax, int degatMin, int PV) : base(nom, lvl, degatMax, degatMin, PV)
        {
            exp = 0;
            pvmax = PV;
            pieceOr = 0;
        }

        public void gagnerExpOr(int montant, int or)
        {
            this.exp += montant;
            this.pieceOr += or;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bravo : Vous avez gagner " + or + " piece d'or durant ce combat");
            Console.WriteLine("Bravo : Vous avez gagner " + montant + " xp durant ce combat");
            while (this.exp>=expRequise())
            {
                pvmax += 10;
                PV = pvmax;
                lvl += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bravo : Vous avez gagner un niveau (niveau "+lvl+")");

                degatMin += 2;
                degatMax += 2;
                this.exp = 0;
            }
        }

        public double expRequise()
        {
            return Math.Round(4 * (Math.Pow(lvl, 3) / 5));
        }

        public string Caracteristique()
        {
            return "Caractéristiques actuels de " + this.nom + "\n" +
                   "Points de vie : " + PV + "\n" +
                   "Niveau :" + lvl + "\n" +
                   "Points d'expérience : (" + exp + "/" + expRequise() +")"+ "\n" +
                   "Dégats : [" + degatMin + ";" + degatMax + "]";
        }
    }
}
