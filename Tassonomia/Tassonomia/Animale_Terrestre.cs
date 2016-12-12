using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Terrestre:Animale
    {
        public Animale_Terrestre(string nome,string tipo,string specie,string habit,string mov):base("Animale Terrestre generico","Animale terrestre","Animale generico","Terra","Movimento generico","Manto generico")
        {
            noman = nome;
            tipoan = tipo;
            spec = specie;
            habitat = habit;
            movimen = mov;
            
        }
    }
}
