namespace pryParedesWendlerIEFI
{
    partial class frmListadoAfiliados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoAfiliados));
            this.dgvListadoAfiliados = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblListadoAfiliados = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoAfiliados
            // 
            this.dgvListadoAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAfiliados.Location = new System.Drawing.Point(21, 59);
            this.dgvListadoAfiliados.Name = "dgvListadoAfiliados";
            this.dgvListadoAfiliados.ReadOnly = true;
            this.dgvListadoAfiliados.Size = new System.Drawing.Size(635, 164);
            this.dgvListadoAfiliados.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(237, 229);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(203, 39);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblListadoAfiliados
            // 
            this.lblListadoAfiliados.AutoSize = true;
            this.lblListadoAfiliados.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoAfiliados.Location = new System.Drawing.Point(241, 21);
            this.lblListadoAfiliados.Name = "lblListadoAfiliados";
            this.lblListadoAfiliados.Size = new System.Drawing.Size(214, 26);
            this.lblListadoAfiliados.TabIndex = 3;
            this.lblListadoAfiliados.Text = "Listado de Afiliados";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(295, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 26);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListadoAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 307);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblListadoAfiliados);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListadoAfiliados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoAfiliados";
            this.Text = "Listado Afiliados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAfiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoAfiliados;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblListadoAfiliados;
        private System.Windows.Forms.Button btnSalir;
    }
}