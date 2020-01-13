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
            this.Question = new System.Windows.Forms.Label();
            this.firstAnswer = new System.Windows.Forms.Label();
            this.thirdAnswear = new System.Windows.Forms.Label();
            this.secondAnswear = new System.Windows.Forms.Label();
            this.forthAnswear = new System.Windows.Forms.Label();
            this.lbLevels = new System.Windows.Forms.ListBox();
            this.gbHelps = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.gbHelps.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Question.Location = new System.Drawing.Point(180, 238);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(252, 37);
            this.Question.TabIndex = 1;
            this.Question.Text = "Ide jön  a kérdés";
            // 
            // firstAnswer
            // 
            this.firstAnswer.AutoSize = true;
            this.firstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstAnswer.Location = new System.Drawing.Point(58, 322);
            this.firstAnswer.Name = "firstAnswer";
            this.firstAnswer.Size = new System.Drawing.Size(122, 25);
            this.firstAnswer.TabIndex = 2;
            this.firstAnswer.Text = "Első válasz";
            // 
            // thirdAnswear
            // 
            this.thirdAnswear.AutoSize = true;
            this.thirdAnswear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirdAnswear.Location = new System.Drawing.Point(71, 394);
            this.thirdAnswear.Name = "thirdAnswear";
            this.thirdAnswear.Size = new System.Drawing.Size(171, 25);
            this.thirdAnswear.TabIndex = 3;
            this.thirdAnswear.Text = "Harmadik válasz";
            // 
            // secondAnswear
            // 
            this.secondAnswear.AutoSize = true;
            this.secondAnswear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondAnswear.Location = new System.Drawing.Point(318, 322);
            this.secondAnswear.Name = "secondAnswear";
            this.secondAnswear.Size = new System.Drawing.Size(161, 25);
            this.secondAnswear.TabIndex = 4;
            this.secondAnswear.Text = "Második válasz";
            this.secondAnswear.Click += new System.EventHandler(this.secondAnswear_Click);
            // 
            // forthAnswear
            // 
            this.forthAnswear.AutoSize = true;
            this.forthAnswear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forthAnswear.Location = new System.Drawing.Point(379, 394);
            this.forthAnswear.Name = "forthAnswear";
            this.forthAnswear.Size = new System.Drawing.Size(170, 25);
            this.forthAnswear.TabIndex = 5;
            this.forthAnswear.Text = "Negyedik válasz";
            // 
            // lbLevels
            // 
            this.lbLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLevels.FormattingEnabled = true;
            this.lbLevels.ItemHeight = 18;
            this.lbLevels.Location = new System.Drawing.Point(638, 126);
            this.lbLevels.Name = "lbLevels";
            this.lbLevels.Size = new System.Drawing.Size(140, 310);
            this.lbLevels.TabIndex = 6;
            // 
            // gbHelps
            // 
            this.gbHelps.Controls.Add(this.button3);
            this.gbHelps.Controls.Add(this.button2);
            this.gbHelps.Controls.Add(this.button1);
            this.gbHelps.Location = new System.Drawing.Point(597, 12);
            this.gbHelps.Name = "gbHelps";
            this.gbHelps.Size = new System.Drawing.Size(181, 100);
            this.gbHelps.TabIndex = 7;
            this.gbHelps.TabStop = false;
            this.gbHelps.Text = "Segítségek";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.gbHelps);
            this.Controls.Add(this.lbLevels);
            this.Controls.Add(this.forthAnswear);
            this.Controls.Add(this.secondAnswear);
            this.Controls.Add(this.thirdAnswear);
            this.Controls.Add(this.firstAnswer);
            this.Controls.Add(this.Question);
            this.Name = "Game";
            this.Text = "Game";
            this.gbHelps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label firstAnswer;
        private System.Windows.Forms.Label thirdAnswear;
        private System.Windows.Forms.Label secondAnswear;
        private System.Windows.Forms.Label forthAnswear;
        private System.Windows.Forms.ListBox lbLevels;
        private System.Windows.Forms.GroupBox gbHelps;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExitGame;
    }
}