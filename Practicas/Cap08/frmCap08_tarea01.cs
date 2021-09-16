using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap08
{
    public partial class frmCap08_tarea01 : Form
    {
        public frmCap08_tarea01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular(); 
        }

        private void Calcular()
        {
            int factorial = 1, x = 1, numero;

            numero = Convert.ToInt32(nudNumero.Value);

            while (x <= numero)
            {
                factorial *= x;
                x++;
            }

            lblrpta.Text = "El factorial de " + numero + " es: " + factorial;
        }
    }
}
