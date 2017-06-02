using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public partial class Funcionalidades : Form
    {
        #region Atributos

            private string _NombreRol;

        #endregion

        #region Constructor

            public Funcionalidades(string nombreRol)
            {
                InitializeComponent();
                CapaInterfaz.Decoracion.Reorganizar(this);
                this.NombreRol = nombreRol;
                titulo.Text = "Rol actual: " + nombreRol;
            }

        #endregion

        #region Acciones

            private void btnAcceder_Click(object sender, EventArgs e)
            {
                if (cbxFuncionalidades.Text == "ABM Rol") // despues veo como mejoro este codigo porque no me gusta que sea tan asi
                {
                    AbmRol.AbmRol siguienteVentana = new AbmRol.AbmRol();
                    siguienteVentana.ShowDialog(this);
                }
                else if (cbxFuncionalidades.Text == "ABM cliente")
                {
                    AbmCliente siguienteVentana = AbmCliente.ObtenerInstancia();
                    siguienteVentana.Show();
                }
                else if (cbxFuncionalidades.Text == "ABM automovil")
                {
                    UberFrba.AbmAuto.AbmAuto siguienteVentana = new AbmAuto.AbmAuto();
                    siguienteVentana.ShowDialog(this);
                }
                else if (cbxFuncionalidades.Text == "ABM turno")
                {
                    AbmTurno siguienteVentana = AbmTurno.ObtenerInstancia();
                    siguienteVentana.Show();
                }
                else if (cbxFuncionalidades.Text == "ABM chofer")
                {
                    AbmChofer siguienteVentana = AbmChofer.ObtenerInstancia();
                    siguienteVentana.Show();
                }
                else if (cbxFuncionalidades.Text == "Registrar viaje")
                {
                    RegistroViajes siguienteVentana = RegistroViajes.ObtenerInstancia();
                    siguienteVentana.Show();
                }
                else if (cbxFuncionalidades.Text == "Rendir viaje")
                {
                    RendicionViajes siguienteVentana = RendicionViajes.ObtenerInstancia();
                    siguienteVentana.Show();
                }
                else if (cbxFuncionalidades.Text == "Facturar cliente")
                {
                    Facturacion siguienteVentana = Facturacion.ObtenerInstancia();
                    siguienteVentana.Show();
                }
                else if (cbxFuncionalidades.Text == "Listado Estadistico")
                {
                    ListadoEstadistico siguienteVentana = ListadoEstadistico.ObtenerInstancia();
                    siguienteVentana.Show();
                }
            }

            private void cerrarSesion_Click(object sender, EventArgs e)
            {
                Login siguienteVentana = new Login();
                Program.contexto.MainForm = siguienteVentana;
                siguienteVentana.Show();
                Close();
            }

            private void Funcionalidades_Load(object sender, EventArgs e)
            {
                CapaInterfaz.Decoracion.Reorganizar(this);
                CapaInterfaz.IRol.CargarFuncionalidades(this.cbxFuncionalidades, this.NombreRol);
            }

            private void cbxFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        #endregion

        #region Getters/Setters

            public string NombreRol
            {
                get { return _NombreRol; }
                set { _NombreRol = value; }
            }

        #endregion


    }
}
