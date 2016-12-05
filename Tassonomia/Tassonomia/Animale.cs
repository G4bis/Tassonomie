using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale
    {
        protected string nomeanimale;
        protected string tipoannimale;
        protected string habitat;
        protected int numerozampe;
        protected string movimento;
        public abstract string getMovimento();
        public abstract string getNomeanimale();
        public abstract string getTipoanimale();
        public abstract string getHabitat();
        

        public Animale(string nome, string tipo, string habit, string mov)
        {
            nomeanimale = nome;
            tipoannimale = tipo;
            habitat = habit;
           
            movimento = mov;

        }
        public void Riepilogo()
        {
            Console.WriteLine("Nome " + nomeanimale);
            Console.WriteLine("Tipo di animale " + tipoannimale);
            Console.WriteLine("Habitat " + habitat);
            Console.WriteLine("Numero di zampe "+numerozampe);
            Console.WriteLine("Questo animale si muove : " + movimento);
        }

    }
}
