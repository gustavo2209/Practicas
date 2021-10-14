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

namespace Practicas.Cap24.UI
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false; // DESHABILITANDO LA AUTOGENERACION DE COLUMNAS
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var listado = invoiceRepository.ConsultarFacturas(dtpFecha1.Value, dtpFecha2.Value);
            dgvListado.DataSource = listado;
            dgvListado.Refresh();
        }
    }
}
