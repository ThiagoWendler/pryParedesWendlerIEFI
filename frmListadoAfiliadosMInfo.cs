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
    public partial class frmListadoAfiliadosMInfo : Form
    {
        public frmListadoAfiliadosMInfo()
        {
            InitializeComponent();
        }

        private void frmListadoAfiliadosMInfo_Load(object sender, EventArgs e)
        {
            //Desactivo las textbox asi no se puede escribir
            txtCantidadPersonasInscribidas.Enabled = false;
            txtPromedioSaldos.Enabled = false;
            txtSaldosTotales.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsAfiliado clsAfiliado = new clsAfiliado();
            clsAfiliado.ListarAfiliados(dgvAfiliadosMasInfo);
            txtCantidadPersonasInscribidas.Text = clsAfiliado.CantidadAfiliados.ToString(); //Se asignan valores a las textbox para que muestren la informacion correcta
            txtPromedioSaldos.Text = clsAfiliado.PromedioSaldo.ToString(); //""
            txtSaldosTotales.Text = clsAfiliado.TotalSaldo.ToString(); //""
        }
    }
}
