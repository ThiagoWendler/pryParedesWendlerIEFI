namespace pryParedesWendlerIEFI
{
    partial class frmListadoDeSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeSucursales));
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListadoSucursales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListadoSucurasles = new System.Windows.Forms.Label();
            this.lblESucursal = new System.Windows.Forms.Label();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(153, 215);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(163, 35);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListadoSucursales
            // 
            this.dgvListadoSucursales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListadoSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListadoSucursales.Location = new System.Drawing.Point(12, 59);
            this.dgvListadoSucursales.Name = "dgvListadoSucursales";
            this.dgvListadoSucursales.Size = new System.Drawing.Size(441, 150);
            this.dgvListadoSucursales.TabIndex = 5;
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
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Saldo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblListadoSucurasles
            // 
            this.lblListadoSucurasles.AutoSize = true;
            this.lblListadoSucurasles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoSucurasles.Location = new System.Drawing.Point(187, 9);
            this.lblListadoSucurasles.Name = "lblListadoSucurasles";
            this.lblListadoSucurasles.Size = new System.Drawing.Size(98, 20);
            this.lblListadoSucurasles.TabIndex = 6;
            this.lblListadoSucurasles.Text = "Sucursales";
            // 
            // lblESucursal
            // 
            this.lblESucursal.AutoSize = true;
            this.lblESucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESucursal.Location = new System.Drawing.Point(12, 33);
            this.lblESucursal.Name = "lblESucursal";
            this.lblESucursal.Size = new System.Drawing.Size(71, 16);
            this.lblESucursal.TabIndex = 7;
            this.lblESucursal.Text = "Sucursal:";
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(89, 32);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(314, 21);
            this.cmbSucursales.TabIndex = 8;
            // 
            // frmListadoDeSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 266);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.lblESucursal);
            this.Controls.Add(this.lblListadoSucurasles);
            this.Controls.Add(this.dgvListadoSucursales);
            this.Controls.Add(this.btnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoDeSucursales";
            this.Text = "Listado De Sucursales";
            this.Load += new System.EventHandler(this.frmListadoDeSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListadoSucursales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblListadoSucurasles;
        private System.Windows.Forms.Label lblESucursal;
        private System.Windows.Forms.ComboBox cmbSucursales;
    }
}