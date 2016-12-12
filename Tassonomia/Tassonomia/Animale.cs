using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale
    {
         protected string noman;
         protected string tipoan;
         protected string spec;
         protected string habitat;
         protected int numzampe;
         protected string movimen;
         protected string mant;
        public Animale(string nome,string tipo,string specie,string habit,string movimento,string manto)
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = movimento;
            mant = manto;

        }
        
        public void Riepilogo()
        {
            Console.WriteLine("Nome Animale: " + noman);
            Console.WriteLine("Tipo Animale: " + tipoan);
            Console.WriteLine("Specie Animale: " + spec);
            Console.WriteLine("Habitat Animale: " + habitat);
            Console.WriteLine("Numero di zampe: " + numzampe);
            Console.WriteLine("Movimento: " + movimen);
            Console.WriteLine("Manto: " + mant);
        }

    }
}
