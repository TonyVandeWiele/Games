using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Entité
    {
        protected string nom;
        protected bool estMort = false;
        protected int PV;
        protected int degatMax;
        protected int degatMin;
        protected int lvl;
        protected Random random = Random.Shared;

        public Entité(string nom, int lvl, int degatMax, int degatMin, int PV)
        {
            this.PV = PV * lvl;
            this.degatMin = degatMin * lvl;
            this.degatMax = degatMax * lvl;
            this.nom = nom;
            this.lvl = lvl;
        }

        public void Attaquer(Entité uneEntité)
        {
            int degat = random.Next(degatMin, degatMax);

            uneEntité.PerdrePointsDeVie(degat);

            Console.WriteLine("Tour de : " + this.nom + "\n");
            Console.WriteLine(this.nom + "(" + this.PV + " PV)" + " attaque -> " + uneEntité.nom);
            Console.WriteLine(uneEntité.nom + " a perdu " + degat + " points de vies");
            Console.WriteLine("Il reste " + uneEntité.PV + " points de vie à " + uneEntité.nom);
            if (uneEntité.estMort)
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine(uneEntité.nom + " est mort");
            }
        }

        protected void PerdrePointsDeVie(int pointsDeVie)
        {
            this.PV-=pointsDeVie;
            if (this.PV <= 0)
            {
                this.PV = 0;
                estMort = true;
            }
        }

        public bool EstMort()
        {
            return this.estMort;
        }

        public int getLvl()
        {
            return this.lvl;
        }

        public string getNom()
        {
            return this.nom;
        }
    }
}
