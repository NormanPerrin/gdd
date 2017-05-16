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
    public partial class AbmCliente : Form
    {
        #region Atributos

            private static AbmCliente _Instancia;

        #endregion

        #region Constructor

            public AbmCliente()
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

            public static AbmCliente ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new AbmCliente();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static AbmCliente Instancia
            {
                get { return AbmCliente._Instancia; }
                set { AbmCliente._Instancia = value; }
            }

        #endregion
    }
}
