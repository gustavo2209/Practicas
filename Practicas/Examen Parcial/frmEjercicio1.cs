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
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void Calculo()
        {
            double totalCalorias = 0;
            int horasDurmiendo = Convert.ToInt32(txtHorasDurmiendo.Text);
            int horasDescansando = Convert.ToInt32(txtHorasDescansando.Text);

            if((horasDescansando + horasDurmiendo) <= 24)
            {
                totalCalorias = (horasDurmiendo * 60 * 1.08) + (horasDescansando * 60 * 1.66);

                lblRpta.Text = "CALORIAS CONSUMIDAS: " + totalCalorias;
            }
            else
            {
                MessageBox.Show("EL TOTAL DE HORAS EXCEDE EN 24");
            }
        }
    }
}
