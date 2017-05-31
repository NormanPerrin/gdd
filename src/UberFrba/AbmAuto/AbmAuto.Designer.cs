namespace UberFrba.o
{
    partial class AbmAuto
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnNuevoAuto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnLista);
            this.groupBox1.Controls.Add(this.btnNuevoAuto);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una acción:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(11, 112);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(151, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver a funcionalidades";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(11, 71);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(151, 23);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Busqueda y listado de autos";
            this.btnLista.UseVisualStyleBackColor = true;
            // 
            // btnNuevoAuto
            // 
            this.btnNuevoAuto.Location = new System.Drawing.Point(11, 29);
            this.btnNuevoAuto.Name = "btnNuevoAuto";
            this.btnNuevoAuto.Size = new System.Drawing.Size(151, 23);
            this.btnNuevoAuto.TabIndex = 0;
            this.btnNuevoAuto.Text = "Alta de un nuevo Auto";
            this.btnNuevoAuto.UseVisualStyleBackColor = true;
            this.btnNuevoAuto.Click += new System.EventHandler(this.btnNuevoRol_Click);
            // 
            // AbmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 220);
            this.Controls.Add(this.groupBox1);
            this.Name = "AbmAuto";
            this.Text = "AbmAuto";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnNuevoAuto;

    }
}