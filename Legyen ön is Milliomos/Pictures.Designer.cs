namespace Legyen_ön_is_Milliomos
{
    partial class Pictures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pictures));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.picQu = new System.Windows.Forms.Label();
            this.valaszA = new System.Windows.Forms.Label();
            this.valaszB = new System.Windows.Forms.Label();
            this.valaszC = new System.Windows.Forms.Label();
            this.valaszD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(530, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Vissza";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picQu
            // 
            this.picQu.AutoSize = true;
            this.picQu.Location = new System.Drawing.Point(68, 260);
            this.picQu.Name = "picQu";
            this.picQu.Size = new System.Drawing.Size(87, 13);
            this.picQu.TabIndex = 2;
            this.picQu.Text = "Mi van a képen?";
            // 
            // valaszA
            // 
            this.valaszA.AutoSize = true;
            this.valaszA.Location = new System.Drawing.Point(28, 311);
            this.valaszA.Name = "valaszA";
            this.valaszA.Size = new System.Drawing.Size(47, 13);
            this.valaszA.TabIndex = 3;
            this.valaszA.Text = "A válasz";
            // 
            // valaszB
            // 
            this.valaszB.AutoSize = true;
            this.valaszB.Location = new System.Drawing.Point(175, 311);
            this.valaszB.Name = "valaszB";
            this.valaszB.Size = new System.Drawing.Size(47, 13);
            this.valaszB.TabIndex = 4;
            this.valaszB.Text = "B válasz";
            // 
            // valaszC
            // 
            this.valaszC.AutoSize = true;
            this.valaszC.Location = new System.Drawing.Point(28, 357);
            this.valaszC.Name = "valaszC";
            this.valaszC.Size = new System.Drawing.Size(47, 13);
            this.valaszC.TabIndex = 5;
            this.valaszC.Text = "C válasz";
            // 
            // valaszD
            // 
            this.valaszD.AutoSize = true;
            this.valaszD.Location = new System.Drawing.Point(175, 357);
            this.valaszD.Name = "valaszD";
            this.valaszD.Size = new System.Drawing.Size(48, 13);
            this.valaszD.TabIndex = 6;
            this.valaszD.Text = "D válasz";
            this.valaszD.Click += new System.EventHandler(this.valaszD_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(338, 157);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(29, 13);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "timer";
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.valaszD);
            this.Controls.Add(this.valaszC);
            this.Controls.Add(this.valaszB);
            this.Controls.Add(this.valaszA);
            this.Controls.Add(this.picQu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pictures";
            this.Text = "Pictures";
            this.Load += new System.EventHandler(this.Pictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label picQu;
        private System.Windows.Forms.Label valaszA;
        private System.Windows.Forms.Label valaszB;
        private System.Windows.Forms.Label valaszC;
        private System.Windows.Forms.Label valaszD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
    }
}