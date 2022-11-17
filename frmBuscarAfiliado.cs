using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryParedesWendlerIEFI
{
    public partial class frmBuscarAfiliado : Form
    {
        clsActividada DActividad = new clsActividada();
        
        public frmBuscarAfiliado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            //Se asignan los valores correspondientes
            //Y se crea variable DniCliente para que corresponda a txtDNI
            Int32 DniCliente = Convert.ToInt32(txtDNI.Text);
            clsAfiliado DCliente = new clsAfiliado(); //Se crea la variable DCliente, la cual va a ser asignada a clsAfiliado (Clase Afiliado)

            DCliente.BuscarAfiliado(DniCliente);

            if (DniCliente != 0)
            {
                
                lblNombre.Text = DCliente.Nombre_Apellido; //Se le asigna el valor correspondiente a la caja de texto
                lblSaldo.Text = DCliente.Saldo.ToString(); //""

                txtNombre.Text = DCliente.Nombre_Apellido;
                txtDNID.Text = DCliente.Dni_Socio.ToString();
                txtDireccion.Text = DCliente.Direccion;
                DCliente.BuscarAfiliado(DCliente.CodigoActividad);
                txtNombreActividad.Text = DActividad.NombreActividad;
                txtCodigoSucursal.Text = DCliente.CCodigoSucursal.ToString();
                txtSaldo.Text = DCliente.Saldo.ToString();



            }
            else
            {
                MessageBox.Show("El DNI no se ha encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 DniCliente = Convert.ToInt32(txtDNI.Text);

            clsAfiliado EliminarAf = new clsAfiliado();
            EliminarAf.Dni_Socio = DniCliente;
            EliminarAf.EliminarAfiliado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 DNI = (Convert.ToInt32(txtDNI.Text));
            string Nombre = txtNombre.Text;
            string Direccion = txtDireccion.Text;
            Int32 CodigoSucursales = (Convert.ToInt32(txtCodigoSucursal.Text));
            Int32 CodigoActividad = (Convert.ToInt32(txtNombreActividad.Text));
            Int32 Saldo = (Convert.ToInt32(txtSaldo.Text));
            clsAfiliado Modificar = new clsAfiliado();
            Modificar.Dni_Socio = DNI;
            Modificar.Nombre_Apellido = Nombre;
            Modificar.Direccion = Direccion;
            Modificar.CCodigoSucursal = CodigoSucursales;
            Modificar.CodigoActividad = CodigoActividad;
            Modificar.Saldo = Saldo;
            Modificar.ModificarAfiliado(DNI);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
