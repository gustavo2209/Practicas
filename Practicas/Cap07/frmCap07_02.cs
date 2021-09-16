﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap07
{
    public partial class frmCap07_02 : Form
    {
        public frmCap07_02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            int numero1 = Convert.ToInt32(txtnum1.Text);
            int numero2 = Convert.ToInt32(txtnum2.Text);
            int numero3 = Convert.ToInt32(txtnum3.Text);

            int suma = numero1 + numero2 + numero3;
            decimal promedio = suma / 3.0m;

            lblresultado.Text = "La suma es: " + suma.ToString() + " y el promedio es: " + decimal.Round(promedio,2);
        }
    }
}
