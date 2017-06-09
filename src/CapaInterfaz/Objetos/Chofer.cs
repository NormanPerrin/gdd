using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaz.Objetos
{
    public class Chofer
    {
        #region Atributos

        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _direccion;
        private int _nroPiso;
        private string _depto; // nuevo requisito del relevamiento
        private string _localidad;
        private string _telefono;
        private string _mail;
        private DateTime _fechaNac;
        private string _habilitado;
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

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
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

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
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

        public string Habilitado
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
    }
}
