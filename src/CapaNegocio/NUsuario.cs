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
    }
}
