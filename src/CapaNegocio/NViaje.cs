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
            // TODO: sacar fechas hardcodeadas
            DateTime fechaDesde = new DateTime(1999, 01, 01);
            DateTime fechaHasta = new DateTime(2017, 01, 01);
            return new CapaDatos.DViaje().ObtenerListaViajesPorChofer(idCliente, fechaDesde, fechaHasta);
        }

        public static void AgregarFacturacion(String idCliente)
        {
            // TODO: sacar fechas hardcodeadas
            DateTime fechaAhora = new DateTime(2016, 06, 06);
            DateTime fechaDesde = new DateTime(1999, 01, 01);
            DateTime fechaHasta = new DateTime(2017, 01, 01);
            new CapaDatos.DViaje().AgregarFacturacion(idCliente, fechaAhora, fechaDesde, fechaHasta);
        }
    }
}
