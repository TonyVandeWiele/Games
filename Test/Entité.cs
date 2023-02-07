using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Entité
    {

        protected string _nom;
        protected bool estMort = false;
        protected int PV;
        protected int degatMax;
        protected int degatMin;
        protected int _lvl;
        protected Random random = Random.Shared;

        public Entité(string nom, int lvl, int degatMax, int degatMin, int PV)
        {
            this.PV = PV * lvl;
            this.degatMin = degatMin * lvl;
            this.degatMax = degatMax * lvl;
            this.Nom = nom;
            this.Lvl = lvl;
        }

        public void Attaquer(Entité uneEntité)
        {
            int degat = random.Next(degatMin, degatMax);

            uneEntité.PerdrePointsDeVie(degat);

            Console.WriteLine("Tour de : " + this.Nom + "\n");
            Console.WriteLine(this.Nom + "(" + this.PV + " PV)" + " attaque -> " + uneEntité.Nom);
            Console.WriteLine(uneEntité.Nom + " a perdu " + degat + " points de vies");
            Console.WriteLine("Il reste " + uneEntité.PV + " points de vie à " + uneEntité.Nom);
            if (uneEntité.estMort)
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine(uneEntité.Nom + " est mort");
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

        public int Lvl
        {
            get { return _lvl; }
            set { _lvl = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
    }
}
