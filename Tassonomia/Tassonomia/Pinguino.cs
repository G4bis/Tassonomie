﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Pinguino:Uccello_Marino,Animale_Piumoso,Bipede
    {
        public Pinguino()
            : base("Pinguino", "volatile", "pinguino specifico(?)", "polo nord", "camminata")
        {

        }
        public void setManto()
        {
            mant = "piumato";
        }
        public void setNzampe()
        {
            numzampe = 2;
        }
    }
}
