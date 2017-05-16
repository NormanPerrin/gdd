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
    public partial class SeleccionarRol : Form
    {
        #region Atributos

            private int _IdUsuario;
            private int _IdPersona;
            private static SeleccionarRol _Instancia;
        
        #endregion

            #region Constructor

            public SeleccionarRol()
            {
                InitializeComponent();
                formatearAtributos();
            }

            public SeleccionarRol(int idUsuario, int idPersona)
            {
                InitializeComponent();
                formatearAtributos();
                this.IdUsuario = idUsuario;
                this.IdPersona = idPersona;
                CapaInterfaz.IRol.CargarRoles(cbxRoles, idUsuario);
            }

        #endregion

        #region Acciones

            private void btnAcceder_Click(object sender, EventArgs e)
            {
                Funcionalidades siguienteVentana = Funcionalidades.ObtenerInstancia(cbxRoles.Text);
                siguienteVentana.Show();
                this.Hide();
                formatearAtributos();
            }

            private void btnCerrarSesion_Click(object sender, EventArgs e)
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
                IdUsuario = (-1);
                IdPersona = (-1);
                cbxRoles.Items.Clear();
            }

            public static SeleccionarRol ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new SeleccionarRol();
                }
                return Instancia;
            }

            public static SeleccionarRol ObtenerInstancia(int idUsuario, int idPersona)
            {
                if (Instancia == null)
                {
                    Instancia = new SeleccionarRol(idUsuario, idPersona);
                }
                else
                {
                    Instancia.formatearAtributos();
                    Instancia.IdUsuario = idUsuario;
                    Instancia.IdPersona = idPersona;
                    CapaInterfaz.IRol.CargarRoles(Instancia.cbxRoles, idUsuario);
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public int IdUsuario
            {
                get { return _IdUsuario; }
                set { _IdUsuario = value; }
            }

            public int IdPersona
            {
                get { return _IdPersona; }
                set { _IdPersona = value; }
            }

            public static SeleccionarRol Instancia
            {
                get { return SeleccionarRol._Instancia; }
                set { SeleccionarRol._Instancia = value; }
            }

        #endregion
    }
}
