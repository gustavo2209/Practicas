
namespace Practicas.Cap08
{
    partial class frmCap08_tarea01
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
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblrpta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese número:";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(141, 22);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(93, 20);
            this.nudNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(276, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblrpta
            // 
            this.lblrpta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrpta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrpta.Location = new System.Drawing.Point(27, 69);
            this.lblrpta.Name = "lblrpta";
            this.lblrpta.Size = new System.Drawing.Size(324, 32);
            this.lblrpta.TabIndex = 3;
            this.lblrpta.Text = "---";
            this.lblrpta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCap08_tarea01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 121);
            this.Controls.Add(this.lblrpta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmCap08_tarea01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial de un Número";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblrpta;
    }
}