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
