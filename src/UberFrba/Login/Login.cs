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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            string msj = CapaInterfaz.IUsuario.Login(txtUsername.Text, usuario);

            if (!msj.Equals(string.Empty)) // si el mensaje es vacio es porque se logro todo okay
            {
                CapaInterfaz.Decoracion.mostrarInfo(msj);
                return;
            }

            if (CapaInterfaz.IUsuario.esPassCorrecta(txtPass.Text, usuario))
            {
                CapaInterfaz.IUsuario.formatearIntentos(usuario);
                SeleccionarRol siguienteVentana = new SeleccionarRol(usuario); // creo una instancia pasando por parametro el idUsuario
                Program.contexto.MainForm = siguienteVentana; // le cambio el contexto al programa principal para que ahora el formulario principal sea la nueva ventana
                siguienteVentana.Show();
                this.Close();
            }
            else
            {
                if (CapaInterfaz.IUsuario.tieneIntentosDisponibles(usuario))
                {
                    CapaInterfaz.IUsuario.aumentarIntentos(usuario);
                    CapaInterfaz.Decoracion.mostrarInfo("La contraseña ingresada es incorrecta");
                }
            }
        }
    }
}
