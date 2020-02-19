using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_Milliomos
{
    public partial class pontszam : Form
    {
        Game jatek = new Game();
        string[] osszSor = File.ReadAllLines("pontszamok.txt", Encoding.UTF8);
        public int[] pontszamook = new int[50000];
        public string[] nevek = new string[50000];
        public int[] idk = new int[50000];

        public pontszam()
        {
            InitializeComponent();

            for (int i = 0; i < osszSor.Length; i++)
            {
                string[] adatok = osszSor[i].Split(';');
                pontszamook[i] = Convert.ToInt32(adatok[1]);
                nevek[i] = adatok[0];
                idk[i] = Convert.ToInt32(adatok[2]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Pontszam)listScore.SelectedItems[0].Tag;
            if(selectedItem != null)
            {
                MessageBox.Show(selectedItem.ToString(), "Personal details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<Pontszam> GetPontszamList()
        {
            var list = new List<Pontszam>();
            for (int i = 0; i < osszSor.Length; i++)
            {
                list.Add(new Pontszam()
                {
                    Id = idk[i], 
                    YourName = nevek[i], 
                    Highscore = pontszamook[i]
                });
            }
            return list;
        }

        private void pontszam_Load(object sender, EventArgs e)
        {
            var pontSZ = GetPontszamList();
            foreach (var person in pontSZ)
            {
                var row = new string[] { Convert.ToString(person.Id), person.YourName, Convert.ToString(person.Highscore) };
                var lvi = new ListViewItem(row);
                listScore.Items.Add(lvi);
            }
        }
    }
}
