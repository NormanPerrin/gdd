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
        int idTurno;
        int idChofer;
        string licenciaVieja;
        string rodadoViejo;
        int habilitado;

        public Edicion(int id, string nomC, string apeC, string descT, string lic, string rod, int hab)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.licenciaVieja = lic;
            this.rodadoViejo = rod;
            this.idAuto = id;
            this.habilitado = hab;

            this.txtApellidoChofer.Text = apeC;
            this.txtNombreChofer.Text = nomC;
            this.txtTurno.Text = descT;
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
            if (habilitado == 0)
            {
                CapaInterfaz.Decoracion.mostrarInfo("Este auto ya se encuentra deshabilitado");
            }
            else
            {
                string respuesta = CapaInterfaz.IAuto.baja(idAuto);
                CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            }
            this.Close();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (habilitado == 1)
            { 
                CapaInterfaz.Decoracion.mostrarInfo("Este auto ya se encuentra habilitado"); 
            }
            else
            {
                string respuesta = CapaInterfaz.IAuto.alta(idAuto);
                CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            }
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGuardarChofer_Click(object sender, EventArgs e)
        {

        }

       
    }
}
