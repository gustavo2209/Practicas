using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap13
{
    public partial class frmAuto : Form
    {
        public frmAuto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            var vehiculo = new Vehiculo();
            vehiculo.Marca = txtMarca.Text;
            vehiculo.NPuertas = Convert.ToInt32(txtPuertas.Text);
            vehiculo.NRuedas = Convert.ToInt32(txtRuedas.Text);
            vehiculo.Placa = txtPlaca.Text;
            vehiculo.VelocidadMaxima = Convert.ToDouble(txtVelocidad.Text);

            var distancia = Convert.ToInt32(txtDistancia.Text);

            txtTiempoPromedio.Text = vehiculo.CalcularTiempoPromedio(distancia).ToString();
            txtClasificar.Text = vehiculo.Clasificar();
        }
    }
}
