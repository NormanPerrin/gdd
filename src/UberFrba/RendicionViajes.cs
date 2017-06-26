using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public partial class RendicionViajes : Form
    {
        int idChofer;
        int importe;

        public RendicionViajes()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);

            //uso metodos ya hechos en otra clase
            CapaInterfaz.Decoracion.Reorganizar(this);
            CapaInterfaz.IAuto.CargarTurnos(this.tablaTurno);
            CapaInterfaz.IAuto.CargarChoferes(this.tablaChofer);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaTurno, 1);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer, 0);
        }

        private void tablaTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaTurno.Columns["Elegir"].Index)
            {
                DataGridViewCheckBoxCell chkElegir = (DataGridViewCheckBoxCell)tablaTurno.Rows[e.RowIndex].Cells["Elegir"];
                chkElegir.Value = !Convert.ToBoolean(chkElegir.Value);
            }
        }

        private void tablaChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
                idChofer = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CapaInterfaz.IAuto.ChequearItemSeleccionado(this.tablaTurno))
            {
                CapaInterfaz.IRendicion.viajes(this.tablaViaje, this.fecha.Value, this.tablaTurno, idChofer);

                importe = CapaInterfaz.IRendicion.calcularImporte(this.tablaViaje);

                this.txtImporte.Text = System.Convert.ToString(importe);
            }
            else
                CapaInterfaz.Decoracion.mostrarInfo("Debe seleccionar al menos un turno");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rendir

            CapaInterfaz.IRendicion.rendir(this.tablaViaje, this.fecha.Value);
            CapaInterfaz.Decoracion.mostrarInfo("Transaccion finalizada");
            //this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
