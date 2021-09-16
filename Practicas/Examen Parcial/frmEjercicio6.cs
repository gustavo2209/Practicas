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
    public partial class frmEjercicio6 : Form
    {
        public frmEjercicio6()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            var sueldos = new int[120];
            LlenarDatos(sueldos);
            txtPromedio.Text = SueldoPromedio(sueldos).ToString();
            txtMaximo.Text = SueldoMaximo(sueldos).ToString();
            txtMinimo.Text = SueldoMinimo(sueldos).ToString();
            txtNumEmpleados.Text = NEmpleadosSueldoInferior(sueldos).ToString();
        }

        private void LlenarDatos(int[] sueldos)
        {
            Random aleatorio = new Random();

            for (var i = 0; i < sueldos.Length; i++)
            {
                sueldos[i] = aleatorio.Next(800, 1700);
            }
        }

        private decimal SueldoPromedio(int[] sueldos)
        {
            decimal acumulador = 0;

            for (var i = 0; i < sueldos.Length; i++)
            {
                acumulador += sueldos[i];
            }

            return decimal.Round(acumulador/sueldos.Length,2);
        }

        private int SueldoMaximo(int[] sueldos)
        {
            int maximo = sueldos[0];

            for (var i = 0; i < sueldos.Length; i++)
            {
                if (sueldos[i] > maximo)
                    maximo = sueldos[i];
            }

            return maximo;
        }

        private int SueldoMinimo(int[] sueldos)
        {
            int minimo = sueldos[0];

            for (var i = 0; i < sueldos.Length; i++)
            {
                if (sueldos[i] < minimo)
                    minimo = sueldos[i];
            }

            return minimo;
        }

        private int NEmpleadosSueldoInferior(int[] sueldos)
        {
            int contador = 0;
            for (var i = 0; i < sueldos.Length; i++)
            {
                if (sueldos[i] < 1000)
                    contador++;
            }
            return contador;
        }
    }
}
