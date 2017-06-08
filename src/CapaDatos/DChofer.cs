using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DChofer
    {
        public DChofer()
        {
        }

        public DataTable ObtenerChoferes()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Choferes");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerTodoChoferes");

            return DtResultado;
        }

        public DataTable ObtenerChoferEspecifico(string nombre, string apellido, string dni)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@choferNombre";
            parametros[0].SqlDbType = SqlDbType.NVarChar;
            parametros[0].Size = 255;
            parametros[0].Value = nombre;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@choferApellido";
            parametros[1].SqlDbType = SqlDbType.NVarChar;
            parametros[1].Size = 255;
            parametros[1].Value = apellido;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@choferDni";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 18;
            parametros[2].Value = dni;

            DataTable DtResultado = new DataTable("Choferes");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerChoferEspecifico");

            return DtResultado;
        }
        
    }
}
