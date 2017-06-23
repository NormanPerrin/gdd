using Entidades;
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

namespace UberFrba.AbmTurno
{
    public partial class Modificacion : Form
    {
        private TextInfo textInfo;
        private Turno turno;

        public Modificacion()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.textInfo = new CultureInfo("en-US", false).TextInfo;
            this.turno = new Turno();

            this.comboHabilitado.Items.Add("Habilitado");
            this.comboHabilitado.Items.Add("Deshabilitado");
            for (int i = 0; i <= 24; i++)
            {
                if (i != 0) this.comboHFin.Items.Add(i);
                if (i != 24) this.comboHInicio.Items.Add(i);
            }

            this.comboHInicio.SelectedIndex = -1;
            this.comboHFin.SelectedIndex = -1;
            this.comboHabilitado.SelectedIndex = -1;


            numericBase.Accelerations.Add(new NumericUpDownAcceleration(1, (decimal)0.1));
            numericBase.Accelerations.Add(new NumericUpDownAcceleration(10, (decimal)0.25));
            numericBase.Accelerations.Add(new NumericUpDownAcceleration(15, (decimal)0.5));

            this.numericValorKm.Accelerations.Add(new NumericUpDownAcceleration(1, (decimal)0.1));
            this.numericValorKm.Accelerations.Add(new NumericUpDownAcceleration(10, (decimal)0.25));
            this.numericValorKm.Accelerations.Add(new NumericUpDownAcceleration(15, (decimal)0.5));

            this.comboHFin.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboHInicio.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            turno.Descripcion = this.textDescBus.Text;

            CapaInterfaz.ITurno.BusquedaTurno(this.turnoGrid, turno);
            if (this.turnoGrid.Rows.Count == 0)
            {
                this.deshabilitarCampos();
                this.limpiarCampos();
            }
        }

        private void deshabilitarCampos()
        {
            this.textDescripcion.Enabled = false;
            this.comboHabilitado.Enabled = false;
            this.comboHFin.Enabled = false;
            this.comboHInicio.Enabled = false;
            this.numericBase.Enabled = false;
            this.numericValorKm.Enabled = false;
            this.buttonBorrar.Enabled = false;
            this.buttonMod.Enabled = false;

        }

        private void habilitarCampos()
        {
            this.textDescripcion.Enabled = true;
            this.comboHabilitado.Enabled = true;
            this.comboHFin.Enabled = true;
            this.comboHInicio.Enabled = true;
            this.numericBase.Enabled = true;
            this.numericValorKm.Enabled = true;
            this.buttonBorrar.Enabled = true;
            this.buttonMod.Enabled = true;
        }

        private void limpiarCampos()
        {
            this.comboHInicio.SelectedIndex = -1;
            this.comboHFin.SelectedIndex = -1;
            this.comboHabilitado.SelectedIndex = -1;
            this.textDescripcion.Text = "";
            this.numericBase.Value = 0;
            this.numericValorKm.Value = 0;
        }

        private void turnoGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                turno.Id_turno = Convert.ToInt32(this.turnoGrid.CurrentRow.Cells["id_turno"].Value);
                this.habilitarCampos();

                this.comboHabilitado.SelectedIndex = comboHabilitado.FindStringExact(this.turnoGrid.CurrentRow.Cells["habilitado"].Value.ToString());
                this.textDescripcion.Text = this.turnoGrid.CurrentRow.Cells["descripcion"].Value.ToString();
                this.comboHFin.SelectedIndex = this.comboHFin.FindStringExact(this.turnoGrid.CurrentRow.Cells["hora_fin"].Value.ToString());
                this.comboHInicio.SelectedIndex = this.comboHFin.FindStringExact(this.turnoGrid.CurrentRow.Cells["hora_inicio"].Value.ToString()) +1;
                this.numericBase.Value = Convert.ToDecimal(this.turnoGrid.CurrentRow.Cells["precio_base"].Value.ToString());
                this.numericValorKm.Value = Convert.ToDecimal(this.turnoGrid.CurrentRow.Cells["valor_km"].Value.ToString());

            }
            catch (Exception ex)
            {
                Exception exje = ex;
                return;
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.ITurno.eliminar(this.turno.Id_turno);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void comboHInicio_SelectectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.comboHFin.SelectedItem) <= Convert.ToInt32(this.comboHInicio.SelectedItem))
            {
                this.comboHFin.SelectedIndex = this.comboHFin.FindStringExact(this.comboHInicio.SelectedItem.ToString()) + 1;
            }
        }

        private void comboHFin_SelectectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.comboHFin.SelectedItem) <= Convert.ToInt32(this.comboHInicio.SelectedItem) && this.comboHInicio.SelectedIndex != -1)
            {
                this.comboHFin.SelectedIndex = this.comboHFin.FindStringExact(this.comboHInicio.SelectedItem.ToString()) + 1;
                CapaInterfaz.Decoracion.mostrarInfo("La hora de fin no puede ser menor o igual a la hora de inicio");
                return;
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            this.textDescripcion.Text = this.textInfo.ToTitleCase(this.textDescripcion.Text);

            if (String.IsNullOrEmpty(this.textDescripcion.Text) || this.comboHInicio.SelectedIndex == -1 || this.comboHFin.SelectedIndex == -1 || this.comboHabilitado.SelectedIndex == -1)
            {
                CapaInterfaz.Decoracion.mostrarInfo("Por favor complete los campos obligatorios");
                return;
            }

            this.turno.Descripcion = this.textDescripcion.Text;
            this.turno.Habilitado = this.comboHabilitado.GetItemText(this.comboHabilitado.SelectedItem).Equals("Habilitado");
            this.turno.Hora_inicio = Convert.ToInt32(this.comboHInicio.SelectedItem);
            this.turno.Hora_fin = Convert.ToInt32(this.comboHFin.SelectedItem);
            this.turno.Valor_km = this.numericValorKm.Value;
            this.turno.Precio_base = this.numericBase.Value;


            string respuesta = CapaInterfaz.ITurno.Modificar(this.turno);

            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }
    }
}
