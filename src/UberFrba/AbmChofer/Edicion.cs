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
    public partial class Edicion : Form
    {
        private Chofer _choferViejo;
        private Chofer _chofer;

        public Chofer ChoferViejo
        {
            get { return _choferViejo; }
            set { _choferViejo = value; }
        }
        public Chofer ChoferNuevo
        {
            get { return _chofer; }
            set { _chofer = value; }
        }

        public Edicion(Chofer choferViejo)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);

            this.ChoferViejo = choferViejo;

            txtNombreViejo.Text = choferViejo.Nombre;
            txtApellidoViejo.Text = choferViejo.Apellido;
            txtDniViejo.Text = choferViejo.DniString;
            txtFechaNacVieja.Text = choferViejo.FechaNacString;
            txtTelefonoViejo.Text = choferViejo.TelefonoString;
            txtMailViejo.Text = choferViejo.Mail;
            txtDireccionVieja.Text = choferViejo.Direccion;
            txtLocalidadVieja.Text = choferViejo.Localidad;
            txtNroPisoViejo.Text = choferViejo.NroPisoString;
            txtDeptoViejo.Text = choferViejo.Depto;
            txtEstado.Text = choferViejo.Estado;
            cbxEstado.Text = choferViejo.Estado;

            txtNombreNuevo.Text = choferViejo.Nombre;
            txtApellidoNuevo.Text = choferViejo.Apellido;
            txtDniNuevo.Text = choferViejo.DniString;
            txtFechaNacNueva.Text = choferViejo.FechaNacString;
            txtTelefonoNuevo.Text = choferViejo.TelefonoString;
            txtMailNuevo.Text = choferViejo.Mail;
            txtDireccionNueva.Text = choferViejo.Direccion;
            txtLocalidadNueva.Text = choferViejo.Localidad;
            txtNroPisoNuevo.Text = choferViejo.NroPisoString;
            txtDeptoNuevo.Text = choferViejo.Depto;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreNuevo.Text = string.Empty;
            txtApellidoNuevo.Text = string.Empty;
            txtDniNuevo.Text = string.Empty;
            txtFechaNacNueva.Text = string.Empty;
            txtTelefonoNuevo.Text = string.Empty;
            txtMailNuevo.Text = string.Empty;
            txtDireccionNueva.Text = string.Empty;
            txtLocalidadNueva.Text = string.Empty;
            txtNroPisoNuevo.Text = string.Empty;
            txtDeptoNuevo.Text = string.Empty;
            cbxEstado.Text = txtEstado.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ChoferNuevo = new Chofer();
            ChoferNuevo.limpiarAtributos(ChoferNuevo);

            this.ChoferNuevo.Nombre = this.txtNombreNuevo.Text;
            this.ChoferNuevo.Apellido = this.txtApellidoNuevo.Text;
            this.ChoferNuevo.DniString = this.txtDniNuevo.Text;
            this.ChoferNuevo.FechaNacString = this.txtFechaNacNueva.Text;
            this.ChoferNuevo.TelefonoString = this.txtTelefonoNuevo.Text;
            this.ChoferNuevo.Mail = this.txtMailNuevo.Text;
            this.ChoferNuevo.Direccion = this.txtDireccionNueva.Text;
            this.ChoferNuevo.Localidad = this.txtLocalidadNueva.Text;
            this.ChoferNuevo.NroPisoString = this.txtNroPisoNuevo.Text;
            this.ChoferNuevo.Depto = this.txtDeptoNuevo.Text;
            this.ChoferNuevo.Estado = this.cbxEstado.Text;

            this.ChoferNuevo.Id = this.ChoferViejo.Id;
            this.ChoferNuevo.IdUsuario = this.ChoferViejo.IdUsuario;
            this.ChoferNuevo.Habilitado = this.ChoferViejo.Habilitado;

            string mensaje = CapaInterfaz.IChofer.actualizarChofer(this.ChoferNuevo, this.ChoferViejo);
            CapaInterfaz.Decoracion.mostrarInfo(mensaje);
        }
    }
}
