using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmTurno
{
    public partial class AbmTurno : Form
    {
        public AbmTurno()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void turnoAltabtn_Click(object sender, EventArgs e)
        {
            Alta ventana = new Alta();
            ventana.ShowDialog(this);
        }

        private void turnoVolverbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void turnoModbtn_Click(object sender, EventArgs e)
        {
            Modificacion ventana = new Modificacion();
            ventana.ShowDialog(this);
        }


    }
}
