using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;

namespace CapaInterfaz
{
   public class IViaje
   {
       public static void AgregarViaje(String idcliente, String idchofer, String turno, String idauto, String fechaDesde, String fechaHasta, int kms)
       {
           CapaNegocio.NViaje.AgregarViaje(idcliente, idchofer, turno, idauto, fechaDesde, fechaHasta, kms);
       }
   }
}
