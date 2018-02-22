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
    public partial class Administrador : Form
    {
        public Administrador()
        { 
            InitializeComponent();
            Añadir_Ruta_Aviones();
            EliminarPais();
            Lugares();
            aeropuertos();
            Rutas();

        }
        /// <summary>
        /// Seccion añadir modificar y eliminar Datos...
        /// </summary>
        /// 
        public void Rutas()
        {
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
                    PaisDadd.Items.Add(dr.GetString(2));
                    PaisOadd.Items.Add(dr.GetString(1));



                    POmod.Items.Add(dr.GetString(1));
                   
                    comboboxdeleteRuta.Items.Add(dr.GetString(0));
                    PDmod.Items.Add(dr.GetString(2));
                    
                    
                   
                }
            }
            conexion.Close();
        }
        public void aeropuertos()
        {
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
                    LugaresMOD.Items.Add(dr.GetString(1));
                    IDmodL.Text = dr.GetString(0);
                    nombremodl.Text = dr.GetString(1);
                   
                    ComboboxLugaresDelete.Items.Add(dr.GetString(1));
                    IDdeleteL.Text = dr.GetString(0);
                }
            }
            conexion.Close();
        }
        public void EliminarPais()
        {
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM paises", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    c.Items.Add(dr.GetString(0));
                    
                }
            }
            conexion.Close();
        }
        public void Añadir_Ruta_Aviones()
        {
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT ruta FROM vuelos", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    RutaTarifaVuelosADD.Items.Add(dr.GetString(0));
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
            int clave = 123;
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
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO paises (id,nombre,bandera) VALUES ('" + Convert.ToInt32(txtIDPais.Text) + "', '" + textBox3.Text + "')", conexion);
            cmd.Parameters.AddWithValue("bandera", imagenPaisesAdd);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarDatosPais()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE paises SET nombre = '" + textBox4.Text + "' WHERE id = '" + Convert.ToInt32(textBox6.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosPais()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM paises WHERE id = '" + Convert.ToInt32(IDPaisDelete.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
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
        }
        public void ModificarDatosLugares()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE lugares SET nombre = '" + nombremodl.Text + "' WHERE id = '" + Convert.ToInt32(IDmodL.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosLugares()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM lugares WHERE id = '" + Convert.ToInt32(IDdeleteL.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// Datos de Aeropuertos
        /// </summary>

        public void InsertarDatosAeropuertos()
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO aeropuertos (id,nombre,localidad,iata) VALUES ('" + Convert.ToInt32(IDaddAeropuerto.Text) + "', '" + NombreaddAeropuerto.Text + "', '" + LOCALIDADddAeropuerto.Text + "', '" + IATAaddAeropuerto + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarDatosAeropuertos()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE aeropuertos SET nombre = '" + nombreMODAeropuerto.Text + "', localidad = '" + modLocalidadAeropuerto.Text + "', iata= '" + iataMODAeropuerto.Text + "' WHERE id = '" + Convert.ToInt32(IDmodAeropuerto.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosAeropuertos()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM aeropuertos WHERE id = '" + Convert.ToInt32(IDDELETEAeropuerto.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Listo



        /// <summary>
        /// Datos de Rutas
        /// </summary>

        public void InsertarDatosRutas()
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO rutas (id,pais_origen,pais_destino,duracion) VALUES ('" + Convert.ToInt32(IDRadd.Text) + "', '" + PaisOadd.Text + "', '" + PaisDadd.Text + "', '" + DuracionRadd.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarDatosRutas()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE rutas SET pais_origen = '" + POmod.Text + "', pais_destino = '" + PDmod.Text + "', duracion= '" + DuracionRmod.Text + "' WHERE id = '" + Convert.ToInt32(IDRMOD.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosRutas()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM rutas WHERE id = '" + comboboxdeleteRuta.SelectedItem + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        /// <summary>
        /// Datos de Hoteles
        /// </summary>

        public void InsertarDatosHoteles()
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO hoteles (id,nombre,foto,pais,lugar,habitaciones) VALUES ('" + Convert.ToInt32(IDHotelesAdd.Text) + "', '" + nombreHotelesAdd.Text + "', '" + imagenhotel.Text + "', '" + paisHotelesADD.Text + "', '" + LugarHotelesADD.Text + "', '" + habitacionHotelesADD.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarDatosHoteles()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE hoteles SET nombre = '" + NombreHotelesMod.Text + "', foto = '" + imagenHotelesMod.Text + "', pais= '" + paisHotelesMod.Text + "', lugar= '" + LugarHotelesMod.Text + "', habitaciones= '" + habitacionesHotelesMod.Text + "' WHERE id = '" + Convert.ToInt32(IDHotelesMOD.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosHoteles()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM hoteles WHERE id = '" + Convert.ToInt32(IDHotelesDelete.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }




        ///Tarifa Hoteles

        public void InsertarDatosTarifaHoteles()
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO tarifa_hoteles (id,precio) VALUES ('" + Convert.ToInt32(IDTarifaHotelesADD.Text) + "', '" + PrecioTarifaHotelesADD.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarDatosTarifaHoteles()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE tarifa_hoteles SET precio = '" + PrecioTarifaHotelesMod.Text + "' WHERE id = '" + Convert.ToInt32(IDTarifaHotelesMod.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosTarifaHoteles()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM tarifa_hoteles WHERE id = '" + Convert.ToInt32(IDTarifaHotelesDelete.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        //Tarifa Vuelos
        public void InsertarDatosTarifaVuelos()
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO vuelos (id,ruta,precio) VALUES ('" + Convert.ToInt32(IDTarifaVuelosADD.Text) + "', '" + RutaTarifaVuelosADD.Text + "', '" + PrecioTarifaVuelosADD.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarDatosTarifaVuelos()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vuelos SET ruta = '" + RutaTarifaVuelosMOD.Text + "','precio =" + PreciosTarifaVuelosMod + "' WHERE id = '" + Convert.ToInt32(IDTarifaVuelosMod.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosTarifaVuelos()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM vuelos WHERE id = '" + Convert.ToInt32(IDTarifaVuelosDelete.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        /// vehiculos

        public void InsertarDatovehiculos()
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO vehiculos (id,marca,modelo,tipo,precio,cantidad) VALUES ('" + Convert.ToInt32(IDVehiculoADD.Text) + "', '" + MarcaVehiculoADD.Text + "', '" + ModeloVehiculoADD.Text + "', '" + TipoVehiculoADD.Text + "', '" + PrecioVehiculoADD.Text + "', '" + CantidadvehiculoADD.Text + "', '" + habitacionHotelesADD.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarDatosvehiculos()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE vehiculos SET marca = '" + MarcavehiculoMod.Text + "', modelo = '" + ModeloVehiculoMod.Text + "', tipo= '" + TipovehiculoMod.Text + "', precio= '" + PreciovehiculoMod.Text + "', cantidad= '" + cantidadvehiculoMod.Text + "' WHERE id = '" + Convert.ToInt32(IDVehiculoMod.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarDatosvehiculos()
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM vehiculos WHERE id = '" + Convert.ToInt32(IDvehiculoDelete.Text) + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModificarDatosAeropuertos();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EliminarDatosAeropuertos();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InsertarDatosRutas();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ModificarDatosRutas();
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
            ModificarDatosTarifaHoteles();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EliminarDatosHoteles();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            InsertarDatosHoteles();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ModificarDatosTarifaHoteles();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            EliminarDatosTarifaHoteles();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InsertarDatosTarifaVuelos();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ModificarDatosTarifaVuelos();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            EliminarDatosTarifaVuelos();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InsertarDatovehiculos();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ModificarDatosvehiculos();
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
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id,pais_origen,pais_destino,duracion FROM rutas WHERE pais_origen = '" + POmod.SelectedItem + "'and pais_destino='"+PDmod.SelectedItem +"'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    IDRMOD.Text = dr.GetString(0);
                    DuracionRmod.Text = dr.GetString(3);




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
            RutasM();
        }

        private void PDmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            RutasM();
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
    }
}
