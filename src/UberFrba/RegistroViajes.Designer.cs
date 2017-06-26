namespace UberFrba
{
    partial class RegistroViajes
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
            this.lblAuto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxChofer = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputKms = new System.Windows.Forms.NumericUpDown();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputKms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAuto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxTurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxChofer);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(924, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información auto";
            // 
            // lblAuto
            // 
            this.lblAuto.AccessibleName = "";
            this.lblAuto.AutoSize = true;
            this.lblAuto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuto.Cursor = System.Windows.Forms.Cursors.No;
            this.lblAuto.Location = new System.Drawing.Point(482, 96);
            this.lblAuto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAuto.MinimumSize = new System.Drawing.Size(398, 37);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(398, 37);
            this.lblAuto.TabIndex = 5;
            this.lblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Auto habilitado";
            // 
            // cbxTurno
            // 
            this.cbxTurno.AccessibleName = "";
            this.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Location = new System.Drawing.Point(102, 104);
            this.cbxTurno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(318, 33);
            this.cbxTurno.TabIndex = 3;
            this.cbxTurno.SelectedIndexChanged += new System.EventHandler(this.cbxTurno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chofer";
            // 
            // cbxChofer
            // 
            this.cbxChofer.AccessibleName = "";
            this.cbxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChofer.FormattingEnabled = true;
            this.cbxChofer.Location = new System.Drawing.Point(102, 38);
            this.cbxChofer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxChofer.Name = "cbxChofer";
            this.cbxChofer.Size = new System.Drawing.Size(318, 33);
            this.cbxChofer.TabIndex = 0;
            this.cbxChofer.SelectedIndexChanged += new System.EventHandler(this.cbxChofer_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.inputKms);
            this.groupBox2.Controls.Add(this.cbxCliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(24, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(924, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información viaje";
            // 
            // inputKms
            // 
            this.inputKms.Location = new System.Drawing.Point(170, 38);
            this.inputKms.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputKms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputKms.Name = "inputKms";
            this.inputKms.Size = new System.Drawing.Size(148, 31);
            this.inputKms.TabIndex = 8;
            this.inputKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputKms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxCliente
            // 
            this.cbxCliente.AccessibleName = "";
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(102, 96);
            this.cbxCliente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(330, 33);
            this.cbxCliente.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cliente";
            // 
            // dateTo
            // 
            this.dateTo.AccessibleName = "";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTo.Location = new System.Drawing.Point(676, 100);
            this.dateTo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(220, 31);
            this.dateTo.TabIndex = 5;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha y hora HASTA";
            // 
            // dateFrom
            // 
            this.dateFrom.AccessibleName = "";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateFrom.Location = new System.Drawing.Point(676, 37);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(220, 31);
            this.dateFrom.TabIndex = 3;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha y hora DESDE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cantidad KMs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 398);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 398);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Calcular costo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCosto.Location = new System.Drawing.Point(284, 402);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCosto.MinimumSize = new System.Drawing.Size(298, 37);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(298, 37);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 9;
            // 
            // RegistroViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 460);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RegistroViajes";
            this.Text = "RegistroViajes";
            this.Load += new System.EventHandler(this.RegistroViajes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputKms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxChofer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.NumericUpDown inputKms;
        private System.Windows.Forms.TextBox textBox1;
    }
}