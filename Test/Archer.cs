using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Archer : Personnages
    {
        public Archer(string nom) : base(nom)
        {
            PV = 100;
            degatMin = 15;
            degatMax = 20;
        }
    }
}
