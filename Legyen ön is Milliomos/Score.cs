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
    public partial class pontszam : Form
    {
        Game jatek = new Game();
        public pontszam()
        {
            InitializeComponent();
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
                MessageBox.Show(selectedItem.ToString(), "Person details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<Pontszam> GetPontszamList()
        {
            var list = new List<Pontszam>();
            list.Add(new Pontszam()
            {
                FirstName = "Jancsi",
                LastName = "Kukorica",
                Highscore = 5
            });
            list.Add(new Pontszam()
            {
                FirstName = "asdad",
                LastName = "sdfg",
                Highscore = 2
            });
            list.Add(new Pontszam()
            {
                FirstName = "bdbwef",
                LastName = "dxrt",
                Highscore = 3
            });
            return list;
        }

        private void pontszam_Load(object sender, EventArgs e)
        {
            var pontSZ = GetPontszamList();
            //clear the listview
            listScore.Items.Clear();
            foreach (var person in pontSZ)
            {
                //ListViewItem lvi = new ListViewItem("John Doe");
                //lvi.SubItems.Add("lndsvlsdn");
                //lvi.SubItems.Add("123");
                var row = new string[] { person.FirstName, person.LastName, Convert.ToString(person.Highscore) };
                var lvi = new ListViewItem(row);
                //we add the whole object to the Tag property if we want 
                //later to dispplay details about the selected item
                //lvi.Tag = person; //we need to cast to Person when we get the value
                //add the item to the listview control
                listScore.Items.Add(lvi);
            }
        }
    }
}
