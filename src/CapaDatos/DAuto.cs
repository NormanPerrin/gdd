using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAuto
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

        #region Constructores

        public DAuto()
        {
        }

        #endregion

        #region Metodos/Atributos

        public string AgregarAuto(string marca, string modelo, string patente, int turno, int chofer)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[6];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idAuto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Direction = ParameterDirection.Output;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@patente";
            parametros[1].SqlDbType = SqlDbType.NVarChar;
            parametros[1].Size = 10;
            parametros[1].Value = patente;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@marca";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 255;
            parametros[2].Value = marca;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@modelo";
            parametros[3].SqlDbType = SqlDbType.NVarChar;
            parametros[3].Size = 255;
            parametros[3].Value = modelo;

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@turno";
            parametros[4].SqlDbType = SqlDbType.Int;
            parametros[4].Value = turno;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@chofer";
            parametros[5].SqlDbType = SqlDbType.Int;
            parametros[5].Value = chofer;

            string resultado = Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAgregarAuto");
            string respuesta = string.Empty;
            switch (resultado)
            {
                case "-1":
                    respuesta = "Se capturo un error al intentar agregar un auto";
                    break;
                case "0":
                    respuesta = "No se logro agregar un auto";
                    break;
                case "1":
                    respuesta = "Se agrego un auto";
                    break;
            }
            return respuesta;
        }

        public object ObtenerTurnos()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Turnos");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerTurnos");

            return DtResultado;
        }


        public object ObtenerChoferes()
        {
            Conexion Conexion = new Conexion();

            DataTable DtResultado = new DataTable("Choferes");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerChoferes");

            return DtResultado;
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
        #endregion


    }
}
