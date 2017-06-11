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
        private string _marca;
        private string _modelo;
        private string _patente;
        private int _turno;
        private int _chofer;
        private int _habilitado;
        private static Dictionary<String, String> auto = new Dictionary<String, String> {};

        #endregion

        #region Metodos/Atributos

        public static string alta(string marca, string modelo, string patente, int turno, int chofer)
        {
            string respuesta = CapaNegocio.NAuto.alta(marca, modelo, patente, turno, chofer);

            return respuesta;
        }
        
        public static void CargarTurnos(System.Windows.Forms.DataGridView tablaTurno)
        {
            tablaTurno.DataSource = CapaNegocio.NAuto.ObtenerTurnos();
        }

        public static void CargarChoferes(System.Windows.Forms.DataGridView tablaChofer)
        {
            tablaChofer.DataSource = CapaNegocio.NAuto.ObtenerChoferes();
        }

        public static void CargarAutoHabilitado(System.Windows.Forms.Label lbl, String chofer, String turno)
        {
            DataTable Datos = CapaNegocio.NAuto.ObtenerAutoHabilitado(chofer, turno);
            auto.Clear();
            if (Datos.Rows.Count != 0)
            {
                lbl.Text = Datos.Rows[0][1].ToString() + ' ' + Datos.Rows[0][2].ToString();
                auto.Add(Datos.Rows[0][0].ToString(), lbl.Text);
            }
        }

        public static String getIdAutoActual(String autoNombre)
        {
            return auto.FirstOrDefault(x => x.Value == autoNombre).Key;
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

