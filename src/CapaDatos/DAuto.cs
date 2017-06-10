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

    }
}
