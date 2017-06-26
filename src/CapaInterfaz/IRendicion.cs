using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public class IRendicion
    {

        public static void viajes(System.Windows.Forms.DataGridView tablaViajes, DateTime fecha, int turno, int idChofer)
        {
            tablaViajes.DataSource = CapaNegocio.NRendicion.ObtenerViajes(fecha, turno, idChofer);
        }

        public static int calcularImporte(DataGridView tablaViajes)
        {
            int importeTotal = 0;

            foreach (DataGridViewRow row in tablaViajes.Rows)
            {
                //en la columna de importe por viaje
                importeTotal += System.Convert.ToInt32(row.Cells[4].Value);

            }
            return importeTotal;

        }

        public static void rendir(DataGridView tablaViajes, DateTime fecha)
        {
            CapaNegocio.NRendicion.rendir(fecha);

            int importe = 0;
            int viaje = 0;
            foreach (DataGridViewRow row in tablaViajes.Rows)
            {
                //en la columna de importe por viaje
                importe = System.Convert.ToInt32(row.Cells[4].Value);
                viaje = System.Convert.ToInt32(row.Cells[3].Value);
                CapaNegocio.NRendicion.importesPorViaje(viaje, importe);
            }
        }



        public static void viajes(DataGridView tablaViajes2, int idChofer)
        {
            tablaViajes2.DataSource = CapaNegocio.NRendicion.ObtenerViajes(idChofer);
        }
    }
}
