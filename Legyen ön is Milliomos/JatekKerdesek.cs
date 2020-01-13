using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_Milliomos
{
    class JatekKerdesek
    {
        private List<JatekKerdes>[] jatekKerdesLista;
        public JatekKerdesek(string fajl)
        {
            this.jatekKerdesLista = new List<JatekKerdes>[15];
            for (int i = 0; i < this.jatekKerdesLista.Length; i++)
            {
                this.jatekKerdesLista[i] = new List<JatekKerdes>();
            }
            StreamReader sr = new StreamReader(fajl, Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                int nehezseg = Convert.ToInt32(adatok[0]);
                JatekKerdes jk = new JatekKerdes(adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6], adatok[7]);
                this.jatekKerdesLista[nehezseg - 1].Add(jk);
            }
        }

        public string getKerdes()
        {
            string kerdes = "";
            StreamReader sr = new StreamReader("kerdes.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                int nehezseg = Convert.ToInt32(adatok[0]);
                JatekKerdes jk = new JatekKerdes(adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6], adatok[7]);
                kerdes = adatok[1];
                return kerdes;
            }
            return kerdes;
        }

        public string getValaszA()
        {
            string valaszA = "";
            StreamReader sr = new StreamReader("kerdes.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                int nehezseg = Convert.ToInt32(adatok[0]);
                JatekKerdes jk = new JatekKerdes(adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6], adatok[7]);
                valaszA = adatok[2];
                return valaszA;
            }
            return valaszA;
        }
        public string getValaszB()
        {
            string valaszB = "";
            StreamReader sr = new StreamReader("kerdes.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                int nehezseg = Convert.ToInt32(adatok[0]);
                JatekKerdes jk = new JatekKerdes(adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6], adatok[7]);
                valaszB = adatok[3];
                return valaszB;
            }
            return valaszB;
        }
        public string getValaszC()
        {
            string valaszC = "";
            StreamReader sr = new StreamReader("kerdes.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                int nehezseg = Convert.ToInt32(adatok[0]);
                JatekKerdes jk = new JatekKerdes(adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6], adatok[7]);
                valaszC = adatok[4];
                return valaszC;
            }
            return valaszC;
        }
        public string getValaszD()
        {
            string valaszD = "";
            StreamReader sr = new StreamReader("kerdes.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                int nehezseg = Convert.ToInt32(adatok[0]);
                JatekKerdes jk = new JatekKerdes(adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6], adatok[7]);
                valaszD = adatok[5];
                return valaszD;
            }
            return valaszD;
        }

        public void ListaHossz()
        {
            for (int i = 0; i < this.jatekKerdesLista.Length; i++)
            {
                Console.WriteLine(this.jatekKerdesLista[i].Count);
            }
        }
    }
}
