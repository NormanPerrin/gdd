namespace UberFrba.AbmTurno
{
    partial class Modificacion
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
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboHabilitado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboHFin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericBase = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericValorKm = new System.Windows.Forms.NumericUpDown();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboHInicio = new System.Windows.Forms.ComboBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.turnoGrid = new System.Windows.Forms.DataGridView();
            this.textDescBus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(348, 412);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Enabled = false;
            this.buttonMod.Location = new System.Drawing.Point(186, 412);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 5;
            this.buttonMod.Text = "Modificar";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboHabilitado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboHFin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericBase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericValorKm);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboHInicio);
            this.groupBox1.Location = new System.Drawing.Point(15, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese todos los campos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Habilitado:";
            // 
            // comboHabilitado
            // 
            this.comboHabilitado.Enabled = false;
            this.comboHabilitado.FormattingEnabled = true;
            this.comboHabilitado.Location = new System.Drawing.Point(81, 91);
            this.comboHabilitado.Name = "comboHabilitado";
            this.comboHabilitado.Size = new System.Drawing.Size(123, 21);
            this.comboHabilitado.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hora Fin:";
            // 
            // comboHFin
            // 
            this.comboHFin.Enabled = false;
            this.comboHFin.FormattingEnabled = true;
            this.comboHFin.Location = new System.Drawing.Point(335, 57);
            this.comboHFin.Name = "comboHFin";
            this.comboHFin.Size = new System.Drawing.Size(51, 21);
            this.comboHFin.TabIndex = 14;
            this.comboHFin.SelectionChangeCommitted += new System.EventHandler(this.comboHFin_SelectectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Km:";
            // 
            // numericBase
            // 
            this.numericBase.BackColor = System.Drawing.SystemColors.Control;
            this.numericBase.DecimalPlaces = 2;
            this.numericBase.Enabled = false;
            this.numericBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericBase.Location = new System.Drawing.Point(81, 58);
            this.numericBase.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericBase.Name = "numericBase";
            this.numericBase.ReadOnly = true;
            this.numericBase.Size = new System.Drawing.Size(54, 20);
            this.numericBase.TabIndex = 8;
            this.numericBase.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio Base:";
            // 
            // numericValorKm
            // 
            this.numericValorKm.BackColor = System.Drawing.SystemColors.Control;
            this.numericValorKm.DecimalPlaces = 2;
            this.numericValorKm.Enabled = false;
            this.numericValorKm.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericValorKm.Location = new System.Drawing.Point(205, 58);
            this.numericValorKm.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericValorKm.Name = "numericValorKm";
            this.numericValorKm.ReadOnly = true;
            this.numericValorKm.Size = new System.Drawing.Size(54, 20);
            this.numericValorKm.TabIndex = 6;
            this.numericValorKm.ThousandsSeparator = true;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Enabled = false;
            this.textDescripcion.Location = new System.Drawing.Point(81, 24);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(178, 20);
            this.textDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora Inicio:";
            // 
            // comboHInicio
            // 
            this.comboHInicio.Enabled = false;
            this.comboHInicio.FormattingEnabled = true;
            this.comboHInicio.Location = new System.Drawing.Point(335, 24);
            this.comboHInicio.Name = "comboHInicio";
            this.comboHInicio.Size = new System.Drawing.Size(51, 21);
            this.comboHInicio.TabIndex = 0;
            this.comboHInicio.SelectionChangeCommitted += new System.EventHandler(this.comboHInicio_SelectectionChangeCommitted);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Enabled = false;
            this.buttonBorrar.Location = new System.Drawing.Point(267, 412);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 6;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Busqueda por Descripción:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(347, 24);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // turnoGrid
            // 
            this.turnoGrid.AllowUserToAddRows = false;
            this.turnoGrid.AllowUserToDeleteRows = false;
            this.turnoGrid.AllowUserToOrderColumns = true;
            this.turnoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnoGrid.Location = new System.Drawing.Point(12, 198);
            this.turnoGrid.Name = "turnoGrid";
            this.turnoGrid.ReadOnly = true;
            this.turnoGrid.Size = new System.Drawing.Size(410, 202);
            this.turnoGrid.TabIndex = 11;
            this.turnoGrid.SelectionChanged += new System.EventHandler(this.turnoGrid_SelectionChanged);
            // 
            // textDescBus
            // 
            this.textDescBus.Location = new System.Drawing.Point(153, 26);
            this.textDescBus.Name = "textDescBus";
            this.textDescBus.Size = new System.Drawing.Size(188, 20);
            this.textDescBus.TabIndex = 12;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 446);
            this.Controls.Add(this.textDescBus);
            this.Controls.Add(this.turnoGrid);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboHabilitado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboHFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboHInicio;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView turnoGrid;
        private System.Windows.Forms.TextBox textDescBus;
        private System.Windows.Forms.NumericUpDown numericBase;
        private System.Windows.Forms.NumericUpDown numericValorKm;
    }
}