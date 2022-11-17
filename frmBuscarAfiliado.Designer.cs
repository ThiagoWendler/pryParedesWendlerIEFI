namespace pryParedesWendlerIEFI
{
    partial class frmBuscarAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarAfiliado));
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.grpDatosClientes = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtCodigoSucursal = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDNID = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(115, 17);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(156, 20);
            this.txtDNI.TabIndex = 17;
            // 
            // grpDatosClientes
            // 
            this.grpDatosClientes.Controls.Add(this.lblSaldo);
            this.grpDatosClientes.Controls.Add(this.lblNombre);
            this.grpDatosClientes.Controls.Add(this.label4);
            this.grpDatosClientes.Controls.Add(this.label2);
            this.grpDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosClientes.Location = new System.Drawing.Point(29, 91);
            this.grpDatosClientes.Name = "grpDatosClientes";
            this.grpDatosClientes.Size = new System.Drawing.Size(298, 109);
            this.grpDatosClientes.TabIndex = 16;
            this.grpDatosClientes.TabStop = false;
            this.grpDatosClientes.Text = "Datos del cliente";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldo.Location = new System.Drawing.Point(87, 24);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(113, 26);
            this.lblSaldo.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(87, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(181, 26);
            this.lblNombre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(26, 17);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(80, 15);
            this.lblDNI.TabIndex = 15;
            this.lblDNI.Text = "DNI Cliente";
            // 
            // txtCodigoSucursal
            // 
            this.txtCodigoSucursal.Location = new System.Drawing.Point(184, 366);
            this.txtCodigoSucursal.MaxLength = 1;
            this.txtCodigoSucursal.Name = "txtCodigoSucursal";
            this.txtCodigoSucursal.Size = new System.Drawing.Size(134, 20);
            this.txtCodigoSucursal.TabIndex = 35;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(182, 442);
            this.txtSaldo.MaxLength = 9;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 34;
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.Location = new System.Drawing.Point(182, 404);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(134, 20);
            this.txtNombreActividad.TabIndex = 33;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(184, 328);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(144, 20);
            this.txtDireccion.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 252);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Saldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Nombre de actividad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Codigo sucursal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Direccion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "DNI:";
            // 
            // txtDNID
            // 
            this.txtDNID.Location = new System.Drawing.Point(184, 290);
            this.txtDNID.MaxLength = 8;
            this.txtDNID.Name = "txtDNID";
            this.txtDNID.Size = new System.Drawing.Size(144, 20);
            this.txtDNID.TabIndex = 36;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(34, 232);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(57, 20);
            this.lblDatos.TabIndex = 37;
            this.lblDatos.Text = "Datos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(253, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(252, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(253, 468);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 502);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 23);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmBuscarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 537);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtDNID);
            this.Controls.Add(this.txtCodigoSucursal);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNombreActividad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.grpDatosClientes);
            this.Controls.Add(this.lblDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarAfiliado";
            this.Text = "Buscar Afiliado";
            this.grpDatosClientes.ResumeLayout(false);
            this.grpDatosClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox grpDatosClientes;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtCodigoSucursal;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNombreActividad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDNID;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolver;
    }
}