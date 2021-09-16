
namespace Practicas.Cap08
{
    partial class frmCap08_tarea02
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRpta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(276, 24);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(141, 27);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(93, 20);
            this.nudNumero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese valor:";
            // 
            // lblRpta
            // 
            this.lblRpta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRpta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRpta.Location = new System.Drawing.Point(27, 72);
            this.lblRpta.Name = "lblRpta";
            this.lblRpta.Size = new System.Drawing.Size(324, 168);
            this.lblRpta.TabIndex = 6;
            this.lblRpta.Text = "---";
            this.lblRpta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCap08_tarea02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.lblRpta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmCap08_tarea02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRpta;
    }
}