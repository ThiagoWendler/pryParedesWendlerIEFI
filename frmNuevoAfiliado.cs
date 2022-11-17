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
    public partial class frmNuevoAfiliado : Form
    {
        public frmNuevoAfiliado()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsAfiliado AgregarA = new clsAfiliado(); //Variable para referirse a la clase Afiliado como "AgregarA"
            AgregarA.Dni_Socio = Convert.ToInt32(txtDNI.Text); //Valores para las cajas de texto
            AgregarA.Nombre_Apellido = txtNombre.Text;
            AgregarA.CCodigoSucursal = Convert.ToInt32(txtCodigoSucursal.Text);
            AgregarA.SaldoC = Convert.ToInt32(txtSaldo.Text);
            AgregarA.CodigoActividadC = Convert.ToInt32(txtCodigoActividad.Text);
            AgregarA.DireccionC = txtDireccion.Text;
            AgregarA.RegistroDeClientes();
        }
    }
}
