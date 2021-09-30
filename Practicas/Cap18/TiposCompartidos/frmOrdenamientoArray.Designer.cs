
namespace Practicas.Cap18.TiposCompartidos
{
    partial class frmOrdenamientoArray
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
            this.lbListaDesordenada = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbListaOrdenada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListaDesordenada
            // 
            this.lbListaDesordenada.FormattingEnabled = true;
            this.lbListaDesordenada.Location = new System.Drawing.Point(26, 84);
            this.lbListaDesordenada.Name = "lbListaDesordenada";
            this.lbListaDesordenada.Size = new System.Drawing.Size(120, 95);
            this.lbListaDesordenada.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(26, 202);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(120, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(26, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(120, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(174, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbListaOrdenada
            // 
            this.lbListaOrdenada.FormattingEnabled = true;
            this.lbListaOrdenada.Location = new System.Drawing.Point(26, 247);
            this.lbListaOrdenada.Name = "lbListaOrdenada";
            this.lbListaOrdenada.Size = new System.Drawing.Size(120, 95);
            this.lbListaOrdenada.TabIndex = 4;
            // 
            // frmOrdenamientoArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 362);
            this.Controls.Add(this.lbListaOrdenada);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lbListaDesordenada);
            this.Name = "frmOrdenamientoArray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenamientoArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaDesordenada;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbListaOrdenada;
    }
}