using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public class IAuto
    {
        #region Atributos

        private int _idAuto;
        private static Dictionary<String, String> auto = new Dictionary<String, String> {};

        #endregion

        public static string alta(int marca, int modelo, string patente, DataGridView tablaTurno, int chofer)
        {
            int turno = 0;

            foreach (DataGridViewRow row in tablaTurno.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    turno = System.Convert.ToInt32(row.Cells[1].Value);
                }
            }

            string respuesta = CapaNegocio.NAuto.alta(marca, modelo, patente, turno, chofer);
            return respuesta;
        }

        public static bool ChequearItemSeleccionado(DataGridView tabla)
        {
            bool resultado;
            resultado = false;
            foreach (DataGridViewRow row in tabla.Rows)
            {
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Elegir"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSelecion.Value))
                    resultado = true;
            }
            return resultado;
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

        public int IdAuto
        {
            get { return _idAuto; }
            set { _idAuto = value; }
        }

        public static void OcultarColumnas(DataGridView dataGridView, int nroColumn)
        {
            dataGridView.Columns[nroColumn].Visible = false; // oculto la columna del id
        }


        public static void BuscarAuto(DataGridView tablaAutos, int marca, int modelo, string patente, int chofer)
        {
            tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(marca,modelo,patente,chofer);
        }

        public static string baja(int idAuto)
        {
            string respuesta = CapaNegocio.NAuto.baja(idAuto);
            return respuesta;
        }

        public static string modificacion(int idAuto, string licencia, string rodado, string nombre)
        {
            string respuesta = CapaNegocio.NAuto.modificacion(idAuto, licencia, rodado, nombre );
            return respuesta;
        }

        public static void CargarMarca(System.Windows.Forms.DataGridView tablaMarca)
        {
            tablaMarca.DataSource = CapaNegocio.NAuto.ObtenerMarcas();
        }


    }
}