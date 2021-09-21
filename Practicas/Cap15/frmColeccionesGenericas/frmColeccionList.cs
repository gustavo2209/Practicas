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
        }
    }
}
