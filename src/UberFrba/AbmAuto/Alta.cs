using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.o
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        #region Atributos

        private static CapaInterfaz.IAuto _Auto;

        #endregion


        #region Acciones/Eventos

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.IAuto.alta(TxtPatente.Text, TxtMarca.Text, TxtModelo.Text, TxtLicencia.Text, TxtRodado.Text);
            //mostrar respuesta
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void LbelModelo_Click(object sender, EventArgs e)
        {

        }

        private void LbelPatente_Click(object sender, EventArgs e)
        {

        }

        private void LbelRodado_Click(object sender, EventArgs e)
        {

        }

        #endregion





        #region Getters y Setters

        public static CapaInterfaz.IAuto Auto
        {
            get { return Alta._Auto; }
            set { Alta._Auto = value; }
        }

        #endregion
    }
}
