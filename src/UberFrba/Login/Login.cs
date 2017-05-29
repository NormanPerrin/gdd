using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaInterfaz;

namespace UberFrba
{
    public partial class Login : Form
    {
        #region Atributos

            private static IUsuario Usuario = null;
            private static Login _Instancia;

        #endregion

        #region Constructor

            public Login()
            {
                InitializeComponent();
                Usuario = new IUsuario();
                formatearAtributos();
                StartPosition = FormStartPosition.CenterScreen;
                AutoSizeMode = AutoSizeMode.GrowAndShrink;
                MaximizeBox = false;
            }

        #endregion

        #region Acciones

            private void btnIngresar_Click(object sender, EventArgs e)
            {
                CapaInterfaz.IUsuario.Login(txtUsername.Text, Usuario);

                if (Usuario != null)
                {
                    if (CapaInterfaz.IUsuario.esPassCorrecta(txtPass.Text, Usuario))
                    {
                        CapaInterfaz.IUsuario.formatearIntentos(Usuario);
                        SeleccionarRol siguienteVentana = SeleccionarRol.ObtenerInstancia(Usuario.IdUsuario);
                        siguienteVentana.Show(); // muestro la seleccion de rol
                        this.Hide(); // escondo el login
                        formatearAtributos();
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
                formatearAtributos();
            }

        #endregion

        #region Metodos y funciones auxiliares

            public static Login ObtenerInstancia()
            {
                if (_Instancia == null)
                {
                    _Instancia = new Login();
                }
                return _Instancia;
            }

            private void formatearAtributos()
            {
                Usuario.IdUsuario = (-1);
                Usuario.Username = string.Empty;
                Usuario.Pass = string.Empty;
                Usuario.Intentos = (-1);
                txtUsername.Text = string.Empty;
                txtPass.Text = string.Empty;
            }

            private void mostrarError(string error)
            {
                MessageBox.Show(error, "UBER FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = string.Empty;
                txtPass.Text = string.Empty;
            }

        #endregion
    }
}
