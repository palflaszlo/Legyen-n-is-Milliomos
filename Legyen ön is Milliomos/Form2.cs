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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void szoveges_Click(object sender, EventArgs e)
        {
            Game GameForm = new Game();
            this.Hide();
            GameForm.ShowDialog();
            this.Show();
        }

        private void kepes_Click(object sender, EventArgs e)
        {
            Pictures kepek = new Pictures();
            this.Hide();
            kepek.ShowDialog();
            this.Show();
        }

        private void zenes_Click(object sender, EventArgs e)
        {
            Zenefelismero zene = new Zenefelismero();
            this.Hide();
            zene.ShowDialog();
            this.Show();
        }

        private void segitE_Click(object sender, EventArgs e)
        {
            Help intr = new Help();
            this.Hide();
            intr.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
