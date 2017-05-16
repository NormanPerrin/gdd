﻿using System;
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
    public partial class AbmChofer : Form
    {
        #region Atributos

            private static AbmChofer _Instancia;

        #endregion

        #region Constructor

            public AbmChofer()
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

            public static AbmChofer ObtenerInstancia()
            {
                if (Instancia == null)
                {
                    Instancia = new AbmChofer();
                }
                return Instancia;
            }

        #endregion

        #region Getters/Setters

            public static AbmChofer Instancia
            {
                get { return AbmChofer._Instancia; }
                set { AbmChofer._Instancia = value; }
            }

        #endregion
    }
}