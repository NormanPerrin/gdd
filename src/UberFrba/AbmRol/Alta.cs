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
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty)
            {
                if(CapaInterfaz.IRol.ChequearItemSeleccionado(this.tablaFuncionalidades))
                {
                    string respuesta = CapaInterfaz.IRol.AgregarRol(this.txtNombre.Text, this.tablaFuncionalidades);
                    CapaInterfaz.Decoracion.mostrarInfo(respuesta);
                    this.Close();
                }
                else
                    CapaInterfaz.Decoracion.mostrarInfo("Debe seleccionar al menos una funcionalidad");
            }
            else
                CapaInterfaz.Decoracion.mostrarInfo("Debe ingresar un nombre/detalle para el rol");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = String.Empty;
            foreach (DataGridViewRow row in tablaFuncionalidades.Rows)
            {
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Elegir"] as DataGridViewCheckBoxCell;
                cellSelecion.Value = false;
            }
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            CapaInterfaz.IRol.CargarFuncionalidades(this.tablaFuncionalidades);
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
    }
}
