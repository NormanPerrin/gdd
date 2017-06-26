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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablaTurno = new System.Windows.Forms.DataGridView();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.tablaViaje = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbelChofer = new System.Windows.Forms.Label();
            this.LbelTurno = new System.Windows.Forms.Label();
            this.tablaChofer = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaChofer2 = new System.Windows.Forms.DataGridView();
            this.tablaViajes2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.importe2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajes2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 595);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendicion de viajes (pago al chofer)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tablaTurno);
            this.groupBox2.Controls.Add(this.txtImporte);
            this.groupBox2.Controls.Add(this.tablaViaje);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LbelChofer);
            this.groupBox2.Controls.Add(this.LbelTurno);
            this.groupBox2.Controls.Add(this.tablaChofer);
            this.groupBox2.Controls.Add(this.fecha);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 496);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criterio de busqueda:";
            // 
            // tablaTurno
            // 
            this.tablaTurno.AllowUserToAddRows = false;
            this.tablaTurno.AllowUserToDeleteRows = false;
            this.tablaTurno.AllowUserToOrderColumns = true;
            this.tablaTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTurno.Location = new System.Drawing.Point(59, 56);
            this.tablaTurno.MultiSelect = false;
            this.tablaTurno.Name = "tablaTurno";
            this.tablaTurno.ReadOnly = true;
            this.tablaTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTurno.Size = new System.Drawing.Size(393, 89);
            this.tablaTurno.TabIndex = 24;
            this.tablaTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTurno_CellContentClick_1);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(62, 467);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(178, 20);
            this.txtImporte.TabIndex = 23;
            // 
            // tablaViaje
            // 
            this.tablaViaje.AllowUserToAddRows = false;
            this.tablaViaje.AllowUserToDeleteRows = false;
            this.tablaViaje.AllowUserToOrderColumns = true;
            this.tablaViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaViaje.Location = new System.Drawing.Point(0, 275);
            this.tablaViaje.MultiSelect = false;
            this.tablaViaje.Name = "tablaViaje";
            this.tablaViaje.ReadOnly = true;
            this.tablaViaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaViaje.Size = new System.Drawing.Size(463, 177);
            this.tablaViaje.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 464);
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
            this.label2.Location = new System.Drawing.Point(12, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Importe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha:";
            // 
            // LbelChofer
            // 
            this.LbelChofer.AutoSize = true;
            this.LbelChofer.Location = new System.Drawing.Point(15, 190);
            this.LbelChofer.Name = "LbelChofer";
            this.LbelChofer.Size = new System.Drawing.Size(41, 13);
            this.LbelChofer.TabIndex = 18;
            this.LbelChofer.Text = "Chofer:";
            // 
            // LbelTurno
            // 
            this.LbelTurno.AutoSize = true;
            this.LbelTurno.Location = new System.Drawing.Point(15, 92);
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
            this.tablaChofer.Location = new System.Drawing.Point(59, 151);
            this.tablaChofer.MultiSelect = false;
            this.tablaChofer.Name = "tablaChofer";
            this.tablaChofer.ReadOnly = true;
            this.tablaChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaChofer.Size = new System.Drawing.Size(393, 89);
            this.tablaChofer.TabIndex = 16;
            this.tablaChofer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaChofer_CellContentClick);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(62, 30);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(280, 20);
            this.fecha.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(377, 246);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 541);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rendicion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.importe2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tablaViajes2);
            this.tabPage2.Controls.Add(this.tablaChofer2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rendicion por chofer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chofer:";
            // 
            // tablaChofer2
            // 
            this.tablaChofer2.AllowUserToAddRows = false;
            this.tablaChofer2.AllowUserToDeleteRows = false;
            this.tablaChofer2.AllowUserToOrderColumns = true;
            this.tablaChofer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaChofer2.Location = new System.Drawing.Point(69, 31);
            this.tablaChofer2.MultiSelect = false;
            this.tablaChofer2.Name = "tablaChofer2";
            this.tablaChofer2.ReadOnly = true;
            this.tablaChofer2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaChofer2.Size = new System.Drawing.Size(393, 89);
            this.tablaChofer2.TabIndex = 20;
            this.tablaChofer2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaChofer2_CellContentClick);
            // 
            // tablaViajes2
            // 
            this.tablaViajes2.AllowUserToAddRows = false;
            this.tablaViajes2.AllowUserToDeleteRows = false;
            this.tablaViajes2.AllowUserToOrderColumns = true;
            this.tablaViajes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaViajes2.Location = new System.Drawing.Point(12, 258);
            this.tablaViajes2.MultiSelect = false;
            this.tablaViajes2.Name = "tablaViajes2";
            this.tablaViajes2.ReadOnly = true;
            this.tablaViajes2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaViajes2.Size = new System.Drawing.Size(463, 177);
            this.tablaViajes2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Importe:";
            // 
            // importe2
            // 
            this.importe2.Location = new System.Drawing.Point(96, 463);
            this.importe2.Name = "importe2";
            this.importe2.ReadOnly = true;
            this.importe2.Size = new System.Drawing.Size(178, 20);
            this.importe2.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RendicionViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 619);
            this.Controls.Add(this.groupBox1);
            this.Name = "RendicionViajes";
            this.Text = "RendicionViajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChofer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajes2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaViaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tablaChofer;
        private System.Windows.Forms.Label LbelTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbelChofer;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tablaTurno;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox importe2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaViajes2;
        private System.Windows.Forms.DataGridView tablaChofer2;
        private System.Windows.Forms.Label label3;
    }
}