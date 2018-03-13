namespace WindowsFormsApp1
{
    partial class Logeo_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logeo_Cliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Agregar_Datos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(289, 97);
            this.txtc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtc.Name = "txtc";
            this.txtc.PasswordChar = '*';
            this.txtc.Size = new System.Drawing.Size(184, 22);
            this.txtc.TabIndex = 59;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(289, 25);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(184, 22);
            this.txtCedula.TabIndex = 58;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(289, 60);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 22);
            this.txtUsuario.TabIndex = 57;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 180);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 28);
            this.button4.TabIndex = 56;
            this.button4.Text = "Atras";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Agregar_Datos
            // 
            this.Agregar_Datos.Location = new System.Drawing.Point(376, 140);
            this.Agregar_Datos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Agregar_Datos.Name = "Agregar_Datos";
            this.Agregar_Datos.Size = new System.Drawing.Size(99, 28);
            this.Agregar_Datos.TabIndex = 55;
            this.Agregar_Datos.Text = "Registrarse";
            this.Agregar_Datos.UseVisualStyleBackColor = true;
            this.Agregar_Datos.Click += new System.EventHandler(this.Agregar_Datos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cedula";
            // 
            // Logeo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Agregar_Datos);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Logeo_Cliente";
            this.Text = "Logeo_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Agregar_Datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}