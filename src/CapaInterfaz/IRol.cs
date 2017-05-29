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

            public static DataTable CargarFuncionalidades()
            {
                DataTable Datos = CapaNegocio.NRol.ObtenerFuncionalidades();
                return Datos;
            }

            public static void OcultarColumnas(DataGridView tablaFuncionalidades)
            {
                tablaFuncionalidades.Columns[1].Visible = false; // oculto la columna del id
            }

            public static string AgregarRol(string nombreRol, DataGridView tablaFuncionalidades)
            {
                string respuesta = CapaNegocio.NRol.AgregarRol(nombreRol);
                DataTable Rol = CapaNegocio.NRol.ObtenerRol(nombreRol);
                if (Rol.Rows.Count != 0)
                {
                    int idRol = System.Convert.ToInt32(Rol.Rows[0][0]);
                    int idFuncionalidad;
                    foreach (DataGridViewRow row in tablaFuncionalidades.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)) // aca agregi las funcionalidades para el rol
                        {
                            idFuncionalidad = System.Convert.ToInt32(row.Cells[1].Value);
                            CapaNegocio.NRol.AgregarRolFuncionalidad(idRol, idFuncionalidad); // tomo el id_funcionalidad que es la columna 1 de la tabla
                        }
                    }
                }
                return respuesta;
            }

        #endregion
    }
}
