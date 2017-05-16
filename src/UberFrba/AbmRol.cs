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
    public partial class AbmRol : Form
    {
        #region Atributos

            private static AbmRol _Instancia;

        #endregion

        #region Constructor

            public AbmRol()
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

            public static AbmRol ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new AbmRol();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static AbmRol Instancia
            {
                get { return AbmRol._Instancia; }
                set { AbmRol._Instancia = value; }
            }

        #endregion
    }
}
