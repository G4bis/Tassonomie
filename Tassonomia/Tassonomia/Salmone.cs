using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Salmone:Animale_fluviale
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
        public Salmone(): base("Salmone", "Pesce")
        {

        }
    }
}
