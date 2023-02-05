using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Sorcier : Personnages
    {
        public Sorcier(string nom) : base(nom)
        {
            PV = 80;
            degatMin = 10;
            degatMax = 25;
        }
    }
}
