using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Security.Cryptography;

namespace CapaInterfaz
{
    public class IAuto
    {
        public static string alta(string marca, string modelo, string patente, int turno, int chofer)
        {
            string respuesta = CapaNegocio.NAuto.alta(marca, modelo, patente, turno, chofer);

            return respuesta;
        }

        public static void CargarTurnos(System.Windows.Forms.DataGridView tablaTurno)
        {
            tablaTurno.DataSource = CapaNegocio.NAuto.ObtenerTurnos();
        }

        public static void CargarChoferes(System.Windows.Forms.DataGridView tablaChofer)
        {
            tablaChofer.DataSource = CapaNegocio.NAuto.ObtenerChoferes();
        }
    }
}