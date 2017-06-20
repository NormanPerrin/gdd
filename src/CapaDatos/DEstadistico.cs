using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class DEstadistico
    {
        public DataTable BuscarAnios()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Anios");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spBuscarAnios");

            return DtResultado;
        }

        public DataTable BuscarChoferesMayorRecaudacion(int trimestre, int anio)
        {
            Conexion Conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@trimestre";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = trimestre;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@anio";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = anio;

            DataTable DtResultado = new DataTable("ChoferesMayorRecaudacion");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spTop5Recaudacion");
            return DtResultado;
        }

        public DataTable BuscarChoferesViajeMasLargo(int trimestre, int anio)
        {
            Conexion Conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@trimestre";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = trimestre;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@anio";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = anio;

            DataTable DtResultado = new DataTable("ChoferesViajeMasLargo");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spTop5ViajesMasLargos");
            return DtResultado;
        }

        public DataTable BuscarClientesMayorConsumo(int trimestre, int anio)
        {
            Conexion Conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@trimestre";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = trimestre;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@anio";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = anio;

            DataTable DtResultado = new DataTable("ClientesMayorConsumo");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spTop5ClientesMayorConsumo");
            return DtResultado;
        }

        public DataTable BuscarCantVecesClienteMismoAuto(int trimestre, int anio)
        {
            Conexion Conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@trimestre";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = trimestre;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@anio";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = anio;

            DataTable DtResultado = new DataTable("CantVecesClienteMismoAuto");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spTop5CantVecesClienteMismoAuto");
            return DtResultado;
        }
    }
}
