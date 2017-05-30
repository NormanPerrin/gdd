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
        
        #endregion
        
        #region Constructor

            public SeleccionarRol(int idUsuario, string username)
            {
                InitializeComponent();
                this.IdUsuario = idUsuario;
                titulo.Text = "Usuario actual: " + username;
                CapaInterfaz.Decoracion.Reorganizar(this);
            }

        #endregion

        #region Acciones

            private void btnAcceder_Click(object sender, EventArgs e)
            {
                string rolNombre = cbxRoles.Text;
                Funcionalidades siguienteVentana = new Funcionalidades(rolNombre);
                Program.contexto.MainForm = siguienteVentana;
                siguienteVentana.Show();
                Close();
            }

            private void btnCerrarSesion_Click(object sender, EventArgs e)
            {
                Login siguienteVentana = new Login();
                Program.contexto.MainForm = siguienteVentana;
                siguienteVentana.Show();
                Close();
            }

            private void SeleccionarRol_Load(object sender, EventArgs e)
            {
                CapaInterfaz.IRol.CargarRoles(this.cbxRoles, this.IdUsuario);
            }

        #endregion

        #region Getters/Setters

            public int IdUsuario
            {
                get { return _IdUsuario; }
                set { _IdUsuario = value; }
            }

        #endregion
    }
}
