namespace UberFrba
{
    partial class Funcionalidades
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
            this.btnAcceder = new System.Windows.Forms.Button();
            this.cbxFuncionalidades = new System.Windows.Forms.ComboBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAcceder);
            this.groupBox1.Controls.Add(this.cbxFuncionalidades);
            this.groupBox1.Controls.Add(this.btnCerrarSesion);
            this.groupBox1.Location = new System.Drawing.Point(16, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades disponibles:";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(158, 88);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 23);
            this.btnAcceder.TabIndex = 8;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // cbxFuncionalidades
            // 
            this.cbxFuncionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuncionalidades.FormattingEnabled = true;
            this.cbxFuncionalidades.Location = new System.Drawing.Point(0, 37);
            this.cbxFuncionalidades.Name = "cbxFuncionalidades";
            this.cbxFuncionalidades.Size = new System.Drawing.Size(233, 21);
            this.cbxFuncionalidades.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 88);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(78, 23);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCambiarRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rol Tal";
            // 
            // Funcionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Funcionalidades";
            this.Text = "Funcionalidades";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.ComboBox cbxFuncionalidades;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label2;
    }
}