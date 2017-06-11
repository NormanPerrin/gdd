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
        static Dictionary<String, String> choferes = new Dictionary<String, String> {};

        public static void CargarChoferesPorTurno(ComboBox cbxChofer, String turno)
        {
            DataTable Datos = CapaNegocio.NChofer.ObtenerChoferes(turno);
            choferes.Clear();
            if (Datos.Rows.Count != 0)
            {
                int cantidadDeItems = Datos.Rows.Count;
                for (int i = 0; i < cantidadDeItems; i++)
                {
                    choferes.Add(Datos.Rows[i][0].ToString(), Datos.Rows[i][1].ToString());
                    cbxChofer.Items.Add(Datos.Rows[i][1]);
                }
                cbxChofer.SelectedIndex = 0;
            }  
        }

        public static String getIdChoferActual(String nombre)
        {
            return choferes.FirstOrDefault(x => x.Value == nombre).Key;
        }
    }
}
