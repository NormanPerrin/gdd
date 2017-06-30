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

        public static DataTable ObtenerAutoHabilitado(String chofer, String turno)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutoHabilitado(chofer, turno);
        }

        public static string baja(int idAuto)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.EliminarAuto(idAuto);
        }

        public static string modificacion(int idAuto, string licencia, string rodado)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.ModificacionAuto(idAuto, licencia, rodado);
        }

        public static object ObtenerMarcas()
        {
            return new CapaDatos.DAuto().ObtenerMarcas();
        }


        public static object ObtenerAutos(int marca, int modelo)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(marca, modelo);
        }

        public static object ObtenerAutos(int chofer)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(chofer);
        }

        public static object ObtenerAutos(string patente)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(patente);
        }

        public static object ObtenerAutos(int marca, int modelo, int chofer)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(marca, modelo, chofer);
        }

        public static object ObtenerAutos(int marca, int modelo, string patente)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(marca, modelo, patente);
        }

        public static object ObtenerAutos(string patente, int chofer)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(patente, chofer);
        }

        public static object ObtenerAutos(int marca, int modelo, string patente, int chofer)
        {
            CapaDatos.DAuto Objeto = new CapaDatos.DAuto();
            return Objeto.ObtenerAutos(marca, modelo, patente, chofer);
        }

        public static string alta(int idAuto)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.HabilitarAuto(idAuto);
        }

        public static string modificarChofer(int auto, int chofer, int turno)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.modificarChofer(auto, chofer, turno);
        }

        public static string modificarTurno(int auto, int chofer, int turno)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.modificarTurno(auto, chofer, turno);
        }
    }
}
