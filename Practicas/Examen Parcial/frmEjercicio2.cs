using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Examen_Parcial
{
    public partial class frmEjercicio2 : Form
    {
        const double IGV = 0.18;

        public frmEjercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            double subtotal, descuentoIGV = 0;
            double monto = Convert.ToDouble(txtMonto.Text);
            double descuento = monto * 0.12;

            subtotal = monto - descuento;
            descuentoIGV = (subtotal * IGV) + subtotal;

            lblRpta.Text = "EL DESCUENTO ES: S/. " + descuento + "\n" +
                           "EL SUBTOTAL ES: S/. " + subtotal + "\n" + 
                           "SUBTOTAL CON IGV: S/. " + descuentoIGV;
        }
    }
}
