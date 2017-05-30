namespace UberFrba
{
    partial class SeleccionarRol
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.titulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 88);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(92, 23);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(213, 88);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(92, 23);
            this.btnAcceder.TabIndex = 6;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrarSesion);
            this.groupBox1.Controls.Add(this.cbxRoles);
            this.groupBox1.Controls.Add(this.btnAcceder);
            this.groupBox1.Location = new System.Drawing.Point(19, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el rol con el que desea acceder:";
            // 
            // cbxRoles
            // 
            this.cbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Location = new System.Drawing.Point(0, 37);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(305, 21);
            this.cbxRoles.TabIndex = 1;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(15, 19);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(140, 23);
            this.titulo.TabIndex = 4;
            this.titulo.Text = "Usuario Nombre";
            // 
            // SeleccionarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titulo);
            this.Name = "SeleccionarRol";
            this.Text = "SeleccionarRol";
            this.Load += new System.EventHandler(this.SeleccionarRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxRoles;
        private System.Windows.Forms.Label titulo;
    }
}