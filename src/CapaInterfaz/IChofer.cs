using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public class IChofer
    {
        #region Atributos

        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _direcion;
        private int _nroPiso;
        private string _depto; // nuevo requisito del relevamiento
        private string _localidad;
        private int _tel;
        private string _mail;
        private DateTime _fechaNac;
        private int _habilitado;
        private int _idUsuario; // clave foranea

        #endregion

        #region Getters and Setters

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Direcion
        {
            get { return _direcion; }
            set { _direcion = value; }
        }

        public int NroPiso
        {
            get { return _nroPiso; }
            set { _nroPiso = value; }
        }

        public string Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }

        public int Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public int Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public string Depto
        {
            get { return _depto; }
            set { _depto = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        #endregion Constructores

        public static void CargarChoferes(DataGridView tablaChoferes)
        {
            tablaChoferes.DataSource = CapaNegocio.NChofer.ObtenerChoferes();
        }

        public static void CargarChoferEspecifico(DataGridView tablaChoferes, string nombre, string apellido, string dni)
        {
            if (!nombre.Equals(String.Empty) || !apellido.Equals(String.Empty) || !dni.Equals(String.Empty))
            {
                tablaChoferes.DataSource = CapaNegocio.NChofer.ObtenerChoferEspecifico(nombre, apellido, dni);
            }
        }

        public static void OcultarColumnasChoferes(DataGridView tablaChoferes)
        {
            tablaChoferes.Columns[0].Visible = false; // oculto la columna del id
            tablaChoferes.Columns[11].Visible = false; // oculto la columna del habilitado booleano
            tablaChoferes.Columns[12].Visible = false; // oculto la columna del id usuario asignado
        }
    }
}
