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

        public Listado()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void Listado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int marca = Decimal.ToInt32(nroMarca.Value);
            int modelo = Decimal.ToInt32(nroModelo.Value);
            int chofer = Decimal.ToInt32(nroChofer.Value);
            CapaInterfaz.IAuto.BuscarAuto(this.tablaAutos, marca, modelo, txtPatente.Text, chofer);
        }

        private void tablaAutos_DoubleClick(object sender, EventArgs e)
        {
            int idAuto = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[0].Value);
            int marca = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[1].Value);
            int modelo = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[2].Value);
            string patente = Convert.ToString(this.tablaAutos.CurrentRow.Cells[3].Value);
            int chofer = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[4].Value);
            string licencia = Convert.ToString(this.tablaAutos.CurrentRow.Cells[5].Value);
            string rodado = Convert.ToString(this.tablaAutos.CurrentRow.Cells[6].Value);
            string nombre = Convert.ToString(this.tablaAutos.CurrentRow.Cells[7].Value);

            Edicion ventana = new Edicion(idAuto, licencia, rodado, nombre);
            ventana.ShowDialog(this);
        }
    }
}
