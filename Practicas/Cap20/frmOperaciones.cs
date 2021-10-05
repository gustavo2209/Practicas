using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap20
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
            ConfigInit();
        }

        private void ConfigInit()
        {
            btnSumar.Click += Sumar;
        }

        private void Sumar(object sender, EventArgs e)
        {
            var suma = Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text);
            txtResultado.Text = suma.ToString();
        }
    }
}
