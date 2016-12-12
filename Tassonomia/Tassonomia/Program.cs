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
            Pinguino p = new Pinguino();
            p.setManto();
            p.setNzampe();
            p.Riepilogo();
            Console.ReadLine();
            Uomo u = new Uomo();
            u.setManto();
            u.setNzampe();
            u.Riepilogo();

            Console.ReadLine();
            Balena b = new Balena();
            b.Riepilogo();
            Console.ReadLine();
            Cavallo c = new Cavallo();
            c.setManto();
            c.setNzampe();
            c.Riepilogo();
            Console.ReadLine();
            Corvo co = new Corvo();
            co.setNzampe();
            co.Riepilogo();
            Console.ReadLine();
            Ippopotamo i = new Ippopotamo();
            i.setNzampe();
            i.setManto();
            i.Riepilogo();
            Console.ReadLine();
            Salmone s = new Salmone();
            s.setManto();
            s.Riepilogo();
            Console.ReadLine();
            Tonno t = new Tonno();
            t.setManto();
            t.Riepilogo();
            Console.ReadLine();

            

        }
    }
}
