using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Tonno:Pesce,Animale_Squamoso
    {
        public Tonno()
            : base("Tonno", "Pesce", "Pesce", "Mare", "nuoto")
        {


        }
        public void setManto()
        {
            mant = "squame";
        }


        
    }
}
