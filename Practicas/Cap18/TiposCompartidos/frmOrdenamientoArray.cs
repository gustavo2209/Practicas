using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap18.TiposCompartidos
{
    public partial class frmOrdenamientoArray : Form
    {
        List<int> numeros = new List<int>();

        public frmOrdenamientoArray()
        {
            InitializeComponent();
            txtNumero.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            numeros.Add(Convert.ToInt32(txtNumero.Text));
            LlenarListaDesordenada();
            txtNumero.Text = "";
            txtNumero.Focus();
        }

        private void LlenarListaDesordenada()
        {
            lbListaDesordenada.DataSource = null;
            lbListaDesordenada.DataSource = numeros;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarLista();
        }

        private void OrdenarLista()
        {
            lbListaOrdenada.DataSource = FuncionesOrdenamiento.Ascendente(numeros.ToArray());
        }
    }
}
