using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap21
{
    public partial class frmCrearArchivo : Form
    {
        public delegate void AfterSaveHandler(string archivo);

        public AfterSaveHandler AfterSave { get; set; }

        public string CarpetaRoot { get; set; }

        public frmCrearArchivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var fullPath = Path.Combine(CarpetaRoot, $"{txtNombreArchivo.Text}.txt");

            if (File.Exists(fullPath))
            {
                MessageBox.Show("EL ARCHIVO YA EXISTE, CONSIDERAR CAMBIAR DE NOMBRE");
            }
            else
            {
                using (var archivoWriter = new StreamWriter(fullPath))
                {
                    archivoWriter.Write(rtbContenido.Text);
                }

                if(AfterSave != null)
                {
                    AfterSave(fullPath);
                }
                
                this.Close();
            }
        }
    }
}
