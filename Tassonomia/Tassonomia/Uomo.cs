using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Uomo:Mammifero_Terrestre,Animale_Peloso,Bipede
    {
        public Uomo():base("Uomo", "Umano", "Umanoide", "Terra", "Camminata")
        {
            
        }
        public void setManto()
        {
            mant = "pelle";
        }
        public void setNzampe()
        {
            numzampe = 2;
        }
    }
}
