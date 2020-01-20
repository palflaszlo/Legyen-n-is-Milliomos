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
            Question.Text = jk.getKerdes(N, szintT);
            firstAnswer.Text = jk.getValaszA(N, szintT);
            secondAnswear.Text = jk.getValaszB(N, szintT);
            thirdAnswear.Text = jk.getValaszC(N, szintT);
            forthAnswear.Text = jk.getValaszD(N, szintT);
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
    }
}
