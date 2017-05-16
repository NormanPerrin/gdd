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
    public partial class RegistroViajes : Form
    {
        #region Atributos

            private static RegistroViajes _Instancia;

        #endregion

        #region Constructor

            public RegistroViajes()
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

            public static RegistroViajes ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new RegistroViajes();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static RegistroViajes Instancia
            {
                get { return RegistroViajes._Instancia; }
                set { RegistroViajes._Instancia = value; }
            }

        #endregion
    }
}
