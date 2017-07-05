using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DRendicion
    {
        public object ObtenerViajes(DateTime fecha, int turno, int chofer)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Viajes");

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@fecha";
            parametros[0].SqlDbType = SqlDbType.DateTime;
            parametros[0].Value = fecha;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@turno";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = turno;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@chofer";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = chofer;
 
            //retornar una tabla con los viajes y una columna adicional que sea el importe del viaje (base+ km * precio km) as importe
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerViajes");

            return DtResultado;
        }

        public object ObtenerViajesS(DateTime fecha, int chofer)
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Viajes");

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@fecha";
            parametros[0].SqlDbType = SqlDbType.DateTime;
            parametros[0].Value = fecha;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@chofer";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = chofer;

            //retornar una tabla con los viajes y una columna adicional que sea el importe del viaje (base+ km * precio km) as importe
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerViajes2");

            return DtResultado;
        }

        public void rendir(DateTime fecha)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@fecha";
            parametros[0].SqlDbType = SqlDbType.DateTime;
            parametros[0].Value = fecha;

            Conexion.Ejecutar(parametros, "CRAZYDRIVER.spRendir");
        }

        public void importesPorViaje(int viaje, int importe)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@viaje";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = viaje;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@importe";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = importe;

            Conexion.Ejecutar(parametros, "CRAZYDRIVER.spImportePorViaje");

        }

        public object ObtenerViajes()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Viajes");


            //retornar una tabla con los viajes y una columna adicional que sea el importe del viaje (base+ km * precio km) as importe
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerTotalViajes");

            return DtResultado;
        }



    }
}
