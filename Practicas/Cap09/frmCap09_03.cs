using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap09
{
    public partial class frmCap09_03 : Form
    {
        public frmCap09_03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            var nota1 = Convert.ToInt32(txtnum1.Text);
            var nota2 = Convert.ToInt32(txtnum2.Text);
            var nota3 = Convert.ToInt32(txtnum3.Text);

            decimal promedio = 0;

            CalcularPromedio(nota1, nota2, nota3, ref promedio);

            lblresultado.Text = promedio.ToString();
        }

        private void CalcularPromedio(int nota1, int nota2, int nota3, ref decimal promedioRef)
        {
            decimal resultado = (nota1 + nota2 + nota3) / 3m;

            promedioRef = resultado;
        }
    }
}
