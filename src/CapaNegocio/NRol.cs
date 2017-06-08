using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NRol
    {
        public NRol()
        {
        }

        public static DataTable ObtenerRoles()
        {
            return new DRol().ObtenerRoles();
        }

        public static DataTable ObtenerRoles(int idUsuario)
        {
            DRol Objeto = new DRol();
            return Objeto.ObtenerRoles(idUsuario);
        }

        public static DataTable ObtenerRoles(string rolNombre)
        {
            DRol Objeto = new DRol();
            return Objeto.ObtenerRoles(rolNombre);
        }

        public static DataTable ObtenerFuncionalidades()
        {
            return new DRol().ObtenerFuncionalidades();
        }

        public static DataTable ObtenerFuncionalidades(string nombreRol)
        {
            DRol Objeto = new DRol();
            return Objeto.ObtenerFuncionalidades(nombreRol);
        }

        public static string AgregarRol(string nombreRol)
        {
            DRol Objeto = new DRol();
            return Objeto.AgregarRol(nombreRol);
        }

        public static DataTable ObtenerRol(string nombreRol)
        {
            DRol Objeto = new DRol();
            return Objeto.ObtenerRol(nombreRol);
        }

        public static string AgregarRolFuncionalidad(int idRol, int idFuncionalidad)
        {
            DRol Objeto = new DRol();
            return Objeto.AgregarRol(idRol, idFuncionalidad);
        }

        public static string ActualizarRol(int idRol, string nombre, int estado)
        {
            DRol Objeto = new DRol();
            return Objeto.ActualizarRol(idRol, nombre, estado);
        }
    }
}
