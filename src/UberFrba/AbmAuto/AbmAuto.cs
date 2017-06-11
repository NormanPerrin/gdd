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
    public partial class AbmAuto : Form
    {

        #region Constructor

            public AbmAuto()
            {
                InitializeComponent();
                CapaInterfaz.Decoracion.Reorganizar(this);
            }

        #endregion
        
        #region Acciones

            private void btnNuevoAuto_Click(object sender, EventArgs e)
            {
                Alta ventana = new Alta();
                ventana.ShowDialog(this);
            }

            private void btnLista_Click_1(object sender, EventArgs e)
            {
                Listado ventana = new Listado();
                ventana.ShowDialog(this);
            }

            private void btnVolver_Click_1(object sender, EventArgs e)
            {
                this.Close();
            }

        #endregion
    }
}
