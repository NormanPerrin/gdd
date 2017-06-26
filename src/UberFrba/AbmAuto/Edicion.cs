using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmAuto
{
    public partial class Edicion : Form
    {
        int idAuto;
        string licenciaVieja;
        string rodadoViejo;

        public Edicion(int id, string lic, string rod)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.licenciaVieja = lic;
            this.rodadoViejo = rod;
            this.idAuto = id;
            this.txtLicenciaVieja.Text = this.licenciaVieja;
            this.txtRodadoViejo.Text = this.rodadoViejo;
        }

        #region Acciones/Eventos


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtNewLicencia.Text)) this.txtNewLicencia.Text = licenciaVieja;
            if (string.IsNullOrWhiteSpace(this.txtNewRodado.Text)) this.txtNewRodado.Text = rodadoViejo;

            string respuesta = CapaInterfaz.IAuto.modificacion(idAuto, this.txtNewLicencia.Text, this.txtNewRodado.Text);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.IAuto.baja(idAuto);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.IAuto.alta(idAuto);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }
    }
}
