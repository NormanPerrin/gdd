using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace UberFrba
{
    public partial class Funcionalidades : Form
    {
        private Rol rol;

        public Funcionalidades(string nombre)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            rol = CapaInterfaz.IRol.obtenerRol(nombre);
        }

        private void Funcionalidades_Load(object sender, EventArgs e)
        {
            titulo.Text = "Rol actual: " + rol.Nombre;
            CapaInterfaz.Decoracion.Reorganizar(this);
            CapaInterfaz.IRol.CargarFuncionalidadesHabilitadas(cbxFuncionalidades, rol);
            cbxFuncionalidades.SelectedIndex = 0;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (cbxFuncionalidades.Text == "ABM rol") // despues veo como mejoro este codigo porque no me gusta que sea tan asi
            {
                AbmRol.AbmRol siguienteVentana = new AbmRol.AbmRol();
                siguienteVentana.ShowDialog(this);
            }
            else if (cbxFuncionalidades.Text == "ABM cliente")
            {
                AbmCliente.AbmCliente siguienteVentana = new AbmCliente.AbmCliente();
                siguienteVentana.Show();
            }
            else if (cbxFuncionalidades.Text == "ABM automovil")
            {
                AbmAuto.AbmAuto siguienteVentana = new AbmAuto.AbmAuto();
                siguienteVentana.ShowDialog(this);
            }
            else if (cbxFuncionalidades.Text == "ABM turno")
            {
                AbmTurno.AbmTurno siguienteVentana = new AbmTurno.AbmTurno();
                siguienteVentana.Show();
            }
            else if (cbxFuncionalidades.Text == "ABM chofer")
            {
                AbmChofer.AbmChofer siguienteVentana = new AbmChofer.AbmChofer();
                siguienteVentana.ShowDialog(this);
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
                Estadisticos.Listado siguienteVentana = new Estadisticos.Listado();
                siguienteVentana.ShowDialog(this);
            }
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            Login siguienteVentana = new Login();
            Program.contexto.MainForm = siguienteVentana;
            siguienteVentana.Show();
            Close();
        }
    }
}
