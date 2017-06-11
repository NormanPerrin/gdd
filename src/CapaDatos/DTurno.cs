using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTurno
    {
        #region Constructores

        public DTurno()
        {
        }

        #endregion

        #region Metodos/Atributos

        public DataTable ObtenerTurnos()
        {
            Conexion Conexion = new Conexion();
            DataTable DtResultado = new DataTable("Turno");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerTurnos");
            return DtResultado;
        }

        public DataTable CargarValorTurno(String turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@turno";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = Int32.Parse(turno);

            DataTable DtResultado = new DataTable("Costo");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerValorTurno");
            return DtResultado;
        }

        #endregion
    }
}
