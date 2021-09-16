using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap11
{
    public partial class frmCap11_01 : Form
    {
        public frmCap11_01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            var arrDatosFactura = new Factura[5];
            var arrMontoVenta = new decimal[5];

            LlenarDatos(ref arrDatosFactura, ref arrMontoVenta);
        }

        private void VentasPorVendedor(Factura[] arrDatosFactura, decimal[] arrMontoVenta, string vendedor)
        {
            var cantidadFacturas = 0;
            decimal montoTotal = 0;

            for(var i=0; i<arrDatosFactura.Length; i++)
            {
                if(arrDatosFactura[i].Vendedor == vendedor)
                {
                    cantidadFacturas++;
                    montoTotal += arrMontoVenta[i];
                }
            }
        }

        private void LlenarDatos(ref Factura[] arrDatosFactura, ref decimal[] arrMontoVenta)
        {
            arrDatosFactura[0].NumeroFactura = "001";
            arrDatosFactura[0].Cliente = "Pedro Diaz";
            arrDatosFactura[0].FechaEmision = DateTime.Now;
            arrDatosFactura[0].Vendedor = "Juan Perez";
            arrMontoVenta[0] = 100;

            arrDatosFactura[1].NumeroFactura = "002";
            arrDatosFactura[1].Cliente = "Maria Ramos";
            arrDatosFactura[1].FechaEmision = DateTime.Now;
            arrDatosFactura[1].Vendedor = "Victor Gonzales";
            arrMontoVenta[1] = 120;

            arrDatosFactura[2].NumeroFactura = "003";
            arrDatosFactura[2].Cliente = "Jose Lopez";
            arrDatosFactura[2].FechaEmision = DateTime.Now;
            arrDatosFactura[2].Vendedor = "Victor Gonzales";
            arrMontoVenta[2] = 140;

            arrDatosFactura[3].NumeroFactura = "004";
            arrDatosFactura[3].Cliente = "Juana Vasquez";
            arrDatosFactura[3].FechaEmision = DateTime.Now;
            arrDatosFactura[3].Vendedor = "Victor Gonzales";
            arrMontoVenta[3] = 160;

            arrDatosFactura[4].NumeroFactura = "005";
            arrDatosFactura[4].Cliente = "Marcos Ramos";
            arrDatosFactura[4].FechaEmision = DateTime.Now;
            arrDatosFactura[4].Vendedor = "Victor Gonzales";
            arrMontoVenta[4] = 180;
        }
    }
}
