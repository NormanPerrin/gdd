namespace UberFrba.AbmCliente
{
    partial class AbmCliente
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
            this.clienteAltabtn = new System.Windows.Forms.Button();
            this.clienteModbtn = new System.Windows.Forms.Button();
            this.clienteVolverbtn = new System.Windows.Forms.Button();
            this.abmClienteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // abmClienteBox
            // 
            this.abmClienteBox.Controls.Add(this.clienteVolverbtn);
            this.abmClienteBox.Controls.Add(this.clienteModbtn);
            this.abmClienteBox.Controls.Add(this.clienteAltabtn);
            this.abmClienteBox.Location = new System.Drawing.Point(13, 25);
            this.abmClienteBox.Name = "abmClienteBox";
            this.abmClienteBox.Size = new System.Drawing.Size(187, 169);
            this.abmClienteBox.TabIndex = 0;
            this.abmClienteBox.TabStop = false;
            this.abmClienteBox.Text = "Seleccione una acción";
            // 
            // clienteAltabtn
            // 
            this.clienteAltabtn.Location = new System.Drawing.Point(20, 37);
            this.clienteAltabtn.Name = "clienteAltabtn";
            this.clienteAltabtn.Size = new System.Drawing.Size(140, 23);
            this.clienteAltabtn.TabIndex = 0;
            this.clienteAltabtn.Text = "Alta de cliente";
            this.clienteAltabtn.UseVisualStyleBackColor = true;
            this.clienteAltabtn.Click += new System.EventHandler(this.clienteAltabtn_Click);
            // 
            // clienteModbtn
            // 
            this.clienteModbtn.Location = new System.Drawing.Point(20, 79);
            this.clienteModbtn.Name = "clienteModbtn";
            this.clienteModbtn.Size = new System.Drawing.Size(140, 23);
            this.clienteModbtn.TabIndex = 1;
            this.clienteModbtn.Text = "Modificación de cliente";
            this.clienteModbtn.UseVisualStyleBackColor = true;
            // 
            // clienteVolverbtn
            // 
            this.clienteVolverbtn.Location = new System.Drawing.Point(20, 121);
            this.clienteVolverbtn.Name = "clienteVolverbtn";
            this.clienteVolverbtn.Size = new System.Drawing.Size(140, 23);
            this.clienteVolverbtn.TabIndex = 2;
            this.clienteVolverbtn.Text = "Volver a funcionalidades";
            this.clienteVolverbtn.UseVisualStyleBackColor = true;
            // 
            // AbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 220);
            this.Controls.Add(this.abmClienteBox);
            this.Name = "AbmCliente";
            this.Text = "AbmCliente";
            this.abmClienteBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox abmClienteBox;
        private System.Windows.Forms.Button clienteVolverbtn;
        private System.Windows.Forms.Button clienteModbtn;
        private System.Windows.Forms.Button clienteAltabtn;
    }
}