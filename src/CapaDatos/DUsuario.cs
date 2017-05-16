using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario
    {
        #region Atributos

            private int _IdUsuario;
            private string _Username;
            private string _Pass;
            private int _IdPersona;
            private int _Intentos;

        #endregion

        #region Constructores

            public DUsuario()
            {
            }

        #endregion

        #region Metodos/Atributos

            public string Insertar(DUsuario Usuario)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[5];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idUsuario";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].Direction = ParameterDirection.Output;

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@username";
                parametros[1].SqlDbType = SqlDbType.NVarChar;
                parametros[1].Size = 255;
                parametros[1].Value = Usuario.Username;

                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@pass";
                parametros[2].SqlDbType = SqlDbType.VarBinary;
                parametros[2].Size = 255;
                parametros[2].Value = Usuario.Pass;

                parametros[1] = new SqlParameter();
                parametros[3].ParameterName = "@idPersona";
                parametros[3].SqlDbType = SqlDbType.Int;
                parametros[3].Value = Usuario.IdPersona;

                parametros[4] = new SqlParameter();
                parametros[4].ParameterName = "@intentos";
                parametros[4].SqlDbType = SqlDbType.Int;
                parametros[4].Value = Usuario.Intentos;

                int resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spInsertarUsuario");
                string respuesta = string.Empty;
                switch(resultado)
                {
                    case -1:
                        respuesta = "Se capturo un error al intentar insertar un usuario";
                        break;
                    case 0:
                        respuesta = "No se logro agregar un usuario";
                        break;
                    case 1:
                        respuesta = "Se agrego un usuario";
                        break;
                }
                return respuesta;
            }

            public string EditarIntentos(DUsuario Usuario)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[2];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idUsuario";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].Value = Usuario.IdUsuario;

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@intentos";
                parametros[1].SqlDbType = SqlDbType.Int;
                parametros[1].Value = Usuario.Intentos;

                int resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spEditarIntentosUsuario");
                string respuesta = string.Empty;
                switch(resultado)
                {
                    case -1:
                        respuesta = "Se capturo un error al intentar editar un usuario";
                        break;
                    case 0:
                        respuesta = "No se logro editar un usuario";
                        break;
                    case 1:
                        respuesta = "Se edito un usuario";
                        break;
                }
                return respuesta;
            }

            public DataTable Login(DUsuario Usuario)
            {
                Conexion Conexion = new Conexion();

                SqlParameter[] parametros = new SqlParameter[1];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@username";
                parametros[0].SqlDbType = SqlDbType.NVarChar;
                parametros[0].Size = 255;
                parametros[0].Value = Usuario.Username;

                DataTable DtResultado = new DataTable("Usuario");
                DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spLogin");

                return DtResultado;
            }

        #endregion

        #region Getters y Setters

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }

        public int IdPersona
        {
            get { return _IdPersona; }
            set { _IdPersona = value; }
        }

        public int Intentos
        {
            get { return _Intentos; }
            set { _Intentos = value; }
        }

        #endregion
    }
}
