using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Text.RegularExpressions;

namespace UberFrba.AbmCliente
{
    public partial class Modificacion : Form
    {

        TextInfo textInfo;
        Cliente cliente;

        public Modificacion()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.textInfo = new CultureInfo("en-US", false).TextInfo;
            this.calendario.MaxSelectionCount = 1;
            this.calendario.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.calendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.comboHabilitado.Items.Add("Habilitado");
            this.comboHabilitado.Items.Add("Deshabilitado");
            this.comboHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente = new Entidades.Cliente();
        }

        private void textNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textAlfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
                this.calendario.Show();
                this.calendario.BringToFront();
                this.calendario.Select();

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textFN.Text = calendario.SelectionRange.Start.ToShortDateString();
            calendario.Hide();
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            this.calendario.Hide();
        }

        private void btnBusquedaClick(object sender, EventArgs e)
        {
            cliente.Nombre = this.textNombreB.Text;
            cliente.Apellido = this.textApellidoB.Text;
            int i;
            int.TryParse( this.textDNIB.Text, out i );
            cliente.Dni = i;
            CapaInterfaz.ICliente.BusquedaCliente(this.clientesGrid, cliente);
            if (this.clientesGrid.Rows.Count == 0)
            {
                this.deshabilitarCampos();
                this.limpiarCampos();
            }
        }

        public void limpiarCampos()
        {

            this.textDNI.Text = "";
            this.textNombre.Text = "";
            this.textApellido.Text = "";
            this.textMail.Text = "";
            this.textFN.Text = "";
            this.textCalle.Text = "";
            this.textPiso.Text = "";
            this.textDpto.Text = "";
            this.textTel.Text = "";
            this.textCP.Text = "";
            this.comboHabilitado.SelectedIndex = -1;

        }

        public void habilitarCampos()
        {
            this.textDNI.Enabled = true;
            this.textNombre.Enabled = true;
            this.textApellido.Enabled = true;
            this.textMail.Enabled = true;
            this.buttonFecha.Enabled = true;
            this.textFN.Enabled = true;
            this.textCalle.Enabled = true;
            this.textPiso.Enabled = true;
            this.textDpto.Enabled = true;
            this.textTel.Enabled = true;
            this.textCP.Enabled = true;
            this.comboHabilitado.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.textLoc.Enabled = true;

        }

        public void deshabilitarCampos()
        {
            this.textDNI.Enabled = false;
            this.textNombre.Enabled = false;
            this.textApellido.Enabled = false;
            this.textMail.Enabled = false;
            this.buttonFecha.Enabled = false;
            this.textFN.Enabled = false;
            this.textCalle.Enabled = false;
            this.textPiso.Enabled = false;
            this.textDpto.Enabled = false;
            this.textTel.Enabled = false;
            this.textCP.Enabled = false;
            this.comboHabilitado.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.textLoc.Enabled = false;
        }

        private void clientesGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                cliente.Id_cliente = Convert.ToInt32(this.clientesGrid.CurrentRow.Cells["id_cliente"].Value);
                habilitarCampos();

                this.textDNI.Text = this.clientesGrid.CurrentRow.Cells["dni"].Value.ToString();
                this.textNombre.Text = this.clientesGrid.CurrentRow.Cells["nombre"].Value.ToString();
                this.textApellido.Text = this.clientesGrid.CurrentRow.Cells["apellido"].Value.ToString();
                this.textMail.Text = this.clientesGrid.CurrentRow.Cells["mail"].Value.ToString();
                this.textFN.Text = Convert.ToDateTime(this.clientesGrid.CurrentRow.Cells["fecha_nac"].Value).ToShortDateString();
                this.calendario.SetDate(Convert.ToDateTime(this.clientesGrid.CurrentRow.Cells["fecha_nac"].Value));
                this.textCalle.Text = this.clientesGrid.CurrentRow.Cells["direccion"].Value.ToString();
                this.textPiso.Text = this.clientesGrid.CurrentRow.Cells["nro_piso"].Value.ToString();
                this.textDpto.Text = this.clientesGrid.CurrentRow.Cells["depto"].Value.ToString();
                this.textTel.Text = this.clientesGrid.CurrentRow.Cells["telefono"].Value.ToString();
                this.textLoc.Text = this.clientesGrid.CurrentRow.Cells["localidad"].Value.ToString();
                this.textCP.Text = this.clientesGrid.CurrentRow.Cells["cod_postal"].Value.ToString();
                this.comboHabilitado.SelectedIndex = comboHabilitado.FindStringExact(this.clientesGrid.CurrentRow.Cells["habilitado"].Value.ToString());
            }
            catch (Exception ex)
            {
                Exception exje = ex; 
                return;
            }
             
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.textNombre.Text = this.textInfo.ToTitleCase(this.textNombre.Text);
            this.textApellido.Text = this.textInfo.ToTitleCase(this.textApellido.Text);
            this.textCalle.Text = this.textInfo.ToTitleCase(this.textCalle.Text);
            this.textLoc.Text = this.textInfo.ToTitleCase(this.textLoc.Text);

            if (String.IsNullOrEmpty(textNombre.Text) || String.IsNullOrEmpty(textApellido.Text) || String.IsNullOrEmpty(textTel.Text) || String.IsNullOrEmpty(textDNI.Text) || String.IsNullOrEmpty(textFN.Text) || String.IsNullOrEmpty(textCalle.Text) || String.IsNullOrEmpty(textLoc.Text) || String.IsNullOrEmpty(textCP.Text) || this.comboHabilitado.SelectedIndex == -1)
            {
                CapaInterfaz.Decoracion.mostrarInfo("Por favor complete los campos obligatorios");
                return;
            }

            bool isEmail = Regex.IsMatch(textMail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail && !String.IsNullOrEmpty(textMail.Text))
            {
                CapaInterfaz.Decoracion.mostrarInfo("Formato de E-Mail no válido");
                return;
            }
 
            string respuesta = CapaInterfaz.ICliente.modificacion(
                this.cliente.asignarCliente(
                int.Parse(this.textDNI.Text),
                this.textNombre.Text,
                this.textApellido.Text,
                this.textMail.Text,
                int.Parse(this.textTel.Text),
                Convert.ToDateTime(this.textFN.Text),
                this.textCalle.Text,
                this.comboHabilitado.GetItemText(this.comboHabilitado.SelectedItem).Equals("Habilitado"),
                Entidades.Cliente.Piso(this.textPiso.Text),
                Entidades.Cliente.Dpto(this.textDpto.Text),
                this.textLoc.Text,
                int.Parse(this.textCP.Text)

                ));


            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.ICliente.eliminar(this.cliente.Id_cliente);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
