using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap07
{
    public partial class frmCap07_01 : Form
    {
        public frmCap07_01()
        {
            InitializeComponent();
            txtnum1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            int numero1 = Convert.ToInt32(txtnum1.Text);
            int numero2 = Convert.ToInt32(txtnum2.Text);

            int resultado = numero1 + numero2;

            lblresultado.Text = resultado.ToString();
        }
    }
}
