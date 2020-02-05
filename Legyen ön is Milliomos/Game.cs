using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_Milliomos
{
    public partial class Game : Form
    {
        //public Label kerdes;
        public Random r = new Random();
        JatekKerdesek jk = new JatekKerdesek();
        Profile pf = new Profile();
        Settings options = new Settings();
        private int szintT = 1;
        private int N = 1;
        private string betu = "A";
        public int[] tomb = new int[5000];
        System.Timers.Timer t = new System.Timers.Timer();
        System.Timers.Timer t2 = new System.Timers.Timer();
        int h, m, s, h2, m2, s2;

        public int pontszam;

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                //ide is jön egy zene
                ellenor.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                
            }));
            string[] osztas = ellenor.Text.Split(':');
            int osztando = Convert.ToInt32(osztas[2]);
            if (osztando%3==0)
            {
                getAnswear(betu);
            }
        }


        private void OnTimeEvent2(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s2 += 1;
                if (s2 == 60)
                {
                    s2 = 0;
                    m2 += 1;
                }
                if (m2 == 60)
                {
                    m2 = 0;
                    h2 += 1;
                }
                //ide is jön egy zene
                ellenor2.Text = string.Format("{0}:{1}:{2}", h2.ToString().PadLeft(2, '0'), m2.ToString().PadLeft(2, '0'), s2.ToString().PadLeft(2, '0'));
            }));
            string[] osztas = ellenor2.Text.Split(':');
            int osztando = Convert.ToInt32(osztas[2]);
            if (osztando % 3 == 0)
            {
                text();
            }
        }


        public Game()
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
            for (int i = 0; i < 5000; i++)
            {
                tomb[i] = r.Next(0, 4999);
            }
            text();
            if (pf.helps.Contains<string>("Felező"))
            {
                felezo.Enabled = true;
            }
            else
            {
                felezo.Enabled = false;
            }
            if (pf.helps.Contains<string>("Közönség"))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            if (pf.helps.Contains<string>("Telefonos"))
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
                if (firstAnswer.InvokeRequired || secondAnswear.InvokeRequired || thirdAnswear.InvokeRequired || forthAnswear.InvokeRequired)
                {
                    firstAnswer.Invoke(new Action(text));
                    secondAnswear.Invoke(new Action(text));
                    thirdAnswear.Invoke(new Action(text));
                    forthAnswear.Invoke(new Action(text));
                    return;
                }
                N = jk.getSor(szintT, tomb[szintT]);
                Question.Text = szintT + ".  " + jk.getKerdes(N, szintT);
                firstAnswer.Text = jk.getValaszA(N, szintT);
                secondAnswear.Text = jk.getValaszB(N, szintT);
                thirdAnswear.Text = jk.getValaszC(N, szintT);
                forthAnswear.Text = jk.getValaszD(N, szintT);
                firstAnswer.BackColor = Color.Black;
                secondAnswear.BackColor = Color.Black;
                thirdAnswear.BackColor = Color.Black;
                forthAnswear.BackColor = Color.Black;
                firstAnswer.Visible = true;
                secondAnswear.Visible = true;
                forthAnswear.Visible = true;
                thirdAnswear.Visible = true;
                t.Stop();
                t2.Stop();
                pontszam++;
                switch (szintT)
                {
                    case 1: lvl1.BackColor = Color.Orange; break;
                    case 2:
                        lvl2.BackColor = Color.Orange;
                        lvl1.BackColor = Color.Green; break;
                    case 3:
                        lvl3.BackColor = Color.Orange;
                        lvl2.BackColor = Color.Green; break;
                    case 4:
                        lvl4.BackColor = Color.Orange;
                        lvl3.BackColor = Color.Green; break;
                    case 5:
                        lvl5.BackColor = Color.Orange;
                        lvl4.BackColor = Color.Green; break;
                    case 6:
                        lvl6.BackColor = Color.Orange;
                        lvl5.BackColor = Color.Green; break;
                    case 7:
                        lvl7.BackColor = Color.Orange;
                        lvl6.BackColor = Color.Green; break;
                    case 8:
                        lvl8.BackColor = Color.Orange;
                        lvl7.BackColor = Color.Green; break;
                    case 9:
                        lvl9.BackColor = Color.Orange;
                        lvl8.BackColor = Color.Green; break;
                    case 10:
                        lvl10.BackColor = Color.Orange;
                        lvl9.BackColor = Color.Green; break;
                    case 11:
                        lvl11.BackColor = Color.Orange;
                        lvl10.BackColor = Color.Green; break;
                    case 12:
                        lvl12.BackColor = Color.Orange;
                        lvl11.BackColor = Color.Green; break;
                    case 13:
                        lvl13.BackColor = Color.Orange;
                        lvl12.BackColor = Color.Green; break;
                    case 14:
                        lvl14.BackColor = Color.Orange;
                        lvl13.BackColor = Color.Green; break;
                    case 15:
                        lvl15.BackColor = Color.Orange;
                        lvl14.BackColor = Color.Green; break;
                    default: lvl15.BackColor = Color.Green; break;
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
                    if (firstAnswer.InvokeRequired || secondAnswear.InvokeRequired || thirdAnswear.InvokeRequired || forthAnswear.InvokeRequired)
                    {
                        firstAnswer.Invoke(new Action(error));
                        secondAnswear.Invoke(new Action(error));
                        thirdAnswear.Invoke(new Action(error));
                        forthAnswear.Invoke(new Action(error));
                        return;
                    }
                    t.Stop();
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
                t.Stop();
                t2.Start();
                szintT++;
                switch (betu)
                {
                    case "A": firstAnswer.BackColor = Color.Green; break;
                    case "B": secondAnswear.BackColor = Color.Green; break;
                    case "C": thirdAnswear.BackColor = Color.Green; break;
                    case "D": forthAnswear.BackColor = Color.Green; break;
                }
                //ide még egy zene jön
                t2.Interval = 1000;
                t2.Elapsed += OnTimeEvent2;
            }
            else
            {
                error();
            }
        }

        private void staart()
        {
            try
            {
                if (firstAnswer.InvokeRequired || secondAnswear.InvokeRequired || thirdAnswear.InvokeRequired || forthAnswear.InvokeRequired)
                {
                    firstAnswer.Invoke(new Action(staart));
                    secondAnswear.Invoke(new Action(staart));
                    thirdAnswear.Invoke(new Action(staart));
                    forthAnswear.Invoke(new Action(staart));
                    return;
                }
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void firstAnswer_Click(object sender, EventArgs e)
        {
            betu = "A";
            firstAnswer.BackColor = Color.Orange;
            Thread tt = new Thread(staart);
            tt.Start();
        }

        private void secondAnswear_Click(object sender, EventArgs e)
        {
            betu = "B";
            secondAnswear.BackColor = Color.Orange;
            Thread tt = new Thread(staart);
            tt.Start();
        }

        private void megallas_Click(object sender, EventArgs e)
        {
            if (firstAnswer.Focused)
            {
                betu = "A";
                firstAnswer.BackColor = Color.Orange;
            }
            if (secondAnswear.Focused)
            {
                betu = "B";
                secondAnswear.BackColor = Color.Orange;
            }
            if (thirdAnswear.Focused)
            {
                betu = "C";
                thirdAnswear.BackColor = Color.Orange;
            }
            if (forthAnswear.Focused)
            {
                betu = "D";
                forthAnswear.BackColor = Color.Orange;
            }
            string helyes = jk.helyesBetu(N);
            switch (helyes)
            {
                case "A": firstAnswer.BackColor = Color.Green; break;
                case "B": secondAnswear.BackColor = Color.Green; break;
                case "C": thirdAnswear.BackColor = Color.Green; break;
                case "D": forthAnswear.BackColor = Color.Green; break;
            }
            //ide még egy zene jön
            string message = "You gave up this level. You won the {0}", szintT;
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

        private void thirdAnswear_Click(object sender, EventArgs e)
        {
            betu = "C";
            thirdAnswear.BackColor = Color.Orange;
            Thread tt = new Thread(staart);
            tt.Start();
        }

        private void forthAnswear_Click(object sender, EventArgs e)
        {
            betu = "D";
            forthAnswear.BackColor = Color.Orange;
            Thread tt = new Thread(staart);
            tt.Start();
        }

        private void Game_Load_1(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            t.Stop();
            Application.DoEvents();
            this.Close();
        }
     
        private void felezo_Click_1(object sender, EventArgs e)
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
            felezo.Enabled = false;
        }
    }
}
