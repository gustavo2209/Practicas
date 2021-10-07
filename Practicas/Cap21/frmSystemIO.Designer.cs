
namespace Practicas.Cap21
{
    partial class frmSystemIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.twCarpetas = new System.Windows.Forms.TreeView();
            this.lvArchivos = new System.Windows.Forms.ListView();
            this.refrescarDirectorios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrescarDirectoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarDirectorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // twCarpetas
            // 
            this.twCarpetas.ContextMenuStrip = this.refrescarDirectorios;
            this.twCarpetas.Dock = System.Windows.Forms.DockStyle.Left;
            this.twCarpetas.Location = new System.Drawing.Point(0, 0);
            this.twCarpetas.Name = "twCarpetas";
            this.twCarpetas.Size = new System.Drawing.Size(205, 450);
            this.twCarpetas.TabIndex = 0;
            // 
            // lvArchivos
            // 
            this.lvArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvArchivos.HideSelection = false;
            this.lvArchivos.Location = new System.Drawing.Point(205, 0);
            this.lvArchivos.Name = "lvArchivos";
            this.lvArchivos.Size = new System.Drawing.Size(453, 450);
            this.lvArchivos.TabIndex = 1;
            this.lvArchivos.UseCompatibleStateImageBehavior = false;
            // 
            // refrescarDirectorios
            // 
            this.refrescarDirectorios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrescarDirectoriosToolStripMenuItem});
            this.refrescarDirectorios.Name = "refrescarDirectorios";
            this.refrescarDirectorios.Size = new System.Drawing.Size(182, 26);
            this.refrescarDirectorios.Click += new System.EventHandler(this.refrescarDirectorios_Click);
            // 
            // refrescarDirectoriosToolStripMenuItem
            // 
            this.refrescarDirectoriosToolStripMenuItem.Name = "refrescarDirectoriosToolStripMenuItem";
            this.refrescarDirectoriosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.refrescarDirectoriosToolStripMenuItem.Text = "Refrescar directorios";
            this.refrescarDirectoriosToolStripMenuItem.Click += new System.EventHandler(this.refrescarDirectoriosToolStripMenuItem_Click);
            // 
            // frmSystemIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.lvArchivos);
            this.Controls.Add(this.twCarpetas);
            this.Name = "frmSystemIO";
            this.Text = "frmSystemIO";
            this.refrescarDirectorios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView twCarpetas;
        private System.Windows.Forms.ListView lvArchivos;
        private System.Windows.Forms.ContextMenuStrip refrescarDirectorios;
        private System.Windows.Forms.ToolStripMenuItem refrescarDirectoriosToolStripMenuItem;
    }
}