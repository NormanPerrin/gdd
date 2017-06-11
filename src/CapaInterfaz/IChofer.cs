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
            tablaChoferes.Columns[0].Visible = false; // oculto la columna del id
            tablaChoferes.Columns[11].Visible = false; // oculto la columna del habilitado booleano
            tablaChoferes.Columns[12].Visible = false; // oculto la columna del id usuario asignado
        }

        public static string validarDatosIngresados(string nombre, string apellido, string dni, string fechaNac,
            string telefono, string mail, string direccion, string nroPiso, string depto)
        {
            if (!CapaInterfaz.Validador.EsSoloLetras(nombre))
                return "El nombre no es valido";
            if (!CapaInterfaz.Validador.EsSoloLetras(apellido))
                return "El apellido no es valido";
            if (!CapaInterfaz.Validador.EsSoloNumeros(dni))
                return "El DNI no es valido";
            if (!CapaInterfaz.Validador.EsFecha(Convert.ToString(fechaNac)))
                return "La fecha de nacimiento no es valida";
            if (!CapaInterfaz.Validador.EsNumeroTelefonico(telefono))
                return "El telefono no es valido";
            if (!CapaInterfaz.Validador.EsMail(mail))
                return "El mail no es valido";
            if (!CapaInterfaz.Validador.EsDomicilio(direccion))
                return "La direccion no es valido";
            // la localidad no se que goma hacer, si validarla o no porque puede ser cualquier cosa (al menos en argentina)
            if (!CapaInterfaz.Validador.EsSoloNumeros(Convert.ToString(nroPiso)))
                return "El numero de piso no es valido";
            if (!CapaInterfaz.Validador.EsSoloLetras(depto))
                return "El depto no es valido";

            return "1";
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
            if (!CapaInterfaz.Validador.EsFecha(choferNuevo.FechaNacString))
                return "La fecha de nacimiento no es valida";
            if (!CapaInterfaz.Validador.EsNumeroTelefonico(choferNuevo.TelefonoString))
                return "El telefono no es valido";
            if (!CapaInterfaz.Validador.EsMail(choferNuevo.Mail))
                return "El mail no es valido";
            if (!CapaInterfaz.Validador.EsDomicilio(choferNuevo.Direccion))
                return "La direccion no es valido";
            // la localidad no se que goma hacer, si validarla o no porque puede ser cualquier cosa (al menos en argentina)
            if (!CapaInterfaz.Validador.EsSoloNumeros(choferNuevo.NroPisoString))
                return "El numero de piso no es valido";
            if (!CapaInterfaz.Validador.EsSoloLetras(choferNuevo.Depto))
                return "El depto no es valido";

            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.DniString))
                choferNuevo.Dni = Convert.ToInt32(choferViejo.DniString);
            else
                choferNuevo.Dni = Convert.ToInt32(choferNuevo.DniString);

            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.FechaNacString))
                choferNuevo.FechaNac = Convert.ToDateTime(choferViejo.FechaNacString);  // no lo actualizo
            else
                choferNuevo.FechaNac = Convert.ToDateTime(choferNuevo.FechaNacString);

            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.TelefonoString))
                choferNuevo.Telefono = Convert.ToInt32(choferViejo.TelefonoString);  // no lo actualizo
            else
                choferNuevo.Telefono = Convert.ToInt32(choferNuevo.TelefonoString);

            if (CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.NroPisoString))
                choferNuevo.NroPiso = Convert.ToInt32(choferViejo.NroPisoString); // no lo actualizo
            else
                choferNuevo.NroPiso = Convert.ToInt32(choferNuevo.NroPisoString);

            if (!CapaInterfaz.Validador.EsCadenaVaciaONula(choferNuevo.Estado))
            {
                if (choferNuevo.Estado.Equals("habilitado"))
                    choferNuevo.Habilitado = 1;
                else
                    choferNuevo.Habilitado = 0; // deshabilitar
            }
            else
                choferNuevo.Habilitado = -1; // valor invalido - sinonimo de no modificar

            msj = CapaNegocio.NChofer.actualizarChofer(choferNuevo);

            return msj;
        }
    }
}
