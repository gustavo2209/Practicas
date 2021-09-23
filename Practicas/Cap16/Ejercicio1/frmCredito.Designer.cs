
namespace Practicas.Cap16.Ejercicio1
{
    partial class frmCredito
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClienteConsumo = new System.Windows.Forms.RadioButton();
            this.rbClienteExclusivo = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONTO:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(111, 23);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(178, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUOTAS:";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(111, 69);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(178, 20);
            this.txtCuotas.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClienteExclusivo);
            this.groupBox1.Controls.Add(this.rbClienteConsumo);
            this.groupBox1.Location = new System.Drawing.Point(29, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // rbClienteConsumo
            // 
            this.rbClienteConsumo.AutoSize = true;
            this.rbClienteConsumo.Location = new System.Drawing.Point(19, 36);
            this.rbClienteConsumo.Name = "rbClienteConsumo";
            this.rbClienteConsumo.Size = new System.Drawing.Size(80, 17);
            this.rbClienteConsumo.TabIndex = 0;
            this.rbClienteConsumo.Text = "CONSUMO";
            this.rbClienteConsumo.UseVisualStyleBackColor = true;
            this.rbClienteConsumo.CheckedChanged += new System.EventHandler(this.rbClienteConsumo_CheckedChanged);
            // 
            // rbClienteExclusivo
            // 
            this.rbClienteExclusivo.AutoSize = true;
            this.rbClienteExclusivo.Location = new System.Drawing.Point(157, 36);
            this.rbClienteExclusivo.Name = "rbClienteExclusivo";
            this.rbClienteExclusivo.Size = new System.Drawing.Size(85, 17);
            this.rbClienteExclusivo.TabIndex = 1;
            this.rbClienteExclusivo.Text = "EXCLUSIVO";
            this.rbClienteExclusivo.UseVisualStyleBackColor = true;
            this.rbClienteExclusivo.CheckedChanged += new System.EventHandler(this.rbClienteExclusivo_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(346, 26);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 63);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CALCULAR:";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(111, 227);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.ReadOnly = true;
            this.txtValorCuota.Size = new System.Drawing.Size(178, 20);
            this.txtValorCuota.TabIndex = 7;
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 269);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Name = "frmCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCredito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClienteExclusivo;
        private System.Windows.Forms.RadioButton rbClienteConsumo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorCuota;
    }
}