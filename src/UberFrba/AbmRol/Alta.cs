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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.IRol.AgregarRol(this.txtNombre.Text, this.tablaFuncionalidades);
            mostrarError(respuesta);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void Alta_Load(object sender, EventArgs e)
        {
            this.tablaFuncionalidades.DataSource = CapaInterfaz.IRol.CargarFuncionalidades();
            CapaInterfaz.IRol.OcultarColumnas(this.tablaFuncionalidades);
        }

        private void tablaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaFuncionalidades.Columns["Elegir"].Index)
            {
                DataGridViewCheckBoxCell chkElegir = (DataGridViewCheckBoxCell) tablaFuncionalidades.Rows[e.RowIndex].Cells["Elegir"];
                chkElegir.Value = !Convert.ToBoolean(chkElegir.Value);
            }
        }

        private void mostrarError(string error)
        {
            MessageBox.Show(error, "UBER FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
