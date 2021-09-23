using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap15.frmColeccionesGenericas
{
    public partial class frmColeccionDiccionario : Form
    {

        Dictionary<string, string> diccionario = new Dictionary<string, string>();

        public frmColeccionDiccionario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            var clave = txtKey.Text;

            if (diccionario.ContainsKey(clave))
            {
                MessageBox.Show("LA CLAVE YA SE INGRESÓ ANTERIORMENTE");
            }
            else
            {
                diccionario.Add(clave, txtValue.Text);
                LlenarCombo();
            }
        }

        private void LlenarCombo()
        {
            cmbListado.Items.Clear();

            foreach (string item in diccionario.Keys)
            {
                cmbListado.Items.Add(item);
            }
        }
    }
}
