namespace Legyen_ön_is_Milliomos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.szoveges = new System.Windows.Forms.Button();
            this.kepes = new System.Windows.Forms.Button();
            this.zenes = new System.Windows.Forms.Button();
            this.segitE = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // szoveges
            // 
            this.szoveges.Location = new System.Drawing.Point(12, 246);
            this.szoveges.Name = "szoveges";
            this.szoveges.Size = new System.Drawing.Size(125, 30);
            this.szoveges.TabIndex = 0;
            this.szoveges.Text = "Szöveges kvíz";
            this.szoveges.UseVisualStyleBackColor = true;
            this.szoveges.Click += new System.EventHandler(this.szoveges_Click);
            // 
            // kepes
            // 
            this.kepes.Location = new System.Drawing.Point(12, 282);
            this.kepes.Name = "kepes";
            this.kepes.Size = new System.Drawing.Size(125, 30);
            this.kepes.TabIndex = 1;
            this.kepes.Text = "Kép kvíz";
            this.kepes.UseVisualStyleBackColor = true;
            this.kepes.Click += new System.EventHandler(this.kepes_Click);
            // 
            // zenes
            // 
            this.zenes.Location = new System.Drawing.Point(12, 318);
            this.zenes.Name = "zenes";
            this.zenes.Size = new System.Drawing.Size(125, 30);
            this.zenes.TabIndex = 2;
            this.zenes.Text = "Zene kvíz";
            this.zenes.UseVisualStyleBackColor = true;
            this.zenes.Click += new System.EventHandler(this.zenes_Click);
            // 
            // segitE
            // 
            this.segitE.Location = new System.Drawing.Point(12, 354);
            this.segitE.Name = "segitE";
            this.segitE.Size = new System.Drawing.Size(125, 30);
            this.segitE.TabIndex = 3;
            this.segitE.Text = "Segítség";
            this.segitE.UseVisualStyleBackColor = true;
            this.segitE.Click += new System.EventHandler(this.segitE_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Vissza";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.segitE);
            this.Controls.Add(this.zenes);
            this.Controls.Add(this.kepes);
            this.Controls.Add(this.szoveges);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button szoveges;
        private System.Windows.Forms.Button kepes;
        private System.Windows.Forms.Button zenes;
        private System.Windows.Forms.Button segitE;
        private System.Windows.Forms.Button btnBack;
    }
}