using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmCliente
{
    public partial class AbmCliente : Form
    {

        #region Constructor

        public AbmCliente()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }
        
        #endregion

        #region Acciones

        private void clienteAltabtn_Click(object sender, EventArgs e)
        {
            Alta ventana = new Alta();
            ventana.ShowDialog(this);
        }

        #endregion
    }
}
