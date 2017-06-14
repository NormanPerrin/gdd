using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace UberFrba
{
    public partial class SeleccionarRol : Form
    {
        private Usuario usuario;

        public SeleccionarRol(Usuario usuarioRecibido)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            usuario = usuarioRecibido;
        }

        private void SeleccionarRol_Load(object sender, EventArgs e)
        {
            titulo.Text = "Usuario actual: " + usuario.Username;
            CapaInterfaz.IRol.CargarRoles(this.cbxRoles, usuario.Id);
        }

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
    }
}
