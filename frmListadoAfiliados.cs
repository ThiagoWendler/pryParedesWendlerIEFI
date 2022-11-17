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
    public partial class frmListadoAfiliados : Form
    {
        public frmListadoAfiliados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsAfiliado ListadoAf = new clsAfiliado();
            ListadoAf.ListarAfiliados(dgvListadoAfiliados);
        }
    }
}
