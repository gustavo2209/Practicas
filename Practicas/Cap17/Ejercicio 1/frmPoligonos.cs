using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap17.Ejercicio_1
{
    public partial class frmPoligonos : Form
    {
        private Poligono poligono;
        private enum TipoPoligono
        {
            Cuadrado,
            Triangulo
        }

        public frmPoligonos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            var medidaLado = Convert.ToDouble(txtLado.Text);
            poligono.Lado = medidaLado;
            lblArea.Text = poligono.CalcularArea().ToString();
            lblPerimetro.Text = poligono.CalcularPerimetro().ToString();
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarPoligono(rbTriangulo.Checked, TipoPoligono.Triangulo);
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurarPoligono(rbCuadrado.Checked, TipoPoligono.Cuadrado);
        }

        private void ConfigurarPoligono(bool flagChecked, TipoPoligono tipoPoligono)
        {
            if (flagChecked)
            {
                if (tipoPoligono == TipoPoligono.Cuadrado)
                    poligono = new Cuadrado() { NLados = 4 };
                else
                    poligono = new TraianguloEquilatero() { NLados = 3 };
            }
        }
    }
}
