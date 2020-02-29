namespace Legyen_ön_is_Milliomos
{
    partial class Kozonseg
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kozonsegChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kozonsegChart)).BeginInit();
            this.SuspendLayout();
            // 
            // kozonsegChart
            // 
            chartArea1.Name = "ChartArea1";
            this.kozonsegChart.ChartAreas.Add(chartArea1);
            this.kozonsegChart.Location = new System.Drawing.Point(12, 12);
            this.kozonsegChart.Name = "kozonsegChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.kozonsegChart.Series.Add(series1);
            this.kozonsegChart.Size = new System.Drawing.Size(260, 300);
            this.kozonsegChart.TabIndex = 0;
            this.kozonsegChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kozonseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kozonsegChart);
            this.Name = "Kozonseg";
            this.Text = "Kozonseg";
            this.Load += new System.EventHandler(this.Kozonseg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kozonsegChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart kozonsegChart;
        private System.Windows.Forms.Button button1;
    }
}