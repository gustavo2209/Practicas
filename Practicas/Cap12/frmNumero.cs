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
    public partial class frmNumero : Form
    {
        public frmNumero()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular(); 
        }

        private void Calcular()
        {
            var objNumero = new Numero();
            int.TryParse(txtNumero.Text, out int valor);
            objNumero.Valor = valor;

            lblFactorial.Text = objNumero.CalcularFactorial().ToString();
            lblPrimo.Text = objNumero.VerificarSiEsPrimo() ? "Es primo" : "No es primo";
        }
    }
}
