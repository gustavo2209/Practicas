
namespace Practicas.Cap13
{
    partial class frmAuto
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
            this.txtRuedas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTiempoPromedio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClasificar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUEDAS:";
            // 
            // txtRuedas
            // 
            this.txtRuedas.Location = new System.Drawing.Point(123, 29);
            this.txtRuedas.Name = "txtRuedas";
            this.txtRuedas.Size = new System.Drawing.Size(100, 20);
            this.txtRuedas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLACA:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(123, 64);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(123, 99);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MARCA:";
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(123, 134);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(100, 20);
            this.txtPuertas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PUERTAS:";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(123, 169);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "VELOCIDAD:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(256, 29);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 194);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTiempoPromedio
            // 
            this.txtTiempoPromedio.Location = new System.Drawing.Point(540, 96);
            this.txtTiempoPromedio.Name = "txtTiempoPromedio";
            this.txtTiempoPromedio.ReadOnly = true;
            this.txtTiempoPromedio.Size = new System.Drawing.Size(165, 20);
            this.txtTiempoPromedio.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TIEMPO PROMEDIO:";
            // 
            // txtClasificar
            // 
            this.txtClasificar.Location = new System.Drawing.Point(540, 131);
            this.txtClasificar.Name = "txtClasificar";
            this.txtClasificar.ReadOnly = true;
            this.txtClasificar.Size = new System.Drawing.Size(165, 20);
            this.txtClasificar.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CLASIFICAR:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(123, 207);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "DISTANCIA";
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 249);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtClasificar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTiempoPromedio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRuedas);
            this.Controls.Add(this.label1);
            this.Name = "frmAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuedas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTiempoPromedio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClasificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label8;
    }
}