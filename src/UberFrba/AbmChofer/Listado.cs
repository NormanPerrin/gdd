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
            chofer.Nombre = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["nombre"].Value);
            chofer.Apellido = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["apellido"].Value);
            chofer.Dni = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["dni"].Value);
            chofer.FechaNac = Convert.ToDateTime(this.tablaChoferes.CurrentRow.Cells["fecha_nac"].Value);
            chofer.Telefono = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["telefono"].Value);
            chofer.Mail = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["mail"].Value);
            chofer.Direccion = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["direccion"].Value);
            
            if (this.tablaChoferes.CurrentRow.Cells["localidad"].Value == null)
                chofer.Localidad = string.Empty;
            else
                chofer.Localidad = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["localidad"].Value);

            if (this.tablaChoferes.CurrentRow.Cells["nro_piso"].Value == null)
                chofer.NroPiso = -1;
            else
                chofer.NroPiso = Convert.ToInt32(this.tablaChoferes.CurrentRow.Cells["nro_piso"].Value);

            if (this.tablaChoferes.CurrentRow.Cells["depto"].Value == null)
                chofer.Depto = "";
            else
                chofer.Depto = Convert.ToString(this.tablaChoferes.CurrentRow.Cells["depto"].Value);

            Edicion ventana = new Edicion(chofer);
            ventana.ShowDialog(this);
        }
    }
}
