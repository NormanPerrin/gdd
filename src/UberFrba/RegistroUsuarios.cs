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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
            CapaInterfaz.IRol.CargarRoles(cbxRoles);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login siguienteVentana = new Login();
            siguienteVentana.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string resultado = CapaNegocio.NUsuario.Insertar(this.txtUsername.Text, this.txtPass.Text);
            mostrarError(resultado);
        }

        private void mostrarError(string error)
        {
            MessageBox.Show(error, "UBER FRBA", MessageBoxButtons.OK);

            txtUsername.Text = "";
            txtPass.Text = "";
        }
    }
}
