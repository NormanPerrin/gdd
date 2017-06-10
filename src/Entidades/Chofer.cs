using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Chofer
    {
        #region Atributos

        // datos de interes de tabla
        private int _id;
        private int _habilitado;
        private int _idUsuario; // clave foranea

        // dato auxiliar
        private string _dniString;
        private string _fechaNacString;
        private string _telefonoString;
        private string _nroPisoString;
        private string _estado; // es lo mismo que habilitado pero lo tengo así para no andar haciendo tantas conversiones

        // datos personales
        private string _nombre;
        private string _apellido;
        private int _dni;
        private DateTime _fechaNac;

        // datos de localizacion
        private int _telefono;
        private string _mail;
        private string _direccion;
        private string _localidad;
        private int _nroPiso;
        private string _depto; // nuevo requisito del relevamiento

        #endregion

        #region Getters and Setters

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

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

        public string FechaNacString
        {
            get { return _fechaNacString; }
            set { _fechaNacString = value; }
        }

        public string NroPisoString
        {
            get { return _nroPisoString; }
            set { _nroPisoString = value; }
        }

        public int Telefono
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

        public int Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
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

        public string DniString
        {
            get { return _dniString; }
            set { _dniString = value; }
        }

        public string TelefonoString
        {
            get { return _telefonoString; }
            set { _telefonoString = value; }
        }

        #endregion Constructores

        public Chofer()
        {
        }

        public void limpiarAtributos(Chofer chofer)
        {
            chofer.Id = -1;
            chofer.Nombre = string.Empty;
            chofer.Apellido = string.Empty;
            chofer.Dni = -1;
            chofer.FechaNac = new DateTime();
            chofer.Telefono = -1;
            chofer.Mail = string.Empty;
            chofer.Direccion = string.Empty;
            chofer.Localidad = string.Empty;
            chofer.NroPiso = new Int32();
            chofer.Depto = string.Empty;
            chofer.Habilitado = -1;
            chofer.Estado = string.Empty;
            chofer.IdUsuario = new Int32();
        }
    }
}
