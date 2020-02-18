namespace Legyen_ön_is_Milliomos
{
    partial class foAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foAblak));
            this.btmStart = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnKerdes = new System.Windows.Forms.Button();
            this.btnPicKviz = new System.Windows.Forms.Button();
            this.btnZene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmStart
            // 
            this.btmStart.BackColor = System.Drawing.SystemColors.Control;
            this.btmStart.Location = new System.Drawing.Point(325, 420);
            this.btmStart.Name = "btmStart";
            this.btmStart.Size = new System.Drawing.Size(150, 30);
            this.btmStart.TabIndex = 0;
            this.btmStart.Text = "Új játék";
            this.btmStart.UseVisualStyleBackColor = false;
            this.btmStart.Click += new System.EventHandler(this.btmStart_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(325, 456);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 30);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Korábbi játék betöltése";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(718, 452);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 70);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Súgó";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(325, 492);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(150, 30);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profil";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 70);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(718, 12);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(70, 70);
            this.btnScore.TabIndex = 6;
            this.btnScore.Text = "Statisztika";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnKerdes
            // 
            this.btnKerdes.Location = new System.Drawing.Point(13, 12);
            this.btnKerdes.Name = "btnKerdes";
            this.btnKerdes.Size = new System.Drawing.Size(75, 76);
            this.btnKerdes.TabIndex = 7;
            this.btnKerdes.Text = "Kérdés felvétele";
            this.btnKerdes.UseVisualStyleBackColor = true;
            this.btnKerdes.Click += new System.EventHandler(this.btnKerdes_Click);
            // 
            // btnPicKviz
            // 
            this.btnPicKviz.Location = new System.Drawing.Point(13, 94);
            this.btnPicKviz.Name = "btnPicKviz";
            this.btnPicKviz.Size = new System.Drawing.Size(75, 63);
            this.btnPicKviz.TabIndex = 8;
            this.btnPicKviz.Text = "Kép kvíz";
            this.btnPicKviz.UseVisualStyleBackColor = true;
            this.btnPicKviz.Click += new System.EventHandler(this.btnPicKviz_Click);
            // 
            // btnZene
            // 
            this.btnZene.Location = new System.Drawing.Point(13, 163);
            this.btnZene.Name = "btnZene";
            this.btnZene.Size = new System.Drawing.Size(75, 69);
            this.btnZene.TabIndex = 9;
            this.btnZene.Text = "Zene kvíz";
            this.btnZene.UseVisualStyleBackColor = true;
            this.btnZene.Click += new System.EventHandler(this.btnZene_Click);
            // 
            // foAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btnZene);
            this.Controls.Add(this.btnPicKviz);
            this.Controls.Add(this.btnKerdes);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btmStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "foAblak";
            this.Text = "Legyen ön is Milliomos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmStart;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnKerdes;
        private System.Windows.Forms.Button btnPicKviz;
        private System.Windows.Forms.Button btnZene;
    }
}

