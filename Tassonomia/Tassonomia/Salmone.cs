using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Salmone:Pesce
    {
        public Salmone():base("Salmone","pesce","pescie","Fiume","nuoto")
        {

        }
        public void setManto()
        {
            mant = "squame";
        }
    }
}
