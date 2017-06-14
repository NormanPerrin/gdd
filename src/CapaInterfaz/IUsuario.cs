using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Security.Cryptography;

using Entidades;

namespace CapaInterfaz
{
    public class IUsuario
    {        
        public static string Login(string usernameIngresado, Usuario usuario)
        {
            DataTable Datos = CapaNegocio.NUsuario.Login(usernameIngresado);

            if (Datos.Rows.Count == 0) // cuento la cantidad de resultados y comparo...
                return "No existe un usuario con tal nombre en la base de datos";

            usuario.Username = usernameIngresado;
            usuario.Id = System.Convert.ToInt32(Datos.Rows[0]["id_usuario"]);
            byte[] binaryString = (byte[])Datos.Rows[0]["pass"]; 
            usuario.Password = BitConverter.ToString(binaryString).Replace("-", ""); //usuario.Password = Datos.Rows[0]["pass"].ToString().Replace("-", "");
            usuario.Intentos = System.Convert.ToInt32(Datos.Rows[0]["intentos"]);
            usuario.Habilitado = System.Convert.ToInt32(Datos.Rows[0]["habilitado"]);

            if (! Convert.ToBoolean(usuario.Habilitado))
                return "Usuario bloqueado";

            return "";
        }

        public static bool esPassCorrecta(string password, Usuario usuario)
        {
            SHA256 encripter = SHA256Managed.Create();
            byte[] passBytes = encripter.ComputeHash(Encoding.Unicode.GetBytes(password)); // encripto la password ingresada por teclado
            string PassIngresada = BitConverter.ToString(passBytes).Replace("-", ""); // convierto la password ingresada por teclado en un string

            if (usuario.Password == PassIngresada) return true;

            return false;
        }

        public static void formatearIntentos(Usuario usuario)
        {
            usuario.Intentos = 0;
            CapaNegocio.NUsuario.EditarIntentos(usuario.Id, usuario.Intentos);
        }

        public static bool tieneIntentosDisponibles(Usuario usuario)
        {
            if (usuario.Intentos < 3) return true;
            return false;
        }

        public static string aumentarIntentos(Usuario usuario)
        {
            usuario.Intentos++;
            return CapaNegocio.NUsuario.EditarIntentos(usuario.Id, usuario.Intentos);
        }
    }
}
