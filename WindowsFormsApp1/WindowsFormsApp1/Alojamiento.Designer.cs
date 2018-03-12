namespace WindowsFormsApp1
{
    partial class formAlojamiento
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
            this.components = new System.ComponentModel.Container();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pHabitaciones = new System.Windows.Forms.Panel();
            this.spnMenores = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.spnAdultos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spnHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.btnCheck = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.pHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDestino.Location = new System.Drawing.Point(64, 22);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(259, 20);
            this.txtDestino.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fechas:";
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(113, 66);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(44, 13);
            this.lblNoches.TabIndex = 3;
            this.lblNoches.Text = "Noches";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(15, 83);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha1.TabIndex = 4;
            this.dtpFecha1.ValueChanged += new System.EventHandler(this.dtpFecha1_ValueChanged);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(116, 83);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(98, 20);
            this.dtpFecha2.TabIndex = 5;
            this.dtpFecha2.ValueChanged += new System.EventHandler(this.dtpFecha2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Habitaciones:";
            // 
            // pHabitaciones
            // 
            this.pHabitaciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pHabitaciones.Controls.Add(this.spnMenores);
            this.pHabitaciones.Controls.Add(this.label7);
            this.pHabitaciones.Controls.Add(this.spnAdultos);
            this.pHabitaciones.Controls.Add(this.label6);
            this.pHabitaciones.Controls.Add(this.lblCantidad);
            this.pHabitaciones.Controls.Add(this.label5);
            this.pHabitaciones.Location = new System.Drawing.Point(340, 12);
            this.pHabitaciones.Name = "pHabitaciones";
            this.pHabitaciones.Size = new System.Drawing.Size(183, 139);
            this.pHabitaciones.TabIndex = 7;
            // 
            // spnMenores
            // 
            this.spnMenores.Location = new System.Drawing.Point(118, 81);
            this.spnMenores.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMenores.Name = "spnMenores";
            this.spnMenores.ReadOnly = true;
            this.spnMenores.Size = new System.Drawing.Size(45, 20);
            this.spnMenores.TabIndex = 5;
            this.spnMenores.Click += new System.EventHandler(this.spnMenores_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "    Menores\r\nHasta 17 años";
            // 
            // spnAdultos
            // 
            this.spnAdultos.Location = new System.Drawing.Point(118, 33);
            this.spnAdultos.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnAdultos.Name = "spnAdultos";
            this.spnAdultos.ReadOnly = true;
            this.spnAdultos.Size = new System.Drawing.Size(45, 20);
            this.spnAdultos.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "    Adultos\r\nDesde 18 años";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(115, 10);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(13, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Habitaciones:";
            // 
            // spnHabitaciones
            // 
            this.spnHabitaciones.Location = new System.Drawing.Point(235, 83);
            this.spnHabitaciones.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.spnHabitaciones.Name = "spnHabitaciones";
            this.spnHabitaciones.Size = new System.Drawing.Size(43, 20);
            this.spnHabitaciones.TabIndex = 8;
            this.toolTip1.SetToolTip(this.spnHabitaciones, "Cada habitacion son para 4 personas maximo");
            this.spnHabitaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(284, 83);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(30, 20);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "+";
            this.toolTip1.SetToolTip(this.btnCheck, "Click aqui para terminar el formulario de habitaciones");
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AllowUserToOrderColumns = true;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 162);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(310, 149);
            this.dgvBusqueda.TabIndex = 11;
            // 
            // formAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 161);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.spnHabitaciones);
            this.Controls.Add(this.pHabitaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestino);
            this.Name = "formAlojamiento";
            this.Text = "Alojamiento";
            this.Load += new System.EventHandler(this.formAlojamiento_Load);
            this.pHabitaciones.ResumeLayout(false);
            this.pHabitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoches;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pHabitaciones;
        private System.Windows.Forms.NumericUpDown spnMenores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spnAdultos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spnHabitaciones;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
    }
}