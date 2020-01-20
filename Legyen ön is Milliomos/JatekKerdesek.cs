using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_Milliomos
{
    class JatekKerdesek
    {
        public Random r = new Random();
        string[] osszSor = File.ReadAllLines("kerdes.txt", Encoding.UTF8);
        public int[] nehezsegek = new int[5000];
        public string[] kerdesek = new string[5000];
        public string[] valaszokA = new string[5000];
        public string[] valaszokB = new string[5000];
        public string[] valaszokC = new string[5000];
        public string[] valaszokD = new string[5000];
        public string[] kategoriak = new string[5000];
        public string[] helyesValaszok = new string[5000];


        public JatekKerdesek()
        {
            for (int i = 0; i < osszSor.Length; i++)
            {
                string[] adatok = osszSor[i].Split(';');
                nehezsegek[i] = Convert.ToInt32(adatok[0]);
                kerdesek[i] = adatok[1];
                valaszokA[i] = adatok[2];
                valaszokB[i] = adatok[3];
                valaszokC[i] = adatok[4];
                valaszokD[i] = adatok[5];
                helyesValaszok[i] = adatok[6];
                kategoriak[i] = adatok[7];
            }
        }

        public int getSor(int szint, int random)
        {
            int sor = 0;
            if (szint > 0 && szint < 8)
            {
                sor = random;
            }
            else if (szint > 7 && szint < 16)
            {
                sor = random;
            }
            else
            {
                string message = "You won the whole game!";
                string caption = "You are a millionare!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    Game.ActiveForm.Close();
                }
            }

            return sor;
        }
        
        public string getKerdes(int sor, int szint)
        {
            string kerdes = "Nincs semmi";
            int j = sor;
            kerdes = kerdesek[j];
            return kerdes;
        }

        public string getValaszA(int sor, int szint)
        {
            string valaszA = "Nincs semmi";
            int j = sor;
            valaszA = valaszokA[j];
            return valaszA;
        }
        public string getValaszB(int sor, int szint)
        {
            string valaszB = "Nincs semmi";
            int j = sor;
            valaszB = valaszokB[j];
            return valaszB;
        }
        public string getValaszC(int sor, int szint)
        {
            string valaszC = "Nincs semmi";
            int j = sor;
            valaszC = valaszokC[j];
            return valaszC;
        }
        public string getValaszD(int sor, int szint)
        {
            string valaszD = "Nincs semmi";
            int j = sor;
            valaszD = valaszokD[j];
            return valaszD;
        }
        
        public string helyesBetu(int sor)
        {
            string valasz = "";
            int j = sor;
            valasz = helyesValaszok[j];
            return valasz;
        }
    }
}
