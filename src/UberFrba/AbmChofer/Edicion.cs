using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaInterfaz.Objetos;

namespace UberFrba.AbmChofer
{
    public partial class Edicion : Form
    {
        public Edicion(Chofer chofer)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);

            txtNombreViejo.Text = chofer.Nombre;
            txtApellidoViejo.Text = chofer.Apellido;
            txtDniViejo.Text = chofer.Dni;
            txtFechaNacVieja.Text = Convert.ToString(chofer.FechaNac);
            txtTelefonoViejo.Text = chofer.Telefono;
            txtMailViejo.Text = chofer.Mail;
            txtDireccionVieja.Text = chofer.Direccion;
            txtLocalidadVieja.Text = chofer.Localidad;
            txtNroPisoViejo.Text = Convert.ToString(chofer.NroPiso);
            txtDeptoViejo.Text = chofer.Depto;
        }

        private void Edicion_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //this.txtRolNombreNuevo.Text = string.Empty;
            //cbxRolEstadoNuevo.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
