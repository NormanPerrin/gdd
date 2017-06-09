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
    public class IChofer
    {
        public static void CargarChoferes(DataGridView tablaChoferes)
        {
            tablaChoferes.DataSource = CapaNegocio.NChofer.ObtenerChoferes();
        }

        public static void CargarChoferEspecifico(DataGridView tablaChoferes, string nombre, string apellido, string dni)
        {
            if (!nombre.Equals(String.Empty) || !apellido.Equals(String.Empty) || !dni.Equals(String.Empty))
            {
                tablaChoferes.DataSource = CapaNegocio.NChofer.ObtenerChoferEspecifico(nombre, apellido, dni);
            }
        }

        public static void OcultarColumnasChoferes(DataGridView tablaChoferes)
        {
            tablaChoferes.Columns[0].Visible = false; // oculto la columna del id
            tablaChoferes.Columns[11].Visible = false; // oculto la columna del habilitado booleano
            tablaChoferes.Columns[12].Visible = false; // oculto la columna del id usuario asignado
        }
    }
}
