using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Marino : Animale
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
        
        public Animale_Marino(string nome,string tipo ):base("Animale marino generico","Animale marino","Mare","nuota")
        {

            nomeanimale = nome;
            tipoannimale = tipo;
        }
    }
}
