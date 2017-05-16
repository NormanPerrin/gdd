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
    public partial class RendicionViajes : Form
    {
        #region Atributos

            private static RendicionViajes _Instancia;

        #endregion

        #region Constructor

            public RendicionViajes()
            {
                InitializeComponent();
            }

        #endregion

        #region Acciones

        #endregion

        #region Metodos y funciones auxiliares

            private void formatearAtributos()
            {
            }

            public static RendicionViajes ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new RendicionViajes();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static RendicionViajes Instancia
            {
                get { return RendicionViajes._Instancia; }
                set { RendicionViajes._Instancia = value; }
            }

        #endregion
    }
}
