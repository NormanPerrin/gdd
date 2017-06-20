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
        #region Atributos

            private static Facturacion _Instancia;

        #endregion

        #region Constructor

            public Facturacion()
            {
                InitializeComponent();
            }

        #endregion

        #region Metodos y funciones auxiliares

            private void formatearAtributos()
            {
            }

            public static Facturacion ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new Facturacion();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static Facturacion Instancia
            {
                get { return Facturacion._Instancia; }
                set { Facturacion._Instancia = value; }
            }

        #endregion

            private void Facturacion_Load(object sender, EventArgs e)
            {
                CapaInterfaz.ICliente.CargarClientesSinFacturacion(cbxCliente);
            }

            private void button1_Click(object sender, EventArgs e)
            {
                String idCliente = CapaInterfaz.ICliente.getIdClienteActual(cbxCliente.Text);
                CapaInterfaz.IViaje.AgregarFacturacion(idCliente);
            }

            private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
            {
                String idCliente = CapaInterfaz.ICliente.getIdClienteActual(cbxCliente.Text);
                CapaInterfaz.IViaje.CargarListaViajes(dataGridView1, idCliente);
            }
    }
}
