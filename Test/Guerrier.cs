using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Guerrier:Personnages
    {
        public Guerrier (string nom) : base(nom)
        {
            PV = 120;
            degatMin = 10;
            degatMax = 15;
        }
    }
}
