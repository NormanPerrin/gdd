using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public class IRol
    {
        #region Metodos

            public static void CargarRoles(ComboBox cbxRoles, int idUsuario)
            {
                DataTable Datos = CapaNegocio.NRol.ObtenerRoles(idUsuario);
                if (Datos.Rows.Count != 0)
                {
                    int cantidadDeItems = Datos.Rows.Count;
                    for (int i = 0; i < cantidadDeItems; i++)
                    {
                        cbxRoles.Items.Add(Datos.Rows[i][0]);
                    }
                    cbxRoles.SelectedIndex = 0; // defino el primer elemento obtenido de la DB como objeto a mostrar en el cbx
                }
            }

            public static void CargarRoles(ComboBox cbxRoles)
            {
                DataTable Datos = CapaNegocio.NRol.ObtenerRoles();
                if (Datos.Rows.Count != 0)
                {
                    int cantidadDeItems = Datos.Rows.Count;
                    for (int i = 0; i < cantidadDeItems; i++)
                    {
                        cbxRoles.Items.Add(Datos.Rows[i][0]);
                    }
                    cbxRoles.SelectedIndex = 0;
                }
            }

            public static void CargarFuncionalidades(ComboBox cbxFuncionalidades, string nombreRol)
            {
                DataTable Datos = CapaNegocio.NRol.ObtenerFuncionalidades(nombreRol);
                if (Datos.Rows.Count != 0)
                {
                    int cantidadDeItems = Datos.Rows.Count;
                    for (int i = 0; i < cantidadDeItems; i++)
                    {
                        cbxFuncionalidades.Items.Add(Datos.Rows[i][0]);
                    }
                    cbxFuncionalidades.SelectedIndex = 0;
                }
                else
                    cbxFuncionalidades.Items.Add(nombreRol);
            }

        #endregion
    }
}
