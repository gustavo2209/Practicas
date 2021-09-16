using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap08
{
    public partial class frmCap08_tarea03 : Form
    {
        public frmCap08_tarea03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String marca = txtMarca.Text;
            int tamanio = Convert.ToInt32(txtTamanio.Text);
            int precio = 0;

            if(marca.Equals("Sony", StringComparison.InvariantCultureIgnoreCase) ||
               marca.Equals("Panasonic", StringComparison.InvariantCultureIgnoreCase) ||
               marca.Equals("Samsung", StringComparison.InvariantCultureIgnoreCase) ||
               marca.Equals("LG", StringComparison.InvariantCultureIgnoreCase)){
                if (tamanio == 12 || tamanio == 20 || tamanio == 29){
                    if (marca.Equals("Sony", StringComparison.InvariantCultureIgnoreCase) && tamanio == 12)
                        precio = 300;
                    else if (marca.Equals("Sony", StringComparison.InvariantCultureIgnoreCase) && tamanio == 20)
                        precio = 415;
                    else if (marca.Equals("Sony", StringComparison.InvariantCultureIgnoreCase) && tamanio == 29)
                        precio = 650;
                    else if (marca.Equals("Panasonic", StringComparison.InvariantCultureIgnoreCase) && tamanio == 12)
                        precio = 270;
                    else if (marca.Equals("Panasonic", StringComparison.InvariantCultureIgnoreCase) && tamanio == 20)
                        precio = 350;
                    else if (marca.Equals("Panasonic", StringComparison.InvariantCultureIgnoreCase) && tamanio == 29)
                        precio = 570;
                    else if (marca.Equals("Samsung", StringComparison.InvariantCultureIgnoreCase) && tamanio == 12)
                        precio = 220;
                    else if (marca.Equals("Samsung", StringComparison.InvariantCultureIgnoreCase) && tamanio == 20)
                        precio = 310;
                    else if (marca.Equals("Samsung", StringComparison.InvariantCultureIgnoreCase) && tamanio == 29)
                        precio = 550;
                    else if (marca.Equals("LG", StringComparison.InvariantCultureIgnoreCase) && tamanio == 12)
                        precio = 200;
                    else if (marca.Equals("LG", StringComparison.InvariantCultureIgnoreCase) && tamanio == 20)
                        precio = 300;
                    else
                        precio = 510;

                    lblRpta.Text = "EL PRECIO DEL TELEVISOR ES: " + precio;
                }else{
                    lblRpta.Text = "NO EXISTE EL TAMAÑO PROPORCIONADO";
                }
            }else {
                lblRpta.Text = "NO EXISTE LA MARCA PROPORCIONADA";
            }
        }
    }
}
