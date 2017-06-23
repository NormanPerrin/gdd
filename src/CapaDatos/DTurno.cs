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

        public string Alta(Entidades.Turno turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[6];
            
            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@desc";
            parametros[0].SqlDbType = SqlDbType.VarChar;
            parametros[0].Size = 225;
            parametros[0].Value = turno.Descripcion;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@hinicio";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = turno.Hora_inicio;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@hfin";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = turno.Hora_fin;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@valorkm";
            parametros[3].SqlDbType = SqlDbType.Float;
            parametros[3].Value = turno.Valor_km;

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@pbase";
            parametros[4].SqlDbType = SqlDbType.Float;
            parametros[4].Value = turno.Precio_base;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@habilitado";
            parametros[5].SqlDbType = SqlDbType.TinyInt;
            parametros[5].Value = turno.Habilitado;


            return Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAltaTurno");
        }

        public object BusquedaTurno(Entidades.Turno turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@desc";
            parametros[0].SqlDbType = SqlDbType.NVarChar;
            parametros[0].Size = 225;
            parametros[0].Value = turno.Descripcion;    

            DataTable DtResultado = new DataTable("Turnos");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spBuscarTurno");

            return DtResultado;
        }

        public string Eliminar(int id_turno)
        {

            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@id_turno";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = id_turno;

            return Conexion.Ejecutar(parametros, "CRAZYDRIVER.spEliminarTurno");
        }

        public string Modificar(Entidades.Turno turno)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[7];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@desc";
            parametros[0].SqlDbType = SqlDbType.VarChar;
            parametros[0].Size = 225;
            parametros[0].Value = turno.Descripcion;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@hinicio";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = turno.Hora_inicio;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@hfin";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = turno.Hora_fin;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@valorkm";
            parametros[3].SqlDbType = SqlDbType.Float;
            parametros[3].Value = turno.Valor_km;

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@pbase";
            parametros[4].SqlDbType = SqlDbType.Float;
            parametros[4].Value = turno.Precio_base;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@habilitado";
            parametros[5].SqlDbType = SqlDbType.TinyInt;
            parametros[5].Value = turno.Habilitado;

            parametros[6] = new SqlParameter();
            parametros[6].ParameterName = "@id_turno";
            parametros[6].SqlDbType = SqlDbType.Int;
            parametros[6].Value = turno.Id_turno;


            return Conexion.Ejecutar(parametros, "CRAZYDRIVER.spModificarTurno");
        }
    }
}
