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

namespace UberFrba.AbmChofer
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.calendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Chofer ChoferNuevo = new Chofer();
            ChoferNuevo.limpiarAtributos(ChoferNuevo);

            ChoferNuevo.Nombre = txtNombre.Text;
            ChoferNuevo.Apellido = txtApellido.Text;
            ChoferNuevo.DniString = txtDni.Text;
            ChoferNuevo.FechaNacString = txtFechaNac.Text;
            ChoferNuevo.TelefonoString = txtTelefono.Text;
            ChoferNuevo.Mail = txtMail.Text;
            ChoferNuevo.Direccion = txtDireccion.Text;
            ChoferNuevo.Localidad = txtLocalidad.Text;
            ChoferNuevo.NroPisoString = txtPiso.Text;
            ChoferNuevo.Depto = txtDepto.Text;

            string msj = CapaInterfaz.IChofer.crearChofer(ChoferNuevo);
            CapaInterfaz.Decoracion.mostrarInfo(msj);
            
            //this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtFechaNac.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtDepto.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            this.calendario.Show();
            this.calendario.BringToFront();
            this.calendario.Select();  
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFechaNac.Text = calendario.SelectionRange.Start.ToShortDateString();
            calendario.Hide();
        }

        private void calendario_Leave(object sender, EventArgs e)
        {
            this.calendario.Hide();
        }

        private void caracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
