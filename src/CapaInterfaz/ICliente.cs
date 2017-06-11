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
    public class ICliente
    {

        private static Dictionary<String, String> clientes = new Dictionary<String, String> {};

        public static void CargarClientes(ComboBox cbxCliente)
        {
            DataTable Datos = CapaNegocio.NCliente.ObtenerClientes();
            clientes.Clear();
            if (Datos.Rows.Count != 0)
            {
                int cantidadDeItems = Datos.Rows.Count;
                for (int i = 0; i < cantidadDeItems; i++)
                {
                    cbxCliente.Items.Add(Datos.Rows[i][1].ToString() + ' ' + Datos.Rows[i][2].ToString());
                    clientes.Add(Datos.Rows[i][0].ToString(), cbxCliente.Text);
                }
                cbxCliente.SelectedIndex = 0;
            }
        }

        public static String getIdClienteActual(String nombre)
        {
            return clientes.FirstOrDefault(x => x.Value == nombre).Key;
        }

    }
}
