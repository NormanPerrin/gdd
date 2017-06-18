using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public class IEstadistico
    {
        public static void BuscarAnios(ComboBox cbxAnios)
        {
            DataTable datos = CapaNegocio.NEstadistico.BuscarAnios();
            CapaInterfaz.Cargador.CargarComboboxConDatos(cbxAnios, datos);
        }

        public static DataTable BuscarChoferesMayorRecaudacion(int trimestre, int anio)
        {
            return CapaNegocio.NEstadistico.BuscarChoferesMayorRecaudacion(trimestre, anio);
        }

        public static DataTable BuscarChoferesViajeMasLargo(int trimestre, int anio)
        {
            return CapaNegocio.NEstadistico.BuscarChoferesViajeMasLargo(trimestre, anio);
        }

        public static DataTable BuscarClientesMayorConsumo(int trimestre, int anio)
        {
            return CapaNegocio.NEstadistico.BuscarClientesMayorConsumo(trimestre, anio);
        }

        public static DataTable BuscarCantVecesClienteMismoAuto(int trimestre, int anio)
        {
            return CapaNegocio.NEstadistico.BuscarCantVecesClienteMismoAuto(trimestre, anio);
        }
    }
}
