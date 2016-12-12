using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Cavallo:Mammifero_Terrestre,Animale_Peloso,Quadrupede
    {
         public Cavallo()
            : base("Cavallo", "Quadrupede", "equino", "Macellaio banco carne", "Galoppo")
        {


        }
         public void setManto()
         {
             mant = "pelo";
         }
         public void setNzampe()
         {
             numzampe = 4;
         }
    }
}
