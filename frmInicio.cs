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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void datosDeToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoAfiliadosMInfo frmListadoAfiliadosMInfo = new frmListadoAfiliadosMInfo();
            frmListadoAfiliadosMInfo.ShowDialog();
        }

        private void buscarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado frmBuscarAfiliado = new frmBuscarAfiliado();
            frmBuscarAfiliado.ShowDialog();
        }

        private void datosDeAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoAfiliados frmListadoAfiliados = new frmListadoAfiliados();
            frmListadoAfiliados.ShowDialog();

        }

        private void clienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoAfiliado frmNuevoAfiliado = new frmNuevoAfiliado();
            frmNuevoAfiliado.ShowDialog();
        }

        private void datosDeLasActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeSucursales frmListadoDeSucursales = new frmListadoDeSucursales();
            frmListadoDeSucursales.ShowDialog();
        }

        private void datosDeLaActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActividad frmActividad = new frmActividad();
            frmActividad.ShowDialog();  
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
