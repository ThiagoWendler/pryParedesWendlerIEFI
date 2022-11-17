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
    public partial class frmListadoDeSucursales : Form
    {
        public frmListadoDeSucursales()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 LstSucursales = Convert.ToInt32(cmbSucursales.SelectedValue);
            clsBarrio Barrio = new clsBarrio();
            Barrio.FiltrajeBarrio(dgvListadoSucursales, LstSucursales);
        }

        private void frmListadoDeSucursales_Load(object sender, EventArgs e)
        {
            clsBarrio CBarrio = new clsBarrio();
            CBarrio.Listarcmb(cmbSucursales);
        }
    }
}
