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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Boolean A;
        string Usu = "Cliente";
        string Admin = "Admin";
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logeo_Cliente v = new Logeo_Cliente();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ValidarUsuario();
            if (A == false)
            {
                ValidarUsuarioAdmin();
            }
            
            
           
        }
        public void ValidarUsuarioAdmin()
        {
          
            ///Mañana averiguo en un video de youtube que linea codigo se coloca despues de el 
            ///npgsqlCommanda cmd = etc despues de esa sigue una linea en especifico para que pueda funcionar
            if (txtu.Text.Length == 0 || txtc.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT cedula,nombre,contraseña,tipo FROM usuario WHERE nombre = '" + txtu.Text + "'and contraseña='" + txtc.Text + "'and tipo='" + Admin + "'", conexion);
                NpgsqlDataReader entra = cmd.ExecuteReader();


                if (entra.Read())
                {
                    this.Hide();
                    Administrador a = new Administrador();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no coinsiden\n Intentelo nuevamente");
                    txtu.Clear();
                    txtc.Clear();
                }
            }
        }
        public void ValidarUsuario()
        {
           
            ///Mañana averiguo en un video de youtube que linea codigo se coloca despues de el 
            ///npgsqlCommanda cmd = etc despues de esa sigue una linea en especifico para que pueda funcionar
            if (txtu.Text.Length == 0 || txtc.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT cedula,nombre,contraseña,tipo FROM usuario WHERE nombre = '" + txtu.Text + "'and contraseña='" + txtc.Text + "'and tipo='" + Usu + "'", conexion);
                NpgsqlDataReader entra = cmd.ExecuteReader();


                if (entra.Read())
                {
                    this.Hide();
                    Cliente a = new Cliente();
                    a.Show();
                    
                   A = true;  
                }
                else
                {
                    A = false;
                   
                }
            }
        }

    }
}
