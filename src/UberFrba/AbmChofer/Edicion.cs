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
        public Chofer Chofer
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
            txtFechaNacVieja.Text = Convert.ToString(choferViejo.FechaNac);
            txtTelefonoViejo.Text = choferViejo.TelefonoString;
            txtMailViejo.Text = choferViejo.Mail;
            txtDireccionVieja.Text = choferViejo.Direccion;
            txtLocalidadVieja.Text = choferViejo.Localidad;
            txtNroPisoViejo.Text = Convert.ToString(choferViejo.NroPiso);
            txtDeptoViejo.Text = choferViejo.Depto;
            txtEstado.Text = choferViejo.Estado;
            cbxEstado.Text = choferViejo.Estado;

            Chofer = new Chofer();
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
            TxtNroPisoNuevo.Text = string.Empty;
            txtDeptoNuevo.Text = string.Empty;
            cbxEstado.Text = txtEstado.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Chofer.Nombre = this.txtNombreNuevo.Text;
            this.Chofer.Apellido = this.txtApellidoNuevo.Text;
            this.Chofer.DniString = this.txtDniNuevo.Text;
            this.Chofer.FechaNacString = this.txtFechaNacNueva.Text;
            this.Chofer.TelefonoString = this.txtTelefonoNuevo.Text;
            this.Chofer.Mail = this.txtMailNuevo.Text;
            this.Chofer.Direccion = this.txtDireccionNueva.Text;
            this.Chofer.Localidad = this.txtLocalidadNueva.Text;
            this.Chofer.NroPisoString = this.TxtNroPisoNuevo.Text;
            this.Chofer.Depto = this.txtDeptoNuevo.Text;
            string mensaje = CapaInterfaz.IChofer.actualizarChofer(this.Chofer, this.ChoferViejo);
            CapaInterfaz.Decoracion.mostrarInfo(mensaje);
        }
    }
}
