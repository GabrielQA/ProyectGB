using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Administrador : Form
    {
        /// <summary>
        /// rowleef
        /// </summary>
        string cadenas;
        public Administrador()
        {
            InitializeComponent();
          
            PaisesA();
          // Lugares();
            aeropuertos();
            //Rutas();
            //TarifaH();
           // TarifaV();
           // vehiculos();

        }
        /// <summary>
        /// Seccion añadir modificar y eliminar Datos...
        /// </summary>
        /// 
        public void vehiculos()
        {
            clearAll();
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,marca,modelo,tipo,precio,cantidad FROM vehiculos", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {



                    IDvehiculoDelete.Items.Add(dr.GetString(0));

                    IDVehiculoMod.Items.Add(dr.GetString(0));




                }
            }
            conexion.Close();
        }
        public void TarifaH()
        {
           
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,precio FROM tarifa_hoteles", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {


                    Precio.Items.Add(dr.GetString(1));
                    PrecioM.Items.Add(dr.GetString(1));
                    TarifaHdelete.Items.Add(dr.GetString(0));

                    ComboboxtarifaH.Items.Add(dr.GetString(0));




                }
            }
            conexion.Close();
        }
        public void TarifaV()
        {
            clearAll();
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,ruta,precio FROM vuelos", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                  

                    IDTarifaVuelosMod.Items.Add(dr.GetString(0));

                    IDTarifaVuelosDelete.Items.Add(dr.GetString(0));




                }
            }
            conexion.Close();
        }
        public void Rutas()
        {
            clearAll();
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,pais_origen,pais_destino,duracion FROM rutas", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    RutaTarifaVuelosADD.Items.Add(dr.GetString(0));
                    RutaTarifaVuelosMOD.Items.Add(dr.GetString(0));
                    IDRMOD.Items.Add(dr.GetString(0));
                    comboboxdeleteRuta.Items.Add(dr.GetString(0));
                }
            }
            conexion.Close();
            RutasM();
        }
        public void aeropuertos()
        {
            clearAll();
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,nombre,localidad,iata FROM aeropuertos", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ComboboxAeropuertoDelete.Items.Add(dr.GetString(1));
                    IDDELETEAeropuerto.Text = dr.GetString(0);
                    AeropuertoMod.Items.Add(dr.GetString(1));
                    IDmodAeropuerto.Text = dr.GetString(0);
                    nombreMODAeropuerto.Text = dr.GetString(1);
                    modLocalidadAeropuerto.Text = dr.GetString(2);
                    iataMODAeropuerto.Text = dr.GetString(3);
                }
            }
            conexion.Close();
        }
        public void Lugares()
        {
            clearAll();
            clearAll();
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,nombre FROM lugares", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    LugarHotelesADD.Items.Add(dr.GetString(1));
                    LugaresMOD.Items.Add(dr.GetString(1));
                    IDmodL.Text = dr.GetString(0);
                    nombremodl.Text = dr.GetString(1);

                    ComboboxLugaresDelete.Items.Add(dr.GetString(1));
                    IDdeleteL.Text = dr.GetString(0);
                }
            }
            conexion.Close();
           
        }
        public void PaisesA()
        {
            
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,nombre,bandera FROM paises", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox6.Items.Add(dr.GetString(0));
                    PaisDadd.Items.Add(dr.GetString(1));
                    PaisOadd.Items.Add(dr.GetString(1));
                    PDmod.Items.Add(dr.GetString(1));
                    POmod.Items.Add(dr.GetString(1));
                    c.Items.Add(dr.GetString(0));
                    paisHotelesADD.Items.Add(dr.GetString(1));
                }
            }
            conexion.Close();
        }
       
        /// <summary>
        /// Variables globales
        /// </summary>
        String ubicacion;
        String id;
        int ID;
        DataSet registro = new DataSet();
        int NumRegistro;
        string[] BtnNextBack;
        string[] ComboBoxText;
        OpenFileDialog Open = new OpenFileDialog();
        static string cadenaConexion = null;
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;
      

        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "bryan2748245";
            string baseDatos = "proyectgb";

            cadenaConexion = "Server=" + servidor + "; " + "Port=" + puerto + "; " + "User Id=" + usuario + "; " + "Password=" + clave + "; " + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            Console.WriteLine(cadenaConexion);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login v = new Login();
            v.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Datos de Pais
        /// </summary>

        public void InsertarDatosPais()
        {
            try {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO paises(id,nombre,bandera) VALUES ('" + txtIDPais.Text + "', '" + textBox3.Text + "', '" + cadenas + "')", conexion);
                //cmd.Parameters.AddWithValue("bandera", imagenPaisesAdd);
                cmd.ExecuteNonQuery();
                conexion.Close();
            } catch (Exception e)
            {
                MessageBox.Show("Fallo en el ingreso de datos"+e.ToString());
            }

        }
        public void ModificarDatosPais()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE paises SET nombre = '" + textBox4.Text + "', bandera= '" + cadenas + "' WHERE id = '" + Convert.ToInt32(textBox6.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al actualizar los datos");
            }
        }
        public void EliminarDatosPais()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM paises WHERE nombre = '" + c.SelectedItem + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Dato no eliminado");
            }
        }



        /// <summary>
        /// Datos de Lugares
        /// </summary>
        /// 
        public void InsertarDatosLugares()
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO lugares(id,nombre) VALUES ('" + IDLADD.Text + "', '" + nombreLADD.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Informacion añadida correctamente");

        }
        public void ModificarDatosLugares()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE lugares SET nombre = '" + nombremodl.Text + "' WHERE id = '" + Convert.ToInt32(IDmodL.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Informacion modificada correctamente");
        }
        public void EliminarDatosLugares()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM lugares WHERE id = '" + Convert.ToInt32(IDdeleteL.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Informacion eliminada correctamente");
        }

        /// <summary>
        /// Datos de Aeropuertos
        /// </summary>

        public void InsertarDatosAeropuertos()
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO aeropuertos (id,nombre,localidad,iata) VALUES ('" + Convert.ToInt32(IDaddAeropuerto.Text) + "', '" + NombreaddAeropuerto.Text + "', '" + LOCALIDADddAeropuerto.Text + "', '" + IATAaddAeropuerto + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion ingreado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al ingreasar informacion");
            }
        }
        public void ModificarDatosAeropuertos()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuertos SET nombre = '" + nombreMODAeropuerto.Text + "', localidad = '" + modLocalidadAeropuerto.Text + "', iata= '" + iataMODAeropuerto.Text + "' WHERE id = '" + Convert.ToInt32(IDmodAeropuerto.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al actualizar informacion");
            }
        }
        public void EliminarDatosAeropuertos()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM aeropuertos WHERE id = '" + Convert.ToInt32(IDDELETEAeropuerto.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al eliminar informacion");
            }
        }
        //Listo



        /// <summary>
        /// Datos de Rutas
        /// </summary>

        public void InsertarDatosRutas()
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO rutas (id,pais_origen,pais_destino,duracion) VALUES ('" + IDRadd.Text + "', '" + PaisOadd.Text + "', '" + PaisDadd.Text + "', '" + DuracionRadd.Text + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion añadida correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al ingreasar informacion");
            }
        }
        public void ModificarDatosRutas()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE rutas SET pais_origen = '" + POmod.Text + "', pais_destino = '" + PDmod.Text + "', duracion= '" + DuracionRmod.Text + "' WHERE id = '" + Convert.ToInt32(IDRMOD.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al modificar informacion");
            }
        }
        public void EliminarDatosRutas()
        {

            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM rutas WHERE id = '" + comboboxdeleteRuta.SelectedItem + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion eliminada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al eliminar informacion");
            }
        }



        /// <summary>
        /// Datos de Hoteles
        /// </summary>

        public void InsertarDatosHoteles()
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO hoteles (id,nombre,foto,pais,lugar,habitaciones,precio) VALUES ('" + Convert.ToInt32(IDHotelesAdd.Text) + "', '" + nombreHotelesAdd.Text + "', '" + cadenas + "', '" + paisHotelesADD.Text + "', '" + LugarHotelesADD.Text + "', '" + habitacionHotelesADD.Text + "', '" + Precio.Text + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion añadida correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al añadir informacion");
            }
        }
        public void ModificarDatosHoteles()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE hoteles SET nombre = '" + NombreHotelesMod.Text + "', foto = '" + imagenHotelesMod.Text + "', pais= '" + paisHotelesMod.Text + "', lugar= '" + LugarHotelesMod.Text + "', habitaciones= '" + habitacionesHotelesMod.Text +"', habitaciones='"+Precio.Text+ "' WHERE id = '" + Convert.ToInt32(IDHotelesMOD.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al modificar informacion");
            }
        }
        public void EliminarDatosHoteles()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM hoteles WHERE id = '" + Convert.ToInt32(IDHotelesDelete.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion eliminada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al eliminar informacion");
            }
        }




        ///Tarifa Hoteles

        public void InsertarDatosTarifaHoteles()
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO tarifa_hoteles (id,precio) VALUES ('" + Convert.ToInt32(IDTarifaHotelesADD.Text) + "', '" + PrecioTarifaHotelesADD.Text + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion añadida correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al añadir informacion");
            }
        }
        public void ModificarDatosTarifaHoteles()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE tarifa_hoteles SET precio = '" + PrecioTarifaHotelesMod.Text + "' WHERE id = '" + Convert.ToInt32(IDTarifaHotelesMod.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al modificar informacion");
            }
        }
        public void EliminarDatosTarifaHoteles()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM tarifa_hoteles WHERE id = '" + TarifaHdelete.SelectedItem + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion eliminada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al eliminar informacion");
            }
        }



        //Tarifa Vuelos
        public void InsertarDatosTarifaVuelos()
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO vuelos (id,ruta,precio) VALUES ('" + Convert.ToInt32(IDTarifaVuelosADD.Text) + "', '" + RutaTarifaVuelosADD.Text + "', '" + PrecioTarifaVuelosADD.Text + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion añadida correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al añadir informacion");
            }
        }
        public void ModificarDatosTarifaVuelos()
        {
            try
            {
                Conexion();
                conexion.Open();
                //NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vuelos SET ruta = '" + RutaTarifaVuelosMOD.Text + "','precio =" + PreciosTarifaVuelosMod.Text + "' WHERE id = '" + IDTarifaVuelosMod.Text + "'", conexion);
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vuelos SET ruta = '" + RutaTarifaVuelosMOD.Text + "', precio = '" + PreciosTarifaVuelosMod.Text + "'WHERE id = '" + Convert.ToInt32(IDTarifaVuelosMod.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al modificar informacion");
            }
        }
        public void EliminarDatosTarifaVuelos()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM vuelos WHERE id = '" + IDTarifaVuelosDelete.Text + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion eliminada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al eliminar informacion");
            }
        }



        /// vehiculos

        public void InsertarDatovehiculos()
        {
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO vehiculos (id,marca,modelo,tipo,precio,cantidad) VALUES ('" + IDVehiculoADD.Text + "', '" + MarcaVehiculoADD.Text + "', '" + ModeloVehiculoADD.Text + "', '" + TipoVehiculoADD.Text + "', '" + PrecioVehiculoADD.Text + "', '" + CantidadvehiculoADD.Text + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion añadida correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al añadir informacion");
            }
        }
        public void ModificarDatosvehiculos()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vehiculos SET marca = '" + MarcavehiculoMod.Text + "', modelo = '" + ModeloVehiculoMod.Text + "', tipo= '" + TipovehiculoMod.Text + "', precio= '" + PreciovehiculoMod.Text + "', cantidad= '" + cantidadvehiculoMod.Text + "' WHERE id = '" + Convert.ToInt32(IDVehiculoMod.Text) + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion modificada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al modificar informacion");
            }
        }
        public void EliminarDatosvehiculos()
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM vehiculos WHERE id = '" + IDvehiculoDelete.Text + "'", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Informacion eliminada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al eliminar informacion");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarDatosPais();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            InsertarDatosPais();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarDatosPais();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertarDatosLugares();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModificarDatosLugares();
            LimpiarLugares();


        }
        public void LimpiarLugares() {

            IDLADD.Clear();
            IDmodL.Clear();
            nombreLADD.Clear();
            nombremodl.Clear();


        }
        private void button7_Click(object sender, EventArgs e)
        {
            EliminarDatosLugares();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InsertarDatosAeropuertos();
            clearAll();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModificarDatosAeropuertos();
            clearAll();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EliminarDatosAeropuertos(); clearAll();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            InsertarDatosRutas(); clearAll();
            clearAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ModificarDatosRutas(); clearAll();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            EliminarDatosRutas();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InsertarDatosHoteles();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ModificarDatosTarifaHoteles(); clearAll();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EliminarDatosHoteles(); clearAll();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clearAll();
            InsertarDatosTarifaHoteles();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ModificarDatosTarifaHoteles(); clearAll();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            EliminarDatosTarifaHoteles(); clearAll();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InsertarDatosTarifaVuelos();
            IDTarifaVuelosADD.Clear();
            RutaTarifaVuelosADD.Items.Clear();
            PrecioTarifaVuelosADD.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ModificarDatosTarifaVuelos(); clearAll();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            EliminarDatosTarifaVuelos(); clearAll();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InsertarDatovehiculos(); clearAll();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ModificarDatosvehiculos(); clearAll();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            EliminarDatosvehiculos();
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void imagenPaisesAdd_Click(object sender, EventArgs e)
        {

        }

        private void imagenPaisesAdd_DoubleClick(object sender, EventArgs e)
        {

        }

        private void imagenPaisesAdd_MouseClick(object sender, MouseEventArgs e)
        {

            Open.Title = "Abrir";
            Open.Filter = "Jpg files (*.jpg)|Gif files (*,gif|Vitmap files (*.Bmp)|*.BMP|PGN files )*.png)|*.png*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                ubicacion = Open.FileName;
                Bitmap picture = new Bitmap(ubicacion);
                pictureBox1.Image = (Image)picture;
                id = Open.SafeFileName;
                txtIDPais.Text = id;
            }

        }

        private void imagemodPaises_MouseClick(object sender, MouseEventArgs e)
        {
            Open.Title = "Abrir";
            Open.Filter = "Jpg files (*.jpg)|Gif files (*,gif|Vitmap files (*.Bmp)|*.BMP|PGN files )*.png)|*.png*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                ubicacion = Open.FileName;
                Bitmap picture = new Bitmap(ubicacion);
                pictureBox1.Image = (Image)picture;
                id = Open.SafeFileName;
                txtIDPais.Text = id;
            }
        }

        private void imagenHotelesMod_MouseClick(object sender, MouseEventArgs e)
        {
            Open.Title = "Abrir";
            Open.Filter = "Jpg files (*.jpg)|Gif files (*,gif|Vitmap files (*.Bmp)|*.BMP|PGN files )*.png)|*.png*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                ubicacion = Open.FileName;
                Bitmap picture = new Bitmap(ubicacion);
                pictureBox1.Image = (Image)picture;
                id = Open.SafeFileName;
                txtIDPais.Text = id;
            }
        }

        private void imagenhotel_MouseClick(object sender, MouseEventArgs e)
        {
            Open.Title = "Abrir";
            Open.Filter = "Jpg files (*.jpg)|Gif files (*,gif|Vitmap files (*.Bmp)|*.BMP|PGN files )*.png)|*.png*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                ubicacion = Open.FileName;
                Bitmap picture = new Bitmap(ubicacion);
                pictureBox1.Image = (Image)picture;
                id = Open.SafeFileName;
                txtIDPais.Text = id;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtt_SelectedIndexChanged(object sender, EventArgs e)
        {




            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RutaTarifaVuelosMOD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TarifaVuelos();

        }

        private void imagemodPaises_Click(object sender, EventArgs e)
        {
            Open.Title = "Abrir";
            Open.Filter = "Jpg files (*.jpg)|Gif files (*,gif|Vitmap files (*.Bmp)|*.BMP|PGN files )*.png)|*.png*";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                ubicacion = Open.FileName;
                Bitmap picture = new Bitmap(ubicacion);
                pictureBox1.Image = (Image)picture;
                id = Open.SafeFileName;
                txtIDPais.Text = id;
            }
        }

        private void imagenPaisesAdd_Click_1(object sender, EventArgs e)
        {


           
            /*  string direccion;
              Open.Title = "Abrir";
              Open.Filter = "Jpg files (*.jpg)|Gif files (*,gif|Vitmap files (*.Bmp)|*.BMP|PGN files )*.png)|*.png*";
              if (Open.ShowDialog() == DialogResult.OK)
              {
                  ubicacion = Open.FileName;
                  Bitmap picture = new Bitmap(ubicacion);
                  imagenPaisesAdd.Image = (Image)picture;
                  id = Open.SafeFileName;
                  direccion = id;
                  MessageBox.Show(direccion);
              }*/
        }
        public void LugaresM()
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,nombre FROM lugares WHERE nombre = '" + LugaresMOD.SelectedItem + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    IDmodL.Text = dr.GetString(0);
                    nombremodl.Text = dr.GetString(1);




                }

                conexion.Close();



            }
        }
        public void LugaresD()
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,nombre FROM lugares WHERE nombre = '" + ComboboxLugaresDelete.SelectedItem + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    IDdeleteL.Text = dr.GetString(0);



                }

                conexion.Close();



            }
        }
        public void AeropuertoM()
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,nombre,localidad,iata FROM aeropuertos WHERE nombre = '" + AeropuertoMod.SelectedItem + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    IDmodAeropuerto.Text = dr.GetString(0);
                    nombreMODAeropuerto.Text = dr.GetString(1);
                    modLocalidadAeropuerto.Text = dr.GetString(2);
                    iataMODAeropuerto.Text = dr.GetString(3);




                }

                conexion.Close();



            }
        }
        public void AeropuertoD()
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,nombre,localidad,iata FROM aeropuertos WHERE nombre = '" + ComboboxAeropuertoDelete.SelectedItem + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    IDDELETEAeropuerto.Text = dr.GetString(0);




                }

                conexion.Close();



            }
        }
        public void RutasM()
        {
            


                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT id, nombre, localidad, iata FROM aeropuertos WHERE nombre = '" + ComboboxAeropuertoDelete.SelectedItem + "'", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                    POmod.Items.Add(dr.GetString(1));

                    PDmod.Items.Add(dr.GetString(2));


                }

                    conexion.Close();



                }
            }

            /* 
             Conexion();
             conexion.Open();
             NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,pais_origen,pais_destino,duracion FROM rutas WHERE id = '" + IDRMOD.SelectedItem +  "'", conexion);
             NpgsqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
             {
                 while (dr.Read())
                 {



                     POmod.Items.Add(dr.GetString(1));

                     PDmod.Items.Add(dr.GetString(2));

                 }

                 conexion.Close();



             }
         }*/
            public void TarifaHoteles()
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,precio FROM tarifa_hoteles WHERE id = '" + ComboboxtarifaH.SelectedItem + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    IDTarifaHotelesMod.Text = dr.GetString(0);
                    PrecioTarifaHotelesMod.Text = dr.GetString(1);




                }

                conexion.Close();



            }
        }
        public void TarifaVuelos()
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,ruta,precio FROM vuelos WHERE id = '" + IDTarifaVuelosMod.SelectedItem + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    RutaTarifaVuelosMOD.Items.Add(dr.GetString(1));
                 
                    PreciosTarifaVuelosMod.Text = dr.GetString(2);




                }

                conexion.Close();



            }
        }
        public void vehiculosM()
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,marca,modelo,tipo,precio,cantidad FROM vehiculos WHERE id = '" + IDVehiculoMod.SelectedItem + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    MarcavehiculoMod.Text = dr.GetString(1);
                    ModeloVehiculoMod.Text = dr.GetString(2);
                    TipovehiculoMod.Text = dr.GetString(3);
                    PreciovehiculoMod.Text = dr.GetString(4);
                    cantidadvehiculoMod.Text = dr.GetString(5);





                }

                conexion.Close();



            }
        }
        private void LugaresMOD_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            LugaresM();
       
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LugaresD();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AeropuertoD();
        }

        private void tabPage17_Click(object sender, EventArgs e)
        {

        }

        private void AeropuertoMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            AeropuertoM();
        }

        private void POmod_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void PDmod_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_4(object sender, EventArgs e)
        {

        }

        private void ComboboxtarifaH_SelectedIndexChanged(object sender, EventArgs e)
        {
            TarifaHoteles();
        }

        private void TarifaHdelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void IDvehiculoDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDVehiculoMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehiculosM();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            InsertarDatosPais();


        }

        private void aeropuertoDelete_MouseClick(object sender, MouseEventArgs e)
        {
            AeropuertoM();
        }
        public void clearAll()
        {
            txtIDPais.Clear();
            textBox3.Clear();
        
            textBox4.Clear();
            
            IDLADD.Clear();
            nombreLADD.Clear();
            IDmodL.Clear();
            nombremodl.Clear();
            IDdeleteL.Clear();
            IDaddAeropuerto.Clear();
            NombreaddAeropuerto.Clear();
            LOCALIDADddAeropuerto.Clear();
            IATAaddAeropuerto.Clear();
            IDmodAeropuerto.Clear();
            nombreMODAeropuerto.Clear();
            modLocalidadAeropuerto.Clear();
            iataMODAeropuerto.Clear();
            IDDELETEAeropuerto.Clear();
            IDRadd.Clear();


            IDHotelesAdd.Clear();
            nombreHotelesAdd.Clear();
            habitacionHotelesADD.Clear();
            IDTarifaHotelesADD.Clear();
            PrecioTarifaHotelesADD.Clear();
            IDTarifaHotelesMod.Clear();
            PrecioTarifaHotelesMod.Clear();
           
            PrecioTarifaVuelosADD.Clear();
            PreciosTarifaVuelosMod.Clear();
            IDVehiculoADD.Clear();
            MarcaVehiculoADD.Clear();
            ModeloVehiculoADD.Clear();
            TipoVehiculoADD.Clear();
            PrecioVehiculoADD.Clear();
            CantidadvehiculoADD.Clear();
            MarcavehiculoMod.Clear();
            ModeloVehiculoMod.Clear();
            TipovehiculoMod.Clear();
            PreciovehiculoMod.Clear();
            cantidadvehiculoMod.Clear();
            LugaresMOD.Items.Clear();
            ComboboxLugaresDelete.Items.Clear();
            TarifaHdelete.Items.Clear();
            ComboboxtarifaH.Items.Clear();
            RutaTarifaVuelosADD.Items.Clear();
            
            RutaTarifaVuelosMOD.Items.Clear();
            IDTarifaVuelosDelete.Items.Clear();
            IDVehiculoMod.Items.Clear();
            IDvehiculoDelete.Items.Clear();
            IDRMOD.Items.Clear();
            POmod.Items.Clear();
            PDmod.Items.Clear();
            


            PaisDadd.Items.Clear();
            







        }

        private void tabControl4_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabControl2_MouseClick(object sender, MouseEventArgs e)
        {

            clearAll();
        }

        private void tabPage14_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage13_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
           

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage10_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void Modificar_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage11_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage16_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage15_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage17_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage18_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage19_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tabPage23_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage20_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage21_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage22_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage24_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage25_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage26_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage27_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage28_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage35_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage29_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage30_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabPage31_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void tabControl8_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void c_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void Paises_MouseClick(object sender, MouseEventArgs e)
        {
            clearAll();
        }

        private void LugaresMOD_MouseClick(object sender, MouseEventArgs e)
        {
            Lugares();
           
        }

        private void ComboboxLugaresDelete_MouseClick(object sender, MouseEventArgs e)
        {
            Lugares();
        }

        private void ComboboxtarifaH_MouseClick(object sender, MouseEventArgs e)
        {
            ComboboxtarifaH.Items.Clear();
            TarifaH();
        }

        private void ComboboxtarifaH_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void TarifaHdelete_MouseClick(object sender, MouseEventArgs e)
        {
            TarifaHdelete.Items.Clear();
            TarifaH();
        }

        private void RutaTarifaVuelosADD_MouseClick(object sender, MouseEventArgs e)
        {
          Rutas();
        }

        private void IDTarifaVuelosDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDTarifaVuelosDelete_MouseClick(object sender, MouseEventArgs e)
        {
            TarifaV();
        }

        private void IDTarifaVuelosMod_MouseClick(object sender, MouseEventArgs e)
        {
           
            IDTarifaVuelosMod.Items.Clear();
            TarifaV();
        }

        private void RutaTarifaVuelosMOD_MouseClick(object sender, MouseEventArgs e)
        {
            Rutas();
        }

        private void IDVehiculoMod_MouseClick(object sender, MouseEventArgs e)
        {
            IDVehiculoMod.Items.Clear();
            vehiculos();
        }

        private void IDvehiculoDelete_MouseClick(object sender, MouseEventArgs e)
        {
            IDvehiculoDelete.Items.Clear();
            vehiculos();
        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void tabPage27_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void IDRMOD_MouseClick(object sender, MouseEventArgs e)
        {

            Rutas();
           
        }

        private void IDRMOD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }

        private void PaisOadd_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void PaisDadd_MouseClick(object sender, MouseEventArgs e)
        {
            PaisDadd.Items.Clear();
            PaisesA();
        }

        private void PDmod_MouseClick(object sender, MouseEventArgs e)
        {
            PDmod.Items.Clear();
            PaisesA();
        }

        private void POmod_MouseClick(object sender, MouseEventArgs e)
        {
            POmod.Items.Clear();
            PaisesA();
        }

        private void comboboxdeleteRuta_MouseClick(object sender, MouseEventArgs e)
        {

            
            
        }

        private void comboboxdeleteRuta_MouseClick_1(object sender, MouseEventArgs e)
        {
            comboboxdeleteRuta.Items.Clear();
            Rutas();
        }

        private void comboboxdeleteRuta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Administrador_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void label68_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.Hide();
            Aeropuertos v = new Aeropuertos();
            v.Show();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            this.Hide();
            Aeropuertos v = new Aeropuertos();
            v.Show();
        }

        private void PrecioM_Click(object sender, EventArgs e)
        {
            PrecioM.Items.Clear();
            TarifaH();
        }

        private void Precio_Click(object sender, EventArgs e)
        {
            Precio.Items.Clear();
            TarifaH();
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                
                }
        }

      
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void IDLADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void nombreLADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void nombremodl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NombreaddAeropuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LOCALIDADddAeropuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void nombreMODAeropuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void modLocalidadAeropuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void nombreHotelesAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NombreHotelesMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MarcaVehiculoADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ModeloVehiculoADD_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModeloVehiculoADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TipoVehiculoADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MarcavehiculoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ModeloVehiculoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TipovehiculoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tabPage32_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rep r = new Rep();
            r.Show();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIDPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void IDHotelesAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void habitacionHotelesADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void habitacionesHotelesMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void IDTarifaHotelesADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void IDTarifaVuelosADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PrecioTarifaVuelosADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PreciosTarifaVuelosMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void IDVehiculoADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PreciovehiculoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cantidadvehiculoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void imagenPaisesAdd_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    cadenas = openFileDialog1.FileName;
                    imagenPaisesAdd.Load(this.openFileDialog1.FileName);
                    MessageBox.Show(cadenas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void imagemodPaises_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    cadenas = openFileDialog1.FileName;
                    imagemodPaises.Load(this.openFileDialog1.FileName);
                    MessageBox.Show(cadenas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void imagenhotel_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    cadenas = openFileDialog1.FileName;
                    imagenhotel.Load(this.openFileDialog1.FileName);
                    MessageBox.Show(cadenas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void imagenHotelesMod_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    cadenas = openFileDialog1.FileName;
                    imagenHotelesMod.Load(this.openFileDialog1.FileName);
                    MessageBox.Show(cadenas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ModificarDatosPais();
        }

        private void TarifaHdelete_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Items.Clear();
            PaisesA();
        }

        private void c_Click(object sender, EventArgs e)
        {
            c.Items.Clear();
            PaisesA();
        }

        private void PrecioTarifaHotelesADD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void paisHotelesADD_MouseClick(object sender, MouseEventArgs e)
        {
            paisHotelesADD.Items.Clear();
            PaisesA();
        }

        private void LugarHotelesADD_MouseClick(object sender, MouseEventArgs e)
        {
            LugarHotelesADD.Items.Clear();
            Lugares();
        }
    }
}
