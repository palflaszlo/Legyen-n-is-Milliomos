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
    public partial class Pictures : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;
        static int countDown;
        public bool dontRunHandler;

        public Pictures()
        {
            InitializeComponent();
            myTimer.Start();
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
            labelTimer.Text = "asfasd";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* Adds the event and the event handler for the method that will 
          process the timer event to the timer. */
            // myTimer.Tick += new EventHandler(TimerEventProcessor);
            countDown++;
            labelTimer.Text = Convert.ToString(countDown);
            if (countDown == 10)
            {
                labelTimer.Text = "Done";
                timer1.Stop();
            }
            // Sets the timer interval to 5 seconds.
            // myTimer.Interval = 5000;
            //myTimer.Start();

            // Runs the timer, and raises the event.
            /*    while (exitFlag == false)
                {
                    // Processes all the events in the queue.
                    Application.DoEvents();
                }*/
        }

        // This is the method to run when the timer is raised.
        private static void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            myTimer.Stop();

            // Displays a message box asking whether to continue running the timer.
            if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Restarts the timer and increments the counter.
                alarmCounter += 1;
                myTimer.Enabled = true;
            }
            else
            {
                // Stops the timer.
                exitFlag = true;
            }
        }

        private void valaszD_Click(object sender, EventArgs e)
        {/*
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
                Thread tt = new Thread(staart);
                tt.Start();
            }*/
        }
    }
}
