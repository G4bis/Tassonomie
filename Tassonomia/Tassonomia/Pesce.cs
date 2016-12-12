using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Pesce : Animale_Marino, Animale_Squamoso
    {
        public Pesce(string nome, string tipo, string specie, string habit, string mov)
            : base("Pesce Generico", "Pesce", "Pesce Generico", "Acqua", "Movimento di un pesce generico", "Manto squamoso")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
        }
        public void setManto()
        {
            mant = "squame";
        }
    }
}
