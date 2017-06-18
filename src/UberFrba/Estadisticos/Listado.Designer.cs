namespace UberFrba.Estadisticos
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
            this.cbxConsulta = new System.Windows.Forms.ComboBox();
            this.cbxTrimestre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbxAnio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxAnio);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxTrimestre);
            this.groupBox1.Controls.Add(this.cbxConsulta);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas a consultar:";
            // 
            // cbxConsulta
            // 
            this.cbxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConsulta.FormattingEnabled = true;
            this.cbxConsulta.Items.AddRange(new object[] {
            "Choferes con mayor recaudacion",
            "Choferes con el viaje mas largo realizado",
            "Clientes con mayor consumo",
            "Clientes que utilizaron mas veces el mismo automovil"});
            this.cbxConsulta.Location = new System.Drawing.Point(64, 19);
            this.cbxConsulta.Name = "cbxConsulta";
            this.cbxConsulta.Size = new System.Drawing.Size(438, 21);
            this.cbxConsulta.TabIndex = 0;
            // 
            // cbxTrimestre
            // 
            this.cbxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrimestre.FormattingEnabled = true;
            this.cbxTrimestre.Items.AddRange(new object[] {
            "Primer trimestre - Enero, Febrero y Marzo",
            "Segundo trimestre - Abril, Mayo y Junio",
            "Tercer trimestre - Julio, Agosto y Septiembre",
            "Cuarto trimestre - Octumbre, Noviembre y Diciembre"});
            this.cbxTrimestre.Location = new System.Drawing.Point(64, 46);
            this.cbxTrimestre.Name = "cbxTrimestre";
            this.cbxTrimestre.Size = new System.Drawing.Size(330, 21);
            this.cbxTrimestre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trimestre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(427, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultados totales:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(13, 138);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(516, 188);
            this.tabla.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(427, 74);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbxAnio
            // 
            this.cbxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnio.FormattingEnabled = true;
            this.cbxAnio.Location = new System.Drawing.Point(64, 74);
            this.cbxAnio.Name = "cbxAnio";
            this.cbxAnio.Size = new System.Drawing.Size(195, 21);
            this.cbxAnio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año:";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 338);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTrimestre;
        private System.Windows.Forms.ComboBox cbxConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxAnio;
    }
}