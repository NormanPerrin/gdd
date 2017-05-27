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
        #region Atributos

        private int _idRol;
        private string _nombre;
        private int _habilitado;

        #endregion
        
        #region Constructores

        public NRol()
        {
        }

        #endregion

        #region Metodos/Atributos

            public static DataTable ObtenerRoles()
            {
                DRol Objeto = new DRol();
                return Objeto.ObtenerRoles();
            }
            public static DataTable ObtenerRoles(int idUsuario)
            {
                DRol Objeto = new DRol();
                return Objeto.ObtenerRoles(idUsuario);
            }

            public static DataTable ObtenerFuncionalidades(string nombreRol)
            {
                DRol Objeto = new DRol();
                return Objeto.ObtenerFuncionalidades(nombreRol);
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
