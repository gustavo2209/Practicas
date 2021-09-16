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
    public partial class frmEjercicio5 : Form
    {
        public frmEjercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            ProcesarPension();
        }

        private void ProcesarPension()
        {
            int indice = cboCategoria.SelectedIndex;
            double promedio = Convert.ToDouble(txtPromedio.Text);
            double descuento = 0, rebaja = 0, nuevaPension = 0;
            int pension = 0;

            if (indice == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ITEM");
                pension = 0;
            }             
            else
            {
                if (indice == 0)
                    pension = 550;
                else if (indice == 1)
                    pension = 500;
                else if (indice == 2)
                    pension = 460;
                else
                    pension = 400;
            }

            if (promedio < 14)
                descuento = 0;
            else if (promedio < 16)
                descuento = 10;
            else if (descuento < 18)
                descuento = 12;
            else
                descuento = 15;

            rebaja = (pension * descuento) / 100;

            nuevaPension = pension - rebaja;

            txtRebaja.Text = rebaja.ToString();

            txtNuevaPension.Text = nuevaPension.ToString();

        }
    }
}
