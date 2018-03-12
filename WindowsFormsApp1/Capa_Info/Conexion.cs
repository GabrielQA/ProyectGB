using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Capa_Info
{
    public class Conexion
    {
        public static string cadenaConexion = null;
        public static NpgsqlConnection conexion;
        public static NpgsqlCommand cmd;
        public static void Coneccion()
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
    }
}
