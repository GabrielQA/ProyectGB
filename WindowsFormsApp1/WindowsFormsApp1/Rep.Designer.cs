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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboboxRep1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.No;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 44);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(331, 298);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboboxRep1
            // 
            this.comboboxRep1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxRep1.FormattingEnabled = true;
            this.comboboxRep1.Location = new System.Drawing.Point(139, 10);
            this.comboboxRep1.Margin = new System.Windows.Forms.Padding(4);
            this.comboboxRep1.Name = "comboboxRep1";
            this.comboboxRep1.Size = new System.Drawing.Size(204, 24);
            this.comboboxRep1.TabIndex = 22;
            this.comboboxRep1.SelectedIndexChanged += new System.EventHandler(this.comboboxRep1_SelectedIndexChanged);
            this.comboboxRep1.SelectedValueChanged += new System.EventHandler(this.comboboxRep1_SelectedValueChanged);
            this.comboboxRep1.Click += new System.EventHandler(this.comboboxRep1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre del hotel:";
            // 
            // Rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboboxRep1);
            this.Controls.Add(this.chart1);
            this.Name = "Rep";
            this.Text = "Rep";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboboxRep1;
        private System.Windows.Forms.Label label1;
    }
}