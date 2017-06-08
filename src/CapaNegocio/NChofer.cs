using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NChofer
    {
        public static DataTable ObtenerChoferes()
        {
            return new DChofer().ObtenerChoferes();
        }
        public static DataTable ObtenerChoferEspecifico(string nombre, string apellido, string dni)
        {
            return new DChofer().ObtenerChoferEspecifico(nombre, apellido, dni);
        }

    }
}
