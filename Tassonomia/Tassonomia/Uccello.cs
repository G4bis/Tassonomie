using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Uccello:Animale_Terrestre,Animale_Piumoso
    {
        public Uccello(string nome, string tipo, string specie, string habit, string mov)
            : base("Uccello Generico", "Uccello", "Uccello Generico", "Alberi", "Volo")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
        }
        public void setManto()
        {
            mant = "piumato";
        }
       
    }
}
