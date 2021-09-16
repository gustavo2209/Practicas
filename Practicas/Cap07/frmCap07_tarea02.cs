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
    public partial class frmCap07_tarea02 : Form
    {
        const double IGV = 0.18;

        public frmCap07_tarea02()
        {
            InitializeComponent();
            txtPrecio.Focus();
            txtIGV.Text = IGV * 100 + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio, calculoIGV, total;

            precio = Convert.ToDouble(txtPrecio.Text);
            calculoIGV = precio * IGV;
            total = precio + calculoIGV;

            lblresultado.Text = total.ToString();

        }
    }
}
