
namespace Practicas.Cap15.frmColeccionesGenericas
{
    partial class frmColeccionStack
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
            this.btnExtraerRemover = new System.Windows.Forms.Button();
            this.btnProximoRemover = new System.Windows.Forms.Button();
            this.lbListado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExtraerRemover
            // 
            this.btnExtraerRemover.Location = new System.Drawing.Point(16, 21);
            this.btnExtraerRemover.Name = "btnExtraerRemover";
            this.btnExtraerRemover.Size = new System.Drawing.Size(154, 37);
            this.btnExtraerRemover.TabIndex = 5;
            this.btnExtraerRemover.Text = "EXTRAER Y REMOVER";
            this.btnExtraerRemover.UseVisualStyleBackColor = true;
            this.btnExtraerRemover.Click += new System.EventHandler(this.btnExtraerRemover_Click);
            // 
            // btnProximoRemover
            // 
            this.btnProximoRemover.Location = new System.Drawing.Point(16, 85);
            this.btnProximoRemover.Name = "btnProximoRemover";
            this.btnProximoRemover.Size = new System.Drawing.Size(154, 37);
            this.btnProximoRemover.TabIndex = 4;
            this.btnProximoRemover.Text = "PROXIMO A REMOVER";
            this.btnProximoRemover.UseVisualStyleBackColor = true;
            this.btnProximoRemover.Click += new System.EventHandler(this.btnProximoRemover_Click);
            // 
            // lbListado
            // 
            this.lbListado.FormattingEnabled = true;
            this.lbListado.Location = new System.Drawing.Point(200, 21);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(189, 225);
            this.lbListado.TabIndex = 3;
            // 
            // frmColeccionStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 267);
            this.Controls.Add(this.btnExtraerRemover);
            this.Controls.Add(this.btnProximoRemover);
            this.Controls.Add(this.lbListado);
            this.Name = "frmColeccionStack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColeccionStack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExtraerRemover;
        private System.Windows.Forms.Button btnProximoRemover;
        private System.Windows.Forms.ListBox lbListado;
    }
}