
namespace Practicas.Cap14
{
    partial class frmLab14_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnFormatear = new System.Windows.Forms.Button();
            this.txtCultura = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÚMERO:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(28, 56);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnFormatear
            // 
            this.btnFormatear.Location = new System.Drawing.Point(28, 98);
            this.btnFormatear.Name = "btnFormatear";
            this.btnFormatear.Size = new System.Drawing.Size(100, 23);
            this.btnFormatear.TabIndex = 2;
            this.btnFormatear.Text = "FORMATOS";
            this.btnFormatear.UseVisualStyleBackColor = true;
            this.btnFormatear.Click += new System.EventHandler(this.btnFormatear_Click);
            // 
            // txtCultura
            // 
            this.txtCultura.Location = new System.Drawing.Point(28, 147);
            this.txtCultura.Name = "txtCultura";
            this.txtCultura.ReadOnly = true;
            this.txtCultura.Size = new System.Drawing.Size(100, 20);
            this.txtCultura.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(28, 187);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // frmLab14_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 233);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCultura);
            this.Controls.Add(this.btnFormatear);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmLab14_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLab14_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnFormatear;
        private System.Windows.Forms.TextBox txtCultura;
        private System.Windows.Forms.TextBox txtResultado;
    }
}