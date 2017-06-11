using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace CapaNegocio
{
    public class NAuto
    {


        public static string alta(string marca, string modelo, string patente, int turno, int chofer)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.AgregarAuto(marca, modelo, patente, turno, chofer);
        }


        public static object ObtenerTurnos()
        {
            return new CapaDatos.DAuto().ObtenerTurnos();
        }

        public static object ObtenerChoferes()
        {
            return new CapaDatos.DAuto().ObtenerChoferes();
        }

        public static DataTable ObtenerAutoHabilitado(String chofer, String turno)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutoHabilitado(chofer, turno);
        }
    }
}
