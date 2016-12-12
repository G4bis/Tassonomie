﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Marino:Animale
    {
        public Animale_Marino(string nome,string tipo,string specie,string habit,string mov,string manto):base("Animale Marino generico","Animale marino","Animale generico","Acqua","Movimento generico","Manto generico")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
            mant = manto;
        }
    }
}
