using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmAuto
{
    public partial class Alta : Form
    {
        public int idChofer;
        public int modelo;
        public int turno;
        public int marca;

        public Alta()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
                //chequeo patente vacia
                if (string.IsNullOrWhiteSpace(TxtPatente.Text))
                {
                    CapaInterfaz.Decoracion.mostrarInfo("La patente no puede ser vacia");
                }
                else
                {
                    string respuesta = CapaInterfaz.IAuto.alta(marca, modelo, TxtPatente.Text, turno, idChofer);
                    CapaInterfaz.Decoracion.mostrarInfo(respuesta);
                    this.Close();
                }
          
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            CapaInterfaz.IAuto.CargarTurnos(this.tablaTurno);
            CapaInterfaz.IAuto.CargarChoferes(this.tablaChofer);
            CapaInterfaz.IAuto.CargarMarca(this.tablaMarca);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaTurno, 1);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca, 2);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numMarca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tablaTurno_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaTurno.Columns["Elegir"].Index)
            {
                DataGridViewCheckBoxCell chkElegir = (DataGridViewCheckBoxCell)tablaTurno.Rows[e.RowIndex].Cells["Elegir"];
                chkElegir.Value = !Convert.ToBoolean(chkElegir.Value);
            }
        }

        private void tablaChofer_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
                idChofer = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }

        private void tablaMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                System.Windows.Forms.DataGridViewCell selectedCell = this.tablaMarca[0, e.RowIndex];
                modelo = Convert.ToInt32(selectedCell.FormattedValue);

                System.Windows.Forms.DataGridViewCell selectedCell2 = this.tablaMarca[2, e.RowIndex];
                marca = Convert.ToInt32(selectedCell2.FormattedValue);
            }
        }

        private void tablaTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewCell selectedCell = this.tablaTurno[0, e.RowIndex];
            turno = Convert.ToInt32(selectedCell.FormattedValue);
        }

    }
}
