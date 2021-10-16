using Practicas.Cap24.Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Examen_Final.UI
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false; // DESHABILITANDO LA AUTOGENERACION DE COLUMNAS
            Todo();
            CantidadTotal();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
            Cantidad();
        }

        private void Consultar()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var listado = invoiceRepository.ConsultarFacturas(dtpFecha1.Value, dtpFecha2.Value);
            dgvListado.DataSource = listado;
            dgvListado.Refresh();
        }

        private void Cantidad()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var cantidad = invoiceRepository.ConsultarFacturasCantidad(dtpFecha1.Value, dtpFecha2.Value);
            lblCantidadRegistros.Text = "CANTIDAD DE REGISTROS: " + cantidad.ToString();
        }

        private void CantidadTotal()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var cantidad = invoiceRepository.ConsultarFacturasCantidadTotal();
            lblCantidadRegistros.Text = "CANTIDAD DE REGISTROS: " + cantidad.ToString();
        }

        private void Todo()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var listado = invoiceRepository.ConsultarFacturasTodo();
            dgvListado.DataSource = listado;
            dgvListado.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmNuevaFactura();
            frm.Show();
        }
    }
}
