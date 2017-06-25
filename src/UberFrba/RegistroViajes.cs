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
                inputKms.Value = 1;
                lblCosto.Text = String.Empty;
                String turno = ITurno.getIdTurnoActual(cbxTurno.Text);
                CapaInterfaz.ITurno.CargarLimitesFechas(dateFrom, dateTo, turno);
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
                int kms = Int32.Parse(inputKms.Value.ToString());
                CapaInterfaz.IViaje.AgregarViaje(idcliente, idchofer, turno, idauto, fechaDesde, fechaHasta, kms);
                reset();
                MessageBox.Show("Se ha registrado el viaje", "Registro viaje", MessageBoxButtons.OKCancel);
            }

            private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
            {
                String turno = CapaInterfaz.ITurno.getIdTurnoActual(cbxTurno.Text);
                CapaInterfaz.IChofer.CargarChoferesPorTurno(cbxChofer, turno);
                String idChofer = CapaInterfaz.IChofer.getIdChoferActual(cbxChofer.Text);
                CapaInterfaz.IAuto.CargarAutoHabilitado(lblAuto, idChofer, turno);
                CapaInterfaz.ITurno.CargarLimitesFechas(dateFrom, dateTo, turno);
            }

            private void cbxChofer_SelectedIndexChanged(object sender, EventArgs e)
            {
                String idChofer = CapaInterfaz.IChofer.getIdChoferActual(cbxChofer.Text);
                String turno = CapaInterfaz.ITurno.getIdTurnoActual(cbxTurno.Text);
                CapaInterfaz.IAuto.CargarAutoHabilitado(lblAuto, idChofer, turno);
            }

            private void button3_Click(object sender, EventArgs e)
            {
                int kms = Int32.Parse(inputKms.Value.ToString());
                String idturno = CapaInterfaz.ITurno.getIdTurnoActual(cbxTurno.Text);
                CapaInterfaz.ITurno.CargarValorTurno(lblCosto, kms, idturno);
            }

            private void dateFrom_ValueChanged(object sender, EventArgs e)
            {   
                DateTime now = DateTime.Now;
                dateTo.MinDate = new DateTime(now.Year, now.Month, now.Day, dateFrom.Value.Hour, dateFrom.Value.Minute, dateFrom.Value.Second);
            }

            private void dateTo_ValueChanged(object sender, EventArgs e)
            {
                DateTime now = DateTime.Now;
                dateFrom.MaxDate = new DateTime(now.Year, now.Month, now.Day, dateTo.Value.Hour, dateTo.Value.Minute, dateTo.Value.Second);
            }

    }
}
