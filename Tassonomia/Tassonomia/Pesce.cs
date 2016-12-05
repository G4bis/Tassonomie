using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Pesce:Animale_Marino
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
        public Pesce(string nome,string tipo):base("Pesce generico","Pesce")
        {
            nomeanimale = nome;
            tipoannimale=tipo;
            numerozampe = 0;
        }
    }
}
