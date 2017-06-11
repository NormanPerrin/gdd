namespace UberFrba
{
    partial class RendicionViajes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaViaje = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbelChofer = new System.Windows.Forms.Label();
            this.LbelTurno = new System.Windows.Forms.Label();
            this.tablaChofer = new System.Windows.Forms.DataGridView();
            this.tablaTurno = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViaje)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaViaje);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 574);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendicion de viajes (pago al chofer)";
            // 
            // tablaViaje
            // 
            this.tablaViaje.AllowUserToAddRows = false;
            this.tablaViaje.AllowUserToDeleteRows = false;
            this.tablaViaje.AllowUserToOrderColumns = true;
            this.tablaViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaViaje.Location = new System.Drawing.Point(19, 317);
            this.tablaViaje.MultiSelect = false;
            this.tablaViaje.Name = "tablaViaje";
            this.tablaViaje.ReadOnly = true;
            this.tablaViaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaViaje.Size = new System.Drawing.Size(411, 177);
            this.tablaViaje.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImporte);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LbelChofer);
            this.groupBox2.Controls.Add(this.LbelTurno);
            this.groupBox2.Controls.Add(this.tablaChofer);
            this.groupBox2.Controls.Add(this.tablaTurno);
            this.groupBox2.Controls.Add(this.fecha);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(19, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 521);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criterio de busqueda:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(92, 476);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(178, 20);
            this.txtImporte.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Rendir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Importe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha:";
            // 
            // LbelChofer
            // 
            this.LbelChofer.AutoSize = true;
            this.LbelChofer.Location = new System.Drawing.Point(18, 154);
            this.LbelChofer.Name = "LbelChofer";
            this.LbelChofer.Size = new System.Drawing.Size(41, 13);
            this.LbelChofer.TabIndex = 18;
            this.LbelChofer.Text = "Chofer:";
            // 
            // LbelTurno
            // 
            this.LbelTurno.AutoSize = true;
            this.LbelTurno.Location = new System.Drawing.Point(18, 56);
            this.LbelTurno.Name = "LbelTurno";
            this.LbelTurno.Size = new System.Drawing.Size(38, 13);
            this.LbelTurno.TabIndex = 17;
            this.LbelTurno.Text = "Turno:";
            // 
            // tablaChofer
            // 
            this.tablaChofer.AllowUserToAddRows = false;
            this.tablaChofer.AllowUserToDeleteRows = false;
            this.tablaChofer.AllowUserToOrderColumns = true;
            this.tablaChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaChofer.Location = new System.Drawing.Point(92, 154);
            this.tablaChofer.MultiSelect = false;
            this.tablaChofer.Name = "tablaChofer";
            this.tablaChofer.ReadOnly = true;
            this.tablaChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaChofer.Size = new System.Drawing.Size(280, 94);
            this.tablaChofer.TabIndex = 16;
            this.tablaChofer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaChofer_CellContentClick);
            // 
            // tablaTurno
            // 
            this.tablaTurno.AllowUserToAddRows = false;
            this.tablaTurno.AllowUserToDeleteRows = false;
            this.tablaTurno.AllowUserToOrderColumns = true;
            this.tablaTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            this.tablaTurno.Location = new System.Drawing.Point(92, 56);
            this.tablaTurno.MultiSelect = false;
            this.tablaTurno.Name = "tablaTurno";
            this.tablaTurno.ReadOnly = true;
            this.tablaTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTurno.Size = new System.Drawing.Size(280, 85);
            this.tablaTurno.TabIndex = 15;
            this.tablaTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTurno_CellContentClick);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(92, 30);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(280, 20);
            this.fecha.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(297, 254);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RendicionViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 607);
            this.Controls.Add(this.groupBox1);
            this.Name = "RendicionViajes";
            this.Text = "RendicionViajes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaViaje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaViaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tablaTurno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
        private System.Windows.Forms.DataGridView tablaChofer;
        private System.Windows.Forms.Label LbelTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbelChofer;
        private System.Windows.Forms.TextBox txtImporte;
    }
}