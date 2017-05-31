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
    public partial class AbmAuto : Form
    {
        #region Atributos

            private static AbmAuto _Instancia;

        #endregion

        #region Constructor

            public AbmAuto()
            {
                InitializeComponent();
            }

        #endregion

        #region Acciones

            private void btnNuevoRol_Click(object sender, EventArgs e)
            {
                Alta ventana = new Alta();
                ventana.ShowDialog(this);
            }

            private void btnLista_Click(object sender, EventArgs e)
            {
                //Listado ventana = new Listado();
                //ventana.ShowDialog(this);
            }

            private void btnVolver_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        #endregion

        #region Metodos y funciones auxiliares

            private void formatearAtributos()
            {
            }

            public static AbmAuto ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new AbmAuto();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static AbmAuto Instancia
            {
                get { return AbmAuto._Instancia; }
                set { AbmAuto._Instancia = value; }
            }

        #endregion

            

  
    }
}
