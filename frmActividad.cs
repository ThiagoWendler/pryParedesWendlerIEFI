using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Configuration;



namespace pryParedesWendlerIEFI
{
    public partial class frmActividad : Form
    {

        

        public frmActividad()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 Listado = (Convert.ToInt32(lstActividades.SelectedValue));
            clsAfiliado ActA = new clsAfiliado();
            lblSaldoTotal.Text = ActA.TotalSaldo.ToString();
            ActA.BusquedaClientesActividad(dgvListadoDeSucursales, Listado);
        }

        private void frmActividad_Load(object sender, EventArgs e)
        {
            clsActividada Actividad = new clsActividada();
            Actividad.ListarLista(lstActividades);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            prtVentanaImp.ShowDialog(); //Muestra la ventana de impresion
            prtDocumentoImp.PrinterSettings = prtVentanaImp.PrinterSettings; //Al objeto documento, le asignamos la impresora que fue seleccionada en la ventana imprimir
            prtDocumentoImp.Print(); //Imprime
            MessageBox.Show("Se realizo la impresion correctamente");
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Int32 ActAfiliado = Convert.ToInt32(lstActividades.SelectedValue);
            clsAfiliado Cliente = new clsAfiliado();
            Cliente.SalidaDeClientes(ActAfiliado);
        }

        

        private void prtDocumentoImp_PrintPage(object sender, PrintPageEventArgs e)
        {
            clsAfiliado ImpD = new clsAfiliado();
            ImpD.ImprimirDatos(e);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
