using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public partial class Funcionalidades : Form
    {
        #region Atributos

            private string _NombreRol;
            private static Funcionalidades _Instancia;

        #endregion

        #region Constructor

            public Funcionalidades()
            {
                InitializeComponent();
                formatearAtributos();
            }

            public Funcionalidades(string nombreRol)
            {
                InitializeComponent();
                formatearAtributos();
                this.NombreRol = nombreRol;
                CapaInterfaz.IRol.CargarFuncionalidades(cbxFuncionalidades, nombreRol);
            }

        #endregion

        #region Acciones

            private void btnAcceder_Click(object sender, EventArgs e)
            {
                if (cbxFuncionalidades.Text == "ABM Rol") // despues veo como mejoro este codigo porque no me gusta que sea tan asi
                {
                    AbmRol.AbmRol siguienteVentana = AbmRol.AbmRol.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "ABM cliente")
                {
                    AbmCliente siguienteVentana = AbmCliente.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "ABM automovil")
                {
                    AbmAuto siguienteVentana = AbmAuto.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "ABM turno")
                {
                    AbmTurno siguienteVentana = AbmTurno.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "ABM chofer")
                {
                    AbmChofer siguienteVentana = AbmChofer.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "Registrar viaje")
                {
                    RegistroViajes siguienteVentana = RegistroViajes.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "Rendir viaje")
                {
                    RendicionViajes siguienteVentana = RendicionViajes.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "Facturar cliente")
                {
                    Facturacion siguienteVentana = Facturacion.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
                else if (cbxFuncionalidades.Text == "Listado Estadistico")
                {
                    ListadoEstadistico siguienteVentana = ListadoEstadistico.ObtenerInstancia();
                    siguienteVentana.Show();
                    this.Hide();
                    formatearAtributos();
                }
            }

            private void btnCambiarRol_Click(object sender, EventArgs e)
            {
                Login siguienteVentana = Login.ObtenerInstancia();
                siguienteVentana.Show();
                this.Hide();
                formatearAtributos();
            }

        #endregion

        #region Metodos y funciones auxiliares

            private void formatearAtributos()
            {
                NombreRol = string.Empty;
                cbxFuncionalidades.Items.Clear();
            }

            public static Funcionalidades ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new Funcionalidades();
                }
                return Instancia;
            }

            public static Funcionalidades ObtenerInstancia(string nombreRol)
            {
                if (Instancia == null)
                {
                    Instancia = new Funcionalidades(nombreRol);
                }
                else
                {
                    Instancia.formatearAtributos();
                    Instancia.NombreRol = nombreRol;
                    CapaInterfaz.IRol.CargarFuncionalidades(Instancia.cbxFuncionalidades, nombreRol);
                }
                return _Instancia;
            }

        #endregion

        #region Getters/Setters

            public string NombreRol
            {
                get { return _NombreRol; }
                set { _NombreRol = value; }
            }

            public static Funcionalidades Instancia
            {
                get { return Funcionalidades._Instancia; }
                set { Funcionalidades._Instancia = value; }
            }

        #endregion
    }
}
