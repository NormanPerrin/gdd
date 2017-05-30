namespace UberFrba.AbmRol
{
    partial class AbmRol
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
            this.btnNuevoRol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnLista);
            this.groupBox1.Controls.Add(this.btnNuevoRol);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 150);
            this.groupBox1.TabIndex = 0;
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
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(11, 71);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(151, 23);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Busqueda y listado de roles";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnNuevoRol
            // 
            this.btnNuevoRol.Location = new System.Drawing.Point(11, 29);
            this.btnNuevoRol.Name = "btnNuevoRol";
            this.btnNuevoRol.Size = new System.Drawing.Size(151, 23);
            this.btnNuevoRol.TabIndex = 0;
            this.btnNuevoRol.Text = "Alta de un nuevo Rol";
            this.btnNuevoRol.UseVisualStyleBackColor = true;
            this.btnNuevoRol.Click += new System.EventHandler(this.btnNuevoRol_Click);
            // 
            // AbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 176);
            this.Controls.Add(this.groupBox1);
            this.Name = "AbmRol";
            this.Text = "AbmRol";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnNuevoRol;
        private System.Windows.Forms.Button btnVolver;
    }
}