using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_Milliomos
{
    class Kerdes
    {
        protected string kerdes;
        protected string valaszA;
        protected string valaszB;
        protected string valaszC;
        protected string valaszD;
        protected string kategoria;

        public Kerdes(string kerdes, string valaszA, string valaszB, string valaszC, string valaszD, string kategoria)
        {
            this.kerdes = kerdes;
            this.valaszA = valaszA;
            this.valaszB = valaszB;
            this.valaszC = valaszC;
            this.valaszD = valaszD;
            this.kategoria = kategoria;
        }

        public string getKerdes()
        {
            return this.kerdes;
        }
        public string getValaszA()
        {
            return this.valaszA;
        }
        public string getValaszB()
        {
            return this.valaszB;
        }
        public string getValaszC()
        {
            return this.valaszC;
        }
        public string getValaszD()
        {
            return this.valaszD;
        }
        public string getKategoria()
        {
            return this.kategoria;
        }
        /*
        public Kerdes()
        {

        }*/

    }
}
