using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;

namespace CapaInterfaz
{
    class Cargador
    {
        public static string CargarComboboxConDatos(ComboBox combobox, DataTable datos)
        {
            string respuesta = string.Empty;
            if (datos.Rows.Count != 0)
            {
                int cantidadDeItems = datos.Rows.Count;
                for (int i = 0; i < cantidadDeItems; i++)
                {
                    combobox.Items.Add(datos.Rows[i][0]);
                }
                combobox.SelectedIndex = 0; // defino el primer elemento obtenido de la DB como objeto a mostrar en el cbx
                respuesta = "Se ha logrado cargar el combobox con los datos";
            }
            else
                respuesta = "No se pudo cargar el combobox con los datos";
            return respuesta;
        }
    }
}
