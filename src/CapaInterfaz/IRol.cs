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
    public class IRol
    {
        public static void CargarRoles(ComboBox cbxRoles, int idUsuario)
        {
            DataTable Datos = CapaNegocio.NRol.ObtenerRoles(idUsuario);
            Cargador.CargarComboboxConDatos(cbxRoles, Datos);
        }

        public static Rol obtenerRol(string nombre)
        {
            Rol rol = new Rol();
            DataTable datos = CapaNegocio.NRol.ObtenerRol(nombre);
            rol.Id = Convert.ToInt32(datos.Rows[0]["id_rol"]);
            rol.Nombre = Convert.ToString(datos.Rows[0]["nombre"]);
            rol.Habilitado = Convert.ToInt32(datos.Rows[0]["habilitado"]);
            rol.Funcionalidades = CapaInterfaz.IRol.cargarFuncionalidades(rol.Id);
            return rol;
        }

        public static List<Funcionalidad> cargarFuncionalidades(int idRol)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            DataTable Datos = CapaNegocio.NRol.ObtenerFuncionalidades(idRol);
            if (Datos.Rows.Count != 0)
            {
                int cantidadDeItems = Datos.Rows.Count;
                for (int i = 0; i < cantidadDeItems; i++)
                {
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.Id = Convert.ToInt32(Datos.Rows[i]["id_funcionalidad"]);
                    funcionalidad.Descripcion = Datos.Rows[i]["descripcion"].ToString();
                    funcionalidad.Habilitado = Convert.ToInt32(Datos.Rows[i]["habilitado"]);
                    funcionalidades.Add(funcionalidad);
                }
            }
            return funcionalidades;
        }

        public static void CargarFuncionalidades(DataGridView tablaFuncionalidades)
        {
            tablaFuncionalidades.DataSource = CapaNegocio.NRol.ObtenerFuncionalidades();
        }

        public static void CargarFuncionalidades(DataGridView tablaFuncionalidades, Rol rol)
        {
            tablaFuncionalidades.DataSource = CapaNegocio.NRol.ObtenerFuncionalidades(rol.Id);

            foreach (DataGridViewRow fila in tablaFuncionalidades.Rows)
            {
                DataGridViewCheckBoxCell check = fila.Cells["Elegir"] as DataGridViewCheckBoxCell;
                bool habilitado = Convert.ToBoolean(fila.Cells["habilitado"].Value);
                if (habilitado)
                    check.Value = true;
                else
                    check.Value = false;
            }

            tablaFuncionalidades.Columns["habilitado"].Visible = false; // ojo esto es para las tablas de funcionalidad por rol
        }

        public static void CargarFuncionalidadesHabilitadas(ComboBox cbxFuncionalidades, Rol rol)
        {
            foreach (Funcionalidad funcionalidad in rol.Funcionalidades)
            {
                if (Convert.ToBoolean(funcionalidad.Habilitado))
                    cbxFuncionalidades.Items.Add(funcionalidad.Descripcion);
            }
        }

        public static void OcultarColumnasFuncionalidades(DataGridView tablaFuncionalidades)
        {
            tablaFuncionalidades.Columns["id_funcionalidad"].Visible = false;
        }

        public static void BuscarRolPorNombre(DataGridView tablaRoles, string RolNombre)
        {
            tablaRoles.DataSource = CapaNegocio.NRol.buscarRoles(RolNombre);
        }

        public static void CargarRoles(DataGridView tablaRoles)
        {
            tablaRoles.DataSource = CapaNegocio.NRol.ObtenerRoles();
        }

        public static void OcultarColumnasRoles(DataGridView tablaRoles)
        {
            tablaRoles.Columns["id_rol"].Visible = false;
        }

        public static bool ChequearItemSeleccionado(DataGridView tablaFuncionalidades)
        {
            bool resultado;
            resultado = false;
            foreach (DataGridViewRow fila in tablaFuncionalidades.Rows)
            {
                DataGridViewCheckBoxCell check = fila.Cells["Elegir"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(check.Value)) 
                    resultado = true;
            }
            return resultado;
        }

        public static string AgregarRol(string nombreRol, DataGridView tablaFuncionalidades)
        {
            string respuesta = CapaNegocio.NRol.AgregarRol(nombreRol);
            Rol Rol = CapaInterfaz.IRol.obtenerRol(nombreRol);
            foreach (DataGridViewRow fila in tablaFuncionalidades.Rows)
            {
                DataGridViewCheckBoxCell check = fila.Cells["Elegir"] as DataGridViewCheckBoxCell;
                int idFuncionalidad = System.Convert.ToInt32(fila.Cells[1].Value);
                if (Convert.ToBoolean(check.Value))
                    CapaNegocio.NRol.AgregarRolFuncionalidad(Rol.Id, idFuncionalidad, 1); // habilitado
                else
                    CapaNegocio.NRol.AgregarRolFuncionalidad(Rol.Id, idFuncionalidad, 0); // deshabilitado
            }
            return respuesta;
        }

        public static string ActualizarRol(Rol rol, DataGridView tablaFuncionalidades)
        {
            if(rol.Nombre.Equals(string.Empty) || rol.Estado.Equals(string.Empty))
                return "No se ha establecido un nombre o un estado al rol";
            
            if(!CapaInterfaz.Validador.EsSoloLetras(rol.Nombre))
                return "El nombre debe contener unicamente caracteres";

            if(!CapaInterfaz.Validador.EsSoloLetras(rol.Estado))
                return "El estado es invalido";

            if(rol.Estado.Equals("habilitado"))
                rol.Habilitado = 1;
            else
                rol.Habilitado = 0;

            string msj;
            
            msj = CapaNegocio.NRol.ActualizarRol(rol);

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (DataGridViewRow fila in tablaFuncionalidades.Rows)
            {
                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.Id = Convert.ToInt32(fila.Cells["id_funcionalidad"].Value);
                funcionalidad.Descripcion = fila.Cells["descripcion"].Value.ToString();
                DataGridViewCheckBoxCell celdaCheck = fila.Cells["Elegir"] as DataGridViewCheckBoxCell;
                funcionalidad.Habilitado = Convert.ToInt32(celdaCheck.Value);
                msj = CapaNegocio.NRol.ActualizarRolFuncionalidad(rol, funcionalidad);
            }

            rol.Funcionalidades = funcionalidades;

            return msj;
        }
    }
}
