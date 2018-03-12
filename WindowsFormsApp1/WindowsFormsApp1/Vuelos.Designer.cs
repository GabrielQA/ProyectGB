namespace WindowsFormsApp1
{
    partial class Vuelos
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxHotel = new System.Windows.Forms.CheckBox();
            this.boxAuto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.spnPasajeros = new System.Windows.Forms.NumericUpDown();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlPasajeros = new System.Windows.Forms.Panel();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.spnHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.pnlHotel = new System.Windows.Forms.Panel();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPreliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnPasajeros)).BeginInit();
            this.pnlPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHabitaciones)).BeginInit();
            this.pnlHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.pnlAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encuentra tu vuelo";
            // 
            // boxHotel
            // 
            this.boxHotel.AutoSize = true;
            this.boxHotel.Location = new System.Drawing.Point(141, 8);
            this.boxHotel.Name = "boxHotel";
            this.boxHotel.Size = new System.Drawing.Size(84, 17);
            this.boxHotel.TabIndex = 1;
            this.boxHotel.Text = "Añadir Hotel";
            this.boxHotel.UseVisualStyleBackColor = true;
            this.boxHotel.CheckedChanged += new System.EventHandler(this.boxHotel_CheckedChanged);
            // 
            // boxAuto
            // 
            this.boxAuto.AutoSize = true;
            this.boxAuto.Location = new System.Drawing.Point(250, 8);
            this.boxAuto.Name = "boxAuto";
            this.boxAuto.Size = new System.Drawing.Size(81, 17);
            this.boxAuto.TabIndex = 2;
            this.boxAuto.Text = "Añadir Auto";
            this.boxAuto.UseVisualStyleBackColor = true;
            this.boxAuto.CheckedChanged += new System.EventHandler(this.boxAuto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOrigen.Location = new System.Drawing.Point(15, 54);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(169, 20);
            this.txtOrigen.TabIndex = 4;
            // 
            // txtDestino
            // 
            this.txtDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDestino.Location = new System.Drawing.Point(190, 54);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(191, 20);
            this.txtDestino.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fechas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dias";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd  MMMM yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(15, 107);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(137, 20);
            this.dtpInicio.TabIndex = 9;
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "dd  MMMM yyyy";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(159, 107);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(144, 20);
            this.dtpFin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pasajeros";
            // 
            // spnPasajeros
            // 
            this.spnPasajeros.Location = new System.Drawing.Point(309, 107);
            this.spnPasajeros.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnPasajeros.Name = "spnPasajeros";
            this.spnPasajeros.Size = new System.Drawing.Size(41, 20);
            this.spnPasajeros.TabIndex = 12;
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.Location = new System.Drawing.Point(355, 106);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(26, 22);
            this.btnPasajeros.TabIndex = 13;
            this.btnPasajeros.Text = "✓";
            this.btnPasajeros.UseVisualStyleBackColor = true;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 146);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlPasajeros
            // 
            this.pnlPasajeros.Controls.Add(this.btnAplicar);
            this.pnlPasajeros.Controls.Add(this.btnCancelar);
            this.pnlPasajeros.Controls.Add(this.numericUpDown2);
            this.pnlPasajeros.Controls.Add(this.numericUpDown1);
            this.pnlPasajeros.Controls.Add(this.label8);
            this.pnlPasajeros.Controls.Add(this.label7);
            this.pnlPasajeros.Location = new System.Drawing.Point(392, 12);
            this.pnlPasajeros.Name = "pnlPasajeros";
            this.pnlPasajeros.Size = new System.Drawing.Size(139, 119);
            this.pnlPasajeros.TabIndex = 15;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(88, 91);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(28, 23);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "✓";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(25, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(28, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(88, 54);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "    Menores\r\nHasta 17 años";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "     Adultos\r\nDesde 18 años";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(281, 5);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(69, 13);
            this.lblHabitaciones.TabIndex = 17;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // spnHabitaciones
            // 
            this.spnHabitaciones.Location = new System.Drawing.Point(283, 21);
            this.spnHabitaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnHabitaciones.Name = "spnHabitaciones";
            this.spnHabitaciones.Size = new System.Drawing.Size(66, 20);
            this.spnHabitaciones.TabIndex = 18;
            this.spnHabitaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlHotel
            // 
            this.pnlHotel.Controls.Add(this.dgvBusqueda);
            this.pnlHotel.Controls.Add(this.spnHabitaciones);
            this.pnlHotel.Controls.Add(this.lblHabitaciones);
            this.pnlHotel.Location = new System.Drawing.Point(15, 191);
            this.pnlHotel.Name = "pnlHotel";
            this.pnlHotel.Size = new System.Drawing.Size(362, 146);
            this.pnlHotel.TabIndex = 19;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AllowUserToOrderColumns = true;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(5, 6);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(271, 134);
            this.dgvBusqueda.TabIndex = 19;
            // 
            // pnlAuto
            // 
            this.pnlAuto.Controls.Add(this.comboBox1);
            this.pnlAuto.Controls.Add(this.label11);
            this.pnlAuto.Controls.Add(this.label10);
            this.pnlAuto.Controls.Add(this.numericUpDown3);
            this.pnlAuto.Controls.Add(this.label9);
            this.pnlAuto.Location = new System.Drawing.Point(387, 15);
            this.pnlAuto.Name = "pnlAuto";
            this.pnlAuto.Size = new System.Drawing.Size(148, 116);
            this.pnlAuto.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tipo";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(71, 42);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vehiculos";
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Location = new System.Drawing.Point(296, 146);
            this.btnPreliminar.Name = "btnPreliminar";
            this.btnPreliminar.Size = new System.Drawing.Size(75, 23);
            this.btnPreliminar.TabIndex = 21;
            this.btnPreliminar.Text = "Preliminar";
            this.btnPreliminar.UseVisualStyleBackColor = true;
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 176);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.pnlAuto);
            this.Controls.Add(this.pnlHotel);
            this.Controls.Add(this.pnlPasajeros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnPasajeros);
            this.Controls.Add(this.spnPasajeros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxAuto);
            this.Controls.Add(this.boxHotel);
            this.Controls.Add(this.label1);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.Vuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnPasajeros)).EndInit();
            this.pnlPasajeros.ResumeLayout(false);
            this.pnlPasajeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHabitaciones)).EndInit();
            this.pnlHotel.ResumeLayout(false);
            this.pnlHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.pnlAuto.ResumeLayout(false);
            this.pnlAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox boxHotel;
        private System.Windows.Forms.CheckBox boxAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spnPasajeros;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlPasajeros;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.NumericUpDown spnHabitaciones;
        private System.Windows.Forms.Panel pnlHotel;
        private System.Windows.Forms.Panel pnlAuto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPreliminar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
    }
}