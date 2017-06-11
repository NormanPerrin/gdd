using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCliente
    {
        public DCliente()
        {
        }

        public DataTable ObtenerClientes()
        {
            Conexion Conexion = new Conexion();
            DataTable DtResultado = new DataTable("Clientes");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerClientes");
            return DtResultado;
        }
    }
}
