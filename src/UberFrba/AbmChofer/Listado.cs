using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //int idRol = Convert.ToInt32(this.tablaRoles.CurrentRow.Cells[0].Value);
            //string nombre = Convert.ToString(this.tablaRoles.CurrentRow.Cells[1].Value);
            //string estado = Convert.ToString(this.tablaRoles.CurrentRow.Cells[2].Value);
            //Edicion ventana = new Edicion();
            //ventana.ShowDialog(this);
        }
    }
}
