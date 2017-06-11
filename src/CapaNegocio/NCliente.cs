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

        public static string alta(int dni, string nombre, string apellido, string direccion, string mail, int telefono, DateTime fecha_nac, int nro_piso, string dpto, string localidad, int cod_postal)
        {
            CapaDatos.DCliente objeto = new CapaDatos.DCliente();
            return objeto.AgregarCliente(dni, nombre, apellido, direccion, mail, telefono, fecha_nac, nro_piso, dpto,localidad, cod_postal);
        }

    }
}
