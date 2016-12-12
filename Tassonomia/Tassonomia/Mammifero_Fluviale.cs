using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Mammifero_Fluviale:Animale_Terrestre
    {
        public Mammifero_Fluviale(string nome, string tipo, string specie, string habit, string mov)
            : base("Mammifero Fluviale Generico", "Mammifero Fluviale", "Mammifero Generico", "Fiume", "Movimento fluviale generico")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
        }
    }
}
