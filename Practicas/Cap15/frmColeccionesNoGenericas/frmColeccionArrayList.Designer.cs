
namespace Practicas.Cap15.frmColeccionesNoGenericas
{
    partial class frmColeccionArrayList
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnVolcar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELEMENTO:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(118, 31);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(217, 20);
            this.txtItem.TabIndex = 1;
            this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CAPACIDAD:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCapacidad.Location = new System.Drawing.Point(118, 80);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(100, 23);
            this.lblCapacidad.TabIndex = 3;
            this.lblCapacidad.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ELEMENTOS:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Location = new System.Drawing.Point(118, 130);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 23);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "---";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(38, 195);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(297, 95);
            this.lstItems.TabIndex = 6;
            // 
            // btnVolcar
            // 
            this.btnVolcar.Location = new System.Drawing.Point(260, 126);
            this.btnVolcar.Name = "btnVolcar";
            this.btnVolcar.Size = new System.Drawing.Size(75, 23);
            this.btnVolcar.TabIndex = 7;
            this.btnVolcar.Text = "VOLCAR";
            this.btnVolcar.UseVisualStyleBackColor = true;
            this.btnVolcar.Click += new System.EventHandler(this.btnVolcar_Click);
            // 
            // frmColeccionArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 328);
            this.Controls.Add(this.btnVolcar);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Name = "frmColeccionArrayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColeccionArrayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnVolcar;
    }
}