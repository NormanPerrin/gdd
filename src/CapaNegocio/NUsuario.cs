using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NUsuario
    {
        #region Atributos

        private int _IdUsuario;
        private string _Username;
        private string _Pass;
        private int _IdPersona;
        private int _Intentos;

        #endregion
        
        #region Constructores

        public NUsuario()
        {
        }

        #endregion

        #region Metodos/Atributos

            public static string Insertar(string username, string pass)
            {
                DUsuario Objeto = new DUsuario();
                Objeto.Username = username;
                Objeto.Pass = pass;
                Objeto.IdPersona = -1; // por creamos usuarios con identidad de "persona"
                Objeto.Intentos = 0; // Arranca con 0 intentos de login
                return Objeto.Insertar(Objeto);
            }

            public static string EditarIntentos(int idUsuario, int intentos)
            {
                DUsuario Objeto = new DUsuario();
                Objeto.IdUsuario = idUsuario;
                Objeto.Intentos = intentos;
                return Objeto.EditarIntentos(Objeto);
            }

            public static DataTable Login(string username)
            {
                DUsuario Objeto = new DUsuario();
                Objeto.Username = username;
                return Objeto.Login(Objeto);
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
