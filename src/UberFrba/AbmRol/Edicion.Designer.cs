﻿namespace UberFrba.AbmRol
{
    partial class Edicion
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
            this.tablaFuncionalidades = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbxRolEstadoNuevo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRolEstadoViejo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRolNombreNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRolNombreViejo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaFuncionalidades);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.cbxRolEstadoNuevo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRolEstadoViejo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtRolNombreNuevo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRolNombreViejo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifique los datos deseados del Rol seleccionado:";
            // 
            // tablaFuncionalidades
            // 
            this.tablaFuncionalidades.AllowUserToAddRows = false;
            this.tablaFuncionalidades.AllowUserToDeleteRows = false;
            this.tablaFuncionalidades.AllowUserToOrderColumns = true;
            this.tablaFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            this.tablaFuncionalidades.Location = new System.Drawing.Point(8, 194);
            this.tablaFuncionalidades.MultiSelect = false;
            this.tablaFuncionalidades.Name = "tablaFuncionalidades";
            this.tablaFuncionalidades.ReadOnly = true;
            this.tablaFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaFuncionalidades.Size = new System.Drawing.Size(273, 179);
            this.tablaFuncionalidades.TabIndex = 11;
            this.tablaFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaFuncionalidades_CellContentClick);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(106, 386);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbxRolEstadoNuevo
            // 
            this.cbxRolEstadoNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRolEstadoNuevo.FormattingEnabled = true;
            this.cbxRolEstadoNuevo.Items.AddRange(new object[] {
            "habilitado",
            "deshabilitado"});
            this.cbxRolEstadoNuevo.Location = new System.Drawing.Point(38, 160);
            this.cbxRolEstadoNuevo.Name = "cbxRolEstadoNuevo";
            this.cbxRolEstadoNuevo.Size = new System.Drawing.Size(211, 21);
            this.cbxRolEstadoNuevo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado nuevo:";
            // 
            // txtRolEstadoViejo
            // 
            this.txtRolEstadoViejo.Location = new System.Drawing.Point(38, 121);
            this.txtRolEstadoViejo.Name = "txtRolEstadoViejo";
            this.txtRolEstadoViejo.ReadOnly = true;
            this.txtRolEstadoViejo.Size = new System.Drawing.Size(211, 20);
            this.txtRolEstadoViejo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado actual:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(198, 386);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRolNombreNuevo
            // 
            this.txtRolNombreNuevo.Location = new System.Drawing.Point(38, 82);
            this.txtRolNombreNuevo.Name = "txtRolNombreNuevo";
            this.txtRolNombreNuevo.Size = new System.Drawing.Size(211, 20);
            this.txtRolNombreNuevo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre nuevo para el Rol:";
            // 
            // txtRolNombreViejo
            // 
            this.txtRolNombreViejo.Location = new System.Drawing.Point(38, 43);
            this.txtRolNombreViejo.Name = "txtRolNombreViejo";
            this.txtRolNombreViejo.ReadOnly = true;
            this.txtRolNombreViejo.Size = new System.Drawing.Size(211, 20);
            this.txtRolNombreViejo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre actual:";
            // 
            // Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 443);
            this.Controls.Add(this.groupBox1);
            this.Name = "Edicion";
            this.Text = "Edicion";
            this.Load += new System.EventHandler(this.Edicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRolNombreViejo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRolNombreNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRolEstadoNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRolEstadoViejo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView tablaFuncionalidades;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
    }
}