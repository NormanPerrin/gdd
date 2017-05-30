using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public class Decoracion
    {
        public static void mostrarInfo(string error)
        {
            MessageBox.Show(error, "UBER FRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Reorganizar(Form ventana)
        {
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ventana.MaximizeBox = false;
            ventana.MaximizeBox = false;
            ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
