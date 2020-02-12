namespace Legyen_ön_is_Milliomos
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Question = new System.Windows.Forms.Label();
            this.firstAnswer = new System.Windows.Forms.Label();
            this.thirdAnswear = new System.Windows.Forms.Label();
            this.secondAnswear = new System.Windows.Forms.Label();
            this.forthAnswear = new System.Windows.Forms.Label();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.felezo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lvl12 = new System.Windows.Forms.Label();
            this.lvl9 = new System.Windows.Forms.Label();
            this.lvl8 = new System.Windows.Forms.Label();
            this.lvl7 = new System.Windows.Forms.Label();
            this.lvl6 = new System.Windows.Forms.Label();
            this.lvl5 = new System.Windows.Forms.Label();
            this.lvl4 = new System.Windows.Forms.Label();
            this.lvl3 = new System.Windows.Forms.Label();
            this.lvl2 = new System.Windows.Forms.Label();
            this.lvl1 = new System.Windows.Forms.Label();
            this.lvl11 = new System.Windows.Forms.Label();
            this.lvl10 = new System.Windows.Forms.Label();
            this.lvl13 = new System.Windows.Forms.Label();
            this.lvl14 = new System.Windows.Forms.Label();
            this.lvl15 = new System.Windows.Forms.Label();
            this.ellenor = new System.Windows.Forms.TextBox();
            this.ellenor2 = new System.Windows.Forms.TextBox();
            this.megallas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AllowDrop = true;
            this.Question.AutoEllipsis = true;
            this.Question.BackColor = System.Drawing.Color.Black;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Question.ForeColor = System.Drawing.Color.White;
            this.Question.Location = new System.Drawing.Point(12, 285);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(667, 108);
            this.Question.TabIndex = 1;
            this.Question.Text = "Ide jön  a kérdés";
            this.Question.UseCompatibleTextRendering = true;
            // 
            // firstAnswer
            // 
            this.firstAnswer.AutoEllipsis = true;
            this.firstAnswer.BackColor = System.Drawing.Color.Black;
            this.firstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstAnswer.ForeColor = System.Drawing.Color.White;
            this.firstAnswer.Location = new System.Drawing.Point(12, 394);
            this.firstAnswer.Name = "firstAnswer";
            this.firstAnswer.Size = new System.Drawing.Size(311, 65);
            this.firstAnswer.TabIndex = 2;
            this.firstAnswer.Text = "Első válasz";
            this.firstAnswer.Click += new System.EventHandler(this.firstAnswer_Click);
            // 
            // thirdAnswear
            // 
            this.thirdAnswear.AutoEllipsis = true;
            this.thirdAnswear.BackColor = System.Drawing.Color.Black;
            this.thirdAnswear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirdAnswear.ForeColor = System.Drawing.Color.White;
            this.thirdAnswear.Location = new System.Drawing.Point(12, 466);
            this.thirdAnswear.Name = "thirdAnswear";
            this.thirdAnswear.Size = new System.Drawing.Size(311, 59);
            this.thirdAnswear.TabIndex = 3;
            this.thirdAnswear.Text = "Harmadik válasz";
            this.thirdAnswear.Click += new System.EventHandler(this.thirdAnswear_Click);
            // 
            // secondAnswear
            // 
            this.secondAnswear.AutoEllipsis = true;
            this.secondAnswear.BackColor = System.Drawing.Color.Black;
            this.secondAnswear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondAnswear.ForeColor = System.Drawing.Color.White;
            this.secondAnswear.Location = new System.Drawing.Point(349, 394);
            this.secondAnswear.Name = "secondAnswear";
            this.secondAnswear.Size = new System.Drawing.Size(330, 65);
            this.secondAnswear.TabIndex = 4;
            this.secondAnswear.Text = "Második válasz";
            this.secondAnswear.Click += new System.EventHandler(this.secondAnswear_Click);
            // 
            // forthAnswear
            // 
            this.forthAnswear.AutoEllipsis = true;
            this.forthAnswear.BackColor = System.Drawing.Color.Black;
            this.forthAnswear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forthAnswear.ForeColor = System.Drawing.Color.White;
            this.forthAnswear.Location = new System.Drawing.Point(349, 466);
            this.forthAnswear.Name = "forthAnswear";
            this.forthAnswear.Size = new System.Drawing.Size(330, 59);
            this.forthAnswear.TabIndex = 5;
            this.forthAnswear.Text = "Negyedik válasz";
            this.forthAnswear.Click += new System.EventHandler(this.forthAnswear_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Location = new System.Drawing.Point(13, 13);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(75, 23);
            this.btnExitGame.TabIndex = 8;
            this.btnExitGame.Text = "Kilépés";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // felezo
            // 
            this.felezo.Location = new System.Drawing.Point(637, 12);
            this.felezo.Name = "felezo";
            this.felezo.Size = new System.Drawing.Size(54, 23);
            this.felezo.TabIndex = 9;
            this.felezo.Text = "felezés";
            this.felezo.UseVisualStyleBackColor = true;
            this.felezo.Click += new System.EventHandler(this.felezo_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lvl12
            // 
            this.lvl12.AutoSize = true;
            this.lvl12.BackColor = System.Drawing.Color.Transparent;
            this.lvl12.ForeColor = System.Drawing.Color.White;
            this.lvl12.Location = new System.Drawing.Point(699, 270);
            this.lvl12.Name = "lvl12";
            this.lvl12.Size = new System.Drawing.Size(85, 13);
            this.lvl12.TabIndex = 27;
            this.lvl12.Text = "12. 5 000 000 Ft";
            // 
            // lvl9
            // 
            this.lvl9.AutoSize = true;
            this.lvl9.BackColor = System.Drawing.Color.Transparent;
            this.lvl9.ForeColor = System.Drawing.Color.White;
            this.lvl9.Location = new System.Drawing.Point(699, 336);
            this.lvl9.Name = "lvl9";
            this.lvl9.Size = new System.Drawing.Size(70, 13);
            this.lvl9.TabIndex = 28;
            this.lvl9.Text = "9. 500 000 Ft";
            // 
            // lvl8
            // 
            this.lvl8.AutoSize = true;
            this.lvl8.BackColor = System.Drawing.Color.Transparent;
            this.lvl8.ForeColor = System.Drawing.Color.White;
            this.lvl8.Location = new System.Drawing.Point(699, 358);
            this.lvl8.Name = "lvl8";
            this.lvl8.Size = new System.Drawing.Size(70, 13);
            this.lvl8.TabIndex = 29;
            this.lvl8.Text = "8. 500 000 Ft";
            // 
            // lvl7
            // 
            this.lvl7.AutoSize = true;
            this.lvl7.BackColor = System.Drawing.Color.Transparent;
            this.lvl7.ForeColor = System.Drawing.Color.White;
            this.lvl7.Location = new System.Drawing.Point(699, 380);
            this.lvl7.Name = "lvl7";
            this.lvl7.Size = new System.Drawing.Size(70, 13);
            this.lvl7.TabIndex = 30;
            this.lvl7.Text = "7. 300 000 Ft";
            // 
            // lvl6
            // 
            this.lvl6.AutoSize = true;
            this.lvl6.BackColor = System.Drawing.Color.Transparent;
            this.lvl6.ForeColor = System.Drawing.Color.White;
            this.lvl6.Location = new System.Drawing.Point(699, 402);
            this.lvl6.Name = "lvl6";
            this.lvl6.Size = new System.Drawing.Size(70, 13);
            this.lvl6.TabIndex = 31;
            this.lvl6.Text = "6. 200 000 Ft";
            // 
            // lvl5
            // 
            this.lvl5.AutoSize = true;
            this.lvl5.BackColor = System.Drawing.Color.Transparent;
            this.lvl5.ForeColor = System.Drawing.Color.White;
            this.lvl5.Location = new System.Drawing.Point(699, 424);
            this.lvl5.Name = "lvl5";
            this.lvl5.Size = new System.Drawing.Size(70, 13);
            this.lvl5.TabIndex = 32;
            this.lvl5.Text = "5. 100 000 Ft";
            // 
            // lvl4
            // 
            this.lvl4.AutoSize = true;
            this.lvl4.BackColor = System.Drawing.Color.Transparent;
            this.lvl4.ForeColor = System.Drawing.Color.White;
            this.lvl4.Location = new System.Drawing.Point(699, 446);
            this.lvl4.Name = "lvl4";
            this.lvl4.Size = new System.Drawing.Size(64, 13);
            this.lvl4.TabIndex = 33;
            this.lvl4.Text = "4. 50 000 Ft";
            // 
            // lvl3
            // 
            this.lvl3.AutoSize = true;
            this.lvl3.BackColor = System.Drawing.Color.Transparent;
            this.lvl3.ForeColor = System.Drawing.Color.White;
            this.lvl3.Location = new System.Drawing.Point(699, 468);
            this.lvl3.Name = "lvl3";
            this.lvl3.Size = new System.Drawing.Size(64, 13);
            this.lvl3.TabIndex = 34;
            this.lvl3.Text = "3. 25 000 Ft";
            // 
            // lvl2
            // 
            this.lvl2.AutoSize = true;
            this.lvl2.BackColor = System.Drawing.Color.Transparent;
            this.lvl2.ForeColor = System.Drawing.Color.White;
            this.lvl2.Location = new System.Drawing.Point(699, 490);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(64, 13);
            this.lvl2.TabIndex = 35;
            this.lvl2.Text = "2. 10 000 Ft";
            // 
            // lvl1
            // 
            this.lvl1.AutoSize = true;
            this.lvl1.BackColor = System.Drawing.Color.Transparent;
            this.lvl1.ForeColor = System.Drawing.Color.White;
            this.lvl1.Location = new System.Drawing.Point(699, 512);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(58, 13);
            this.lvl1.TabIndex = 36;
            this.lvl1.Text = "1. 5 000 Ft";
            // 
            // lvl11
            // 
            this.lvl11.AutoSize = true;
            this.lvl11.BackColor = System.Drawing.Color.Transparent;
            this.lvl11.ForeColor = System.Drawing.Color.White;
            this.lvl11.Location = new System.Drawing.Point(699, 292);
            this.lvl11.Name = "lvl11";
            this.lvl11.Size = new System.Drawing.Size(85, 13);
            this.lvl11.TabIndex = 37;
            this.lvl11.Text = "11. 3 000 000 Ft";
            // 
            // lvl10
            // 
            this.lvl10.AutoSize = true;
            this.lvl10.BackColor = System.Drawing.Color.Transparent;
            this.lvl10.ForeColor = System.Drawing.Color.White;
            this.lvl10.Location = new System.Drawing.Point(699, 314);
            this.lvl10.Name = "lvl10";
            this.lvl10.Size = new System.Drawing.Size(85, 13);
            this.lvl10.TabIndex = 38;
            this.lvl10.Text = "10. 1 500 000 Ft";
            // 
            // lvl13
            // 
            this.lvl13.AutoSize = true;
            this.lvl13.BackColor = System.Drawing.Color.Transparent;
            this.lvl13.ForeColor = System.Drawing.Color.White;
            this.lvl13.Location = new System.Drawing.Point(699, 248);
            this.lvl13.Name = "lvl13";
            this.lvl13.Size = new System.Drawing.Size(91, 13);
            this.lvl13.TabIndex = 39;
            this.lvl13.Text = "13. 10 000 000 Ft";
            // 
            // lvl14
            // 
            this.lvl14.AutoSize = true;
            this.lvl14.BackColor = System.Drawing.Color.Transparent;
            this.lvl14.ForeColor = System.Drawing.Color.White;
            this.lvl14.Location = new System.Drawing.Point(699, 226);
            this.lvl14.Name = "lvl14";
            this.lvl14.Size = new System.Drawing.Size(91, 13);
            this.lvl14.TabIndex = 40;
            this.lvl14.Text = "14. 20 000 000 Ft";
            // 
            // lvl15
            // 
            this.lvl15.AutoSize = true;
            this.lvl15.BackColor = System.Drawing.Color.Transparent;
            this.lvl15.ForeColor = System.Drawing.Color.White;
            this.lvl15.Location = new System.Drawing.Point(699, 204);
            this.lvl15.Name = "lvl15";
            this.lvl15.Size = new System.Drawing.Size(91, 13);
            this.lvl15.TabIndex = 41;
            this.lvl15.Text = "15. 40 000 000 Ft";
            // 
            // ellenor
            // 
            this.ellenor.Location = new System.Drawing.Point(52, 79);
            this.ellenor.Name = "ellenor";
            this.ellenor.Size = new System.Drawing.Size(100, 20);
            this.ellenor.TabIndex = 42;
            this.ellenor.Text = "00:00:00";
            this.ellenor.Visible = false;
            // 
            // ellenor2
            // 
            this.ellenor2.Location = new System.Drawing.Point(219, 79);
            this.ellenor2.Name = "ellenor2";
            this.ellenor2.Size = new System.Drawing.Size(100, 20);
            this.ellenor2.TabIndex = 43;
            this.ellenor2.Text = "00:00:00";
            this.ellenor2.Visible = false;
            // 
            // megallas
            // 
            this.megallas.Location = new System.Drawing.Point(106, 12);
            this.megallas.Name = "megallas";
            this.megallas.Size = new System.Drawing.Size(75, 23);
            this.megallas.TabIndex = 44;
            this.megallas.Text = "Megállni";
            this.megallas.UseVisualStyleBackColor = true;
            this.megallas.Click += new System.EventHandler(this.megallas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(398, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "label2";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.megallas);
            this.Controls.Add(this.ellenor2);
            this.Controls.Add(this.ellenor);
            this.Controls.Add(this.lvl15);
            this.Controls.Add(this.lvl14);
            this.Controls.Add(this.lvl13);
            this.Controls.Add(this.lvl10);
            this.Controls.Add(this.lvl11);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.lvl3);
            this.Controls.Add(this.lvl4);
            this.Controls.Add(this.lvl5);
            this.Controls.Add(this.lvl6);
            this.Controls.Add(this.lvl7);
            this.Controls.Add(this.lvl8);
            this.Controls.Add(this.lvl9);
            this.Controls.Add(this.lvl12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.felezo);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.forthAnswear);
            this.Controls.Add(this.secondAnswear);
            this.Controls.Add(this.thirdAnswear);
            this.Controls.Add(this.firstAnswer);
            this.Controls.Add(this.Question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label firstAnswer;
        private System.Windows.Forms.Label thirdAnswear;
        private System.Windows.Forms.Label secondAnswear;
        private System.Windows.Forms.Label forthAnswear;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button felezo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lvl12;
        private System.Windows.Forms.Label lvl9;
        private System.Windows.Forms.Label lvl8;
        private System.Windows.Forms.Label lvl7;
        private System.Windows.Forms.Label lvl6;
        private System.Windows.Forms.Label lvl5;
        private System.Windows.Forms.Label lvl4;
        private System.Windows.Forms.Label lvl3;
        private System.Windows.Forms.Label lvl2;
        private System.Windows.Forms.Label lvl1;
        private System.Windows.Forms.Label lvl11;
        private System.Windows.Forms.Label lvl10;
        private System.Windows.Forms.Label lvl13;
        private System.Windows.Forms.Label lvl14;
        private System.Windows.Forms.Label lvl15;
        private System.Windows.Forms.TextBox ellenor;
        private System.Windows.Forms.TextBox ellenor2;
        private System.Windows.Forms.Button megallas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}