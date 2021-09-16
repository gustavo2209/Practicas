using Practicas.Cap07;
using Practicas.Cap08;
using Practicas.Cap09;
using Practicas.Cap10;
using Practicas.Cap12;
using Practicas.Examen_Parcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap07_01());
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap07_02());
        }

        private void tareaEjercicio02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap07_tarea02());
        }

        private void tareaEjercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap08_tarea01());
        }

        private void tareaEjercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap08_tarea02());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tareaEjercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap08_tarea03());
        }

        private void ejercicio03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap09_03());
        }

        private void mostrarFormulario(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void ejercicio01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap10_01());
        }

        private void ejercicio02CustomExceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCap10_customException());
        }

        private void ejercicio01ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmEjercicio1());
        }

        private void ejercicio02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmEjercicio2());
        }

        private void ejercicio03ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmEjercicio3());
        }

        private void ejercicio04ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmEjercicio4());
        }

        private void ejercicio05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmEjercicio5());
        }

        private void ejercicio06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmEjercicio6());
        }

        private void ejercicio07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmEjercicio7());
        }

        private void ejercicio02ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmCuotas());
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmDocumentos());
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarFormulario(new frmNumero());
        }
    }
}
