using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NRendicion
    {
        public static object ObtenerViajes(DateTime fecha, int turno, int idChofer)
        {
            CapaDatos.DRendicion Objeto = new CapaDatos.DRendicion();
            return Objeto.ObtenerViajes(fecha, turno, idChofer);
        }

        public static void rendir(DateTime fecha)
        {
            CapaDatos.DRendicion Objeto = new CapaDatos.DRendicion();
            Objeto.rendir(fecha);
        }

        public static void importesPorViaje(int viaje, int importe)
        {
            CapaDatos.DRendicion Objeto = new CapaDatos.DRendicion();
            Objeto.importesPorViaje(viaje, importe);
        }

        public static object ObtenerViajes(int idChofer)
        {
            CapaDatos.DRendicion Objeto = new CapaDatos.DRendicion();
            return Objeto.ObtenerViajes(idChofer);
        }
    }
}
