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
    public partial class frmColeccionList : Form
    {
        List<string> listadoPaises = new List<string>();

        public frmColeccionList()
        {
            InitializeComponent();
            txtPais.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar(); 
        }

        private void Agregar()
        {
            var pais = txtPais.Text;
            listadoPaises.Add(pais);

            lbItems.Items.Clear();
            lbItems.Items.AddRange(listadoPaises.ToArray());

            txtPais.Text = "";
            txtPais.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var item = lbItems.SelectedIndex;

            if(item >= 0)
            {
                var seleccion = lbItems.Items[item];
                listadoPaises.RemoveAt(item);
                MessageBox.Show("ELIMINADO: " + seleccion.ToString());

                lbItems.Items.Clear();
                lbItems.Items.AddRange(listadoPaises.ToArray());
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            foreach(string item in listadoPaises)
            {
                MessageBox.Show(item);
            }
        }
    }
}
