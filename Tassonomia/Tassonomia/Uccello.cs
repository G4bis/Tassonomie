using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Uccello:Animale
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
        
        public Uccello(string nome,string tipo):base("Uccello generico","Uccello","Alberi","Vola")
        {
            numerozampe = 2;
            nomeanimale = nome;
            tipoannimale = tipo;
        }

    }
}
