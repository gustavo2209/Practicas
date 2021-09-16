using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap10
{
    public partial class frmCap10_01 : Form
    {
        public frmCap10_01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            try
            {
                int numerador = Convert.ToInt32(txtNumerador.Text);
                int denominador = Convert.ToInt32(txtDenominador.Text);

                int division = numerador / denominador;
            }catch(DivideByZeroException ex){
                MessageBox.Show("La división entre cero no existe");
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally{
                MessageBox.Show("Operación realizada");
            }
        }
    }
}
