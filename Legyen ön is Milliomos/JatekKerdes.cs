using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_Milliomos
{
    class JatekKerdes : Kerdes
    {
        private string helyesValasz;
        public JatekKerdes(string kerdes, string valaszA, string valaszB, string valaszC, string valaszD, string helyesValasz, string kategoria)
            : base(kerdes, valaszA, valaszB, valaszC, valaszD, kategoria)
        {
            this.helyesValasz = helyesValasz;
        }/*
        public JatekKerdes(string sor)
        {
            string[] adatok = sor.Split(';');
            base.kerdes = adatok[0];
            base.valaszA = adatok[1];
            base.valaszB = adatok[2];
            base.valaszC = adatok[3];
            base.valaszD = adatok[4];
            this.helyesValasz = adatok[5];
            base.kategoria = adatok[6];
        }*/
    }
}
