using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Security.Cryptography;

namespace CapaInterfaz
{
    public class IUsuario
    {
        #region Metodos/Atributos abstractos

        public static void Insertar(string username, string pass)
        {
            CapaNegocio.NUsuario.Insertar(username, pass);
        }

        public static NUsuario Login(string usernameIngresado, NUsuario usuario)
        {
            DataTable Datos = CapaNegocio.NUsuario.Login(usernameIngresado);

            if (Datos.Rows.Count != 0) // cuento la cantidad de resultados y comparo...
            {
                usuario.IdUsuario = System.Convert.ToInt32(Datos.Rows[0][0]); // dato 1
                byte[] binaryString = (byte[])Datos.Rows[0][1]; // dato 2
                usuario.Pass = BitConverter.ToString(binaryString).Replace("-", ""); // convierto dato 2 en string
                usuario.IdPersona = 0; //(int)System.Convert.ToInt32(Datos.Rows[0][2]); // dato 3
                usuario.Intentos = System.Convert.ToInt32(Datos.Rows[0][3]); // dato 4
            }
            else
            {
                usuario = null;
            }
            return usuario;
        }

        public static bool esPassCorrecta(string password, NUsuario usuario)
        {
            SHA256 encripter = SHA256Managed.Create();
            byte[] passBytes = encripter.ComputeHash(Encoding.Unicode.GetBytes(password)); // encripto la password ingresada por teclado
            string PassIngresada = BitConverter.ToString((passBytes)).Replace("-", ""); // convierto la password ingresada por teclado en un string

            if (usuario.Pass == PassIngresada) return true;

            return false;
        }

        public static void formatearIntentos(NUsuario usuario)
        {
            usuario.Intentos = 0;
            CapaNegocio.NUsuario.EditarIntentos(usuario.IdUsuario, usuario.Intentos);
        }

        public static bool tieneIntentosDisponibles(NUsuario usuario)
        {
            if (usuario.Intentos < 3) return true;
            return false;
        }

        public static void aumentarIntentos(NUsuario usuario)
        {
            usuario.Intentos++;
            CapaNegocio.NUsuario.EditarIntentos(usuario.IdUsuario, usuario.Intentos);
        }

        #endregion
    }
}
