using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NAuto
    {


        public static string alta(int marca, int modelo, string patente, int turno, int chofer)
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

        public static object ObtenerAutos(int marca, int modelo, string patente, int chofer)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(marca, modelo, patente, chofer);
        }

        public static string baja(int idAuto)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.EliminarAuto(idAuto);
        }

        public static string modificacion(int idAuto, string licencia, string rodado, string nombre)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.ModificacionAuto(idAuto, licencia, rodado, nombre);
        }
    }
}
