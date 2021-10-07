using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap20
{
    public partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }

        private void btnLlamarFormHijo_Click(object sender, EventArgs e)
        {
            var frm = new frmHijo();
            frm.HandlerDespuesCerrarFormulario += CallBackRetornoFormularioHijo;
            frm.Show();
        }

        private void CallBackRetornoFormularioHijo()
        {
            MessageBox.Show("Se ha grabado información del formulario hijo");
        }
    }
}
