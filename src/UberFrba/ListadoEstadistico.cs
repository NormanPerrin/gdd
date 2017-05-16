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
    public partial class ListadoEstadistico : Form
    {
        #region Atributos

            private static ListadoEstadistico _Instancia;

        #endregion

        #region Constructor

            public ListadoEstadistico()
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

            public static ListadoEstadistico ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new ListadoEstadistico();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static ListadoEstadistico Instancia
            {
                get { return ListadoEstadistico._Instancia; }
                set { ListadoEstadistico._Instancia = value; }
            }

        #endregion
    }
}
