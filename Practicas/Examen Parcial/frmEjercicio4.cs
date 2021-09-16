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
    public partial class frmEjercicio4 : Form
    {
        public frmEjercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            int monto = Convert.ToInt32(txtMontoDonacion.Text);
            double donacionCS = 0, donacionCN = 0, donacionBolsa = 0;

            if (monto >= 10000)
            {
                donacionCS = monto * 0.3;
                donacionCN = monto * 0.5;
                donacionBolsa = monto - donacionCS - donacionCN;
            }
            else
            {
                donacionCS = monto * 0.25;
                donacionCN = monto * 0.6;
                donacionBolsa = monto - donacionCS - donacionCN;
            }

            lblRpta.Text = "DONACION CENTRO DE SALUD: " + donacionCS + "\n" +
                           "DONACION COMEDOR DE NIÑOS: " + donacionCN + "\n" +
                           "BOLSA: " + donacionBolsa;
        }
    }
}
