using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Preliminar : Form
    {

        public static DateTime fecha1;
        public static DateTime fecha2;
        public static string Origen;
        public static string Destino;
        public static string Escala;
        public static string Hotel;
        public static string Habitaciones;
        public static string Marca;
        public static string Modelo;
        public static string Tipo;
        public static string Cantidad;
        public static string Pvuelo;


        public Preliminar()
        {
            InitializeComponent();
            pnlHotel.Visible = false;
            pnlTotal.Visible = false;
            pnlVehiculo.Visible = false;
        }

        private void Preliminar_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = fecha1;
            dtpFinal.Value = fecha2;
            txtOrigen1.Text = txtDestino2.Text = Origen;
            txtOrigen2.Text = txtDestino1.Text = Destino;
            txtEscala.Text = Escala;
            txtHabitaciones.Text = Habitaciones;
            txtVehiculo.Text = Marca;
            txtModeloV.Text = Modelo;
            txtTipoV.Text = Tipo;
            txtCantidadV.Text = Cantidad;
            txtVueloP.Text = Pvuelo;

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (btnTotal.Text.Equals("+"))
            {
                btnTotal.Text = "-";
                this.Size = new Size(this.Size.Width, 374);
                pnlTotal.Visible = true;
            }
            else if (btnHotel.Text.Equals("-") || btnVehiculo.Text.Equals("-"))
            {
                btnTotal.Text = "+";
                pnlTotal.Visible = false;
            }
            else
            {
                btnTotal.Text = "+";
                this.Size = new Size(this.Size.Width, 238);
                pnlTotal.Visible = false;
            }  
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            if (btnHotel.Text.Equals("+"))
            {
                btnHotel.Text = "-";
                this.Size = new Size(this.Size.Width, 374);
                pnlHotel.Visible = true;
            }
            else if (btnVehiculo.Text.Equals("-") || btnTotal.Text.Equals("-"))
            {
                btnHotel.Text = "+";
                pnlHotel.Visible = false;
            }
            else
            {
                btnHotel.Text = "+";
                this.Size = new Size(this.Size.Width, 238);
                pnlHotel.Visible = false;
            }
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            if (btnVehiculo.Text.Equals("+"))
            {
                btnVehiculo.Text = "-";
                this.Size = new Size(this.Size.Width, 374);
                pnlVehiculo.Visible = true;
            }
            else if(btnHotel.Text.Equals("-") || btnTotal.Text.Equals("-"))
            {
                btnVehiculo.Text = "+";
                pnlVehiculo.Visible = false;
            }
            else
            {
                btnVehiculo.Text = "+";
                this.Size = new Size(this.Size.Width, 238);
                pnlVehiculo.Visible = false;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}
