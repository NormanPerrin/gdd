namespace UberFrba.AbmTurno
{
    partial class AbmTurno
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
            this.abmClienteBox = new System.Windows.Forms.GroupBox();
            this.turnoVolverbtn = new System.Windows.Forms.Button();
            this.turnoModbtn = new System.Windows.Forms.Button();
            this.turnoAltabtn = new System.Windows.Forms.Button();
            this.abmClienteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // abmClienteBox
            // 
            this.abmClienteBox.Controls.Add(this.turnoVolverbtn);
            this.abmClienteBox.Controls.Add(this.turnoModbtn);
            this.abmClienteBox.Controls.Add(this.turnoAltabtn);
            this.abmClienteBox.Location = new System.Drawing.Point(13, 26);
            this.abmClienteBox.Name = "abmClienteBox";
            this.abmClienteBox.Size = new System.Drawing.Size(187, 169);
            this.abmClienteBox.TabIndex = 1;
            this.abmClienteBox.TabStop = false;
            this.abmClienteBox.Text = "Seleccione una acción";
            // 
            // turnoVolverbtn
            // 
            this.turnoVolverbtn.Location = new System.Drawing.Point(20, 121);
            this.turnoVolverbtn.Name = "turnoVolverbtn";
            this.turnoVolverbtn.Size = new System.Drawing.Size(140, 23);
            this.turnoVolverbtn.TabIndex = 2;
            this.turnoVolverbtn.Text = "Volver a funcionalidades";
            this.turnoVolverbtn.UseVisualStyleBackColor = true;
            this.turnoVolverbtn.Click += new System.EventHandler(this.turnoVolverbtn_Click);
            // 
            // turnoModbtn
            // 
            this.turnoModbtn.Location = new System.Drawing.Point(20, 79);
            this.turnoModbtn.Name = "turnoModbtn";
            this.turnoModbtn.Size = new System.Drawing.Size(140, 23);
            this.turnoModbtn.TabIndex = 1;
            this.turnoModbtn.Text = "Modificación de turno";
            this.turnoModbtn.UseVisualStyleBackColor = true;
            this.turnoModbtn.Click += new System.EventHandler(this.turnoModbtn_Click);
            // 
            // turnoAltabtn
            // 
            this.turnoAltabtn.Location = new System.Drawing.Point(20, 37);
            this.turnoAltabtn.Name = "turnoAltabtn";
            this.turnoAltabtn.Size = new System.Drawing.Size(140, 23);
            this.turnoAltabtn.TabIndex = 0;
            this.turnoAltabtn.Text = "Alta de turno";
            this.turnoAltabtn.UseVisualStyleBackColor = true;
            this.turnoAltabtn.Click += new System.EventHandler(this.turnoAltabtn_Click);
            // 
            // AbmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 220);
            this.Controls.Add(this.abmClienteBox);
            this.Name = "AbmTurno";
            this.Text = "AbmTurno";
            this.abmClienteBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox abmClienteBox;
        private System.Windows.Forms.Button turnoVolverbtn;
        private System.Windows.Forms.Button turnoModbtn;
        private System.Windows.Forms.Button turnoAltabtn;
    }
}