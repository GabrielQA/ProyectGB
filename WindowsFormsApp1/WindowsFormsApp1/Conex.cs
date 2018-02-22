using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Conex
    {
        public static string insertar_Imagen()
        {
            return "INSERT INTO paises VALUES(@id,@nombre,@bandera)";

        }

    }
}
