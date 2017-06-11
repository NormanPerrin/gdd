namespace UberFrba.AbmAuto
{
    partial class Listado
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
            this.tablaAutos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nroMarca = new System.Windows.Forms.NumericUpDown();
            this.nroModelo = new System.Windows.Forms.NumericUpDown();
            this.nroChofer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaAutos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 473);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Roles:";
            // 
            // tablaAutos
            // 
            this.tablaAutos.AllowUserToAddRows = false;
            this.tablaAutos.AllowUserToDeleteRows = false;
            this.tablaAutos.AllowUserToOrderColumns = true;
            this.tablaAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAutos.Location = new System.Drawing.Point(19, 227);
            this.tablaAutos.MultiSelect = false;
            this.tablaAutos.Name = "tablaAutos";
            this.tablaAutos.ReadOnly = true;
            this.tablaAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAutos.Size = new System.Drawing.Size(411, 222);
            this.tablaAutos.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nroChofer);
            this.groupBox2.Controls.Add(this.nroModelo);
            this.groupBox2.Controls.Add(this.nroMarca);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPatente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(19, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 174);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criterio de busqueda:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(322, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(98, 103);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(135, 20);
            this.txtPatente.TabIndex = 6;
            this.txtPatente.Text = "vacio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Patente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chofer:";
            // 
            // nroMarca
            // 
            this.nroMarca.Location = new System.Drawing.Point(98, 39);
            this.nroMarca.Name = "nroMarca";
            this.nroMarca.Size = new System.Drawing.Size(135, 20);
            this.nroMarca.TabIndex = 10;
            // 
            // nroModelo
            // 
            this.nroModelo.Location = new System.Drawing.Point(98, 70);
            this.nroModelo.Name = "nroModelo";
            this.nroModelo.Size = new System.Drawing.Size(135, 20);
            this.nroModelo.TabIndex = 11;
            // 
            // nroChofer
            // 
            this.nroChofer.Location = new System.Drawing.Point(98, 135);
            this.nroChofer.Name = "nroChofer";
            this.nroChofer.Size = new System.Drawing.Size(135, 20);
            this.nroChofer.TabIndex = 12;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 494);
            this.Controls.Add(this.groupBox1);
            this.Name = "Listado";
            this.Text = "Listado";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroChofer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaAutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nroChofer;
        private System.Windows.Forms.NumericUpDown nroModelo;
        private System.Windows.Forms.NumericUpDown nroMarca;
    }
}