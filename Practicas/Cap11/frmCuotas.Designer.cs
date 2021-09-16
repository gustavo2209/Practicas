
namespace Practicas.Cap12
{
    partial class frmCuotas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCuotaMensual = new System.Windows.Forms.NumericUpDown();
            this.nudNumeroCuotas = new System.Windows.Forms.NumericUpDown();
            this.cboMesInicio = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbListadoCuotas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoMayor = new System.Windows.Forms.TextBox();
            this.txtMontoMenor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotaMensual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUOTA MENSUAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NÚMERO CUOTAS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MES DE INICIO:";
            // 
            // nudCuotaMensual
            // 
            this.nudCuotaMensual.Location = new System.Drawing.Point(157, 33);
            this.nudCuotaMensual.Name = "nudCuotaMensual";
            this.nudCuotaMensual.Size = new System.Drawing.Size(120, 20);
            this.nudCuotaMensual.TabIndex = 3;
            // 
            // nudNumeroCuotas
            // 
            this.nudNumeroCuotas.Location = new System.Drawing.Point(157, 72);
            this.nudNumeroCuotas.Name = "nudNumeroCuotas";
            this.nudNumeroCuotas.Size = new System.Drawing.Size(120, 20);
            this.nudNumeroCuotas.TabIndex = 4;
            // 
            // cboMesInicio
            // 
            this.cboMesInicio.FormattingEnabled = true;
            this.cboMesInicio.Location = new System.Drawing.Point(157, 111);
            this.cboMesInicio.Name = "cboMesInicio";
            this.cboMesInicio.Size = new System.Drawing.Size(120, 21);
            this.cboMesInicio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(324, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbListadoCuotas
            // 
            this.lbListadoCuotas.FormattingEnabled = true;
            this.lbListadoCuotas.Location = new System.Drawing.Point(30, 174);
            this.lbListadoCuotas.Name = "lbListadoCuotas";
            this.lbListadoCuotas.Size = new System.Drawing.Size(369, 160);
            this.lbListadoCuotas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MONTO MAYOR:";
            // 
            // txtMontoMayor
            // 
            this.txtMontoMayor.Location = new System.Drawing.Point(157, 371);
            this.txtMontoMayor.Name = "txtMontoMayor";
            this.txtMontoMayor.Size = new System.Drawing.Size(120, 20);
            this.txtMontoMayor.TabIndex = 9;
            // 
            // txtMontoMenor
            // 
            this.txtMontoMenor.Location = new System.Drawing.Point(157, 414);
            this.txtMontoMenor.Name = "txtMontoMenor";
            this.txtMontoMenor.Size = new System.Drawing.Size(120, 20);
            this.txtMontoMenor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MONTO MENOR:";
            // 
            // frmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoMenor);
            this.Controls.Add(this.txtMontoMayor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbListadoCuotas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboMesInicio);
            this.Controls.Add(this.nudNumeroCuotas);
            this.Controls.Add(this.nudCuotaMensual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCuotas";
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotaMensual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCuotaMensual;
        private System.Windows.Forms.NumericUpDown nudNumeroCuotas;
        private System.Windows.Forms.ComboBox cboMesInicio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbListadoCuotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoMayor;
        private System.Windows.Forms.TextBox txtMontoMenor;
        private System.Windows.Forms.Label label5;
    }
}