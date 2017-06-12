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
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            CapaInterfaz.IChofer.CargarChoferes(this.tablaChoferes);
            CapaInterfaz.IChofer.OcultarColumnasChoferes(this.tablaChoferes);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtChoferNombre.Text = String.Empty;
            this.txtChoferApellido.Text = String.Empty;
            this.txtChoferDni.Text = String.Empty;
            CapaInterfaz.IChofer.CargarChoferes(this.tablaChoferes);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaInterfaz.IChofer.CargarChoferEspecifico(this.tablaChoferes, this.txtChoferNombre.Text, this.txtChoferApellido.Text, this.txtChoferDni.Text);
        }

        private void tablaChoferes_DoubleClick(object sender, EventArgs e)
        {
            Chofer chofer = new Chofer();
            chofer.limpiarAtributos(chofer);

            // datos de interes para la interfaz
            chofer.Nombre = this.tablaChoferes.CurrentRow.Cells["nombre"].Value.ToString();
            chofer.Apellido = this.tablaChoferes.CurrentRow.Cells["apellido"].Value.ToString();
            chofer.DniString = this.tablaChoferes.CurrentRow.Cells["dni"].Value.ToString(); // ojo es un int en realidad
            chofer.FechaNacString = this.tablaChoferes.CurrentRow.Cells["fecha_nac"].Value.ToString(); // ojo es un datetime en realidad
            chofer.TelefonoString = this.tablaChoferes.CurrentRow.Cells["telefono"].Value.ToString(); // ojo es un int en realidad
            chofer.Mail = this.tablaChoferes.CurrentRow.Cells["mail"].Value.ToString();
            chofer.Direccion = this.tablaChoferes.CurrentRow.Cells["direccion"].Value.ToString();
            chofer.Localidad = this.tablaChoferes.CurrentRow.Cells["localidad"].Value.ToString();
            chofer.NroPisoString = this.tablaChoferes.CurrentRow.Cells["nro_piso"].Value.ToString(); // ojo es un int en realidad
            chofer.Depto = this.tablaChoferes.CurrentRow.Cells["depto"].Value.ToString();
            chofer.Estado = this.tablaChoferes.CurrentRow.Cells["estado"].Value.ToString();

            // otros datos de interes
            chofer.Id = Convert.ToInt32(this.tablaChoferes.CurrentRow.Cells["id_chofer"].Value);
            chofer.Habilitado = Convert.ToInt32(this.tablaChoferes.CurrentRow.Cells["habilitado"].Value);
            chofer.IdUsuario = Convert.ToInt32(this.tablaChoferes.CurrentRow.Cells["id_usuario"].Value);

            Edicion ventana = new Edicion(chofer);
            ventana.ShowDialog(this);
        }

    }
}
