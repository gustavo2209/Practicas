using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap16.Ejercicio1
{
    public partial class frmCredito : Form
    {
        ICredito credito;

        public frmCredito()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if(rbClienteConsumo.Checked || rbClienteExclusivo.Checked)
            {
                credito.MontoSolicitado = Convert.ToDouble(txtMonto.Text);
                credito.NumeroCuotas = Convert.ToInt32(txtCuotas.Text);
                credito.Calcular();
                txtValorCuota.Text = credito.CuotaCalculada.ToString();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN TIPO DE CLIENTE");
            }
        }
        
        private void rbClienteConsumo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClienteConsumo.Checked)
                credito = new CreditoClienteConsumo();
        }

        private void rbClienteExclusivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClienteExclusivo.Checked)
                credito = new CreditoClienteExclusivo();
        }
    }
}
