using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Windows.Forms;
using System.Security.Cryptography;
using Entidades;

namespace CapaInterfaz
{
    public class ICliente
    {
        #region Metodos/Atributos

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
                    clientes.Add(Datos.Rows[i][0].ToString(), Datos.Rows[i][1].ToString() + ' ' + Datos.Rows[i][2].ToString());
                }
                cbxCliente.SelectedIndex = 0;
            }
        }

        public static String getIdClienteActual(String nombre)
        {
            return clientes.FirstOrDefault(x => x.Value == nombre).Key;
        }


        public static string alta(int dni, string nombre, string apellido, string direccion, string mail, int telefono, DateTime fecha_nac, int? nro_piso, char? dpto ,string localidad, int cod_postal)
        {
            string respuesta = CapaNegocio.NCliente.alta(dni, nombre, apellido, direccion, mail, telefono, fecha_nac, nro_piso, dpto,  localidad, cod_postal);

            return respuesta;
        }


        public static string modificacion(Cliente cliente)
        {
            string respuesta = CapaNegocio.NCliente.modificacion(cliente);

            return respuesta;
        }

        public static void BusquedaCliente(DataGridView tablaClientes, Entidades.Cliente cliente)
        {
            tablaClientes.DataSource = CapaNegocio.NCliente.BuscarCliente(cliente);

        }

        #endregion



        public static string eliminar(int id_cliente)
        {
            return CapaNegocio.NCliente.eliminar(id_cliente);
        }
    }
}
