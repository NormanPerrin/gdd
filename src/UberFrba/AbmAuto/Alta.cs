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
        public Alta()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        #region Atributos

        private static CapaInterfaz.IAuto _Auto;
        public int idTurno;
        public int idChofer;

        #endregion

        #region Acciones/Eventos

            private void BtnAlta_Click(object sender, EventArgs e)
            {
                string respuesta = CapaInterfaz.IAuto.alta(TxtMarca.Text, TxtModelo.Text, TxtPatente.Text, idTurno, idChofer);
                CapaInterfaz.Decoracion.mostrarInfo(respuesta);
                this.Close();
            }

            private void Alta_Load(object sender, EventArgs e)
            {
                CapaInterfaz.IAuto.CargarTurnos(this.tablaTurno);
                CapaInterfaz.IAuto.CargarChoferes(this.tablaChofer);
            }

            private void tablaTurno_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
            {
                if (e.RowIndex > -1)
                {
                    System.Windows.Forms.DataGridViewCell selectedCell = this.tablaTurno.CurrentCell;
                    object selectedItem = this.tablaTurno[0, e.RowIndex];
                    idTurno = Convert.ToInt32(selectedItem);
                }
            }

            private void tablaChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex > -1)
                {
                    System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer.CurrentCell;
                    object selectedItem = this.tablaChofer[0, e.RowIndex];
                    idChofer = Convert.ToInt32(selectedItem);
                }
            }

            private void btnVolver_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        #endregion

        #region Getters y Setters

        public static CapaInterfaz.IAuto Auto
        {
            get { return Alta._Auto; }
            set { Alta._Auto = value; }
        }

        #endregion
    }
}
