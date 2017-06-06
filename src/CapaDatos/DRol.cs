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

            public DataTable ObtenerRoles()
            {
                Conexion Conexion = new Conexion();

                DataTable DtResultado = new DataTable("Roles");
                DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerRoles");

                return DtResultado;
            }

            public DataTable ObtenerRoles(int idUsuario)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idUsuario";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].Value = idUsuario;

                DataTable DtResultado = new DataTable("Roles");
                DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerRolesPorUsuario");

                return DtResultado;
            }

            public DataTable ObtenerRoles(string rolNombre)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@rolNombre";
                parametros[0].SqlDbType = SqlDbType.NVarChar;
                parametros[0].Size = 100;
                parametros[0].Value = rolNombre;

                DataTable DtResultado = new DataTable("Roles");
                DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerRolesPorNombre");

                return DtResultado;
            }

            public DataTable ObtenerFuncionalidades()
            {
                Conexion Conexion = new Conexion();

                DataTable DtResultado = new DataTable("Funcionalidades");
                DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerFuncionalidades");

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
                DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerFuncionalidadesPorRol");

                return DtResultado;
            }

            public string AgregarRol(string nombreRol)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[2];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idRol";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].Direction = ParameterDirection.Output;

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nombreRol";
                parametros[1].SqlDbType = SqlDbType.NVarChar;
                parametros[1].Size = 100;
                parametros[1].Value = nombreRol;

                int resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAgregarRol");
                string respuesta = string.Empty;
                switch (resultado)
                {
                    case -1:
                        respuesta = "Se capturo un error al intentar agregar un rol";
                        break;
                    case 0:
                        respuesta = "No se logro agregar un rol";
                        break;
                    case 1:
                        respuesta = "Se agrego un usuario";
                        break;
                }
                return respuesta;
            }

            public DataTable ObtenerRol(string rolNombre)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@rolNombre";
                parametros[0].SqlDbType = SqlDbType.NVarChar;
                parametros[0].Size = 100;
                parametros[0].Value = rolNombre;

                DataTable DtResultado = new DataTable("Rol");
                DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerRol");

                return DtResultado;
            }

            public string AgregarRol(int idRol, int idFuncionalidad)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[2];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idRol";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].Value = idRol;

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@idFuncionalidad";
                parametros[1].SqlDbType = SqlDbType.Int;
                parametros[1].Value = idFuncionalidad;

                int resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAgregarRolFuncionalidad");
                string respuesta = string.Empty;
                switch (resultado)
                {
                    case -1:
                        respuesta = "Se capturo un error al intentar agregar una funcionalidad al rol";
                        break;
                    case 0:
                        respuesta = "No se logro agregar una funcionalidad al rol";
                        break;
                    case 1:
                        respuesta = "Se agrego un usuario";
                        break;
                }
                return respuesta;
            }

            public string ActualizarRol(int idRol, string nombre, int estado)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[3];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idRol";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].Value = idRol;

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@rolNombre";
                parametros[1].SqlDbType = SqlDbType.NVarChar;
                parametros[1].Size = 100;
                parametros[1].Value = nombre;

                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@habilitado";
                parametros[2].SqlDbType = SqlDbType.Int;
                parametros[2].Value = estado;

                int resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spActualizarRol");
                string respuesta = string.Empty;
                switch (resultado)
                {
                    case -1:
                        respuesta = "Se capturo un error al intentar agregar una funcionalidad al rol";
                        break;
                    case 0:
                        respuesta = "No se logro agregar una funcionalidad al rol";
                        break;
                    case 1:
                        respuesta = "Se agrego un usuario";
                        break;
                }
                return respuesta;
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
