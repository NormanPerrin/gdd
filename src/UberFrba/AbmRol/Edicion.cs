using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmRol
{
    public partial class Edicion : Form
    {
        private int idRol;
        private string rolNombreViejo;
        private string rolEstadoViejo;

        public Edicion(int id, string nombre, string estado)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.rolNombreViejo = nombre;
            this.rolEstadoViejo = estado;
            this.idRol = id;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtRolNombreNuevo.Text = string.Empty;
            cbxRolEstadoNuevo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtRolNombreNuevo.Text.Equals(this.rolNombreViejo) || this.txtRolNombreNuevo.Text.Equals(String.Empty)) // si tiene el mismo nombre..
            {
                if (this.cbxRolEstadoNuevo.Text.Equals(this.rolEstadoViejo)) // si tiene el mismo estado...
                    CapaInterfaz.Decoracion.mostrarInfo("No se estan generando cambios en relacion a los datos viejos"); // no hago ningun cambio
                else
                    CapaInterfaz.IRol.ActualizarRol(this.idRol, this.rolNombreViejo, this.cbxRolEstadoNuevo.Text); // actualizo solo el estado
            }
            else // si no tiene el mismo nombre
            {
                if (this.cbxRolEstadoNuevo.Text.Equals(this.rolEstadoViejo)) // si tiene el mismo estado...
                    CapaInterfaz.IRol.ActualizarRol(this.idRol, this.txtRolNombreNuevo.Text, this.rolEstadoViejo); // actualizo solo el nombre
                else
                    CapaInterfaz.IRol.ActualizarRol(this.idRol, this.txtRolNombreNuevo.Text, this.cbxRolEstadoNuevo.Text); // actualizo todo
            }
        }

        private void Edicion_Load(object sender, EventArgs e)
        {
            this.txtRolNombreViejo.Text = this.rolNombreViejo;
            this.txtRolEstadoViejo.Text = this.rolEstadoViejo;
            cbxRolEstadoNuevo.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
