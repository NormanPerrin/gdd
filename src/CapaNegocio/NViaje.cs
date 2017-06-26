using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NViaje
    {
        public static void AgregarViaje(String idcliente, String idchofer, String turno, String idauto, DateTime fechaDesde, DateTime fechaHasta, int kms)
        {
            DViaje Objeto = new DViaje();
            Objeto.AgregarViaje(idcliente, idchofer, turno, idauto, fechaDesde, fechaHasta, kms);
        }

        public static DataTable ObtenerListaViajesPorChofer(String idCliente)
        {
            DateTime now = DateTime.Now;
            DateTime fechaDesde = new DateTime(now.Year, now.Month, 1);
            DateTime fechaHasta = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
            return new CapaDatos.DViaje().ObtenerListaViajesPorChofer(idCliente, fechaDesde, fechaHasta);
        }

        public static void AgregarFacturacion(String idCliente)
        {
            DateTime now = DateTime.Now;
            DateTime fechaDesde = new DateTime(now.Year, now.Month, 1);
            DateTime fechaHasta = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month), 23, 59, 59);
            new CapaDatos.DViaje().AgregarFacturacion(idCliente, now, fechaDesde, fechaHasta);
        }
    }
}
