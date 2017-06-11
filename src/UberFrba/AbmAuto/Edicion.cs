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
        string nombreViejo;

        public Edicion(int id, string lic, string rod, string nom)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.licenciaVieja = lic;
            this.rodadoViejo = rod;
            this.nombreViejo = nom;
            this.idAuto = id;
        }



        private void Edicion_Load(object sender, EventArgs e)
        {
            this.txtLicenciaVieja.Text = this.licenciaVieja;
            this.txtRodadoViejo.Text = this.rodadoViejo;
            this.txtNombreViejo.Text = this.nombreViejo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Hacer un insert
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
            //Hacer un delete
        }
    }
}
