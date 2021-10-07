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
    public partial class frmSystemIO : Form
    {
        const string CarpetaRoot = @"D:\Solicitudes";

        public frmSystemIO()
        {
            InitializeComponent();
            InitConfig();
        }

        public void InitConfig()
        {
            if (!Directory.Exists(CarpetaRoot))
            {
                Directory.CreateDirectory(CarpetaRoot);
            }

            ActualizarDirectorios();
        }

        private void ActualizarDirectorios()
        {
            twCarpetas.Nodes.Clear();

            var nombreCarpetaPadre = new DirectoryInfo(CarpetaRoot).Name;
            var nodePadre = twCarpetas.Nodes.Add(nombreCarpetaPadre);
            nodePadre.Expand();

            foreach (var directorio in Directory.GetDirectories(CarpetaRoot))
            {
                nodePadre.Nodes.Add(new DirectoryInfo(directorio).Name);
            }
        }

        private void refrescarDirectoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarDirectorios();
        }

        private void twCarpetas_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            HandlerNode(e.Node);
        }

        private void HandlerNode(TreeNode nodoSeleccionado)
        {
            lvArchivos.Items.Clear();

            if (nodoSeleccionado != null && nodoSeleccionado.Level > 0)
            {
                var fullPath = Path.Combine(CarpetaRoot, nodoSeleccionado.Text);

                foreach (var archivo in Directory.GetFiles(fullPath))
                {
                    var fileInfo = new FileInfo(archivo);
                    var listaPropiedades = new List<string>();
                    listaPropiedades.Add(fileInfo.Name);
                    listaPropiedades.Add(fileInfo.CreationTime.ToString());
                    listaPropiedades.Add($"{fileInfo.Length} bytes");
                    listaPropiedades.Add(fileInfo.Extension);
                    
                    var lvItem = new ListViewItem(listaPropiedades.ToArray());
                    lvArchivos.Items.Add(lvItem);
                }
            }
        }

        private void crearArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearArchivo();
        }

        private void CrearArchivo()
        {
            if(twCarpetas.SelectedNode != null)
            {
                var frm = new frmCrearArchivo();
                frm.CarpetaRoot = Path.Combine(CarpetaRoot, twCarpetas.SelectedNode.Text);
                frm.AfterSave += CallBackDespuesCrearArchivo;
                frm.Show();
            }
        }

        private void CallBackDespuesCrearArchivo(string archivo)
        {
            if(twCarpetas.SelectedNode != null)
            {
                HandlerNode(twCarpetas.SelectedNode);
            }
        }

        private void lvArchivos_DoubleClick(object sender, EventArgs e)
        {
            if(lvArchivos.SelectedItems != null)
            {
                var lisItem = lvArchivos.SelectedItems[0];
                MessageBox.Show(lisItem.Text.ToString());
            }   
        }
    }
}
