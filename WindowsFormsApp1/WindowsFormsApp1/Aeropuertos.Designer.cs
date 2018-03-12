namespace WindowsFormsApp1
{
    partial class Aeropuertos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.A1 = new System.Windows.Forms.TextBox();
            this.A4 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.A3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.M1 = new System.Windows.Forms.TextBox();
            this.M4 = new System.Windows.Forms.TextBox();
            this.M2 = new System.Windows.Forms.TextBox();
            this.M3 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(28, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 443);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.A1);
            this.tabPage1.Controls.Add(this.A4);
            this.tabPage1.Controls.Add(this.A2);
            this.tabPage1.Controls.Add(this.A3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Añadir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(125, 304);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(157, 22);
            this.A1.TabIndex = 15;
            this.A1.TextChanged += new System.EventHandler(this.IDTXT_TextChanged);
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(646, 304);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(169, 22);
            this.A4.TabIndex = 13;
            this.A4.Leave += new System.EventHandler(this.A4_Leave);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(288, 304);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(166, 22);
            this.A2.TabIndex = 12;
            this.A2.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(460, 304);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(180, 22);
            this.A3.TabIndex = 11;
            this.A3.TextChanged += new System.EventHandler(this.b_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 266);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.M1);
            this.tabPage2.Controls.Add(this.M4);
            this.tabPage2.Controls.Add(this.M2);
            this.tabPage2.Controls.Add(this.M3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.MouseHover += new System.EventHandler(this.tabPage2_MouseHover);
            // 
            // M1
            // 
            this.M1.Enabled = false;
            this.M1.Location = new System.Drawing.Point(142, 327);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(175, 22);
            this.M1.TabIndex = 19;
            this.M1.TextChanged += new System.EventHandler(this.M1_TextChanged);
            // 
            // M4
            // 
            this.M4.Location = new System.Drawing.Point(669, 327);
            this.M4.Name = "M4";
            this.M4.Size = new System.Drawing.Size(175, 22);
            this.M4.TabIndex = 18;
            this.M4.TextChanged += new System.EventHandler(this.M4_TextChanged);
            this.M4.DoubleClick += new System.EventHandler(this.M4_DoubleClick);
            this.M4.Leave += new System.EventHandler(this.M4_Leave);
            // 
            // M2
            // 
            this.M2.Location = new System.Drawing.Point(323, 327);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(166, 22);
            this.M2.TabIndex = 17;
            this.M2.TextChanged += new System.EventHandler(this.M2_TextChanged);
            // 
            // M3
            // 
            this.M3.Location = new System.Drawing.Point(495, 327);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(165, 22);
            this.M3.TabIndex = 16;
            this.M3.TextChanged += new System.EventHandler(this.M3_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(70, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(888, 266);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1043, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(77, 74);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(888, 266);
            this.dataGridView3.TabIndex = 20;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 24);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Aeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 547);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Aeropuertos";
            this.Text = "Aeropuertos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox A4;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox M1;
        private System.Windows.Forms.TextBox M4;
        private System.Windows.Forms.TextBox M2;
        private System.Windows.Forms.TextBox M3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
    }
}