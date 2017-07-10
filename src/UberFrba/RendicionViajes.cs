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
        int turno;
        DateTime fechaBuscada;

        public RendicionViajes()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);

            
        }

        private void Edicion_Load(object sender, EventArgs e)
        {
            //uso metodos ya hechos en otra clase
            CapaInterfaz.Decoracion.Reorganizar(this);
            CapaInterfaz.IAuto.CargarTurnos(this.tablaTurno);
            CapaInterfaz.IAuto.CargarChoferes(this.tablaChofer);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaTurno, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer, 0);
            this.fecha.Value = Properties.Settings.Default.FechaSistema;
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
                //System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
                //idChofer = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            idChofer = 0;
            turno = 0;
            if (this.tablaChofer.CurrentRow != null)
            { idChofer = Convert.ToInt32(this.tablaChofer.CurrentRow.Cells[0].Value); }
            if (this.tablaTurno.CurrentRow != null)
            { turno = Convert.ToInt32(this.tablaTurno.CurrentRow.Cells[0].Value); }
            if (turno == 0 || idChofer == 0)
            {
                CapaInterfaz.Decoracion.mostrarInfo("Selecciona otra vez valores en todos los campos");
            }
            else
            {
                CapaInterfaz.IRendicion.viajes(this.tablaViaje, this.fecha.Value, turno, idChofer);

                this.fechaBuscada = this.fecha.Value;

                importe = CapaInterfaz.IRendicion.calcularImporte(this.tablaViaje);

                this.txtImporte.Text = System.Convert.ToString(importe);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rendir

            if (this.tablaViaje.RowCount == 0)
            {
                CapaInterfaz.Decoracion.mostrarInfo("No hay viajes por rendir");
            }
            else if (this.fecha.Value == Properties.Settings.Default.FechaSistema)
            {
                CapaInterfaz.Decoracion.mostrarInfo("No puede rendir los viajes del dia de la fecha");
            }
            else
            {
                CapaInterfaz.IRendicion.viajes2(this.tablaViaje, this.fecha.Value, idChofer);

                CapaInterfaz.IRendicion.rendir(this.tablaViaje, this.fechaBuscada);

                CapaInterfaz.IRendicion.viajes2(this.tablaViaje, this.fecha.Value, idChofer);

                CapaInterfaz.Decoracion.mostrarInfo("Se rindieron todos los turnos del chofer");

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablaTurno_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
               // turno = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            CapaInterfaz.IRendicion.viajes(this.tablaViajes2);
        }


    }
}
