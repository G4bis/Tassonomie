using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Ippopotamo:Mammifero_Fluviale,Quadrupede
    {
        public Ippopotamo()
            : base("Ippopotamo", "mammifero", "specie dell'ippopotamo", "savana", "cammino")
        {

        }
        public void setManto()
        {
            mant = "Pelle";
        }
        public void setNzampe()
        {
            numzampe = 4;
        }
    }
}
