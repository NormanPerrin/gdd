using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAuto
    {
        public DAuto()
        {
        }

        public string AgregarAuto(int marca, int modelo, string patente, int turno, int chofer)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[5];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@patente";
            parametros[0].SqlDbType = SqlDbType.NVarChar;
            parametros[0].Size = 10;
            parametros[0].Value = patente;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@marca";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = marca;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@modelo";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = modelo;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@idTurno";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].Value = turno;

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@idChofer";
            parametros[4].SqlDbType = SqlDbType.Int;
            parametros[4].Value = chofer;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAltaAutomovil");
            string respuesta = string.Empty;
         
            return resultado;
        }

        public object ObtenerTurnos()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Turnos");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerTurnos");

            return DtResultado;
        }

        public object ObtenerChoferes()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Choferes");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerChoferes");

            return DtResultado;
        }

        public DataTable ObtenerAutoHabilitado(String chofer, String turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idchofer";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = Int32.Parse(chofer);

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@turno";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = Int32.Parse(turno);

            DataTable DtResultado = new DataTable("Modelo");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutoPorIDChoferTurno");
            return DtResultado;
        }

        public string EliminarAuto(int idAuto)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = idAuto;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spEliminarAuto");
            string respuesta = string.Empty;
          
            return resultado;
        }

        public string ModificacionAuto(int idAuto, string licencia, string rodado)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = idAuto;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@licencia";
            parametros[1].SqlDbType = SqlDbType.NVarChar;
            parametros[1].Size = 26;
            parametros[1].Value = licencia;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@rodado";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 10;
            parametros[2].Value = rodado;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spModificacionAutomovil");
            string respuesta = string.Empty;
  
            return resultado;
        }

        public object ObtenerMarcas()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Marcas");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerMarcasYModelos");

            return DtResultado;
        }

        public object ObtenerAutos(int marca, int modelo)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Autos");

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@marca";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = marca;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@modelo";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = modelo;

            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutosMarcaModelo");

            return DtResultado;
        }

        public object ObtenerAutos(int chofer)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Autos");

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@chofer";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = chofer;

            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutosChofer");

            return DtResultado;
        }

        public object ObtenerAutos(string patente)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Autos");

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@patente";
            parametros[0].SqlDbType = SqlDbType.NVarChar;
            parametros[0].Size = 10;
            parametros[0].Value = patente;

            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutosPatente");

            return DtResultado;
        }

        public object ObtenerAutos(int marca, int modelo, int chofer)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Autos");

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@marca";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = marca;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@modelo";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = modelo;


            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@chofer";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = chofer;

            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutosMarcaModeloChofer");

            return DtResultado;
        }

        public object ObtenerAutos(int marca, int modelo, string patente)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Autos");

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@marca";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = marca;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@modelo";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = modelo;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@patente";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 10;
            parametros[2].Value = patente;

            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutosMarcaModeloPatente");

            return DtResultado;
        }

        public object ObtenerAutos(string patente, int chofer)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Autos");

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@patente";
            parametros[0].SqlDbType = SqlDbType.NVarChar;
            parametros[0].Size = 10;
            parametros[0].Value = patente;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@chofer";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = chofer;

            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutosPatenteChofer");

            return DtResultado;
        }

        public object ObtenerAutos(int marca, int modelo, string patente, int chofer)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Autos");

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@marca";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = marca;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@modelo";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = modelo;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@patente";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 10;
            parametros[2].Value = patente;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@chofer";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].Value = chofer;

            // me devuelva una tabla con las siugientes columnas
            //id_auto, marca, modelo, patente, chofer, licencia, rodado, nombre
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutos");

            return DtResultado;
        }

        public string HabilitarAuto(int idAuto)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = idAuto;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spHabilitarAuto");
            string respuesta = string.Empty;

            return resultado;
        }

        public string modificarChofer(int auto, int chofer, int nuevoC, int turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = auto;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@idChofer";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = chofer;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@idTurno";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = turno;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@idChoferNuevo";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].Value = nuevoC;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spModificarChofer");
            string respuesta = string.Empty;

            return resultado;
        }

        public string modificarTurno(int auto, int chofer, int turno, int nuevoT)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = auto;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@idChofer";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = chofer;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@idTurnoViejo";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = turno;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@idTurnoNuevo";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].Value = nuevoT;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spModificarTurnoAuto");
            string respuesta = string.Empty;

            return resultado;
        }

        public string agregarTurno(int auto, int chofer, int turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = auto;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@idChofer";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = chofer;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@idTurno";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = turno;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAgregarTurnoAuto");
            string respuesta = string.Empty;

            return resultado;
        }

        public string quitarTurno(int auto, int chofer, int turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = auto;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@idChofer";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = chofer;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@idTurno";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = turno;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spQuitarTurnoAuto");
            string respuesta = string.Empty;

            return resultado; 
        }

        public object ObtenerMarcas2()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Marcas");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerMarcasYModelos2");

            return DtResultado;
        }

        public object ObtenerChoferes2()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Choferes");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerChoferes2");

            return DtResultado;
        }
    }
}