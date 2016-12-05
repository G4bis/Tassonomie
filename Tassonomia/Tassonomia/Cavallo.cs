using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Cavallo:Quadrupede
    {
       public override string getTipoanimale()
        {
            return tipoannimale;
        }
        public override string getHabitat()
        {
            return habitat;
        }
        public override string getMovimento()
        {
            return movimento;
        }
        public override string getNomeanimale()
        {
            return nomeanimale;
        }
        public Cavallo(): base("Cavallo", "Quadrupede")
        {

        }
    }
}
