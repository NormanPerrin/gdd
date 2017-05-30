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
    public partial class AbmRol : Form
    {
        #region Constructor

            public AbmRol()
            {
                InitializeComponent();
                CapaInterfaz.Decoracion.Reorganizar(this);
            }

        #endregion

            #region Acciones

            private void btnNuevoRol_Click(object sender, EventArgs e)
            {
                Alta ventana = new Alta();
                ventana.ShowDialog(this);
            }

            private void btnLista_Click(object sender, EventArgs e)
            {
                Listado ventana = new Listado();
                ventana.ShowDialog(this);
            }

            private void btnVolver_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        #endregion
    }
}
