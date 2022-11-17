namespace pryParedesWendlerIEFI
{
    partial class frmListadoAfiliadosMInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoAfiliadosMInfo));
            this.dgvAfiliadosMasInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMasDatosAfiliados = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCantidadPersonasInscribidas = new System.Windows.Forms.Label();
            this.lblSaldosT = new System.Windows.Forms.Label();
            this.lblPromedioSaldos = new System.Windows.Forms.Label();
            this.txtCantidadPersonasInscribidas = new System.Windows.Forms.TextBox();
            this.txtSaldosTotales = new System.Windows.Forms.TextBox();
            this.txtPromedioSaldos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliadosMasInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAfiliadosMasInfo
            // 
            this.dgvAfiliadosMasInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAfiliadosMasInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvAfiliadosMasInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliadosMasInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvAfiliadosMasInfo.Location = new System.Drawing.Point(12, 32);
            this.dgvAfiliadosMasInfo.Name = "dgvAfiliadosMasInfo";
            this.dgvAfiliadosMasInfo.ReadOnly = true;
            this.dgvAfiliadosMasInfo.Size = new System.Drawing.Size(494, 201);
            this.dgvAfiliadosMasInfo.TabIndex = 1;
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
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Saldo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblMasDatosAfiliados
            // 
            this.lblMasDatosAfiliados.AutoSize = true;
            this.lblMasDatosAfiliados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasDatosAfiliados.Location = new System.Drawing.Point(196, 9);
            this.lblMasDatosAfiliados.Name = "lblMasDatosAfiliados";
            this.lblMasDatosAfiliados.Size = new System.Drawing.Size(111, 20);
            this.lblMasDatosAfiliados.TabIndex = 2;
            this.lblMasDatosAfiliados.Text = "Afiliados (+I)";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(178, 239);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(163, 35);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblCantidadPersonasInscribidas
            // 
            this.lblCantidadPersonasInscribidas.AutoSize = true;
            this.lblCantidadPersonasInscribidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonasInscribidas.Location = new System.Drawing.Point(8, 306);
            this.lblCantidadPersonasInscribidas.Name = "lblCantidadPersonasInscribidas";
            this.lblCantidadPersonasInscribidas.Size = new System.Drawing.Size(280, 20);
            this.lblCantidadPersonasInscribidas.TabIndex = 4;
            this.lblCantidadPersonasInscribidas.Text = "Cantidad de personas inscribidas:";
            // 
            // lblSaldosT
            // 
            this.lblSaldosT.AutoSize = true;
            this.lblSaldosT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldosT.Location = new System.Drawing.Point(8, 340);
            this.lblSaldosT.Name = "lblSaldosT";
            this.lblSaldosT.Size = new System.Drawing.Size(133, 20);
            this.lblSaldosT.TabIndex = 5;
            this.lblSaldosT.Text = "Saldos Totales:";
            // 
            // lblPromedioSaldos
            // 
            this.lblPromedioSaldos.AutoSize = true;
            this.lblPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos.Location = new System.Drawing.Point(8, 377);
            this.lblPromedioSaldos.Name = "lblPromedioSaldos";
            this.lblPromedioSaldos.Size = new System.Drawing.Size(174, 20);
            this.lblPromedioSaldos.TabIndex = 6;
            this.lblPromedioSaldos.Text = "Promedio de Saldos:";
            // 
            // txtCantidadPersonasInscribidas
            // 
            this.txtCantidadPersonasInscribidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadPersonasInscribidas.Location = new System.Drawing.Point(294, 306);
            this.txtCantidadPersonasInscribidas.Name = "txtCantidadPersonasInscribidas";
            this.txtCantidadPersonasInscribidas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadPersonasInscribidas.TabIndex = 7;
            // 
            // txtSaldosTotales
            // 
            this.txtSaldosTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldosTotales.Location = new System.Drawing.Point(157, 340);
            this.txtSaldosTotales.Name = "txtSaldosTotales";
            this.txtSaldosTotales.Size = new System.Drawing.Size(100, 20);
            this.txtSaldosTotales.TabIndex = 8;
            // 
            // txtPromedioSaldos
            // 
            this.txtPromedioSaldos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPromedioSaldos.Location = new System.Drawing.Point(188, 377);
            this.txtPromedioSaldos.Name = "txtPromedioSaldos";
            this.txtPromedioSaldos.Size = new System.Drawing.Size(168, 20);
            this.txtPromedioSaldos.TabIndex = 9;
            // 
            // frmListadoAfiliadosMInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 419);
            this.Controls.Add(this.txtPromedioSaldos);
            this.Controls.Add(this.txtSaldosTotales);
            this.Controls.Add(this.txtCantidadPersonasInscribidas);
            this.Controls.Add(this.lblPromedioSaldos);
            this.Controls.Add(this.lblSaldosT);
            this.Controls.Add(this.lblCantidadPersonasInscribidas);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblMasDatosAfiliados);
            this.Controls.Add(this.dgvAfiliadosMasInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoAfiliadosMInfo";
            this.Text = "Mas informacion acerca... Afiliados";
            this.Load += new System.EventHandler(this.frmListadoAfiliadosMInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliadosMasInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAfiliadosMasInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblMasDatosAfiliados;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCantidadPersonasInscribidas;
        private System.Windows.Forms.Label lblSaldosT;
        private System.Windows.Forms.Label lblPromedioSaldos;
        private System.Windows.Forms.TextBox txtCantidadPersonasInscribidas;
        private System.Windows.Forms.TextBox txtSaldosTotales;
        private System.Windows.Forms.TextBox txtPromedioSaldos;
    }
}