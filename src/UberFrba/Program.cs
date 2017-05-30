using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    internal sealed class Program
    {
        static public ApplicationContext contexto;

        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            contexto = new ApplicationContext(new Login());
            Application.Run(contexto);
        }
    }
}
