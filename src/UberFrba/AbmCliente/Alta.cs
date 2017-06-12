using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmCliente
{
    public partial class Alta : Form
    {
        #region Atributos

            TextInfo textInfo;

        #endregion

        #region Constructores

            public Alta()
            {
                InitializeComponent();
                CapaInterfaz.Decoracion.Reorganizar(this);
                this.textInfo = new CultureInfo("en-US", false).TextInfo;
                this.calendario.MaxSelectionCount = 1;
                this.calendario.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
                this.calendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);

            }

        #endregion

        private void button4_Click(object sender, EventArgs e)
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

         /*Validación para campos no numericos*/
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        /* Validación para campos numéricos*/
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            this.textNombre.Text = this.textInfo.ToTitleCase(this.textNombre.Text);
            this.textApellido.Text = this.textInfo.ToTitleCase(this.textApellido.Text);
            this.textCalle.Text = this.textInfo.ToTitleCase(this.textCalle.Text);
            this.textLoc.Text = this.textInfo.ToTitleCase(this.textLoc.Text);

            if (String.IsNullOrEmpty(textNombre.Text) || String.IsNullOrEmpty(textApellido.Text) || String.IsNullOrEmpty(textTel.Text) || String.IsNullOrEmpty(textDNI.Text) || String.IsNullOrEmpty(textFN.Text) || String.IsNullOrEmpty(textCalle.Text) || String.IsNullOrEmpty(textLoc.Text) || String.IsNullOrEmpty(textCP.Text))
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
            
/*
            if (!CapaInterfaz.Validador.EsMail(textMail.Text) || CapaInterfaz.Validador.EsCadenaVaciaONula(textMail.Text))
            {
                CapaInterfaz.Decoracion.mostrarInfo("Formato de E-Mail no válido");
                return;
            }
            */
            int nro_piso;

            string respuesta = CapaInterfaz.ICliente.alta(int.Parse(this.textDNI.Text), this.textNombre.Text, this.textApellido.Text, this.textCalle.Text, this.textMail.Text, int.Parse(this.textTel.Text), Convert.ToDateTime(this.textFN.Text), Entidades.Cliente.Piso(this.textPiso.Text), Entidades.Cliente.Dpto(this.textDpto.Text), this.textLoc.Text, int.Parse(this.textCP.Text));
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            this.textApellido.Clear();
            this.textNombre.Clear();
            this.textCP.Clear();
            this.textDNI.Clear();
            this.textDpto.Clear();
            this.textFN.Clear();
            this.textLoc.Clear();
            this.textPiso.Clear();
            this.textTel.Clear();
            this.textMail.Clear();
            this.textCalle.Clear();
        }

     
    }
}
