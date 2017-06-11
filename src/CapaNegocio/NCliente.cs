using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCliente
    {
        public static DataTable ObtenerClientes()
        {
            DCliente Objeto = new DCliente();
            return Objeto.ObtenerClientes();
        }
    }
}
