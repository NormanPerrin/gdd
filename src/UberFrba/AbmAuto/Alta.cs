﻿using System;
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
    public partial class Alta : Form
    {
        public int idChofer;
        public int modelo;
        public int turno;
        public int marca;

        public Alta()
        {
            InitializeComponent();
            CapaInterfaz.Decoracion.Reorganizar(this);

            CapaInterfaz.IAuto.CargarTurnos(this.tablaTurno);
            CapaInterfaz.IAuto.CargarChoferes(this.tablaChofer);
            CapaInterfaz.IAuto.CargarMarca(this.tablaMarca);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaTurno, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaChofer, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca, 0);
            CapaInterfaz.IAuto.OcultarColumnas(this.tablaMarca, 2);
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            idChofer = 0;
            turno = 0;
            marca = 0;
            modelo = 0;
            if (this.tablaChofer.CurrentRow != null)
            { idChofer = Convert.ToInt32(this.tablaChofer.CurrentRow.Cells[0].Value); }
            if (this.tablaTurno.CurrentRow != null)
            { turno = Convert.ToInt32(this.tablaTurno.CurrentRow.Cells[0].Value); }
            if (this.tablaMarca.CurrentRow != null)
            { modelo = Convert.ToInt32(this.tablaMarca.CurrentRow.Cells[0].Value); }
            if (this.tablaMarca.CurrentRow != null)
            { marca = Convert.ToInt32(this.tablaMarca.CurrentRow.Cells[2].Value); }
            
                //chequeo patente vacia
                if (string.IsNullOrWhiteSpace(TxtPatente.Text))
                {
                    CapaInterfaz.Decoracion.mostrarInfo("La patente no puede ser vacia");
                }
                else if (turno == 0 || idChofer == 0 || marca == 0)
                {
                    CapaInterfaz.Decoracion.mostrarInfo("Selecciona otra vez valores en TODOS los campos");
                }else
                {
                    string respuesta = CapaInterfaz.IAuto.alta(marca, modelo, TxtPatente.Text, turno, idChofer);
                    CapaInterfaz.Decoracion.mostrarInfo(respuesta);
                    this.Close();
                }
          
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numMarca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tablaChofer_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
              //  System.Windows.Forms.DataGridViewCell selectedCell = this.tablaChofer[0, e.RowIndex];
              //  idChofer = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }

        private void tablaMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
             //  System.Windows.Forms.DataGridViewCell selectedCell = this.tablaMarca[0, e.RowIndex];
             //   modelo = Convert.ToInt32(selectedCell.FormattedValue);

             //   System.Windows.Forms.DataGridViewCell selectedCell2 = this.tablaMarca[2, e.RowIndex];
             //   marca = Convert.ToInt32(selectedCell2.FormattedValue);
            }
        }

        private void tablaTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
           // System.Windows.Forms.DataGridViewCell selectedCell = this.tablaTurno[0, e.RowIndex];
           // turno = Convert.ToInt32(selectedCell.FormattedValue);
            }
        }

    }
}
