using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap15.frmColeccionesNoGenericas
{
    public partial class frmColeccionArrayList : Form
    {
        ArrayList elementos = new ArrayList(); 
        public frmColeccionArrayList()
        {
            InitializeComponent();
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla = Convert.ToInt32(e.KeyChar);
            if (tecla == 13)
            {
                AgregarItem();
            }
        }

        private void AgregarItem()
        {
            elementos.Add(txtItem.Text);
            lblCantidad.Text = elementos.Count.ToString();
            lblCapacidad.Text = elementos.Capacity.ToString();
        }

        private void btnVolcar_Click(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            lstItems.Items.Clear();
            lstItems.Items.AddRange(elementos.ToArray());
        }
    }
}
