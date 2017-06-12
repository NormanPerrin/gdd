using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Windows.Forms;
using Entidades;

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
            tablaChoferes.Columns["id_chofer"].Visible = false; // oculto la columna del id
            tablaChoferes.Columns["habilitado"].Visible = false; // oculto la columna del habilitado booleano
            tablaChoferes.Columns["id_usuario"].Visible = false; // oculto la columna del id usuario asignado
        }

        public static string actualizarChofer(Chofer choferNuevo, Chofer choferViejo)
        {
            string msj;

            if (!CapaInterfaz.Validador.EsSoloLetras(choferNuevo.Nombre))
                return "El nombre no es valido";
            if (!CapaInterfaz.Validador.EsSoloLetras(choferNuevo.Apellido))
                return "El apellido no es valido";
            if (!CapaInterfaz.Validador.EsSoloNumeros(choferNuevo.DniString))
                return "El DNI no es valido";
            if (!CapaInterfaz.Validador.EsFechaHMS(choferNuevo.FechaNacString))
                return "La fecha de nacimiento no es valida";
            if (!CapaInterfaz.Validador.EsNumeroTelefonico(choferNuevo.TelefonoString))
                return "El telefono no es valido";
            if (!CapaInterfaz.Validador.EsMail(choferNuevo.Mail))
                return "El mail no es valido";
            if (!CapaInterfaz.Validador.EsDomicilio(choferNuevo.Direccion))
                return "La direccion no es valido";
            if (!CapaInterfaz.Validador.EsSoloNumeros(choferNuevo.NroPisoString) && !CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.NroPisoString))
                return "El numero de piso no es valido";
            if ((!CapaInterfaz.Validador.EsSoloLetras(choferNuevo.Depto) || choferNuevo.Depto.Length != 1)  && !CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.NroPisoString))
                return "El depto no es valido";

            // realizo las converciones correspondientes si los datos son validos
            choferNuevo.Dni = Convert.ToInt32(choferNuevo.DniString);
            choferNuevo.FechaNac = Convert.ToDateTime(choferNuevo.FechaNacString);
            choferNuevo.Telefono = Convert.ToInt32(choferNuevo.TelefonoString);
            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.NroPisoString)) choferNuevo.NroPiso = -1;
            else choferNuevo.NroPiso = Convert.ToInt32(choferNuevo.NroPisoString);
            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.Depto)) choferNuevo.Depto = string.Empty;
            if (choferNuevo.Estado.Equals("habilitado")) choferNuevo.Habilitado = 1;
            else choferNuevo.Habilitado = 0; // deshabilitar

            msj = CapaNegocio.NChofer.actualizarChofer(choferNuevo);

            return msj;
        }

        public static string crearChofer(Chofer choferNuevo)
        {
            if (String.IsNullOrEmpty(choferNuevo.Nombre) || String.IsNullOrEmpty(choferNuevo.Apellido) ||
                String.IsNullOrEmpty(choferNuevo.TelefonoString) || String.IsNullOrEmpty(choferNuevo.DniString) ||
                String.IsNullOrEmpty(choferNuevo.FechaNacString) || String.IsNullOrEmpty(choferNuevo.Direccion) ||
                String.IsNullOrEmpty(choferNuevo.Localidad) || CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.Mail) )
            {
                return "Por favor complete los campos obligatorios";
            }

            if (!CapaInterfaz.Validador.EsMail(choferNuevo.Mail))
                return "El mail no es valido";
            if (!CapaInterfaz.Validador.EsDomicilio(choferNuevo.Direccion))
                return "La direccion no es valida";
            if (choferNuevo.Depto.Length != 1 && !CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.NroPisoString))
                return "El depto no es valido";

            choferNuevo.Dni = Convert.ToInt32(choferNuevo.DniString);
            choferNuevo.FechaNac = Convert.ToDateTime(choferNuevo.FechaNacString);
            choferNuevo.Telefono = Convert.ToInt32(choferNuevo.TelefonoString);
            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.NroPisoString)) choferNuevo.NroPiso = -1;
            else choferNuevo.NroPiso = Convert.ToInt32(choferNuevo.NroPisoString);
            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.Depto)) choferNuevo.Depto = string.Empty;
            
            return CapaNegocio.NChofer.crearChofer(choferNuevo);
        }
    }
}
