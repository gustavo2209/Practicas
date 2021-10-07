
namespace Practicas.Cap20
{
    partial class frmPadre
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
            this.btnLlamarFormHijo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamarFormHijo
            // 
            this.btnLlamarFormHijo.Location = new System.Drawing.Point(26, 36);
            this.btnLlamarFormHijo.Name = "btnLlamarFormHijo";
            this.btnLlamarFormHijo.Size = new System.Drawing.Size(156, 50);
            this.btnLlamarFormHijo.TabIndex = 0;
            this.btnLlamarFormHijo.Text = "BUSCAR";
            this.btnLlamarFormHijo.UseVisualStyleBackColor = true;
            this.btnLlamarFormHijo.Click += new System.EventHandler(this.btnLlamarFormHijo_Click);
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 129);
            this.Controls.Add(this.btnLlamarFormHijo);
            this.Name = "frmPadre";
            this.Text = "frmPadre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlamarFormHijo;
    }
}