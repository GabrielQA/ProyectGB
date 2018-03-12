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
            this.lblDias = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.spnPasajeros = new System.Windows.Forms.NumericUpDown();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlPasajeros = new System.Windows.Forms.Panel();
            this.spnMenores = new System.Windows.Forms.NumericUpDown();
            this.spnAdultos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.spnHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.pnlHotel = new System.Windows.Forms.Panel();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.boxMarca = new System.Windows.Forms.ComboBox();
            this.boxModelo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spnCantidadV = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPreliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnPasajeros)).BeginInit();
            this.pnlPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHabitaciones)).BeginInit();
            this.pnlHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.pnlAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidadV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encuentra tu vuelo";
            // 
            // boxHotel
            // 
            this.boxHotel.AutoSize = true;
            this.boxHotel.Location = new System.Drawing.Point(188, 10);
            this.boxHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxHotel.Name = "boxHotel";
            this.boxHotel.Size = new System.Drawing.Size(108, 21);
            this.boxHotel.TabIndex = 1;
            this.boxHotel.Text = "Añadir Hotel";
            this.boxHotel.UseVisualStyleBackColor = true;
            this.boxHotel.CheckedChanged += new System.EventHandler(this.boxHotel_CheckedChanged);
            // 
            // boxAuto
            // 
            this.boxAuto.AutoSize = true;
            this.boxAuto.Location = new System.Drawing.Point(333, 10);
            this.boxAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxAuto.Name = "boxAuto";
            this.boxAuto.Size = new System.Drawing.Size(104, 21);
            this.boxAuto.TabIndex = 2;
            this.boxAuto.Text = "Añadir Auto";
            this.boxAuto.UseVisualStyleBackColor = true;
            this.boxAuto.CheckedChanged += new System.EventHandler(this.boxAuto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOrigen.Location = new System.Drawing.Point(20, 66);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(224, 22);
            this.txtOrigen.TabIndex = 4;
            // 
            // txtDestino
            // 
            this.txtDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDestino.Location = new System.Drawing.Point(253, 66);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(253, 22);
            this.txtDestino.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fechas";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(208, 112);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(36, 17);
            this.lblDias.TabIndex = 8;
            this.lblDias.Text = "Dias";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd  MMMM yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(20, 132);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(181, 22);
            this.dtpInicio.TabIndex = 9;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "dd  MMMM yyyy";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(212, 132);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(191, 22);
            this.dtpFin.TabIndex = 10;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pasajeros";
            // 
            // spnPasajeros
            // 
            this.spnPasajeros.Location = new System.Drawing.Point(412, 132);
            this.spnPasajeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spnPasajeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnPasajeros.Name = "spnPasajeros";
            this.spnPasajeros.ReadOnly = true;
            this.spnPasajeros.Size = new System.Drawing.Size(55, 22);
            this.spnPasajeros.TabIndex = 12;
            this.spnPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.Location = new System.Drawing.Point(473, 130);
            this.btnPasajeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(35, 27);
            this.btnPasajeros.TabIndex = 13;
            this.btnPasajeros.Text = "+";
            this.btnPasajeros.UseVisualStyleBackColor = true;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 180);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlPasajeros
            // 
            this.pnlPasajeros.Controls.Add(this.spnMenores);
            this.pnlPasajeros.Controls.Add(this.spnAdultos);
            this.pnlPasajeros.Controls.Add(this.label8);
            this.pnlPasajeros.Controls.Add(this.label7);
            this.pnlPasajeros.Location = new System.Drawing.Point(523, 15);
            this.pnlPasajeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPasajeros.Name = "pnlPasajeros";
            this.pnlPasajeros.Size = new System.Drawing.Size(185, 146);
            this.pnlPasajeros.TabIndex = 15;
            // 
            // spnMenores
            // 
            this.spnMenores.Location = new System.Drawing.Point(117, 66);
            this.spnMenores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spnMenores.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMenores.Name = "spnMenores";
            this.spnMenores.ReadOnly = true;
            this.spnMenores.Size = new System.Drawing.Size(64, 22);
            this.spnMenores.TabIndex = 3;
            this.spnMenores.Click += new System.EventHandler(this.spnMenores_Click);
            // 
            // spnAdultos
            // 
            this.spnAdultos.Location = new System.Drawing.Point(117, 15);
            this.spnAdultos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spnAdultos.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnAdultos.Name = "spnAdultos";
            this.spnAdultos.ReadOnly = true;
            this.spnAdultos.Size = new System.Drawing.Size(64, 22);
            this.spnAdultos.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 34);
            this.label8.TabIndex = 1;
            this.label8.Text = "    Menores\r\nHasta 17 años";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "     Adultos\r\nDesde 18 años";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(375, 6);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(90, 17);
            this.lblHabitaciones.TabIndex = 17;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // spnHabitaciones
            // 
            this.spnHabitaciones.Location = new System.Drawing.Point(377, 26);
            this.spnHabitaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spnHabitaciones.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnHabitaciones.Name = "spnHabitaciones";
            this.spnHabitaciones.ReadOnly = true;
            this.spnHabitaciones.Size = new System.Drawing.Size(88, 22);
            this.spnHabitaciones.TabIndex = 18;
            this.spnHabitaciones.Click += new System.EventHandler(this.spnHabitaciones_Click);
            // 
            // pnlHotel
            // 
            this.pnlHotel.Controls.Add(this.dgvBusqueda);
            this.pnlHotel.Controls.Add(this.spnHabitaciones);
            this.pnlHotel.Controls.Add(this.lblHabitaciones);
            this.pnlHotel.Location = new System.Drawing.Point(20, 235);
            this.pnlHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHotel.Name = "pnlHotel";
            this.pnlHotel.Size = new System.Drawing.Size(483, 180);
            this.pnlHotel.TabIndex = 19;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AllowUserToOrderColumns = true;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(7, 7);
            this.dgvBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(361, 165);
            this.dgvBusqueda.TabIndex = 19;
            this.dgvBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellClick);
            // 
            // pnlAuto
            // 
            this.pnlAuto.Controls.Add(this.label12);
            this.pnlAuto.Controls.Add(this.boxMarca);
            this.pnlAuto.Controls.Add(this.boxModelo);
            this.pnlAuto.Controls.Add(this.label5);
            this.pnlAuto.Controls.Add(this.boxTipo);
            this.pnlAuto.Controls.Add(this.label11);
            this.pnlAuto.Controls.Add(this.label10);
            this.pnlAuto.Controls.Add(this.spnCantidadV);
            this.pnlAuto.Controls.Add(this.label9);
            this.pnlAuto.Location = new System.Drawing.Point(516, 15);
            this.pnlAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAuto.Name = "pnlAuto";
            this.pnlAuto.Size = new System.Drawing.Size(197, 193);
            this.pnlAuto.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Marca";
            // 
            // boxMarca
            // 
            this.boxMarca.FormattingEnabled = true;
            this.boxMarca.Location = new System.Drawing.Point(59, 159);
            this.boxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxMarca.Name = "boxMarca";
            this.boxMarca.Size = new System.Drawing.Size(123, 24);
            this.boxMarca.TabIndex = 7;
            this.boxMarca.Click += new System.EventHandler(this.boxMarca_Click);
            // 
            // boxModelo
            // 
            this.boxModelo.FormattingEnabled = true;
            this.boxModelo.Location = new System.Drawing.Point(59, 126);
            this.boxModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxModelo.Name = "boxModelo";
            this.boxModelo.Size = new System.Drawing.Size(123, 24);
            this.boxModelo.TabIndex = 6;
            this.boxModelo.Click += new System.EventHandler(this.boxModelo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Modelo";
            // 
            // boxTipo
            // 
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Location = new System.Drawing.Point(59, 92);
            this.boxTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(123, 24);
            this.boxTipo.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tipo";
            // 
            // spnCantidadV
            // 
            this.spnCantidadV.Location = new System.Drawing.Point(95, 52);
            this.spnCantidadV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spnCantidadV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnCantidadV.Name = "spnCantidadV";
            this.spnCantidadV.Size = new System.Drawing.Size(88, 22);
            this.spnCantidadV.TabIndex = 1;
            this.spnCantidadV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vehiculos";
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Location = new System.Drawing.Point(395, 180);
            this.btnPreliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreliminar.Name = "btnPreliminar";
            this.btnPreliminar.Size = new System.Drawing.Size(100, 28);
            this.btnPreliminar.TabIndex = 21;
            this.btnPreliminar.Text = "Preliminar";
            this.btnPreliminar.UseVisualStyleBackColor = true;
            this.btnPreliminar.Click += new System.EventHandler(this.btnPreliminar_Click);
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 217);
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
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxAuto);
            this.Controls.Add(this.boxHotel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.Vuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnPasajeros)).EndInit();
            this.pnlPasajeros.ResumeLayout(false);
            this.pnlPasajeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHabitaciones)).EndInit();
            this.pnlHotel.ResumeLayout(false);
            this.pnlHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.pnlAuto.ResumeLayout(false);
            this.pnlAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidadV)).EndInit();
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
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spnPasajeros;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlPasajeros;
        private System.Windows.Forms.NumericUpDown spnMenores;
        private System.Windows.Forms.NumericUpDown spnAdultos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.NumericUpDown spnHabitaciones;
        private System.Windows.Forms.Panel pnlHotel;
        private System.Windows.Forms.Panel pnlAuto;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown spnCantidadV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPreliminar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox boxMarca;
        private System.Windows.Forms.ComboBox boxModelo;
        private System.Windows.Forms.Label label5;
    }
}