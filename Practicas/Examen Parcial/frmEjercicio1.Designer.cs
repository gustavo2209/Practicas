
namespace Practicas.Examen_Parcial
{
    partial class frmEjercicio1
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
            this.txtHorasDurmiendo = new System.Windows.Forms.TextBox();
            this.txtHorasDescansando = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.lblRpta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HORAS DURMIENDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HORAS DESCANSANDO:";
            // 
            // txtHorasDurmiendo
            // 
            this.txtHorasDurmiendo.Location = new System.Drawing.Point(184, 30);
            this.txtHorasDurmiendo.Name = "txtHorasDurmiendo";
            this.txtHorasDurmiendo.Size = new System.Drawing.Size(100, 20);
            this.txtHorasDurmiendo.TabIndex = 2;
            // 
            // txtHorasDescansando
            // 
            this.txtHorasDescansando.Location = new System.Drawing.Point(184, 88);
            this.txtHorasDescansando.Name = "txtHorasDescansando";
            this.txtHorasDescansando.Size = new System.Drawing.Size(100, 20);
            this.txtHorasDescansando.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.Calcular.Location = new System.Drawing.Point(332, 86);
            this.Calcular.Name = "btnCalcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "CALCULAR";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRpta
            // 
            this.lblRpta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRpta.Location = new System.Drawing.Point(29, 154);
            this.lblRpta.Name = "lblRpta";
            this.lblRpta.Size = new System.Drawing.Size(378, 61);
            this.lblRpta.TabIndex = 5;
            this.lblRpta.Text = "---";
            // 
            // frmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 237);
            this.Controls.Add(this.lblRpta);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.txtHorasDescansando);
            this.Controls.Add(this.txtHorasDurmiendo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALORÍAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasDurmiendo;
        private System.Windows.Forms.TextBox txtHorasDescansando;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label lblRpta;
    }
}