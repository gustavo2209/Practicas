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
    public partial class frmColeccionStack : Form
    {
        Stack<string> stack = new Stack<string>();

        public frmColeccionStack()
        {
            InitializeComponent();
            InicializarData();
        }

        private void InicializarData()
        {
            stack.Push("Uno");
            stack.Push("Dos");
            stack.Push("Tres");
            stack.Push("Cuatro");
            stack.Push("Cinco");
            stack.Push("Seis");

            lbListado.Items.AddRange(stack.ToArray());
        }

        private void btnExtraerRemover_Click(object sender, EventArgs e)
        {
            Extraer();
        }

        private void Extraer()
        {
            stack.Pop();

            //MessageBox.Show(stack.Pop());

            lbListado.Items.Clear();
            lbListado.Items.AddRange(stack.ToArray());
        }

        private void btnProximoRemover_Click(object sender, EventArgs e)
        {
            ProximoRemover();
        }

        private void ProximoRemover()
        {
            stack.Peek();
        }
    }
}
