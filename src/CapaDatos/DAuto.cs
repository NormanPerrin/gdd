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
            /*switch (resultado)
            {
                case "-1":
                    respuesta = "Se capturo un error al intentar agregar un auto";
                    break;
                case "0":
                    respuesta = "No se logro agregar un auto";
                    break;
                case "1":
                    respuesta = "Se agrego un auto";
                    break;
            }*/
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

        #region Getters y Setters

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
            parametros[3].ParameterName = "@idChofer";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].Value = chofer;

            //Hacer SP que busque por estos parametros, aunque algunos sean NULL y me devuelva una tabla con las siugientes columnas
            //id_auto, marca, modelo, patente, chofer. licencia, rodado, nombre
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerAutos");

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

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spBajaAutomovil");
            string respuesta = string.Empty;
            /*switch (resultado)
            {
                case "-1":
                    respuesta = "Se capturo un error al intentar agregar un auto";
                    break;
                case "0":
                    respuesta = "No se logro agregar un auto";
                    break;
                case "1":
                    respuesta = "Se agrego un auto";
                    break;
            }*/
            return resultado;
        }

        public string ModificacionAuto(int idAuto, string licencia, string rodado, string nombre)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = idAuto;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@licencia";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 10;
            parametros[2].Value = licencia;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@rodado";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 10;
            parametros[2].Value = rodado;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@nombre";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 10;
            parametros[2].Value = nombre;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spModificacionAutomovil");
            string respuesta = string.Empty;
            /*switch (resultado)
            {
                case "-1":
                    respuesta = "Se capturo un error al intentar agregar un auto";
                    break;
                case "0":
                    respuesta = "No se logro agregar un auto";
                    break;
                case "1":
                    respuesta = "Se agrego un auto";
                    break;
            }*/
            return resultado;
        }

        #endregion

        public object ObtenerMarcas()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Marcas");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerMarcasYModelos");

            return DtResultado;
        }
    }
}