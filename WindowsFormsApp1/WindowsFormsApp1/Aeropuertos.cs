using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
namespace WindowsFormsApp1
{
    public partial class Aeropuertos : Form
    {
        int id = 0;
        int iata = 0;
        string localidad = "";
        string nombre = "";
        string La1 = string.Empty;
        string La2 = string.Empty;
        string La3 = string.Empty;
        static string cadenaConexion = null;
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;
        string Query = "";
        DataSet dataSet = new DataSet();
        public Aeropuertos()
        {
            InitializeComponent();
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            int clave = 123;
            string baseDatos = "proyectgb";


            cadenaConexion = "Server=" + servidor + "; " + "Port=" + puerto + "; " + "User Id=" + usuario + "; " + "Password=" + clave + "; " + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            Console.WriteLine(cadenaConexion);


            try
            {
                conexion.Open();

            }
            catch (Exception E)
            {
              
            }



            Query = "SELECT * FROM aeropuertos; ";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(Query, conexion);
            add.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView2.DataSource = dataSet.Tables[0];
            dataGridView3.DataSource = dataSet.Tables[0];
            A1.Clear();
            A2.Clear();
            A3.Clear();
            A4.Clear();
            M1.Clear();
            M2.Clear();
            M3.Clear();
            M4.Clear();
            conexion.Close();
            Insertar(id, nombre, localidad, iata);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (A1.Text == "" || A2.Text == "" || A3.Text == "" || A4.Text == "")
            {
                MessageBox.Show("deben de tener todos los campos llenos");
            }
            else
            {
                agregar();
            }
        }
        //////////////////////////Agregar modificar eliminar Informacion
        public void agregar()
        {


            if (A1.Text == "" || A2.Text == "" || A3.Text == "" || A4.Text == "")
            {
                MessageBox.Show("deben de tener todos los campos llenos");
            }
            else
            {
                conexion.Open();
                id = Convert.ToInt32(A1.Text);
                nombre = A2.Text;
                localidad = A3.Text;
                iata = Convert.ToInt32(A4.Text);
                Insertar(id, nombre, localidad, iata);

                dataSet.Clear();
                dataGridView1.DataSource = dataSet.Tables[0];

                Query = "SELECT * FROM aeropuertos;";
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(Query, conexion);
                add.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];

                A2.Clear();
                A3.Clear();
                A4.Clear();
                A1.Clear();
                conexion.Close();
            }

        }
        public static void Insertar(int id, string nombre, string localidad, int iata)
        {

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO aeropuertos(id,nombre,localidad,iata) VALUES('" + id + "','" + nombre + "','" + localidad + "','" + iata + "');", conexion);
                command.ExecuteNonQuery();
            }
            catch (Exception E)
            {
             

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            A1.Text = Convert.ToString(fila.Cells[0].Value);
            A2.Text = Convert.ToString(fila.Cells[1].Value);
            A3.Text = Convert.ToString(fila.Cells[2].Value);
            A4.Text = Convert.ToString(fila.Cells[3].Value);
        }
        public void eliminarR(int id)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM aeropuertos WHERE id =" + id + ";", conexion);
                command.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error" + E.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            nombre = (M2.Text);
            localidad = (M3.Text);
            iata = Convert.ToInt32(M4.Text);
            DataGridViewRow FILA = dataGridView1.CurrentRow;
            id = Convert.ToInt32(FILA.Cells[0].Value);
            actualizarM();
            dataSet.Clear();
            dataGridView1.DataSource = dataSet.Tables[0];
            Query = "SELECT * FROM aeropuertos;";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(Query, conexion);
            add.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            M1.Clear();
            M2.Clear();
            M3.Clear();
            M4.Clear();

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            DataGridViewRow fila = dataGridView1.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            eliminarR(id);

            dataSet.Clear();
            dataGridView1.DataSource = dataSet.Tables[0];

            Query = "SELECT * FROM aeropuertos;";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(Query, conexion);
            add.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            A2.Clear();
            A3.Clear();
            A4.Clear();
            conexion.Close();
        }
        public void actualizarM()
        {
            try
            {

                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuertos SET nombre = '" + M2.Text + "', localidad = '" + M3.Text + "', iata= '" + M4.Text + "' WHERE id = '" + Convert.ToInt32(M1.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al modificar la informacion");
            }

        }
        public void actualizar()
        {
            try
            {
                
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuertos SET nombre = '" + A2.Text + "', localidad = '" + A3.Text + "', iata= '" + A4.Text + "' WHERE id = '" + Convert.ToInt32(A1.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al modificar la informacion");
            }
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView2.CurrentRow;
            M1.Text = Convert.ToString(fila.Cells[0].Value);
            M2.Text = Convert.ToString(fila.Cells[1].Value);
            M3.Text = Convert.ToString(fila.Cells[2].Value);
            M4.Text = Convert.ToString(fila.Cells[3].Value);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void M4_TextChanged(object sender, EventArgs e)
        {

        }

        private void M3_TextChanged(object sender, EventArgs e)
        {

        }

        private void M2_TextChanged(object sender, EventArgs e)
        {

        }

        private void M1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            conexion.Open();
            DataGridViewRow fila = dataGridView1.CurrentRow;
            id = Convert.ToInt32(fila.Cells[0].Value);
            eliminarR(id);

            dataSet.Clear();
            dataGridView1.DataSource = dataSet.Tables[0];

            Query = "SELECT * FROM aeropuertos;";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(Query, conexion);
            add.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            A2.Clear();
            A3.Clear();
            A4.Clear();
            conexion.Close();
        }

        private void button3_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
