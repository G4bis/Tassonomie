using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Mammifero_Marino:Animale_Marino
    {
        public Mammifero_Marino(string nome, string tipo, string specie, string habit, string mov)
            : base("Mammifero Marino Generico", "Mammifero Marino", "Mammifero Generico", "Acqua", "Movimento di un mammifero marino generico", "Pelle")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
          
        }
    }
}
