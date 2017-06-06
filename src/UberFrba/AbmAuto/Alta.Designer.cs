namespace UberFrba.AbmAuto
{
    partial class Alta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAlta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.TxtPatente = new System.Windows.Forms.TextBox();
            this.LbelPatente = new System.Windows.Forms.Label();
            this.LbelMarca = new System.Windows.Forms.Label();
            this.LbelModelo = new System.Windows.Forms.Label();
            this.LbelTurno = new System.Windows.Forms.Label();
            this.LbelChofer = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.tablaTurno = new System.Windows.Forms.DataGridView();
            this.tablaChofer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(253, 404);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(100, 32);
            this.BtnAlta.TabIndex = 0;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(22, 404);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 32);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Atras";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // TxtPatente
            // 
            this.TxtPatente.Location = new System.Drawing.Point(87, 101);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(170, 20);
            this.TxtPatente.TabIndex = 2;
            // 
            // LbelPatente
            // 
            this.LbelPatente.AutoSize = true;
            this.LbelPatente.Location = new System.Drawing.Point(38, 104);
            this.LbelPatente.Name = "LbelPatente";
            this.LbelPatente.Size = new System.Drawing.Size(47, 13);
            this.LbelPatente.TabIndex = 3;
            this.LbelPatente.Text = "Patente:";
            // 
            // LbelMarca
            // 
            this.LbelMarca.AutoSize = true;
            this.LbelMarca.Location = new System.Drawing.Point(45, 34);
            this.LbelMarca.Name = "LbelMarca";
            this.LbelMarca.Size = new System.Drawing.Size(40, 13);
            this.LbelMarca.TabIndex = 4;
            this.LbelMarca.Text = "Marca:";
            // 
            // LbelModelo
            // 
            this.LbelModelo.AutoSize = true;
            this.LbelModelo.Location = new System.Drawing.Point(41, 67);
            this.LbelModelo.Name = "LbelModelo";
            this.LbelModelo.Size = new System.Drawing.Size(45, 13);
            this.LbelModelo.TabIndex = 5;
            this.LbelModelo.Text = "Modelo:";
            // 
            // LbelTurno
            // 
            this.LbelTurno.AutoSize = true;
            this.LbelTurno.Location = new System.Drawing.Point(47, 143);
            this.LbelTurno.Name = "LbelTurno";
            this.LbelTurno.Size = new System.Drawing.Size(38, 13);
            this.LbelTurno.TabIndex = 6;
            this.LbelTurno.Text = "Turno:";
            this.LbelTurno.Click += new System.EventHandler(this.LbelTurno_Click);
            // 
            // LbelChofer
            // 
            this.LbelChofer.AutoSize = true;
            this.LbelChofer.Location = new System.Drawing.Point(44, 273);
            this.LbelChofer.Name = "LbelChofer";
            this.LbelChofer.Size = new System.Drawing.Size(41, 13);
            this.LbelChofer.TabIndex = 7;
            this.LbelChofer.Text = "Chofer:";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(87, 31);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(170, 20);
            this.TxtMarca.TabIndex = 8;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(87, 64);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(170, 20);
            this.TxtModelo.TabIndex = 9;
            // 
            // tablaTurno
            // 
            this.tablaTurno.AllowUserToAddRows = false;
            this.tablaTurno.AllowUserToDeleteRows = false;
            this.tablaTurno.AllowUserToOrderColumns = true;
            this.tablaTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTurno.Location = new System.Drawing.Point(87, 143);
            this.tablaTurno.Name = "tablaTurno";
            this.tablaTurno.ReadOnly = true;
            this.tablaTurno.Size = new System.Drawing.Size(240, 105);
            this.tablaTurno.TabIndex = 10;
            this.tablaTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTurno_CellContentClick);
            // 
            // tablaChofer
            // 
            this.tablaChofer.AllowUserToAddRows = false;
            this.tablaChofer.AllowUserToDeleteRows = false;
            this.tablaChofer.AllowUserToOrderColumns = true;
            this.tablaChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaChofer.Location = new System.Drawing.Point(87, 273);
            this.tablaChofer.Name = "tablaChofer";
            this.tablaChofer.ReadOnly = true;
            this.tablaChofer.Size = new System.Drawing.Size(240, 111);
            this.tablaChofer.TabIndex = 11;
            this.tablaChofer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaChofer_CellContentClick);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 454);
            this.Controls.Add(this.tablaChofer);
            this.Controls.Add(this.tablaTurno);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.LbelChofer);
            this.Controls.Add(this.LbelTurno);
            this.Controls.Add(this.LbelModelo);
            this.Controls.Add(this.LbelMarca);
            this.Controls.Add(this.LbelPatente);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.BtnAlta);
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void LbelTurno_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox TxtPatente;
        private System.Windows.Forms.Label LbelPatente;
        private System.Windows.Forms.Label LbelMarca;
        private System.Windows.Forms.Label LbelModelo;
        private System.Windows.Forms.Label LbelTurno;
        private System.Windows.Forms.Label LbelChofer;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.DataGridView tablaTurno;
        private System.Windows.Forms.DataGridView tablaChofer;
    }
}