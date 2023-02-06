using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Sorcier : Personnages
    {

        public Sorcier(string nom, int lvl, int degatMax, int degatMin, int PV) : base(nom, lvl, degatMax, degatMin, PV)
        {
            
        }
    }
}
