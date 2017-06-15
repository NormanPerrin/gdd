using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using Entidades;

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

        public static DataTable buscarRoles(string rolNombre) // por usuario
        {
            DRol Objeto = new DRol();
            return Objeto.buscarRoles(rolNombre);
        }

        public static DataTable ObtenerFuncionalidades()
        {
            return new DRol().ObtenerFuncionalidades();
        }

        public static DataTable ObtenerFuncionalidades(int rolId)
        {
            DRol Objeto = new DRol();
            return Objeto.ObtenerFuncionalidades(rolId);
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

        public static string AgregarRolFuncionalidad(int idRol, int idFuncionalidad, int habilitado)
        {
            DRol Objeto = new DRol();
            return Objeto.AgregarRolFuncionalidad(idRol, idFuncionalidad, habilitado);
        }

        public static string ActualizarRol(Rol rol)
        {
            DRol Objeto = new DRol();
            return Objeto.ActualizarRol(rol);
        }

        public static string ActualizarRolFuncionalidad(Rol rol, Funcionalidad funcionalidad)
        {
            DRol Objeto = new DRol();
            return Objeto.ActualizarRolFuncionalidad(rol, funcionalidad);
        }
    }
}
