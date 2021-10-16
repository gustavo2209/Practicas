using Practicas.Examen_Final.Infraestructura;
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
        public frmNuevaFactura()
        {
            InitializeComponent();
            dgvFactura.AutoGenerateColumns = false; // DESHABILITANDO LA AUTOGENERACION DE COLUMNAS
            llenarComboClientes();
            llenarComboTracks();
        }

        private void llenarComboClientes()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var listado = invoiceRepository.mostrarClientes();
            cbCliente.DataSource = listado;
            cbCliente.ValueMember = "FullName";
            cbCliente.Refresh();
        }

        private void llenarComboTracks()
        {
            var invoiceRepository = new InvoiceRepositorio();
            var listado = invoiceRepository.mostrarTracks();
            cbTrack.DataSource = listado;
            cbTrack.ValueMember = "Name";
            cbTrack.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvFactura);
            fila.Cells[0].Value = cbCliente.SelectedValue;
            fila.Cells[1].Value = nudCantidad.Value;
            fila.Cells[2].Value = nudPrecio.Value;
            fila.Cells[3].Value = (nudCantidad.Value * nudPrecio.Value);
            dgvFactura.Rows.Add(fila);
            
            cbCliente.Text = "";
            cbTrack.Text = "";
            txtAddress.Text = "";
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
        }
    }
}
