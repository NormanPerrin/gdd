namespace UberFrba.AbmAuto
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
            this.BtnAlta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.TxtPatente = new System.Windows.Forms.TextBox();
            this.LbelPatente = new System.Windows.Forms.Label();
            this.LbelMarca = new System.Windows.Forms.Label();
            this.LbelModelo = new System.Windows.Forms.Label();
            this.LbelLicencia = new System.Windows.Forms.Label();
            this.LbelRodado = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtLicencia = new System.Windows.Forms.TextBox();
            this.TxtRodado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(175, 213);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(100, 32);
            this.BtnAlta.TabIndex = 0;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(44, 213);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 32);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Atras";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // TxtPatente
            // 
            this.TxtPatente.Location = new System.Drawing.Point(105, 31);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(170, 20);
            this.TxtPatente.TabIndex = 2;
            // 
            // LbelPatente
            // 
            this.LbelPatente.AutoSize = true;
            this.LbelPatente.Location = new System.Drawing.Point(52, 34);
            this.LbelPatente.Name = "LbelPatente";
            this.LbelPatente.Size = new System.Drawing.Size(47, 13);
            this.LbelPatente.TabIndex = 3;
            this.LbelPatente.Text = "Patente:";
            this.LbelPatente.Click += new System.EventHandler(this.LbelPatente_Click);
            // 
            // LbelMarca
            // 
            this.LbelMarca.AutoSize = true;
            this.LbelMarca.Location = new System.Drawing.Point(52, 68);
            this.LbelMarca.Name = "LbelMarca";
            this.LbelMarca.Size = new System.Drawing.Size(40, 13);
            this.LbelMarca.TabIndex = 4;
            this.LbelMarca.Text = "Marca:";
            // 
            // LbelModelo
            // 
            this.LbelModelo.AutoSize = true;
            this.LbelModelo.Location = new System.Drawing.Point(52, 105);
            this.LbelModelo.Name = "LbelModelo";
            this.LbelModelo.Size = new System.Drawing.Size(45, 13);
            this.LbelModelo.TabIndex = 5;
            this.LbelModelo.Text = "Modelo:";
            this.LbelModelo.Click += new System.EventHandler(this.LbelModelo_Click);
            // 
            // LbelLicencia
            // 
            this.LbelLicencia.AutoSize = true;
            this.LbelLicencia.Location = new System.Drawing.Point(52, 139);
            this.LbelLicencia.Name = "LbelLicencia";
            this.LbelLicencia.Size = new System.Drawing.Size(50, 13);
            this.LbelLicencia.TabIndex = 6;
            this.LbelLicencia.Text = "Licencia:";
            // 
            // LbelRodado
            // 
            this.LbelRodado.AutoSize = true;
            this.LbelRodado.Location = new System.Drawing.Point(52, 177);
            this.LbelRodado.Name = "LbelRodado";
            this.LbelRodado.Size = new System.Drawing.Size(48, 13);
            this.LbelRodado.TabIndex = 7;
            this.LbelRodado.Text = "Rodado:";
            this.LbelRodado.Click += new System.EventHandler(this.LbelRodado_Click);
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(105, 65);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(170, 20);
            this.TxtMarca.TabIndex = 8;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(105, 102);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(170, 20);
            this.TxtModelo.TabIndex = 9;
            // 
            // TxtLicencia
            // 
            this.TxtLicencia.Location = new System.Drawing.Point(105, 136);
            this.TxtLicencia.Name = "TxtLicencia";
            this.TxtLicencia.Size = new System.Drawing.Size(170, 20);
            this.TxtLicencia.TabIndex = 10;
            // 
            // TxtRodado
            // 
            this.TxtRodado.Location = new System.Drawing.Point(105, 174);
            this.TxtRodado.Name = "TxtRodado";
            this.TxtRodado.Size = new System.Drawing.Size(170, 20);
            this.TxtRodado.TabIndex = 11;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 279);
            this.Controls.Add(this.TxtRodado);
            this.Controls.Add(this.TxtLicencia);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.LbelRodado);
            this.Controls.Add(this.LbelLicencia);
            this.Controls.Add(this.LbelModelo);
            this.Controls.Add(this.LbelMarca);
            this.Controls.Add(this.LbelPatente);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.BtnAlta);
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox TxtPatente;
        private System.Windows.Forms.Label LbelPatente;
        private System.Windows.Forms.Label LbelMarca;
        private System.Windows.Forms.Label LbelModelo;
        private System.Windows.Forms.Label LbelLicencia;
        private System.Windows.Forms.Label LbelRodado;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtLicencia;
        private System.Windows.Forms.TextBox TxtRodado;
    }
}