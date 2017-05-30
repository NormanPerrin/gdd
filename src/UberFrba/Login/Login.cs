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

            private static IUsuario _Usuario;

        #endregion

        #region Constructor

            public Login()
            {
                InitializeComponent();
                CapaInterfaz.Decoracion.Reorganizar(this);
                Usuario = new IUsuario();
            }

        #endregion

        #region Acciones/Eventos

            private void btnIngresar_Click(object sender, EventArgs e)
            {
                CapaInterfaz.IUsuario.Login(txtUsername.Text, Usuario);

                if (Usuario != null)
                {
                    if (CapaInterfaz.IUsuario.esPassCorrecta(txtPass.Text, Usuario))
                    {
                        CapaInterfaz.IUsuario.formatearIntentos(Usuario);
                        SeleccionarRol siguienteVentana = new SeleccionarRol(Usuario.IdUsuario, Usuario.Username); // creo una instancia pasando por parametro el idUsuario
                        Program.contexto.MainForm = siguienteVentana; // le cambio el contexto al programa principal para que ahora el formulario principal sea la nueva ventana
                        siguienteVentana.Show();
                        Close();
                    }
                    else
                    {
                        if (CapaInterfaz.IUsuario.tieneIntentosDisponibles(Usuario))
                        {
                            CapaInterfaz.IUsuario.aumentarIntentos(Usuario);
                            CapaInterfaz.Decoracion.mostrarInfo("La contraseña ingresada es incorrecta");
                        }
                        else
                            CapaInterfaz.Decoracion.mostrarInfo("El usuario esta bloqueado por exceso de intentos fallidos");
                    }
                }
                else
                    CapaInterfaz.Decoracion.mostrarInfo("El usuario no existe");
            }

            private void btnCerrar_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        #endregion
        
        #region Getters/Setters 

            public static IUsuario Usuario
            {
                get { return Login._Usuario; }
                set { Login._Usuario = value; }
            }

        #endregion
    }
}
