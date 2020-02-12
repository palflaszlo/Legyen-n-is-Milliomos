using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_Milliomos
{
    public partial class Pictures : Form
    {
        public bool dontRunHandler;
        public System.Timers.Timer myTimer = new System.Timers.Timer();
        public System.Timers.Timer myTimer2 = new System.Timers.Timer();
        public int countDown = 0;
        public int countDown2 = 0;

        public Random r = new Random();
        KepJatekKerdesek jk = new KepJatekKerdesek();
        Profile pf = new Profile();
        private int szintT = 1;
        private int N;
        private string betu = "A";
        public int[] tomb = new int[50000];

        public int pontszam;


        public Pictures()
        {
            InitializeComponent();
            myTimer.Elapsed += new ElapsedEventHandler(customfn);
            myTimer.Interval = 1000;
            myTimer2.Elapsed += new ElapsedEventHandler(customfn2);
            myTimer2.Interval = 1000;
        }

        private void customfn(object source, ElapsedEventArgs e)
        {
            countDown++;
            if (countDown % 3 == 0)
            {
                myTimer.Stop();
                getAnswear(betu);
            }
        }

        private void customfn2(object source, ElapsedEventArgs e)
        {
            countDown2++;
            if (countDown2 % 3 == 0)
            {
                myTimer2.Stop();
                text();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Pictures_Load(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "https://branted-live.s3.eu-west-2.amazonaws.com/i/fc8007d4d412675ec8ab11d06d23d742419953ce-s.jpg";
            pb1.Load("https://branted-live.s3.eu-west-2.amazonaws.com/i/fc8007d4d412675ec8ab11d06d23d742419953ce-s.jpg");
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            var request = System.Net.WebRequest.Create("https://branted-live.s3.eu-west-2.amazonaws.com/i/fc8007d4d412675ec8ab11d06d23d742419953ce-s.jpg");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }            

            for (int i = 0; i < jk.kerdesek.Length-1; i++)
            {
                tomb[i] = r.Next(0, 4999);
            }
            text();

            string segit = "Felező";
            string[] segitsegek = Properties.Settings.Default.helps.Split(',');
            if (segitsegek.Contains<string>(segit))
            {
                felezo.Enabled = true;
            }
            else
            {
                felezo.Enabled = false;
            }
            segit = "Közönség";
            if (segitsegek.Contains<string>(segit))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            segit = "Telefonos";
            if (segitsegek.Contains<string>(segit))
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        public void text()
        {
            try
            {
                if (valaszA.InvokeRequired || valaszB.InvokeRequired || valaszC.InvokeRequired || valaszD.InvokeRequired)
                {
                    valaszA.Invoke(new Action(text));
                    valaszB.Invoke(new Action(text));
                    valaszC.Invoke(new Action(text));
                    valaszD.Invoke(new Action(text));
                    return;
                }
                N = jk.getSor(szintT, tomb[szintT]);
                picQu.Text = szintT + ".  " + jk.getKerdes(N, szintT);
                valaszA.Text = jk.getValaszA(N, szintT);
                valaszB.Text = jk.getValaszB(N, szintT);
                valaszC.Text = jk.getValaszC(N, szintT);
                valaszD.Text = jk.getValaszD(N, szintT);

                valaszA.BackColor = Color.Black;
                valaszB.BackColor = Color.Black;
                valaszC.BackColor = Color.Black;
                valaszD.BackColor = Color.Black;

                valaszA.Visible = true;
                valaszB.Visible = true;
                valaszC.Visible = true;
                valaszD.Visible = true;

                switch (szintT)
                {
                    case 1: lvl1.BackColor = Color.Orange; break;
                    case 2:
                        lvl2.BackColor = Color.Orange;
                        lvl1.BackColor = Color.Green; pontszam++; break;
                    case 3:
                        lvl3.BackColor = Color.Orange;
                        lvl2.BackColor = Color.Green; pontszam++; break;
                    case 4:
                        lvl4.BackColor = Color.Orange;
                        lvl3.BackColor = Color.Green; pontszam++; break;
                    case 5:
                        lvl5.BackColor = Color.Orange;
                        lvl4.BackColor = Color.Green; pontszam++; break;
                    case 6:
                        lvl6.BackColor = Color.Orange;
                        lvl5.BackColor = Color.Green; pontszam++; break;
                    case 7:
                        lvl7.BackColor = Color.Orange;
                        lvl6.BackColor = Color.Green; pontszam++; break;
                    case 8:
                        lvl8.BackColor = Color.Orange;
                        lvl7.BackColor = Color.Green; pontszam++; break;
                    case 9:
                        lvl9.BackColor = Color.Orange;
                        lvl8.BackColor = Color.Green; pontszam++; break;
                    case 10:
                        lvl10.BackColor = Color.Orange;
                        lvl9.BackColor = Color.Green; pontszam++; break;
                    case 11:
                        lvl11.BackColor = Color.Orange;
                        lvl10.BackColor = Color.Green; pontszam++; break;
                    case 12:
                        lvl12.BackColor = Color.Orange;
                        lvl11.BackColor = Color.Green; pontszam++; break;
                    case 13:
                        lvl13.BackColor = Color.Orange;
                        lvl12.BackColor = Color.Green; pontszam++; break;
                    case 14:
                        lvl14.BackColor = Color.Orange;
                        lvl13.BackColor = Color.Green; pontszam++; break;
                    case 15:
                        lvl15.BackColor = Color.Orange;
                        lvl14.BackColor = Color.Green; pontszam++; break;
                    case 16:
                        lvl15.BackColor = Color.Green; pontszam++;
                        Properties.Settings.Default.levels = pontszam; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        public void error()
        {
            string message = "Worng! You lost!";
            string caption = "Game over!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Closes the parent form.
                try
                {
                    if (valaszA.InvokeRequired || valaszB.InvokeRequired || valaszC.InvokeRequired || valaszD.InvokeRequired)
                    {
                        valaszA.Invoke(new Action(error));
                        valaszB.Invoke(new Action(error));
                        valaszC.Invoke(new Action(error));
                        valaszD.Invoke(new Action(error));
                        return;
                    }
                    myTimer.Stop();
                    Application.DoEvents();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getAnswear(string betu)
        {
            if (jk.helyesBetu(N).Equals(betu))
            {
                szintT++;
                switch (betu)
                {
                    case "A": valaszA.BackColor = Color.Green; break;
                    case "B": valaszB.BackColor = Color.Green; break;
                    case "C": valaszC.BackColor = Color.Green; break;
                    case "D": valaszD.BackColor = Color.Green; break;
                }
                //ide még egy zene jön
                myTimer2.Start();
            }
            else
            {
                error();
            }
        }

        private void valaszA_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "A";
                valaszA.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.BackColor = Color.Green; break;
                    case "B": valaszB.BackColor = Color.Green; break;
                    case "C": valaszC.BackColor = Color.Green; break;
                    case "D": valaszD.BackColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + szintT + "level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "A";
                valaszA.BackColor = Color.Orange;
                myTimer.Start();
            }
        }

        private void valaszB_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "B";
                valaszB.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.BackColor = Color.Green; break;
                    case "B": valaszB.BackColor = Color.Green; break;
                    case "C": valaszC.BackColor = Color.Green; break;
                    case "D": valaszD.BackColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + szintT + "level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "B";
                valaszB.BackColor = Color.Orange;
                myTimer.Start();
            }
        }

        private void valaszC_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "C";
                valaszC.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.BackColor = Color.Green; break;
                    case "B": valaszB.BackColor = Color.Green; break;
                    case "C": valaszC.BackColor = Color.Green; break;
                    case "D": valaszD.BackColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + szintT + "level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "C";
                valaszC.BackColor = Color.Orange;
                myTimer.Start();
            }
        }

        private void valaszD_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "D";
                valaszD.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": valaszA.BackColor = Color.Green; break;
                    case "B": valaszB.BackColor = Color.Green; break;
                    case "C": valaszC.BackColor = Color.Green; break;
                    case "D": valaszD.BackColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the " + szintT + "level";
                string caption = "Game over!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    Application.DoEvents();
                    this.Close();
                }
            }
            else
            {
                betu = "D";
                valaszD.BackColor = Color.Orange;
                myTimer.Start();
            }
        }

        private void felezo_Click(object sender, EventArgs e)
        {
            string helyesvalasz = jk.helyesBetu(N);
            int HV = 0;
            switch (helyesvalasz)
            {
                case "A": HV = 0; break;
                case "B": HV = 1; break;
                case "C": HV = 2; break;
                case "D": HV = 3; break;
            }
            int rand, rand2;
            do
            {
                rand = r.Next(0, 4);
                rand2 = r.Next(0, 4);
            } while (rand == rand2 || rand == HV || rand2 == HV);
            switch (rand)
            {
                case 0: valaszA.Visible = false; break;
                case 1: valaszB.Visible = false; break;
                case 2: valaszC.Visible = false; break;
                case 3: valaszD.Visible = false; break;
            }
            switch (rand2)
            {
                case 0: valaszA.Visible = false; break;
                case 1: valaszB.Visible = false; break;
                case 2: valaszC.Visible = false; break;
                case 3: valaszD.Visible = false; break;
            }
            if (!valaszA.Visible || !valaszB.Visible || !valaszC.Visible || !valaszD.Visible)
            {
                felezo.Enabled = false;
            }
        }

        private void megallas_Click_1(object sender, EventArgs e)
        {
            dontRunHandler = true;
        }
    }
}
