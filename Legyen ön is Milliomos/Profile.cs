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
    public partial class Profile : Form
    {
        public string yourName = "";
        public string[] helps = new string[3];
        public string[] Checkedthemes = new string[20];
        public string[] themes = new string[20];
        public string[] UnCheckedthemes = new string[20];
        public string difficulty = "";
        Settings options = new Settings();

        public Profile()
        {
            InitializeComponent();
            if (options.teljesAblak)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string item in checkedListBox2.CheckedItems)
            {
                helps[i] = item;
                i++;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string item in checkedListBox1.CheckedItems)
            {
                Checkedthemes[i] = item;
                i++;
            }
            i = 0;
            foreach (string item in checkedListBox1.Items)
            {
                themes[i] = item;
                i++;
            }
            i = 0;
            foreach (string item in checkedListBox1.Items)
            {
                if (!Checkedthemes.Contains<string>(item))
                {
                    UnCheckedthemes[i] = item;
                    i++;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                difficulty = "easy";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                difficulty = "normal";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                difficulty = "hard";
            }
        }

        private void profileName_TextChanged(object sender, EventArgs e)
        {
            yourName = profileName.Text;
        }
    }
}
