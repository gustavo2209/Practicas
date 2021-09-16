using Practicas.Cap11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap12
{
    public partial class frmCuotas : Form
    {
        private Cuotas[] arrCuotas = new Cuotas[5];
        private int currentIndice = 0;

        public frmCuotas()
        {
            InitializeComponent();
            Setup();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Setup()
        {
            LlenasMeses();
            
        }

        private void LlenasMeses()
        {
            cboMesInicio.Items.Add("Enero");
            cboMesInicio.Items.Add("Febrero");
            cboMesInicio.Items.Add("Marzo");
            cboMesInicio.Items.Add("Abril");
            cboMesInicio.Items.Add("Mayo");
            cboMesInicio.Items.Add("Junio");
            cboMesInicio.Items.Add("Julio");
            cboMesInicio.Items.Add("Agosto");
            cboMesInicio.Items.Add("Setiembre");
            cboMesInicio.Items.Add("Octubre");
            cboMesInicio.Items.Add("Noviembre");
            cboMesInicio.Items.Add("Diciembre");
        }

        private void Agregar()
        {
            try
            {
                if (currentIndice > arrCuotas.Length - 1)
                {
                    MessageBox.Show("LISTA COMPLETA DE CUOTAS");
                    return;
                }
                arrCuotas[currentIndice].CuotaMensual = (double)nudCuotaMensual.Value;
                arrCuotas[currentIndice].NumeroCuotas = (int)nudNumeroCuotas.Value;
                arrCuotas[currentIndice].MesInicio = cboMesInicio.SelectedIndex + 1;

                currentIndice++;

                ListarCuotas();
                Calculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCURRIÓ UN ERROR EN EL SISTEMA. INTENTAR NUEVAMENTE");
            }

        }

        private void ListarCuotas()
        {
            lbListadoCuotas.Items.Clear();
            foreach (Cuotas item in arrCuotas)
            {
                lbListadoCuotas.Items.Add($"Mes:{item.MesInicio} - Cuota:{item.CuotaMensual} - Numero:{item.NumeroCuotas}");
            }
        }

        private void Calculos()
        {
            double mayor = -1, menor = 999999999;

            foreach (Cuotas item in arrCuotas)
            {
                double monto = item.CuotaMensual * item.NumeroCuotas;

                if (monto > mayor)
                {
                    mayor = monto;
                }

                if (monto < menor)
                {
                    menor = monto;
                }
            }

            txtMontoMayor.Text = mayor.ToString();
            txtMontoMenor.Text = menor.ToString();
        }
    }
}
