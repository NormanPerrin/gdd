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
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes, 0);
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes, 3);
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes, 6);
        }

        public static void viajes2(System.Windows.Forms.DataGridView tablaViajes, DateTime fecha, int idChofer)
        {
            tablaViajes.DataSource = CapaNegocio.NRendicion.ObtenerViajesS(fecha, idChofer);
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes, 0);
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes, 3);
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes, 6);
        }

        public static int calcularImporte(DataGridView tablaViajes)
        {
            int importeTotal = 0;

            foreach (DataGridViewRow row in tablaViajes.Rows)
            {
                //en la columna de importe por viaje
                importeTotal += System.Convert.ToInt32(row.Cells[7].Value);

            }
            return importeTotal;

        }

        public static void rendir(DataGridView tablaViajes, DateTime fecha)
        {  
                //rendicion
                CapaNegocio.NRendicion.rendir(fecha);

                int importe = 0;
                int viaje = 0;
                foreach (DataGridViewRow row in tablaViajes.Rows)
                {
                    //en la columna de importe por viaje
                    importe = System.Convert.ToInt32(row.Cells[7].Value);
                    viaje = System.Convert.ToInt32(row.Cells[6].Value);
                    CapaNegocio.NRendicion.importesPorViaje(viaje, importe);
                }
       
        }



        public static void viajes(DataGridView tablaViajes2)
        {
            tablaViajes2.DataSource = CapaNegocio.NRendicion.ObtenerViajes();
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes2, 0);
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes2, 3);
            CapaInterfaz.IAuto.OcultarColumnas(tablaViajes2, 6);
        }
    }
}
