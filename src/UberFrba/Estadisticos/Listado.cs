using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Estadisticos
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            cbxConsulta.SelectedIndex = 0;
            cbxTrimestre.SelectedIndex = 0;
            CapaInterfaz.IEstadistico.BuscarAnios(cbxAnio);
            cbxAnio.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tabla.DataSource = null;
            tabla.Refresh();
            int consulta = Convert.ToInt32(cbxConsulta.SelectedIndex);
            int trimestre = Convert.ToInt32(cbxTrimestre.SelectedIndex)+1;
            int anio = Convert.ToInt32(cbxAnio.Text);
            switch (consulta)
            {
                case 0:
                    tabla.DataSource = CapaInterfaz.IEstadistico.BuscarChoferesMayorRecaudacion(trimestre, anio);
                    break;
                case 1:
                    tabla.DataSource = CapaInterfaz.IEstadistico.BuscarChoferesViajeMasLargo(trimestre, anio);
                    break;
                case 2:
                    tabla.DataSource = CapaInterfaz.IEstadistico.BuscarClientesMayorConsumo(trimestre, anio);
                    break;
                case 3:
                    tabla.DataSource = CapaInterfaz.IEstadistico.BuscarCantVecesClienteMismoAuto(trimestre, anio);
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
