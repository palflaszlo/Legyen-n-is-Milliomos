﻿using System;
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
    public partial class foAblak : Form
    {
        public foAblak()
        {
            InitializeComponent();
        }
        public bool btnLoadSave = false;
        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profil = new Profile();
            this.Hide();
            profil.ShowDialog();
            this.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoadSave = true;
            Properties.Settings.Default.mentes = true;
            Properties.Settings.Default.Save();
            Game GameForm = new Game();
            this.Hide();
            GameForm.ShowDialog();
            this.Show();
        }

        private void btmStart_Click(object sender, EventArgs e)
        {
            Form2 jatekFormok = new Form2();
            this.Hide();
            jatekFormok.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            pontszam pontszam = new pontszam();
            this.Hide();
            pontszam.ShowDialog();
            this.Show();
        }

        private void btnKerdes_Click(object sender, EventArgs e)
        {
            NewQuestion kerdes = new NewQuestion();
            this.Hide();
            kerdes.ShowDialog();
            this.Show();
        }
    }
}
