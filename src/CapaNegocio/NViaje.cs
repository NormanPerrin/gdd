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
        public static void AgregarViaje(String idcliente, String idchofer, String turno, String idauto, String fechaDesde, String fechaHasta, int kms)
        {
            DViaje Objeto = new DViaje();
            Objeto.AgregarViaje(idcliente, idchofer, turno, idauto, fechaDesde, fechaHasta, kms);
        }
    }
}
