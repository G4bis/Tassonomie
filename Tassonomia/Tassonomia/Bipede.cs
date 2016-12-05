using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
     abstract class Bipede:Animale_terrestre
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
        
        public Bipede(string nome,string tipo):base("Animale bipede generico","Bipede")
        {
            numerozampe = 2;
            nomeanimale = nome;
            tipoannimale = tipo;
        }
    }
}
