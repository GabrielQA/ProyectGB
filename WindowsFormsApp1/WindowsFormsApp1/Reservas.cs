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

namespace WindowsFormsApp1
{
    public partial class Reservas : Form
    {
        DataSet reservas = new DataSet();
        public static int ID;
        int id;
        string hotel;
        string total;
        DateTime fecha_inicio, fecha_final;
        string pais_origen, pais_destino, escala, nombre_hotel, lugar_hotel, habitaciones_hotel, marca_vehiculo, modelo_vehiculo, cantidad_vehiculo, precio_vuelo, precio_hotel, precio_vehiculo, precio_total, cantidad_personas, adultos, menores;

        public Reservas()
        {
            InitializeComponent();
        }

        public void cargardgv()
        {
            try
            {
                dgvReservas.DataSource = null;
                reservas.Clear();
                Conexion.Coneccion();
                Conexion.conexion.Open();
                NpgsqlDataAdapter read = new NpgsqlDataAdapter("SELECT fecha_inicio, fecha_final, pais_origen, pais_destino, escala, nombre_hotel, lugar_hotel, habitaciones_hotel, marca_vehiculo, modelo_vehiculo, cantidad_vehiculo, precio_vuelo, precio_hotel, precio_vehiculo, precio_total, cantidad_personas, adultos, menores FROM reservas WHERE id = '" + ID + "'", Conexion.conexion);
                read.Fill(reservas);
                DataTable dtAll = reservas.Tables[0].Copy();
                for (var i = 1; i < reservas.Tables.Count; i++)
                {
                    dtAll.Merge(reservas.Tables[i]);
                }
                dgvReservas.AutoGenerateColumns = true;
                dgvReservas.DataSource = dtAll;
                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este usuario no tiene reservas.");
            }
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            cargardgv();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM reservas WHERE id = '" + ID + "'and nombre_hotel = '" + hotel + "'and precio_total = '" + total + "'", Conexion.conexion);
                command.ExecuteNonQuery();
                Conexion.conexion.Close();
                cargardgv();

            }
            catch (Exception E)
            {
                MessageBox.Show("Error" + E.Message);
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvReservas.CurrentRow;
            fecha_inicio = Convert.ToDateTime(fila.Cells[0].Value);
            fecha_final = Convert.ToDateTime(fila.Cells[1].Value);
            pais_origen = Convert.ToString(fila.Cells[2].Value);
            pais_destino = Convert.ToString(fila.Cells[3].Value);
            escala = Convert.ToString(fila.Cells[4].Value);
            hotel = Convert.ToString(fila.Cells[5].Value);
            lugar_hotel = Convert.ToString(fila.Cells[6].Value);
            habitaciones_hotel = Convert.ToString(fila.Cells[7].Value);
            marca_vehiculo = Convert.ToString(fila.Cells[8].Value);
            modelo_vehiculo = Convert.ToString(fila.Cells[9].Value);
            cantidad_vehiculo = Convert.ToString(fila.Cells[10].Value);
            precio_vuelo = Convert.ToString(fila.Cells[11].Value);
            precio_hotel = Convert.ToString(fila.Cells[12].Value);
            precio_vehiculo = Convert.ToString(fila.Cells[13].Value);
            total = Convert.ToString(fila.Cells[14].Value);
            cantidad_personas = Convert.ToString(fila.Cells[15].Value);
            adultos = Convert.ToString(fila.Cells[16].Value);
            menores = Convert.ToString(fila.Cells[17].Value);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente ven = new Cliente();
            ven.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string calificacion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la Calificacion al hotel " + hotel, "Calificacion", "Ingrese la votacion del 1 al 10");
            try
            {
                Conexion.Coneccion();
                Conexion.conexion.Open();
                Conexion.cmd = new NpgsqlCommand("INSERT INTO compra(id,fecha_inicio,fecha_final,pais_origen,pais_destino,hotel,vehiculo,calificacion,precio_total,cantidad_personas, escala, adultos, menores) VALUES ('" + ID + "', '" + fecha_inicio + "', '" + fecha_final + "', '" + pais_origen + "', '" + pais_destino + "', '" + nombre_hotel + "','" + marca_vehiculo + "', '" + calificacion + "', '" + total + "', '" + cantidad_personas + "', '" + escala + "', '" + adultos + "', '" + menores + "')", Conexion.conexion);
                Conexion.cmd.ExecuteNonQuery();
                Conexion.conexion.Close();
                btnEliminar_Click(sender, e);
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
    }
}
