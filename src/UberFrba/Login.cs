using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaInterfaz;

namespace UberFrba
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            NUsuario Usuario = new NUsuario();
            Usuario = CapaInterfaz.IUsuario.Login(txtUsername.Text, Usuario);

            if (Usuario != null)
            {
                if (CapaInterfaz.IUsuario.esPassCorrecta(txtPass.Text, Usuario))
                {
                    CapaInterfaz.IUsuario.formatearIntentos(Usuario);
                    SeleccionarRol siguienteVentana = new SeleccionarRol();
                    siguienteVentana.IdUsuario = Usuario.IdUsuario;
                    siguienteVentana.IdPersona = Usuario.IdPersona;
                    siguienteVentana.Show(); // muestro la seleccion de rol
                    this.Hide(); // escondo el login
                }
                else
                {
                    if (CapaInterfaz.IUsuario.tieneIntentosDisponibles(Usuario))
                    {
                        CapaInterfaz.IUsuario.aumentarIntentos(Usuario);
                        mostrarError("La contraseña ingresada es incorrecta");
                    }
                    else
                        mostrarError("El usuario esta bloqueado por exceso de intentos fallidos");
                }
            }
            else
                mostrarError("El usuario no existe");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            RegistroUsuarios siguienteVentana = new RegistroUsuarios();
            siguienteVentana.Show();
            this.Hide();
        }

        private void mostrarError(string error)
        {
            MessageBox.Show(error, "UBER FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtUsername.Text = "";
            txtPass.Text = "";
        }
    }
}
