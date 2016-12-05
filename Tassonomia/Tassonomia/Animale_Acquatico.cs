using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Acquatico:Animale
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

        public Animale_Acquatico(string nome, string tipo): base("Animale acquatico generico", "Animale aquatico", "Acqua", "nuota")
        {
            nomeanimale = nome;
            tipoannimale = tipo;
        }
    }
}
