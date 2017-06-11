using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        #region Atributos

        private int _idAuto;
        private string _marca;
        private string _modelo;
        private string _patente;
        private int _turno;
        private int _chofer;
        private int _habilitado;

        #endregion

        #region Getters y Setters

        public int IdAuto
        {
            get { return _idAuto; }
            set { _idAuto = value; }
        }

        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public int Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        public int Chofer
        {
            get { return _chofer; }
            set { _chofer = value; }
        }

        public int Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        #endregion
    }
}
