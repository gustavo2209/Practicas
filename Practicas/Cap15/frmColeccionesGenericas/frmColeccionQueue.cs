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
    public partial class frmColeccionQueue : Form
    {
        Queue<string> cola = new Queue<string>();

        public frmColeccionQueue()
        {
            InitializeComponent();
            InicializarData();
        }

        private void InicializarData()
        {
            cola.Enqueue("Uno");
            cola.Enqueue("Dos");
            cola.Enqueue("Tres");
            cola.Enqueue("Cuatro");
            cola.Enqueue("Cinco");
            cola.Enqueue("Seis");

            lbListado.Items.AddRange(cola.ToArray());
        }

        private void btnExtraerRemover_Click(object sender, EventArgs e)
        {
            Extraer();
        }

        private void Extraer()
        {
            cola.Dequeue();

            //MessageBox.Show(cola.Dequeue());

            lbListado.Items.Clear();
            lbListado.Items.AddRange(cola.ToArray());
        }

        private void btnProximoRemover_Click(object sender, EventArgs e)
        {
            ProximoRemover();
        }

        private void ProximoRemover()
        {
            cola.Peek();
        }
    }
}
