using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_Milliomos
{
    public partial class Game : Form
    {
        public bool dontRunHandler;
        System.Timers.Timer t = new System.Timers.Timer();
        System.Timers.Timer t2 = new System.Timers.Timer();
        public int countDown = 0;
        public int countDown2 = 0;

        public Random r = new Random();
        foAblak ujrajatsz = new foAblak();
        JatekKerdesek jk = new JatekKerdesek();
        Profile pf = new Profile();
        Pontszam pTsz = new Pontszam();
        private int szintT = 1;
        private int N;
        private string betu = "A";
        public int[] tomb = new int[50000];
 
        public int pontszam;
        string[] mentettAllas;

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            countDown++;
            if (countDown % 3 == 0)
            {
                t.Stop();
                getAnswear(betu);
            }
        }

        private void OnTimeEvent2(object sender, ElapsedEventArgs e)
        {
            countDown2++;
            if (countDown2 % 3 == 0)
            {
                t2.Stop();
                text();
            }
        }

        public Game()
        {
            InitializeComponent();
            pTsz.Id++;
            t.Elapsed += new ElapsedEventHandler(OnTimeEvent);
            t.Interval = 1000;
            t2.Elapsed += new ElapsedEventHandler(OnTimeEvent2);
            t2.Interval = 1000;
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
                if (Properties.Settings.Default.mentes)
                {
                    try
                    {
                        Properties.Settings.Default.mentes = false;
                        mentettAllas = File.ReadAllLines("save.txt", Encoding.UTF8);
                        string[] adatok = mentettAllas[0].Split(';');
                        pTsz.Id = Convert.ToInt32(adatok[2]);
                        N = Convert.ToInt32(adatok[4]);
                        szintT = Convert.ToInt32(adatok[3]);
                        pontszam = Convert.ToInt32(adatok[1]);
                        Properties.Settings.Default.playerName = adatok[0];
                        Question.Text = szintT + ".  " + jk.getKerdes(N, szintT);
                        firstAnswer.Text = jk.getValaszA(N, szintT);
                        secondAnswear.Text = jk.getValaszB(N, szintT);
                        thirdAnswear.Text = jk.getValaszC(N, szintT);
                        forthAnswear.Text = jk.getValaszD(N, szintT); 
                        switch (szintT)
                        {
                            case 1: lvl1.BackColor = Color.Orange; break;
                            case 2:
                                lvl2.BackColor = Color.Orange;
                                lvl1.BackColor = Color.Green;  break;
                            case 3:
                                lvl3.BackColor = Color.Orange;
                                lvl2.BackColor = Color.Green;  break;
                            case 4:
                                lvl4.BackColor = Color.Orange;
                                lvl3.BackColor = Color.Green;  break;
                            case 5:
                                lvl5.BackColor = Color.Orange;
                                lvl4.BackColor = Color.Green;  break;
                            case 6:
                                lvl6.BackColor = Color.Orange;
                                lvl5.BackColor = Color.Green; break;
                            case 7:
                                lvl7.BackColor = Color.Orange;
                                lvl6.BackColor = Color.Green;  break;
                            case 8:
                                lvl8.BackColor = Color.Orange;
                                lvl7.BackColor = Color.Green;  break;
                            case 9:
                                lvl9.BackColor = Color.Orange;
                                lvl8.BackColor = Color.Green;  break;
                            case 10:
                                lvl10.BackColor = Color.Orange;
                                lvl9.BackColor = Color.Green;  break;
                            case 11:
                                lvl11.BackColor = Color.Orange;
                                lvl10.BackColor = Color.Green;  break;
                            case 12:
                                lvl12.BackColor = Color.Orange;
                                lvl11.BackColor = Color.Green;  break;
                            case 13:
                                lvl13.BackColor = Color.Orange;
                                lvl12.BackColor = Color.Green;  break;
                            case 14:
                                lvl14.BackColor = Color.Orange;
                                lvl13.BackColor = Color.Green;  break;
                            case 15:
                                lvl15.BackColor = Color.Orange;
                                lvl14.BackColor = Color.Green; break;
                            case 16:
                                lvl15.BackColor = Color.Green;  break;
                        }
                    }
                    catch (FileNotFoundException e)
                    {

                    }
                }
                else
                {
                    N = jk.getSor(szintT, tomb[szintT]);
                    Question.Text = szintT + ".  " + jk.getKerdes(N, szintT);
                    firstAnswer.Text = jk.getValaszA(N, szintT);
                    secondAnswear.Text = jk.getValaszB(N, szintT);
                    thirdAnswear.Text = jk.getValaszC(N, szintT);
                    forthAnswear.Text = jk.getValaszD(N, szintT);
                }
                if(szintT != 1)
                {
                    pontszam++;
                }
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
                switch (szintT)
                {
                    case 1: lvl1.BackColor = Color.Orange; break;
                    case 2: lvl2.BackColor = Color.Orange;
                            lvl1.BackColor = Color.Green;  break;
                    case 3: lvl3.BackColor = Color.Orange;
                            lvl2.BackColor = Color.Green; break;
                    case 4: lvl4.BackColor = Color.Orange;
                            lvl3.BackColor = Color.Green; break;
                    case 5: lvl5.BackColor = Color.Orange;
                            lvl4.BackColor = Color.Green;  break;
                    case 6: lvl6.BackColor = Color.Orange;
                            lvl5.BackColor = Color.Green;  break;
                    case 7: lvl7.BackColor = Color.Orange;
                            lvl6.BackColor = Color.Green;  break;
                    case 8: lvl8.BackColor = Color.Orange;
                            lvl7.BackColor = Color.Green;  break;
                    case 9: lvl9.BackColor = Color.Orange;
                            lvl8.BackColor = Color.Green;  break;
                    case 10: lvl10.BackColor = Color.Orange;
                             lvl9.BackColor = Color.Green;  break;
                    case 11: lvl11.BackColor = Color.Orange;
                             lvl10.BackColor = Color.Green;  break;
                    case 12: lvl12.BackColor = Color.Orange;
                             lvl11.BackColor = Color.Green; break;
                    case 13: lvl13.BackColor = Color.Orange;
                             lvl12.BackColor = Color.Green;  break;
                    case 14: lvl14.BackColor = Color.Orange;
                             lvl13.BackColor = Color.Green;  break;
                    case 15: lvl15.BackColor = Color.Orange;
                             lvl14.BackColor = Color.Green;  break;
                    case 16: lvl15.BackColor = Color.Green; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void error()
        {
            jk.win = "lost";
            string message = "Worng! You lost!";
            string caption = "Game over!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
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
                //t2.Interval = 1000;
                //t2.Elapsed += OnTimeEvent2;
            }
            else
            {
                error();
            }
        }

        private void firstAnswer_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "A";
                firstAnswer.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.BackColor = Color.Green; break;
                    case "B": secondAnswear.BackColor = Color.Green; break;
                    case "C": thirdAnswear.BackColor = Color.Green; break;
                    case "D": forthAnswear.BackColor = Color.Green; break;
                }
                //ide még egy zene jön
                string message = "You gave up on this level. You won the "+ szintT + "level";
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
                firstAnswer.BackColor = Color.Orange;
                //Thread tt = new Thread(staart);
                //tt.Start();
                t.Start();
            }
        }

        private void secondAnswear_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "B";
                secondAnswear.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.BackColor = Color.Green; break;
                    case "B": secondAnswear.BackColor = Color.Green; break;
                    case "C": thirdAnswear.BackColor = Color.Green; break;
                    case "D": forthAnswear.BackColor = Color.Green; break;
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
                secondAnswear.BackColor = Color.Orange;
                //Thread tt = new Thread(staart);
                //tt.Start();
                t.Start();
            }
        }

        private void megallas_Click(object sender, EventArgs e)
        {
            dontRunHandler = true;           
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (jk.win.Equals("won"))
            {
                Properties.Settings.Default.ID = pTsz.Id;
                int ize = Properties.Settings.Default.ID;
                Properties.Settings.Default.levels = pontszam/4;
                Properties.Settings.Default.Save();
                File.WriteAllText("save.txt", "");
                using (StreamWriter outputFile = File.AppendText("pontszamok.txt"))
                {
                    //outputFile.Write(ize + ';');
                    outputFile.WriteLine(Properties.Settings.Default.playerName + ';' + pontszam/4 + ';' + ize);
                }
                jk.win = "";
            }
            else if(jk.win.Equals("lost"))
            {
                Properties.Settings.Default.ID = pTsz.Id;
                int ize = Properties.Settings.Default.ID;
                Properties.Settings.Default.levels = pontszam/4;
                Properties.Settings.Default.Save();
                File.WriteAllText("save.txt", "");
                using (StreamWriter outputFile = File.AppendText("pontszamok.txt"))
                {
                    //outputFile.Write(ize + ';');
                    outputFile.WriteLine(Properties.Settings.Default.playerName + ';' + (pontszam/4) + ';' + ize);
                }
                jk.win = "";
            }
            else
            {
                Properties.Settings.Default.ID = pTsz.Id;
                int ize = Properties.Settings.Default.ID;
                Properties.Settings.Default.levels = pontszam/4;
                Properties.Settings.Default.Save();
                using (StreamWriter outputFile = new StreamWriter("save.txt"))
                {
                    outputFile.WriteLine(Properties.Settings.Default.playerName + ';' + (pontszam/4) + ';' + ize + ';' + Convert.ToString(szintT) + ';' + Convert.ToString(N));
                }
            }
        }

        private void thirdAnswear_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "C";
                thirdAnswear.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.BackColor = Color.Green; break;
                    case "B": secondAnswear.BackColor = Color.Green; break;
                    case "C": thirdAnswear.BackColor = Color.Green; break;
                    case "D": forthAnswear.BackColor = Color.Green; break;
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
                thirdAnswear.BackColor = Color.Orange;
                //Thread tt = new Thread(staart);
                //tt.Start();
                t.Start();
            }
            
        }

        private void forthAnswear_Click(object sender, EventArgs e)
        {
            if (dontRunHandler)
            {
                betu = "D";
                forthAnswear.BackColor = Color.Orange;
                string helyes = jk.helyesBetu(N);
                switch (helyes)
                {
                    case "A": firstAnswer.BackColor = Color.Green; break;
                    case "B": secondAnswear.BackColor = Color.Green; break;
                    case "C": thirdAnswear.BackColor = Color.Green; break;
                    case "D": forthAnswear.BackColor = Color.Green; break;
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
                forthAnswear.BackColor = Color.Orange;
                //Thread tt = new Thread(staart);
                //tt.Start();
                t.Start();
            }
            
        }

        private void Game_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < jk.kerdesek.Length - 1; i++)
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

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
            int rand, rand2;
            do
            {
                rand = r.Next(0, 4);
                rand2 = r.Next(0, 4);
            } while (rand == rand2 || rand == HV || rand2 == HV);
            switch (rand)
            {
                case 0: firstAnswer.Visible = false; break;
                case 1: secondAnswear.Visible = false; break;
                case 2: thirdAnswear.Visible = false; break;
                case 3: forthAnswear.Visible = false; break;
            }
            switch (rand2)
            {
                case 0: firstAnswer.Visible = false; break;
                case 1: secondAnswear.Visible = false; break;
                case 2: thirdAnswear.Visible = false; break;
                case 3: forthAnswear.Visible = false; break;
            }
            if(!firstAnswer.Visible || !secondAnswear.Visible || !thirdAnswear.Visible || !forthAnswear.Visible)
            {
                felezo.Enabled = false;
            }
        }
    }
}
