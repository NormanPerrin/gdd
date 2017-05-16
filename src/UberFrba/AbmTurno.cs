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
    public partial class AbmTurno : Form
    {
        #region Atributos

            private static AbmTurno _Instancia;

        #endregion

        #region Constructor

            public AbmTurno()
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

            public static AbmTurno ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new AbmTurno();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static AbmTurno Instancia
            {
                get { return AbmTurno._Instancia; }
                set { AbmTurno._Instancia = value; }
            }

        #endregion
    }
}
