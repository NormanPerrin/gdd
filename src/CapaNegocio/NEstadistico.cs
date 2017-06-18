using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NEstadistico
    {
        public static DataTable BuscarAnios()
        {
            return new DEstadistico().BuscarAnios();
        }

        public static DataTable BuscarChoferesMayorRecaudacion(int trimestre, int anio)
        {
            return new DEstadistico().BuscarChoferesMayorRecaudacion(trimestre, anio);
        }

        public static DataTable BuscarChoferesViajeMasLargo(int trimestre, int anio)
        {
            return new DEstadistico().BuscarChoferesViajeMasLargo(trimestre, anio);
        }

        public static DataTable BuscarClientesMayorConsumo(int trimestre, int anio)
        {
            return new DEstadistico().BuscarClientesMayorConsumo(trimestre, anio);
        }

        public static DataTable BuscarCantVecesClienteMismoAuto(int trimestre, int anio)
        {
            return new DEstadistico().BuscarCantVecesClienteMismoAuto(trimestre, anio);
        }
    }
}
