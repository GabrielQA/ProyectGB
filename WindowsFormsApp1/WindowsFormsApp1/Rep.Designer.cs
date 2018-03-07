namespace WindowsFormsApp1
{
    partial class Rep
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.QQ = new System.Windows.Forms.TextBox();
            this.QQQ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(165, 68);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(564, 268);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // QQ
            // 
            this.QQ.Location = new System.Drawing.Point(673, 429);
            this.QQ.Name = "QQ";
            this.QQ.Size = new System.Drawing.Size(156, 22);
            this.QQ.TabIndex = 2;
            // 
            // QQQ
            // 
            this.QQQ.Location = new System.Drawing.Point(673, 401);
            this.QQQ.Name = "QQQ";
            this.QQQ.Size = new System.Drawing.Size(156, 22);
            this.QQQ.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QQ);
            this.Controls.Add(this.QQQ);
            this.Controls.Add(this.chart1);
            this.Name = "Rep";
            this.Text = "Rep";
            this.Load += new System.EventHandler(this.Rep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox QQ;
        private System.Windows.Forms.TextBox QQQ;
        private System.Windows.Forms.Button button1;
    }
}