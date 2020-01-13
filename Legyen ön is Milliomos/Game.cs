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
        public Game()
        {
            InitializeComponent();
            JatekKerdesek jk = new JatekKerdesek("kerdes.txt");
            Question.Text = jk.getKerdes();
            //kerdes = this.Question;
            firstAnswer.Text = jk.getValaszA();
            secondAnswear.Text = jk.getValaszB();
            thirdAnswear.Text = jk.getValaszC();
            forthAnswear.Text = jk.getValaszD();
            
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void secondAnswear_Click(object sender, EventArgs e)
        {
            //JatekKerdes helyesE = new JatekKerdes();

        }
    }
}
