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
                Cargador.CargarComboboxConDatos(cbxRoles, Datos);
            }

            public static void CargarRoles(ComboBox cbxRoles)
            {
                DataTable Datos = CapaNegocio.NRol.ObtenerRoles();
                Cargador.CargarComboboxConDatos(cbxRoles, Datos);
            }

            public static void CargarFuncionalidades(ComboBox cbxFuncionalidades, string nombreRol)
            {
                DataTable Datos = CapaNegocio.NRol.ObtenerFuncionalidades(nombreRol);
                Cargador.CargarComboboxConDatos(cbxFuncionalidades, Datos);
            }

            public static void CargarFuncionalidades(DataGridView tablaFuncionalidades)
            {
                tablaFuncionalidades.DataSource = CapaNegocio.NRol.ObtenerFuncionalidades();
            }

            public static void OcultarColumnas(DataGridView tablaFuncionalidades)
            {
                tablaFuncionalidades.Columns[1].Visible = false; // oculto la columna del id
            }

            public static bool ChequearItemSeleccionado(DataGridView tablaFuncionalidades)
            {
                bool resultado;
                resultado = false;
                foreach (DataGridViewRow row in tablaFuncionalidades.Rows)
                {
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Elegir"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value)) 
                        resultado = true;
                }
                return resultado;
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
                        if (Convert.ToBoolean(row.Cells[0].Value)) // aca agrego las funcionalidades para el rol
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
