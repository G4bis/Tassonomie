using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Program
    {
        static void Main(string[] args)
        {

            Uomo u = new Uomo();
            u.Riepilogo();
            Console.ReadLine();
            Cavallo c = new Cavallo();
            c.Riepilogo();
            Console.ReadLine();
            Pinguino p = new Pinguino();
            p.Riepilogo();
            Console.ReadLine();
            Salmone s = new Salmone();
            s.Riepilogo();
            Console.ReadLine();
            Tonno t = new Tonno();
            t.Riepilogo();
            Console.ReadLine();
            Corvo co = new Corvo();
            co.Riepilogo();
            Console.ReadLine();
        }
    }
}

