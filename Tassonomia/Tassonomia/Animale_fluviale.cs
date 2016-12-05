using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_fluviale:Animale
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

        public Animale_fluviale(string nome, string tipo): base("Animale fluviale generico", "Animale fluviale", "Fiume", "nuota")
        {
            nomeanimale = nome;
            tipoannimale = tipo;
        }
    }
}
