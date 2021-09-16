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
    public partial class frmEjercicio7 : Form
    {
        public frmEjercicio7()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            int numero, a = 1, b = 2, c = 0;
            String auxiliar = "";

            numero = Convert.ToInt32(nudNumero.Value);

            if (numero == 0)
            {
                auxiliar = "DEBE INDICAR UN VALOR MAYOR A 0";
            }
            else if (numero == 1)
            {
                auxiliar += a;
                auxiliar += "\n\n El término " + numero + " de la serie es: " + a;
            }
            else if (numero == 2)
            {
                auxiliar += a + " " + b;
                auxiliar += "\n\n El término " + numero + " de la serie es: " + b;
            }
            else
            {
                auxiliar += a + " " + b + " ";

                for (int i = 0; i <= numero - 3; i++)
                {

                    c = a + b;
                    a = b;
                    b = c;

                    auxiliar += c + " ";
                }

                auxiliar += "\n\n El término " + numero + " de la serie es: " + c;
            }

            lblRpta.Text = auxiliar;
        }
    }
}
