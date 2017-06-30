using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.AbmAuto
{
    public partial class Edicion : Form
    {
        int idAuto;
        int idTurno;
        int idChofer;
        int newidTurno;
        int newidChofer;
        string licenciaVieja;
        string rodadoViejo;
        int habilitado;

        public Edicion(int id, int idChofer, string nomC, string apeC,int idTurno, string descT, string lic, string rod, int hab)
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);
            this.licenciaVieja = lic;
            this.rodadoViejo = rod;
            this.idAuto = id;
            this.habilitado = hab;
            this.idChofer = idChofer;
            this.idTurno = idTurno;

            this.txtApellidoChofer.Text = apeC;
            this.txtNombreChofer.Text = nomC;
            this.txtTurno.Text = descT;
            this.txtLicenciaVieja.Text = this.licenciaVieja;
            this.txtRodadoViejo.Text = this.rodadoViejo;

            CapaInterfaz.IAuto.CargarTurnos(this.tablaTurno);
            CapaInterfaz.IAuto.CargarChoferes(this.tablaChofer);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaTurno, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer, 1);
        }

        #region Acciones/Eventos


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtNewLicencia.Text)) this.txtNewLicencia.Text = licenciaVieja;
            if (string.IsNullOrWhiteSpace(this.txtNewRodado.Text)) this.txtNewRodado.Text = rodadoViejo;

            string respuesta = CapaInterfaz.IAuto.modificacion(idAuto, this.txtNewLicencia.Text, this.txtNewRodado.Text);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (habilitado == 0)
            {
                CapaInterfaz.Decoracion.mostrarInfo("Este auto ya se encuentra deshabilitado");
            }
            else
            {
                string respuesta = CapaInterfaz.IAuto.baja(idAuto);
                CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            }
            this.Close();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (habilitado == 1)
            { 
                CapaInterfaz.Decoracion.mostrarInfo("Este auto ya se encuentra habilitado"); 
            }
            else
            {
                string respuesta = CapaInterfaz.IAuto.alta(idAuto);
                CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            }
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGuardarChofer_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.IAuto.modificarChofer(this.idAuto ,this.newidChofer,this.idTurno);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void txtGuardarTurno_Click(object sender, EventArgs e)
        {
            string respuesta = CapaInterfaz.IAuto.modificarTurno(this.idAuto, this.idChofer, this.newidTurno);
            CapaInterfaz.Decoracion.mostrarInfo(respuesta);
            this.Close();
        }

        private void tablaChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
                //ID DEL NUEVO CHOFER HECHO POR DATAGRID
                this.newidChofer = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }

        private void tablaTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                System.Windows.Forms.DataGridViewCell selectedCell = this.tablaTurno[0, e.RowIndex];
                //ID DEL NUEVO TURNO HECHO POR DATAGRID
                this.newidTurno = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }

       
    }
}
