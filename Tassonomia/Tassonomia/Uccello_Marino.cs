using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Uccello_Marino:Animale_Marino
    {
        public Uccello_Marino(string nome,string tipo,string specie,string habit,string mov):base("Uccello Marino Generico","Uccello Marino","Uccello Generico","Indefinito","Movimento di un uccello marino generico","Manto di un Uccello marino")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
            
        }
    }
}
