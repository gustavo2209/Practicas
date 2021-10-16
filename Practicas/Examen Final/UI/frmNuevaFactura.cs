using Practicas.Examen_Final.Infraestructura;
using Practicas.Examen_Final.Dominio.Entities;
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
    public partial class frmNuevaFactura : Form
    {
        private Invoice invoice = new Invoice();

        public frmNuevaFactura()
        {
            InitializeComponent();
            dgvFactura.AutoGenerateColumns = false; // DESHABILITANDO LA AUTOGENERACION DE COLUMNAS
            llenarComboClientes();
            llenarComboTracks();
            invoice.InvoiceLine = new List<InvoiceLine>();
        }

        private void llenarComboClientes()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var listado = invoiceRepository.mostrarClientes();
            cbCliente.ValueMember = "customerId";
            cbCliente.DisplayMember = "FullName";
            cbCliente.DataSource = listado;
            cbCliente.Refresh();
        }

        private void llenarComboTracks()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var listado = invoiceRepository.mostrarTracks();
            cbTrack.ValueMember = "TrackId";
            cbTrack.DisplayMember = "Name";
            cbTrack.DataSource = listado;
            cbTrack.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indiceCliente = cbCliente.SelectedIndex;
            int indiceTrack = cbTrack.SelectedIndex;
            //int cantidad = 
            /*DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvFactura);
            fila.Cells[0].Value = cbCliente.SelectedItem.ToString();
            fila.Cells[1].Value = nudCantidad.Value;
            fila.Cells[2].Value = nudPrecio.Value;
            fila.Cells[3].Value = (nudCantidad.Value * nudPrecio.Value);
            dgvFactura.Rows.Add(fila);

            cbCliente.Text = "";
            cbTrack.Text = "";
            txtAddress.Text = "";
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;*/

            /*InvoiceLine detalle = new InvoiceLine();

            detalle.InvoiceId = cbCliente.SelectedIndex;
            detalle.TrackId = cbTrack.SelectedIndex;
            detalle.UnitPrice = nudPrecio.Value;
            detalle.Quantity = Convert.ToInt32(nudCantidad.Value);

            invoice.InvoiceLine.Add(detalle);*/

            //dgvFactura.DataSource = detalle;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var invoiceRepository = new InvoiceRepositorio();
            invoice.CustomerId = cbCliente.SelectedIndex;
            invoice.InvoiceDate = DateTime.Now;
            invoice.BillingAddress = txtAddress.Text;
            invoice.BillingCity = "-";
            invoice.BillingState = "-";
            invoice.BillingCountry = "-";
            invoice.BillingPostalCode = "-";



            //cmd.Parameters.Add(CreateParameter("@Total", entity.Total));
            //var listado = invoiceRepository.Insertar(invoice);
           // dgvListado.DataSource = listado;
            //dgvListado.Refresh();
        }
    }
}
