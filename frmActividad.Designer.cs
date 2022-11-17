namespace pryParedesWendlerIEFI
{
    partial class frmActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActividad));
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblSaldoMenor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldoMayor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvListadoDeSucursales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstActividades = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.prtVentanaImp = new System.Windows.Forms.PrintDialog();
            this.prtDocumentoImp = new System.Drawing.Printing.PrintDocument();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDeSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoTotal.Location = new System.Drawing.Point(243, 338);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(181, 26);
            this.lblSaldoTotal.TabIndex = 27;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(98, 413);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(181, 26);
            this.lblPromedio.TabIndex = 26;
            // 
            // lblSaldoMenor
            // 
            this.lblSaldoMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoMenor.Location = new System.Drawing.Point(402, 290);
            this.lblSaldoMenor.Name = "lblSaldoMenor";
            this.lblSaldoMenor.Size = new System.Drawing.Size(181, 26);
            this.lblSaldoMenor.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Saldo menor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Saldo total";
            // 
            // lblSaldoMayor
            // 
            this.lblSaldoMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoMayor.Location = new System.Drawing.Point(108, 291);
            this.lblSaldoMayor.Name = "lblSaldoMayor";
            this.lblSaldoMayor.Size = new System.Drawing.Size(181, 26);
            this.lblSaldoMayor.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Saldo mayor";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Location = new System.Drawing.Point(484, 197);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(75, 23);
            this.cmdImprimir.TabIndex = 19;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Location = new System.Drawing.Point(243, 226);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(123, 23);
            this.cmdExportar.TabIndex = 18;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(243, 197);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(123, 23);
            this.cmdListar.TabIndex = 17;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // dgvListadoDeSucursales
            // 
            this.dgvListadoDeSucursales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListadoDeSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDeSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListadoDeSucursales.Location = new System.Drawing.Point(15, 41);
            this.dgvListadoDeSucursales.Name = "dgvListadoDeSucursales";
            this.dgvListadoDeSucursales.Size = new System.Drawing.Size(544, 150);
            this.dgvListadoDeSucursales.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Saldo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lstActividades
            // 
            this.lstActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(148, 10);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(411, 23);
            this.lstActividades.TabIndex = 15;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(12, 13);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(130, 15);
            this.lblDeporte.TabIndex = 14;
            this.lblDeporte.Text = "Seleccione un deporte";
            // 
            // prtVentanaImp
            // 
            this.prtVentanaImp.UseEXDialog = true;
            // 
            // prtDocumentoImp
            // 
            this.prtDocumentoImp.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumentoImp_PrintPage);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(484, 413);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 26);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListadoDeSucursales);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblSaldoMenor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaldoMayor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.lstActividades);
            this.Controls.Add(this.lblDeporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActividad";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.frmActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDeSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSaldoMenor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldoMayor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvListadoDeSucursales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox lstActividades;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.PrintDialog prtVentanaImp;
        private System.Drawing.Printing.PrintDocument prtDocumentoImp;
        private System.Windows.Forms.Button btnVolver;
    }
}