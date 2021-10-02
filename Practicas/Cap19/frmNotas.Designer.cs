
namespace Practicas.Cap19
{
    partial class frmNotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPracticas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPorNombre = new System.Windows.Forms.RadioButton();
            this.rbPorNota = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.txtNotaBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbDatos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPracticas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR NOTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRÁCTICA:";
            // 
            // cbPracticas
            // 
            this.cbPracticas.FormattingEnabled = true;
            this.cbPracticas.Location = new System.Drawing.Point(100, 66);
            this.cbPracticas.Name = "cbPracticas";
            this.cbPracticas.Size = new System.Drawing.Size(80, 21);
            this.cbPracticas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOTA:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(100, 106);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(80, 20);
            this.txtNota.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(217, 104);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(116, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "REGISTRAR NOTA";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtNotaBusqueda);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNombreBusqueda);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbPorNota);
            this.groupBox2.Controls.Add(this.rbPorNombre);
            this.groupBox2.Location = new System.Drawing.Point(25, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR";
            // 
            // rbPorNombre
            // 
            this.rbPorNombre.AutoSize = true;
            this.rbPorNombre.Location = new System.Drawing.Point(58, 34);
            this.rbPorNombre.Name = "rbPorNombre";
            this.rbPorNombre.Size = new System.Drawing.Size(98, 17);
            this.rbPorNombre.TabIndex = 0;
            this.rbPorNombre.TabStop = true;
            this.rbPorNombre.Text = "POR NOMBRE";
            this.rbPorNombre.UseVisualStyleBackColor = true;
            // 
            // rbPorNota
            // 
            this.rbPorNota.AutoSize = true;
            this.rbPorNota.Location = new System.Drawing.Point(205, 34);
            this.rbPorNota.Name = "rbPorNota";
            this.rbPorNota.Size = new System.Drawing.Size(81, 17);
            this.rbPorNota.TabIndex = 1;
            this.rbPorNota.TabStop = true;
            this.rbPorNota.Text = "POR NOTA";
            this.rbPorNota.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOMBRE:";
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Location = new System.Drawing.Point(100, 84);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(233, 20);
            this.txtNombreBusqueda.TabIndex = 3;
            // 
            // txtNotaBusqueda
            // 
            this.txtNotaBusqueda.Location = new System.Drawing.Point(100, 125);
            this.txtNotaBusqueda.Name = "txtNotaBusqueda";
            this.txtNotaBusqueda.Size = new System.Drawing.Size(80, 20);
            this.txtNotaBusqueda.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NOTA:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(217, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lbDatos
            // 
            this.lbDatos.FormattingEnabled = true;
            this.lbDatos.Location = new System.Drawing.Point(429, 25);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(201, 355);
            this.lbDatos.TabIndex = 2;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 405);
            this.Controls.Add(this.lbDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPracticas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNotaBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPorNota;
        private System.Windows.Forms.RadioButton rbPorNombre;
        private System.Windows.Forms.ListBox lbDatos;
    }
}