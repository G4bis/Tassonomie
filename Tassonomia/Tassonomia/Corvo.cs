using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Corvo:Uccello
    {
         public Corvo()
            : base("Corvo", "volatile", "specie del corvo", "castelli tenebrosi", "volot")
        {

        }
        
        public void setNzampe()
        {
            numzampe = 2;
        }
    }
}
