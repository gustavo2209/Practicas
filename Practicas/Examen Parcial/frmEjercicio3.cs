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
    public partial class frmEjercicio3 : Form
    {
        public frmEjercicio3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            int unidades = Convert.ToInt32(txtUnidades.Text);
            double precioUnitario = 0, importe = 0, descuento = 0;

            if (unidades <= 50)
                precioUnitario = 25.5;
            else if (unidades <= 100)
                precioUnitario = 22.5;
            else if (unidades <= 150)
                precioUnitario = 20;
            else
                precioUnitario = 18;

            if(unidades > 50)
                descuento = (precioUnitario * unidades) * 0.15;
            else
                descuento = (precioUnitario * unidades) * 0.05;

            importe = (precioUnitario * unidades) - descuento;

            lblRpta.Text = "IMPORTE DE LA COMPRA: S/. " + (precioUnitario * unidades) + "\n" + 
                           "IMPORTE DE DESCUENTO: S/. " + descuento + "\n" + 
                           "IMPORTE A PAGAR: S/. " + importe;
        }
    }
}
