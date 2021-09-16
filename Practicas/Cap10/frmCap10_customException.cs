using Practicas.Cap10.CustomException;
using Practicas.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap10
{
    public partial class frmCap10_customException : Form
    {
        public frmCap10_customException()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void Grabar()
        {
            try
            {
                var estudiante = new Estudiante(txtnombre.Text, dtpFechaNacimiento.Value);
                MessageBox.Show("Datos del estudiante están correctos");
            }catch(DatosEstudianteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
