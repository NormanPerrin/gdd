﻿namespace UberFrba.AbmCliente
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textFN = new System.Windows.Forms.TextBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textDpto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textLoc = new System.Windows.Forms.TextBox();
            this.textCP = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textFN);
            this.groupBox1.Controls.Add(this.buttonAtras);
            this.groupBox1.Controls.Add(this.buttonAlta);
            this.groupBox1.Controls.Add(this.buttonBorrar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textTel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textDNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.calendario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese sus datos personales:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonFecha
            // 
            this.buttonFecha.Location = new System.Drawing.Point(307, 108);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(75, 23);
            this.buttonFecha.TabIndex = 30;
            this.buttonFecha.Text = "Seleccionar";
            this.buttonFecha.UseVisualStyleBackColor = true;
            this.buttonFecha.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "*Fecha de Nacimiento:";
            // 
            // textFN
            // 
            this.textFN.Location = new System.Drawing.Point(190, 110);
            this.textFN.Name = "textFN";
            this.textFN.ReadOnly = true;
            this.textFN.Size = new System.Drawing.Size(111, 20);
            this.textFN.TabIndex = 27;
            this.textFN.TabStop = false;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(595, 282);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 26;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(433, 282);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(75, 23);
            this.buttonAlta.TabIndex = 25;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(514, 282);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 24;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "* campos obligatorios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Teléfono:";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(499, 71);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(161, 20);
            this.textTel.TabIndex = 8;
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail:";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(273, 71);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(158, 20);
            this.textMail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*DNI:";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(73, 71);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(130, 20);
            this.textDNI.TabIndex = 4;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Apellido:";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(396, 39);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(260, 20);
            this.textApellido.TabIndex = 2;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(73, 39);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(260, 20);
            this.textNombre.TabIndex = 0;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textCalle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textPiso);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textDpto);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textLoc);
            this.groupBox2.Controls.Add(this.textCP);
            this.groupBox2.Location = new System.Drawing.Point(15, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 91);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // textCalle
            // 
            this.textCalle.Location = new System.Drawing.Point(80, 30);
            this.textCalle.Name = "textCalle";
            this.textCalle.Size = new System.Drawing.Size(544, 20);
            this.textCalle.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "*Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Piso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Dpto:";
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(80, 56);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(41, 20);
            this.textPiso.TabIndex = 15;
            this.textPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "*Localidad:";
            // 
            // textDpto
            // 
            this.textDpto.Location = new System.Drawing.Point(175, 56);
            this.textDpto.Name = "textDpto";
            this.textDpto.Size = new System.Drawing.Size(41, 20);
            this.textDpto.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "*Código Postal:";
            // 
            // textLoc
            // 
            this.textLoc.Location = new System.Drawing.Point(296, 56);
            this.textLoc.Name = "textLoc";
            this.textLoc.Size = new System.Drawing.Size(157, 20);
            this.textLoc.TabIndex = 19;
            // 
            // textCP
            // 
            this.textCP.Location = new System.Drawing.Point(557, 56);
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(67, 20);
            this.textCP.TabIndex = 21;
            this.textCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // calendario
            // 
            this.calendario.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.calendario.Location = new System.Drawing.Point(307, 102);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 23;
            this.calendario.Visible = false;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.calendario.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 332);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alta";
            this.Text = "Alta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFN;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textDpto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textLoc;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}