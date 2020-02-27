using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_Milliomos
{
    class Kerdes
    {
        private int nehezseg;
        private string kerdes_;
        private string[] valaszok = new string[4];
        private string kategoria;
        //private string kategoria2;
        private string helyesValasz;

        public int Nehezseg { get => nehezseg; set => nehezseg = value; }
        public string Kerdes_ { get => kerdes_; set => kerdes_ = value; }
        public string[] Valaszok { get => valaszok; set => valaszok = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        //public string Kategoria2 { get => kategoria2; set => kategoria2 = value; }
        public string HelyesValasz { get => helyesValasz; set => helyesValasz = value; }

        public Kerdes(int nehezseg, string kerdes, string[] valaszok, string kategoria,/* string kategoria2,*/ string helyesValasz)
        {
            this.nehezseg = nehezseg;
            this.kerdes_ = kerdes;
            this.valaszok[0] = valaszok[0];
            this.valaszok[1] = valaszok[1];
            this.valaszok[2] = valaszok[2];
            this.valaszok[3] = valaszok[3];
            this.kategoria = kategoria;
            // this.kategoria2 = kategoria2;
            this.helyesValasz = helyesValasz;
        }
    }
}
