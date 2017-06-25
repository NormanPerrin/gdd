namespace UberFrba.AbmAuto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEdicion = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewRodado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRodadoViejo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLicenciaVieja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBaja = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewLicencia = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabEdicion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEdicion);
            this.tabControl1.Controls.Add(this.tabBaja);
            this.tabControl1.Location = new System.Drawing.Point(30, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEdicion
            // 
            this.tabEdicion.Controls.Add(this.groupBox1);
            this.tabEdicion.Location = new System.Drawing.Point(4, 22);
            this.tabEdicion.Name = "tabEdicion";
            this.tabEdicion.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdicion.Size = new System.Drawing.Size(310, 256);
            this.tabEdicion.TabIndex = 0;
            this.tabEdicion.Text = "Edicion";
            this.tabEdicion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNewLicencia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNewRodado);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtRodadoViejo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLicenciaVieja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifique los datos deseados del Auto seleccionado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rodado nuevo:";
            // 
            // txtNewRodado
            // 
            this.txtNewRodado.Location = new System.Drawing.Point(145, 112);
            this.txtNewRodado.Name = "txtNewRodado";
            this.txtNewRodado.Size = new System.Drawing.Size(91, 20);
            this.txtNewRodado.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Licencia nueva:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(33, 166);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(154, 166);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRodadoViejo
            // 
            this.txtRodadoViejo.Location = new System.Drawing.Point(145, 64);
            this.txtRodadoViejo.Name = "txtRodadoViejo";
            this.txtRodadoViejo.Size = new System.Drawing.Size(91, 20);
            this.txtRodadoViejo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rodado actual:";
            // 
            // txtLicenciaVieja
            // 
            this.txtLicenciaVieja.Location = new System.Drawing.Point(25, 64);
            this.txtLicenciaVieja.Name = "txtLicenciaVieja";
            this.txtLicenciaVieja.ReadOnly = true;
            this.txtLicenciaVieja.Size = new System.Drawing.Size(91, 20);
            this.txtLicenciaVieja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licencia actual:";
            // 
            // tabBaja
            // 
            this.tabBaja.Controls.Add(this.button2);
            this.tabBaja.Controls.Add(this.button1);
            this.tabBaja.Location = new System.Drawing.Point(4, 22);
            this.tabBaja.Name = "tabBaja";
            this.tabBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaja.Size = new System.Drawing.Size(310, 256);
            this.tabBaja.TabIndex = 1;
            this.tabBaja.Text = "Baja";
            this.tabBaja.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewLicencia
            // 
            this.txtNewLicencia.Location = new System.Drawing.Point(25, 112);
            this.txtNewLicencia.Name = "txtNewLicencia";
            this.txtNewLicencia.Size = new System.Drawing.Size(91, 20);
            this.txtNewLicencia.TabIndex = 15;
            // 
            // Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "Edicion";
            this.Text = "Edicion";
            this.tabControl1.ResumeLayout(false);
            this.tabEdicion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBaja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEdicion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewRodado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRodadoViejo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLicenciaVieja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabBaja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewLicencia;

    }
}