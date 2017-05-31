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
    public class IAuto
    {
        #region Atributos

        private int _idAuto;
        private string _patente;
        private string _marca;
        private string _modelo;
        private string _licencia;
        private string _rodado;
        private int _habilitado;

        #endregion

        #region Metodos/Atributos

        public static string alta(string patente, string marca, string modelo, string licencia, string rodado)
        {
            string respuesta = CapaNegocio.NAuto.alta(patente, marca, modelo, licencia, rodado);

            return respuesta;
        }

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

        public string Licencia
        {
            get { return _licencia; }
            set { _licencia = value; }
        }

        public string Rodado
        {
            get { return _rodado; }
            set { _rodado = value; }
        }
        #endregion

    }

}
