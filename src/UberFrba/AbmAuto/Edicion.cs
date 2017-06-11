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
        #region Atributos

        int idAuto;
        string licenciaVieja;
        string rodadoViejo;
        string nombreViejo;

        #endregion

        public Edicion(int id, string lic, string rod, string nom)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.licenciaVieja = lic;
            this.rodadoViejo = rod;
            this.nombreViejo = nom;
            this.idAuto = id;
        }

        #region Acciones/Eventos

        private void Edicion_Load(object sender, EventArgs e)
        {
            this.txtLicenciaVieja.Text = this.licenciaVieja;
            this.txtRodadoViejo.Text = this.rodadoViejo;
            this.txtNombreViejo.Text = this.nombreViejo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.IAuto.modificacion(idAuto,this.txtNewLicencia.Text, this.txtNewRodado.Text, this.txtNewNombre.Text);
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
    }
}
