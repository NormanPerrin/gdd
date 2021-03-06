﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaInterfaz
{
   public class IViaje
   {
       public static void AgregarViaje(String idcliente, String idchofer, String turno, String idauto, DateTime fechaDesde, DateTime fechaHasta, int kms)
       {
           CapaNegocio.NViaje.AgregarViaje(idcliente, idchofer, turno, idauto, fechaDesde, fechaHasta, kms);
       }

       public static void CargarListaViajes(DataGridView dgvViajes, String idCliente, DateTime now)
       {
           dgvViajes.DataSource = CapaNegocio.NViaje.ObtenerListaViajesPorChofer(idCliente, now);
       }

       public static void AgregarFacturacion(String idCliente, DateTime now)
       {
           CapaNegocio.NViaje.AgregarFacturacion(idCliente, now);
       }
   }
}
