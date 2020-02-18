using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_Milliomos
{
    public partial class Zenefelismero : Form
    {
        public Zenefelismero()
        {
            InitializeComponent();
        }

        private void btnZene_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\Rumpelstiltskin.Masterpiece\Desktop\szakdolgozat\Legyen ön is Milliomos\Legyen ön is Milliomos\bin\Debug\Sophia Angeles - Gone (Lyrics).mp3");
            sp.Play();
        }
    }
}
