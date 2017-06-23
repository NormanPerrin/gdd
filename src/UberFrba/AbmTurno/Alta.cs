using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Globalization;

namespace UberFrba.AbmTurno
{
    public partial class Alta : Form
    {

        private TextInfo textInfo;
        private Turno turno;
        
        public Alta()
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.comboHInicio.SelectedIndex = -1;
            this.comboHFin.SelectedIndex = -1;
            this.textDescripcion.Text = "";
            this.numericBase.Value = 0;
            this.numericValorKm.Value = 0;
            this.comboHabilitado.SelectedIndex = -1;
        }



        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
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


            string respuesta = CapaInterfaz.ITurno.Alta(this.turno);

            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }
    }
}
