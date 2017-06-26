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

        public static DataTable ObtenerClientes(DateTime dateFrom, DateTime dateTo)
        {
            DCliente Objeto = new DCliente();
            return Objeto.ObtenerClientes(dateFrom, dateTo);
        }

        public static string alta(int dni, string nombre, string apellido, string direccion, string mail, int telefono, DateTime fecha_nac, int? nro_piso, char? dpto, string localidad, int cod_postal)
        {
            CapaDatos.DCliente objeto = new CapaDatos.DCliente();
            return objeto.AgregarCliente(dni, nombre, apellido, direccion, mail, telefono, fecha_nac, nro_piso, dpto,localidad, cod_postal);
        }

        public static DataTable BuscarCliente(Entidades.Cliente cliente)
        {
            return new DCliente().BuscarCliente(cliente);
        }

        public static string modificacion(Entidades.Cliente cliente)
        {
            return new DCliente().Modificacion(cliente);
        }

        public static string eliminar(int cliente)
        {
            CapaDatos.DCliente objeto = new CapaDatos.DCliente();
            return objeto.eliminar(cliente);
        }

        public static DataTable ObtenerClientesSinFacturacion(DateTime fechaDesde, DateTime fechaHasta)
        {
            DCliente Objeto = new DCliente();
            return Objeto.ObtenerClientesSinFacturacion(fechaDesde, fechaHasta);
        }
    }
}
