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
    public partial class Listado : Form
    {

        int marca;
        int modelo;
        int chofer;
        int idAuto;
        string licencia;
        string rodado;

        public Listado()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            //uso metodos que estan en auto
            CapaInterfaz.IAuto.CargarChoferes(this.tablaChofer);
            CapaInterfaz.IAuto.CargarMarca(this.tablaMarca);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca, 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaInterfaz.IAuto.BuscarAuto(this.tablaAutos, marca, modelo, txtPatente.Text, chofer);
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

        private void tablaChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
                chofer = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            idAuto = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[0].Value);
            licencia = Convert.ToString(this.tablaAutos.CurrentRow.Cells[5].Value);
            rodado = Convert.ToString(this.tablaAutos.CurrentRow.Cells[6].Value);

            Edicion ventana = new Edicion(idAuto, licencia, rodado);
            ventana.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
