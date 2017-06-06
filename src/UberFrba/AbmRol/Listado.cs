using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmRol
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
            CapaInterfaz.IRol.CargarRoles(this.tablaRoles);
            CapaInterfaz.IRol.OcultarColumnasRoles(this.tablaRoles);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaInterfaz.IRol.BuscarRolPorNombre(this.tablaRoles, this.txRolNombre.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txRolNombre.Text = String.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablaRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txRolNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.txRolNombre.Text == string.Empty)
                CapaInterfaz.IRol.CargarRoles(this.tablaRoles);
            else
                CapaInterfaz.IRol.BuscarRolPorNombre(this.tablaRoles, this.txRolNombre.Text);
        }

        private void tablaRoles_DoubleClick(object sender, EventArgs e)
        {
            int idRol = Convert.ToInt32(this.tablaRoles.CurrentRow.Cells[0].Value);
            string nombre = Convert.ToString(this.tablaRoles.CurrentRow.Cells[1].Value);
            string estado = Convert.ToString(this.tablaRoles.CurrentRow.Cells[2].Value);
            Edicion ventana = new Edicion(idRol, nombre, estado);
            ventana.ShowDialog(this);
        }
    }
}
