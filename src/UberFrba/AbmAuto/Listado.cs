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
        int habilitado;
        int idTurno;
        int idChofer;
        string licencia;
        string rodado;
        string nombreChofer;
        string apellidoChofer;
        string descTurno;

        public Listado()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }
        private void Alta_Load(object sender, EventArgs e)
        {
            //uso metodos que estan en auto
            CapaInterfaz.IAuto.CargarChoferes2(this.tablaChofer2);
            CapaInterfaz.IAuto.CargarMarca2(this.tablaMarca2);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer2, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca2, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca2, 2);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            chofer = 0;
            marca = 0;
            modelo = 0;
            if (this.tablaChofer2.CurrentRow != null)
            { chofer = Convert.ToInt32(this.tablaChofer2.CurrentRow.Cells[0].Value); }
            if (this.tablaMarca2.CurrentRow != null)
            { modelo = Convert.ToInt32(this.tablaMarca2.CurrentRow.Cells[0].Value); }
            if (this.tablaMarca2.CurrentRow != null)
            { marca = Convert.ToInt32(this.tablaMarca2.CurrentRow.Cells[2].Value); }

            CapaInterfaz.IAuto.BuscarAuto(this.tablaAutos, marca, modelo, txtPatente.Text, chofer);
            if (tablaAutos.DataSource != null)
            {
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 0);
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 2);
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 4);
                //idchofer
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 6);
                //idturno
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 9);
                //habilitado
                //CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 13);
            }
        }

        private void tablaMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               // System.Windows.Forms.DataGridViewCell selectedCell = this.tablaMarca[0, e.RowIndex];
               // modelo = Convert.ToInt32(selectedCell.FormattedValue);

               // System.Windows.Forms.DataGridViewCell selectedCell2 = this.tablaMarca[2, e.RowIndex];
               // marca = Convert.ToInt32(selectedCell2.FormattedValue);
            }
        }

        private void tablaChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               // System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
               // chofer = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.tablaAutos.DataSource == null)
            {
            }
            else if(this.tablaAutos.CurrentRow != null)
            {
                idAuto = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[0].Value);
                idChofer = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[6].Value);
                nombreChofer = Convert.ToString(this.tablaAutos.CurrentRow.Cells[7].Value);
                apellidoChofer = Convert.ToString(this.tablaAutos.CurrentRow.Cells[8].Value);
                idTurno = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[9].Value);
                descTurno = Convert.ToString(this.tablaAutos.CurrentRow.Cells[10].Value);
                licencia = Convert.ToString(this.tablaAutos.CurrentRow.Cells[11].Value);
                rodado = Convert.ToString(this.tablaAutos.CurrentRow.Cells[12].Value);
                habilitado = Convert.ToInt32(this.tablaAutos.CurrentRow.Cells[13].Value);
                Edicion ventana = new Edicion(idAuto, idChofer, nombreChofer, apellidoChofer, idTurno, descTurno, licencia, rodado, habilitado);
                ventana.ShowDialog(this);
                CapaInterfaz.IAuto.BuscarAuto(this.tablaAutos, marca, modelo, txtPatente.Text, chofer);
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 0);
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 2);
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 4);
                //idchofer
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 6);
                //idturno
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 9);
                //habilitado
                CapaInterfaz.IAuto.OcultarColumnas(this.tablaAutos, 13);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            marca = 0;
            modelo = 0;
            txtPatente.Text = "";
            chofer = 0;
           // CapaInterfaz.Decoracion.mostrarInfo("Seleccione DE VUELTA los campos que desea");
        }
    }
}
