using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap14
{
    public partial class frmLab14_01 : Form
    {
        public frmLab14_01()
        {
            InitializeComponent();
        }

        private void btnFormatear_Click(object sender, EventArgs e)
        {
            Formatear();
        }

        private void Formatear()
        {
            var numero = Convert.ToInt32(txtNumero.Text);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-PE");

            txtCultura.Text = CultureInfo.CurrentCulture.Name;
            txtResultado.Text = numero.ToString("C2");
        }
    }
}
