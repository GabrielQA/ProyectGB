using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
namespace WindowsFormsApp1
{
    public partial class Rep : Form
    {

        int A;
        int B;
        public Rep()
        {
            InitializeComponent();
        }
        static string cadenaConexion = null;
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;
        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "123";
            string baseDatos = "proyectgb";
            cadenaConexion = "Server=" + servidor + "; " + "Port=" + puerto + "; " + "User Id=" + usuario + "; " + "Password=" + clave + "; " + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            Console.WriteLine(cadenaConexion);

        }
        public void Rep1()
        {
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM hoteles", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboboxRep1.Items.Add(dr.GetString(0));
                }
            }
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador v = new Administrador();
            v.Show();
        }

        private void comboboxRep1_Click(object sender, EventArgs e)
        {
            comboboxRep1.Items.Clear();
            Rep1();

        }

        private void comboboxRep1_SelectedValueChanged(object sender, EventArgs e)
        {
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT count(nombre_hotel) AS contador FROM reservas WHERE nombre_hotel='"+comboboxRep1.SelectedItem+"'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    resultado(Convert.ToInt32(dr["contador"].ToString()), comboboxRep1.SelectedItem.ToString());
                }
            }
            conexion.Close();
        }

        public void resultado(int valor, string nombre)
        {
            string[] series = { nombre };
            int[] puntos = { valor };
            chart1.Palette = ChartColorPalette.Pastel;
            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private void comboboxRep1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
