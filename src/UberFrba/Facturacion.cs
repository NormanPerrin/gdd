using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaInterfaz;

namespace UberFrba
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }
        private void reset()
        {
            CapaInterfaz.ICliente.CargarClientesSinFacturacion(cbxCliente);
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CapaInterfaz.ICliente.CargarClientesSinFacturacion(cbxCliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String idCliente = CapaInterfaz.ICliente.getIdClienteActual(cbxCliente.Text);
            CapaInterfaz.IViaje.AgregarFacturacion(idCliente);
            reset();
            MessageBox.Show("Se ha registrado la facturacion", "Registro facturacion", MessageBoxButtons.OKCancel);
            this.Close();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idCliente = CapaInterfaz.ICliente.getIdClienteActual(cbxCliente.Text);
            CapaInterfaz.IViaje.CargarListaViajes(dataGridView1, idCliente);
        }
    }
}
