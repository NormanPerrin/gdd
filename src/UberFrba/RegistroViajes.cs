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
    public partial class RegistroViajes : Form
    {
        #region Atributos

            private static RegistroViajes _Instancia;

        #endregion

        #region Constructor

            public RegistroViajes()
            {
                InitializeComponent();
            }

        #endregion

        #region Acciones

            // verifica que los campos esten completos 
            private Boolean validarCampos()
            {
                return true;
            }

            // resetea valores a su default
            private void reset()
            {
                inputKms.Clear();
                lblCosto.Text = String.Empty;
            }

        #endregion

        #region Metodos y funciones auxiliares

            private void formatearAtributos()
            {
            }

            public static RegistroViajes ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new RegistroViajes();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static RegistroViajes Instancia
            {
                get { return RegistroViajes._Instancia; }
                set { RegistroViajes._Instancia = value; }
            }

        #endregion

            private void button1_Click(object sender, EventArgs e)
            {
                reset();
            }

            private void RegistroViajes_Load(object sender, EventArgs e)
            {
                CapaInterfaz.ITurno.CargarTurnos(cbxTurno);
                CapaInterfaz.ICliente.CargarClientes(cbxCliente);
            }

            private void button2_Click(object sender, EventArgs e)
            {
                String idcliente = CapaInterfaz.ICliente.getIdClienteActual(cbxCliente.Text);
                String idchofer = CapaInterfaz.IChofer.getIdChoferActual(cbxChofer.Text);
                String turno = CapaInterfaz.ITurno.getIdTurnoActual(cbxTurno.Text);
                String idauto = CapaInterfaz.IAuto.getIdAutoActual(lblAuto.Text);
                DateTime fechaDesde = dateFrom.Value;
                DateTime fechaHasta = dateTo.Value;
                int kms = Int32.Parse(inputKms.Text);
                CapaInterfaz.IViaje.AgregarViaje(idcliente, idchofer, turno, idauto, fechaDesde, fechaHasta, kms);
                reset();
            }

            private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
            {
                String turno = CapaInterfaz.ITurno.getIdTurnoActual(cbxTurno.Text);
                CapaInterfaz.IChofer.CargarChoferesPorTurno(cbxChofer, turno);
                String idChofer = CapaInterfaz.IChofer.getIdChoferActual(cbxChofer.Text);
                CapaInterfaz.IAuto.CargarAutoHabilitado(lblAuto, idChofer, turno);
            }

            private void cbxChofer_SelectedIndexChanged(object sender, EventArgs e)
            {
                String idChofer = CapaInterfaz.IChofer.getIdChoferActual(cbxChofer.Text);
                String turno = CapaInterfaz.ITurno.getIdTurnoActual(cbxTurno.Text);
                CapaInterfaz.IAuto.CargarAutoHabilitado(lblAuto, idChofer, turno);
            }

            private void button3_Click(object sender, EventArgs e)
            {
                int kms = Int32.Parse(inputKms.Text);
                String idturno = CapaInterfaz.ITurno.getIdTurnoActual(cbxTurno.Text);
                CapaInterfaz.ITurno.CargarValorTurno(lblCosto, kms, idturno);
            } 

    }
}
