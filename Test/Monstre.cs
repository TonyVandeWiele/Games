using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Monstre:Entité
    {
        public Monstre(string nom): base(nom)
        {
            this.nom=nom;
            this.PV = 60;
            this.degatMin = 5;
            this.degatMax = 10;
        }
    }
}
