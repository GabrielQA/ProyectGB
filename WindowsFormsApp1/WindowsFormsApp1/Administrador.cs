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
            cmd = new NpgsqlCommand("INSERT INTO lugares (id,nombre) VALUES ('" + Convert.ToInt32(IDLADD.Text) + "', '" + nombreLADD.Text + "')", conexion);
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
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM rutas WHERE id = '" + Convert.ToInt32(idrdelete.Text) + "'", conexion);
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    }































































}

