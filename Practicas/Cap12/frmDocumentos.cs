using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap12
{
    public partial class frmDocumentos : Form
    {
        public frmDocumentos()
        {
            InitializeComponent();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            ProcesarFactura();
        }

        private void ProcesarFactura()
        {
            var factura = new Factura();
            factura.Cliente = "Pedro Diaz";
            factura.Fecha = DateTime.Now;
            factura.NumeroDocumento = 1;
            factura.Detalle = new DocumentoItem[2];

            var item1 = new DocumentoItem();
            item1.ItemId = 1;
            item1.Producto = "Computadora";
            item1.Precio = 100;
            item1.Cantidad = 2;
            factura.Detalle[0] = item1;

            var item2 = new DocumentoItem();
            item2.ItemId = 2;
            item2.Producto = "Mouse LG";
            item2.Precio = 150;
            item2.Cantidad = 3;
            factura.Detalle[1] = item2;
        }
    }
}
