using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Quadrupede:Animale_terrestre
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
        public Quadrupede(string nome,string tipo):base("Quadrupede generico","Quadrupede terrestre")
        {
            numerozampe = 4;
            nomeanimale = nome;
            tipoannimale = tipo;
        }
    }
}
