using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmChofer
{
    public partial class AbmChofer : Form
    {
        public AbmChofer()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Listado ventana = new Listado();
            ventana.ShowDialog(this);
        }
    }
}
