﻿namespace UberFrba.AbmCliente
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
            this.clientesGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textApellidoB = new System.Windows.Forms.TextBox();
            this.textNombreB = new System.Windows.Forms.TextBox();
            this.textDNIB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboHabilitado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textFN = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label11 = new System.Windows.Forms.Label();
            this.textCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDpto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textLoc = new System.Windows.Forms.TextBox();
            this.textCP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesGrid
            // 
            this.clientesGrid.AllowUserToAddRows = false;
            this.clientesGrid.AllowUserToDeleteRows = false;
            this.clientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesGrid.Location = new System.Drawing.Point(15, 315);
            this.clientesGrid.Name = "clientesGrid";
            this.clientesGrid.ReadOnly = true;
            this.clientesGrid.Size = new System.Drawing.Size(687, 202);
            this.clientesGrid.TabIndex = 0;
            this.clientesGrid.SelectionChanged += new System.EventHandler(this.clientesGrid_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textApellidoB);
            this.groupBox1.Controls.Add(this.textNombreB);
            this.groupBox1.Controls.Add(this.textDNIB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador:";
            // 
            // textApellidoB
            // 
            this.textApellidoB.Location = new System.Drawing.Point(64, 91);
            this.textApellidoB.Name = "textApellidoB";
            this.textApellidoB.Size = new System.Drawing.Size(177, 20);
            this.textApellidoB.TabIndex = 6;
            this.textApellidoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlfa_KeyPress);
            // 
            // textNombreB
            // 
            this.textNombreB.Location = new System.Drawing.Point(64, 58);
            this.textNombreB.Name = "textNombreB";
            this.textNombreB.Size = new System.Drawing.Size(177, 20);
            this.textNombreB.TabIndex = 5;
            this.textNombreB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlfa_KeyPress);
            // 
            // textDNIB
            // 
            this.textDNIB.Location = new System.Drawing.Point(64, 25);
            this.textDNIB.MaxLength = 9;
            this.textDNIB.Name = "textDNIB";
            this.textDNIB.Size = new System.Drawing.Size(177, 20);
            this.textDNIB.TabIndex = 4;
            this.textDNIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumerico_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(197, 121);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.btnBusquedaClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(534, 529);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(627, 529);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboHabilitado
            // 
            this.comboHabilitado.Enabled = false;
            this.comboHabilitado.FormattingEnabled = true;
            this.comboHabilitado.Location = new System.Drawing.Point(558, 276);
            this.comboHabilitado.Name = "comboHabilitado";
            this.comboHabilitado.Size = new System.Drawing.Size(121, 21);
            this.comboHabilitado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Habilitado:";
            // 
            // buttonFecha
            // 
            this.buttonFecha.Enabled = false;
            this.buttonFecha.Location = new System.Drawing.Point(252, 193);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(75, 23);
            this.buttonFecha.TabIndex = 34;
            this.buttonFecha.Text = "Seleccionar";
            this.buttonFecha.UseVisualStyleBackColor = true;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "*Fecha de Nacimiento:";
            // 
            // textFN
            // 
            this.textFN.Enabled = false;
            this.textFN.Location = new System.Drawing.Point(135, 195);
            this.textFN.Name = "textFN";
            this.textFN.ReadOnly = true;
            this.textFN.Size = new System.Drawing.Size(111, 20);
            this.textFN.TabIndex = 32;
            this.textFN.TabStop = false;
            // 
            // calendario
            // 
            this.calendario.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.calendario.Location = new System.Drawing.Point(252, 193);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 31;
            this.calendario.Visible = false;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.calendario.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "* campos obligatorios";
            // 
            // textCalle
            // 
            this.textCalle.Enabled = false;
            this.textCalle.Location = new System.Drawing.Point(135, 222);
            this.textCalle.Name = "textCalle";
            this.textCalle.Size = new System.Drawing.Size(544, 20);
            this.textCalle.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "*Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Piso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Dpto:";
            // 
            // textPiso
            // 
            this.textPiso.Enabled = false;
            this.textPiso.Location = new System.Drawing.Point(135, 248);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(41, 20);
            this.textPiso.TabIndex = 47;
            this.textPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumerico_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "*Localidad:";
            // 
            // textDpto
            // 
            this.textDpto.Enabled = false;
            this.textDpto.Location = new System.Drawing.Point(227, 248);
            this.textDpto.MaxLength = 1;
            this.textDpto.Name = "textDpto";
            this.textDpto.Size = new System.Drawing.Size(41, 20);
            this.textDpto.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "*Código Postal:";
            // 
            // textLoc
            // 
            this.textLoc.Enabled = false;
            this.textLoc.Location = new System.Drawing.Point(133, 276);
            this.textLoc.Name = "textLoc";
            this.textLoc.Size = new System.Drawing.Size(157, 20);
            this.textLoc.TabIndex = 51;
            // 
            // textCP
            // 
            this.textCP.Enabled = false;
            this.textCP.Location = new System.Drawing.Point(403, 276);
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(67, 20);
            this.textCP.TabIndex = 53;
            this.textCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumerico_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "*Teléfono:";
            // 
            // textTel
            // 
            this.textTel.Enabled = false;
            this.textTel.Location = new System.Drawing.Point(403, 248);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(161, 20);
            this.textTel.TabIndex = 43;
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumerico_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Mail:";
            // 
            // textMail
            // 
            this.textMail.Enabled = false;
            this.textMail.Location = new System.Drawing.Point(349, 134);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(260, 20);
            this.textMail.TabIndex = 41;
            // 
            // textDNI
            // 
            this.textDNI.Enabled = false;
            this.textDNI.Location = new System.Drawing.Point(349, 38);
            this.textDNI.MaxLength = 9;
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(130, 20);
            this.textDNI.TabIndex = 40;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumerico_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "*Apellido:";
            // 
            // textApellido
            // 
            this.textApellido.Enabled = false;
            this.textApellido.Location = new System.Drawing.Point(349, 102);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(260, 20);
            this.textApellido.TabIndex = 38;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlfa_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "*Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(349, 70);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(260, 20);
            this.textNombre.TabIndex = 36;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlfa_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(314, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "*DNI:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(441, 529);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 56;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 560);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPiso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDpto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textLoc);
            this.Controls.Add(this.textCP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textFN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboHabilitado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientesGrid);
            this.Controls.Add(this.calendario);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            ((System.ComponentModel.ISupportInitialize)(this.clientesGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientesGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDNIB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textApellidoB;
        private System.Windows.Forms.TextBox textNombreB;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboHabilitado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textFN;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDpto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textLoc;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonCerrar;
    }
}