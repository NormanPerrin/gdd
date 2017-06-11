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

        public DataTable ObtenerChoferes(String turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@turno";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = Int32.Parse(turno);

            DataTable DtResultado = new DataTable("Chofer");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerChoferesPorTurno");
            return DtResultado;
        }

    }
}
