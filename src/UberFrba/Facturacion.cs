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
            CapaInterfaz.ICliente.CargarClientesSinFacturacion(cbxCliente, Properties.Settings.Default.FechaSistema);
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CapaInterfaz.ICliente.CargarClientesSinFacturacion(cbxCliente, Properties.Settings.Default.FechaSistema);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxCliente.Text == "")
            {
                MessageBox.Show("No hay clientes para facturar", "Error facturación", MessageBoxButtons.OK);
                return;
            }

            String idCliente = CapaInterfaz.ICliente.getIdClienteActual(cbxCliente.Text);
            CapaInterfaz.IViaje.AgregarFacturacion(idCliente, Properties.Settings.Default.FechaSistema);
            reset();
            MessageBox.Show("Se ha registrado la facturacion", "Registro facturacion", MessageBoxButtons.OK);
            this.Close();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idCliente = CapaInterfaz.ICliente.getIdClienteActual(cbxCliente.Text);
            CapaInterfaz.IViaje.CargarListaViajes(dataGridView1, idCliente, Properties.Settings.Default.FechaSistema);
        }
    }
}
