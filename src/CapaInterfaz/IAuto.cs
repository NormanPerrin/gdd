﻿using System;
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

        public static string alta(int marca, int modelo, string patente, int turno, int chofer)
        {

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

        public static void CargarAutoHabilitado(TextBox lbl, String chofer, String turno)
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

        private static bool seleccionoChofer(int chofer)
        {
            if (chofer == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool seleccionoMarcaOModelo(int marca)
        {
            if (marca == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool patenteVacia(string patente)
        {
            if(string.IsNullOrWhiteSpace(patente))
            {
                return true;
            }else{
                return false;
            }
        }

        private static bool not(bool b)
        {
            if (b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static void BuscarAuto(DataGridView tablaAutos, int marca, int modelo, string patente, int chofer)
        {
            //chequeo datos
            if (patenteVacia(patente)&&not(seleccionoChofer(chofer))&&not(seleccionoMarcaOModelo(marca)))
            {
                CapaInterfaz.Decoracion.mostrarInfo("seleccione por lo menos un campo");
                tablaAutos.DataSource = null;
            }
            else if (patenteVacia(patente) && not(seleccionoChofer(chofer)) && seleccionoMarcaOModelo(marca))
            {
                tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(marca, modelo);
            }
            else if (patenteVacia(patente) && not(seleccionoMarcaOModelo(marca)) && seleccionoChofer(chofer))
            {
                tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(chofer);
            }
            else if (not(seleccionoChofer(chofer)) && not(seleccionoMarcaOModelo(marca)) && not(patenteVacia(patente)))
            {
                tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(patente);
            }
            else if (patenteVacia(patente) && seleccionoChofer(chofer) && seleccionoMarcaOModelo(marca))
            {
                tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(marca, modelo, chofer);
            }
            else if (not(seleccionoChofer(chofer)) && not(patenteVacia(patente)) && seleccionoMarcaOModelo(marca))
            {
                tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(marca, modelo, patente);
            }
            else if (not(seleccionoMarcaOModelo(marca)) && not(patenteVacia(patente)) && seleccionoChofer(chofer))
            {
                tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(patente, chofer);
            }
            else if (not(patenteVacia(patente)) && seleccionoChofer(chofer) && seleccionoMarcaOModelo(marca))
            {
                tablaAutos.DataSource = CapaNegocio.NAuto.ObtenerAutos(marca, modelo, patente, chofer);
            }
        }

        public static string baja(int idAuto)
        {
            string respuesta = CapaNegocio.NAuto.baja(idAuto);
            return respuesta;
        }

        public static string modificacion(int idAuto, string licencia, string rodado)
        {
            string respuesta = CapaNegocio.NAuto.modificacion(idAuto, licencia, rodado);
            return respuesta;
        }

        public static void CargarMarca(System.Windows.Forms.DataGridView tablaMarca)
        {
            tablaMarca.DataSource = CapaNegocio.NAuto.ObtenerMarcas();
        }


        public static string alta(int idAuto)
        {
            string respuesta = CapaNegocio.NAuto.alta(idAuto);
            return respuesta;
        }

        public static string modificarChofer(int auto, int chofer, int nuevoChofer, int turno)
        {
            string respuesta = CapaNegocio.NAuto.modificarChofer(auto, chofer, nuevoChofer, turno);
            return respuesta;
        }

        public static string modificarTurno(int auto, int chofer, int turno, int nuevoTurno)
        {
            string respuesta = CapaNegocio.NAuto.modificarTurno(auto, chofer, turno, nuevoTurno);
            return respuesta;
        }

        public static string agregarTurno(int auto, int chofer, int turno)
        {
            string respuesta = CapaNegocio.NAuto.agregarrChofer(auto, chofer,  turno);
            return respuesta;
        }

        public static string quitarTurno(int auto, int chofer, int turno)
        {
            string respuesta = CapaNegocio.NAuto.quitarChofer(auto, chofer,  turno);
            return respuesta;
        }

        public static void CargarMarca2(DataGridView tablaMarca)
        {
            tablaMarca.DataSource = CapaNegocio.NAuto.ObtenerMarcas2();
        }

        public static void CargarChoferes2(DataGridView tablaChofer)
        {
            tablaChofer.DataSource = CapaNegocio.NAuto.ObtenerChoferes2();
        }
    }
}