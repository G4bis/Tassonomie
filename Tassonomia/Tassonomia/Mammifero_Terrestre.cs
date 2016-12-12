using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Mammifero_Terrestre:Animale_Terrestre
    {
        public Mammifero_Terrestre(string nome, string tipo, string specie, string habit, string mov): base("Mammifero Terrestre Generico", "Mammifero Terrestre", "Mammifero Generico", "Terra", "Movimento terrestre generico")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
           
        }
    }
}
