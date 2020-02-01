using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_Milliomos
{
    public partial class Game : Form
    {
        //public Label kerdes;
        public Random r = new Random();
        JatekKerdesek jk = new JatekKerdesek();
        private int szintT = 1;
        private int N = 1;
        private string betu = "A";
        public int[] tomb = new int[5000];

        public Game()
        {
            InitializeComponent();
            for (int i = 0; i < 5000; i++)
            {
                tomb[i] = r.Next(0, 4999);
            }
            text();
        }

        public void text()
        {
            N = jk.getSor(szintT, tomb[szintT]);
            Question.Text = szintT + ".  " + jk.getKerdes(N, szintT);
            firstAnswer.Text = jk.getValaszA(N, szintT);
            secondAnswear.Text = jk.getValaszB(N, szintT);
            thirdAnswear.Text = jk.getValaszC(N, szintT);
            forthAnswear.Text = jk.getValaszD(N, szintT);
            switch (szintT)
            {
                case 1: lvl1.BackColor = Color.Orange; break;
                case 2: lvl2.BackColor = Color.Orange;
                    lvl1.BackColor = Color.Green; break;
                case 3: lvl3.BackColor = Color.Orange;
                    lvl2.BackColor = Color.Green; break;
                case 4: lvl4.BackColor = Color.Orange;
                    lvl3.BackColor = Color.Green; break;
                case 5: lvl5.BackColor = Color.Orange;
                    lvl4.BackColor = Color.Green; break;
                case 6: lvl6.BackColor = Color.Orange;
                    lvl5.BackColor = Color.Green; break;
                case 7: lvl7.BackColor = Color.Orange;
                    lvl6.BackColor = Color.Green; break;
                case 8: lvl8.BackColor = Color.Orange;
                    lvl7.BackColor = Color.Green; break;
                case 9: lvl9.BackColor = Color.Orange;
                    lvl8.BackColor = Color.Green; break;
                case 10: lvl10.BackColor = Color.Orange;
                    lvl9.BackColor = Color.Green; break;
                case 11: lvl11.BackColor = Color.Orange;
                    lvl10.BackColor = Color.Green; break;
                case 12: lvl12.BackColor = Color.Orange;
                    lvl11.BackColor = Color.Green; break;
                case 13: lvl13.BackColor = Color.Orange;
                    lvl12.BackColor = Color.Green; break;
                case 14: lvl14.BackColor = Color.Orange;
                    lvl13.BackColor = Color.Green; break;
                case 15: lvl15.BackColor = Color.Orange;
                    lvl14.BackColor = Color.Green; break;
                default: lvl15.BackColor = Color.Green; break;
            }
        }


        public void error()
        {
            string message = "Worng! You lost!";
            string caption = "Game over!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void firstAnswer_Click(object sender, EventArgs e)
        {
            betu = "A";
            if (jk.helyesBetu(N).Equals(betu))
            {
                szintT++;
                firstAnswer.Visible = true;
                secondAnswear.Visible = true;
                forthAnswear.Visible = true;
                thirdAnswear.Visible = true;
                text();
            }
            else
            {
                error();
            }
        }

        private void secondAnswear_Click(object sender, EventArgs e)
        {
            betu = "B";
            if (jk.helyesBetu(N).Equals(betu))
            {
                szintT++;
                firstAnswer.Visible = true;
                secondAnswear.Visible = true;
                forthAnswear.Visible = true;
                thirdAnswear.Visible = true;
                text();
            }
            else
            {
                error();
            }
        }

        private void thirdAnswear_Click(object sender, EventArgs e)
        {
            betu = "C";
            if (jk.helyesBetu(N).Equals(betu))
            {
                szintT++;
                firstAnswer.Visible = true;
                secondAnswear.Visible = true;
                forthAnswear.Visible = true;
                thirdAnswear.Visible = true;
                text();
            }
            else
            {
                error();
            }
        }

        private void forthAnswear_Click(object sender, EventArgs e)
        {
            betu = "D";
            if (jk.helyesBetu(N).Equals(betu))
            {
                szintT++;
                firstAnswer.Visible = true;
                secondAnswear.Visible = true;
                forthAnswear.Visible = true;
                thirdAnswear.Visible = true;
                text();
            }
            else
            {
                error();
            }
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
     
        private void felezo_Click_1(object sender, EventArgs e)
        {
            string helyesvalasz = jk.helyesBetu(N);
            ellenor.Text = helyesvalasz;
            int HV = 0;
            switch (helyesvalasz)
            {
                case "A": HV = 0; break;
                case "B": HV = 1; break;
                case "C": HV = 2; break;
                case "D": HV = 3; break;
            }
            int rand, rand2 = 0;
            do
            {

                rand = r.Next(0, 4);
                rand2 = r.Next(0, 4);

            } while (rand == HV || rand2 == HV);
            switch (rand)
            {
                case 0:
                    firstAnswer.Visible = false; break;
                case 1:
                    secondAnswear.Visible = false; break;
                case 2:
                    thirdAnswear.Visible = false; break;
                case 3:
                    forthAnswear.Visible = false; break;
            }
            switch (rand2)
            {
                case 0:
                    firstAnswer.Visible = false; break;
                case 1:
                    secondAnswear.Visible = false; break;
                case 2:
                    thirdAnswear.Visible = false; break;
                case 3:
                    forthAnswear.Visible = false; break;
            }
        }
    }
}
