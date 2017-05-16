using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DRol
    {
        #region Atributos

        private int _idRol;
        private string _nombre;
        private int _habilitado;

        #endregion

        #region Constructores

        public DRol()
        {
        }

        #endregion

        #region Metodos/Atributos

            public DataTable ObtenerRoles(int idUsuario)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idUsuario";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].Value = idUsuario;

                DataTable DtResultado = new DataTable("Roles");
                DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerRoles");

                return DtResultado;
            }

            public DataTable ObtenerFuncionalidades(string nombreRol)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@nombreRol";
                parametros[0].SqlDbType = SqlDbType.NVarChar;
                parametros[0].Size = 100;
                parametros[0].Value = nombreRol;

                DataTable DtResultado = new DataTable("Funcionalidades");
                DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerFuncionalidades");

                return DtResultado;
            }

        #endregion

        #region Getters/Setters

        public int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        #endregion
    }
}
