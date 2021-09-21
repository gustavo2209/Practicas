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
    public partial class frmHashTable : Form
    {
        Hashtable listaHash = new Hashtable();

        public frmHashTable()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            listaHash.Clear();
            listaHash.Add("USD", "Dolar");
            listaHash.Add("NS", "Soles");
            listaHash.Add("EU", "Euro");
            listaHash.Add("Y", "Yenes");
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla = Convert.ToInt32(e.KeyChar);
            if (tecla == 13)
            {
                BuscarEnHash();
            }
        }

        private void BuscarEnHash()
        {
            string key = txtKey.Text;

            if (listaHash.ContainsKey(key))
            {
                string valorEncontrado = listaHash[key].ToString();
                lblValue.Text = valorEncontrado;
            }
            else
            {
                MessageBox.Show("EL ELEMENTO NO EXISTE");
            }
            
        }
    }
}
