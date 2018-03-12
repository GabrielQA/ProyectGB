using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using Capa_Info;
namespace WindowsFormsApp1
{
    public partial class Logeo_Cliente : Form
    {
        public Logeo_Cliente()
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
            int clave = 123;
            string baseDatos = "proyectgb";
            cadenaConexion = "Server=" + servidor + "; " + "Port=" + puerto + "; " + "User Id=" + usuario + "; " + "Password=" + clave + "; " + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            Console.WriteLine(cadenaConexion);

        }
        private void Agregar_Datos_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length == 0 || txtc.Text.Length == 0 || txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
                txtc.Clear();
                txtCedula.Clear();
                txtUsuario.Clear();        
            }
            else
            {
                String Usu = "Cliente";
                String ContraseñaEn = Contraseña.EncriptarContraseña(txtc.Text);
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO usuario (cedula,nombre,contraseña,tipo) VALUES ('" + txtCedula.Text + "', '" + txtUsuario.Text + "', '" + ContraseñaEn + "', '" + Usu + "'  )", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("A sido registrado exitosamente");
                txtc.Clear();
                txtCedula.Clear();
                txtUsuario.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login v = new Login();
            v.Show();

        }
    }
}
