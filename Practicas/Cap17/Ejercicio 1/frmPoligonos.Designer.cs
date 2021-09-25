
namespace Practicas.Cap17.Ejercicio_1
{
    partial class frmPoligonos
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEDIDA LADO:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(120, 29);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCuadrado);
            this.groupBox1.Controls.Add(this.rbTriangulo);
            this.groupBox1.Location = new System.Drawing.Point(29, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POLÍGONO";
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(23, 33);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(88, 17);
            this.rbTriangulo.TabIndex = 0;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "TRIÁNGULO";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Location = new System.Drawing.Point(23, 69);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(86, 17);
            this.rbCuadrado.TabIndex = 1;
            this.rbCuadrado.TabStop = true;
            this.rbCuadrado.Text = "CUADRADO";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            this.rbCuadrado.CheckedChanged += new System.EventHandler(this.rbCuadrado_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(268, 27);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 158);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PERÍMETRO:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerimetro.Enabled = false;
            this.lblPerimetro.Location = new System.Drawing.Point(482, 81);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(100, 23);
            this.lblPerimetro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ÁREA:";
            // 
            // lblArea
            // 
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Enabled = false;
            this.lblArea.Location = new System.Drawing.Point(482, 127);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 23);
            this.lblArea.TabIndex = 7;
            // 
            // frmPoligonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 214);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label1);
            this.Name = "frmPoligonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPoligonos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArea;
    }
}