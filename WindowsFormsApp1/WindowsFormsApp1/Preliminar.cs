using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Info;
using Npgsql;
using NpgsqlTypes;
using Microsoft.VisualBasic;
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
        public static string Photel;
        public static string Hlugar;
        public static string Pvehiculo;
        public static string Validar;
        public static string Adultos;
        public static string Menores;
        public static int ID;
        public static string Personas;
        public Preliminar()
        {
            InitializeComponent();
            pnlHotel.Visible = false;
            pnlTotal.Visible = false;
            pnlVehiculo.Visible = false;
        }

        private void Preliminar_Load(object sender, EventArgs e)
        {
            int dias = fecha2.DayOfYear - fecha1.DayOfYear;
            if (Validar.Equals("Ambos"))
            {
                double IVA = (Convert.ToDouble(Pvuelo) + Convert.ToDouble(Photel) + Convert.ToDouble(Pvehiculo)) * 0.13;
                dtpInicio.Value = fecha1;
                dtpFinal.Value = fecha2;
                dtpInicio.MaxDate = fecha1;
                dtpInicio.MinDate = fecha1;
                dtpFinal.MaxDate = fecha2;
                dtpFinal.MinDate = fecha2;
                txtOrigen1.Text = txtDestino2.Text = Origen;
                txtOrigen2.Text = txtDestino1.Text = Destino;
                txtEscala.Text = Escala;
                txtHabitaciones.Text = Habitaciones;
                txtVehiculo.Text = Marca;
                txtModeloV.Text = Modelo;
                txtTipoV.Text = Tipo;
                txtCantidadV.Text = Cantidad;
                txtVueloP.Text = Pvuelo;
                txtHotelP.Text = Convert.ToString(Convert.ToInt32(Photel) * Convert.ToInt32(Habitaciones) * dias);
                txtLugarH.Text = Hlugar;
                txtHotel.Text = Hotel;
                txtVehiculoP.Text = Convert.ToString(Convert.ToInt32(Pvehiculo) * Convert.ToInt32(Cantidad));
                txtTotal.Text = Convert.ToString((Convert.ToDouble(Pvuelo) + Convert.ToDouble(txtHotelP.Text) + Convert.ToDouble(txtVehiculoP.Text)) + IVA);
            }
            else if (Validar.Equals("Hotel"))
            {
                double IVA = (Convert.ToDouble(Pvuelo) + Convert.ToDouble(Photel)) * 0.13;
                dtpInicio.Value = fecha1;
                dtpFinal.Value = fecha2;
                dtpInicio.MaxDate = fecha1;
                dtpInicio.MinDate = fecha1;
                dtpFinal.MaxDate = fecha2;
                dtpFinal.MinDate = fecha2;
                txtOrigen1.Text = txtDestino2.Text = Origen;
                txtOrigen2.Text = txtDestino1.Text = Destino;
                txtEscala.Text = Escala;
                txtHabitaciones.Text = Habitaciones;
                txtVueloP.Text = Pvuelo;
                txtHotelP.Text = Convert.ToString(Convert.ToInt32(Photel) * Convert.ToInt32(Habitaciones) * dias);
                txtLugarH.Text = Hlugar;
                txtHotel.Text = Hotel;
                txtTotal.Text = Convert.ToString((Convert.ToDouble(Pvuelo) + Convert.ToDouble(txtHotelP.Text)) + IVA);
            }
            else if (Validar.Equals("Auto"))
            {
                double IVA = (Convert.ToDouble(Pvuelo) + Convert.ToDouble(Pvehiculo)) * 0.13;
                dtpInicio.Value = fecha1;
                dtpFinal.Value = fecha2;
                dtpInicio.MaxDate = fecha1;
                dtpInicio.MinDate = fecha1;
                dtpFinal.MaxDate = fecha2;
                dtpFinal.MinDate = fecha2;
                txtOrigen1.Text = txtDestino2.Text = Origen;
                txtOrigen2.Text = txtDestino1.Text = Destino;
                txtEscala.Text = Escala;
                txtVehiculo.Text = Marca;
                txtModeloV.Text = Modelo;
                txtTipoV.Text = Tipo;
                txtCantidadV.Text = Cantidad;
                txtVueloP.Text = Pvuelo;
                txtVehiculoP.Text = Convert.ToString(Convert.ToInt32(Pvehiculo) * Convert.ToInt32(Cantidad));
                txtTotal.Text = Convert.ToString((Convert.ToDouble(Pvuelo) + Convert.ToDouble(txtVehiculoP.Text)) + IVA);
            }
            else if (Validar.Equals("Vuelo"))
            {
                double IVA = (Convert.ToDouble(Pvuelo)) * 0.13;
                dtpInicio.Value = fecha1;
                dtpFinal.Value = fecha2;
                dtpInicio.MaxDate = fecha1;
                dtpInicio.MinDate = fecha1;
                dtpFinal.MaxDate = fecha2;
                dtpFinal.MinDate = fecha2;
                txtOrigen1.Text = txtDestino2.Text = Origen;
                txtOrigen2.Text = txtDestino1.Text = Destino;
                txtEscala.Text = Escala;
                txtVueloP.Text = Pvuelo;
                txtTotal.Text = Convert.ToString((Convert.ToDouble(Pvuelo)) + IVA);
            }
            
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
            string calificacion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la Calificacion al hotel " + txtHotel.Text, "Calificacion", "Ingrese la votacion del 1 al 10");
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("INSERT INTO compra(id,fecha_inicio,fecha_final,pais_origen,pais_destino,hotel,vehiculo,calificacion,precio_total,cantidad_personas, escala, adultos, menores) VALUES ('" + ID + "', '" + dtpInicio.Value + "', '" + dtpFinal.Value + "', '" + txtOrigen1.Text + "', '" + txtDestino1.Text + "', '" + txtHotel.Text + "','" + txtVehiculo.Text + "', '" + calificacion + "', '" + txtTotal.Text + "', '" + Personas + "', '" + txtEscala.Text + "')", Conexion.conexion);
                Conexion.cmd.ExecuteNonQuery();
                Conexion.conexion.Close();
                MessageBox.Show("Su compra a sido exitosa");
                this.Hide();
                Cliente c = new Cliente();
                c.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();

                Conexion.cmd = new NpgsqlCommand("INSERT INTO reservas(id,fecha_inicio,fecha_final,pais_origen,pais_destino,escala,nombre_hotel,lugar_hotel,habitaciones_hotel,marca_vehiculo,modelo_vehiculo,cantidad_vehiculo,precio_vuelo,precio_hotel,precio_vehiculo,precio_total,cantidad_personas) VALUES ('" + ID + "', '" + dtpInicio.Value + "', '" + dtpFinal.Value + "', '" + txtOrigen1.Text + "', '" + txtDestino1.Text + "', '" + txtEscala.Text + "', '" + txtHotel.Text + "', '" + txtLugarH.Text + "', '" + txtHabitaciones.Text + "', '" + txtVehiculo.Text + "', '" + txtModeloV.Text + "', '" + txtCantidadV.Text + "', '" + txtVueloP.Text + "', '" + txtHotelP.Text + "', '" + txtVehiculoP.Text + "', '" + txtTotal.Text + "', '" + Personas + "')", Conexion.conexion);
                Conexion.cmd.ExecuteNonQuery();
                Conexion.conexion.Close();
                MessageBox.Show("Su reserva a sido exitosa");
                this.Hide();
                Cliente c = new Cliente();
                c.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
