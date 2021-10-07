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
    public partial class frmHijo : Form
    {

        public delegate void EventoDespuesCerrarFormulario();

        public EventoDespuesCerrarFormulario HandlerDespuesCerrarFormulario { get; set; }

        public frmHijo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            HandlerDespuesCerrarFormulario();
        }
    }
}
