namespace pryParedesWendlerIEFI
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmListado = new System.Windows.Forms.ToolStripTextBox();
            this.datosDeAfiliadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLasActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLaActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBodytech = new System.Windows.Forms.Label();
            this.lblBien = new System.Windows.Forms.Label();
            this.lblGimnasio = new System.Windows.Forms.Label();
            this.mspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(539, 24);
            this.mspMenu.TabIndex = 0;
            this.mspMenu.Text = "mspMenu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteNuevoToolStripMenuItem,
            this.toolStripSeparator1,
            this.buscarAfiliadoToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmListado,
            this.datosDeAfiliadosToolStripMenuItem,
            this.datosDeToToolStripMenuItem,
            this.datosDeLasActividadesToolStripMenuItem,
            this.datosDeLaActividadToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clienteNuevoToolStripMenuItem
            // 
            this.clienteNuevoToolStripMenuItem.Name = "clienteNuevoToolStripMenuItem";
            this.clienteNuevoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.clienteNuevoToolStripMenuItem.Text = "Cliente nuevo...";
            this.clienteNuevoToolStripMenuItem.Click += new System.EventHandler(this.clienteNuevoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // buscarAfiliadoToolStripMenuItem
            // 
            this.buscarAfiliadoToolStripMenuItem.Name = "buscarAfiliadoToolStripMenuItem";
            this.buscarAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.buscarAfiliadoToolStripMenuItem.Text = "Buscar afiliado...";
            this.buscarAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.buscarAfiliadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // tsmListado
            // 
            this.tsmListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsmListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsmListado.Enabled = false;
            this.tsmListado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsmListado.ForeColor = System.Drawing.Color.Black;
            this.tsmListado.Name = "tsmListado";
            this.tsmListado.Size = new System.Drawing.Size(180, 23);
            this.tsmListado.Text = "                   LISTADOS";
            // 
            // datosDeAfiliadosToolStripMenuItem
            // 
            this.datosDeAfiliadosToolStripMenuItem.Name = "datosDeAfiliadosToolStripMenuItem";
            this.datosDeAfiliadosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.datosDeAfiliadosToolStripMenuItem.Text = "Afiliados...";
            this.datosDeAfiliadosToolStripMenuItem.Click += new System.EventHandler(this.datosDeAfiliadosToolStripMenuItem_Click);
            // 
            // datosDeToToolStripMenuItem
            // 
            this.datosDeToToolStripMenuItem.Name = "datosDeToToolStripMenuItem";
            this.datosDeToToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.datosDeToToolStripMenuItem.Text = "Datos de todos los afiliados";
            this.datosDeToToolStripMenuItem.Click += new System.EventHandler(this.datosDeToToolStripMenuItem_Click);
            // 
            // datosDeLasActividadesToolStripMenuItem
            // 
            this.datosDeLasActividadesToolStripMenuItem.Name = "datosDeLasActividadesToolStripMenuItem";
            this.datosDeLasActividadesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.datosDeLasActividadesToolStripMenuItem.Text = "Sucursal...";
            this.datosDeLasActividadesToolStripMenuItem.Click += new System.EventHandler(this.datosDeLasActividadesToolStripMenuItem_Click);
            // 
            // datosDeLaActividadToolStripMenuItem
            // 
            this.datosDeLaActividadToolStripMenuItem.Name = "datosDeLaActividadToolStripMenuItem";
            this.datosDeLaActividadToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.datosDeLaActividadToolStripMenuItem.Text = "Actividad...";
            this.datosDeLaActividadToolStripMenuItem.Click += new System.EventHandler(this.datosDeLaActividadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblBodytech
            // 
            this.lblBodytech.AutoSize = true;
            this.lblBodytech.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodytech.Location = new System.Drawing.Point(169, 113);
            this.lblBodytech.Name = "lblBodytech";
            this.lblBodytech.Size = new System.Drawing.Size(217, 39);
            this.lblBodytech.TabIndex = 2;
            this.lblBodytech.Text = "BODYTECH";
            // 
            // lblBien
            // 
            this.lblBien.AutoSize = true;
            this.lblBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBien.Location = new System.Drawing.Point(197, 40);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(149, 25);
            this.lblBien.TabIndex = 3;
            this.lblBien.Text = "Bienvenido/a";
            // 
            // lblGimnasio
            // 
            this.lblGimnasio.AutoSize = true;
            this.lblGimnasio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGimnasio.Location = new System.Drawing.Point(276, 152);
            this.lblGimnasio.Name = "lblGimnasio";
            this.lblGimnasio.Size = new System.Drawing.Size(110, 25);
            this.lblGimnasio.TabIndex = 4;
            this.lblGimnasio.Text = "Gimnasio";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 315);
            this.Controls.Add(this.lblGimnasio);
            this.Controls.Add(this.lblBien);
            this.Controls.Add(this.lblBodytech);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mspMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspMenu;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buscarAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tsmListado;
        private System.Windows.Forms.ToolStripMenuItem datosDeAfiliadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeLasActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeLaActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBodytech;
        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.Label lblGimnasio;
    }
}

