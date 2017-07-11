namespace UberFrba.Abm_Cliente {
    partial class BajaCliente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmbTeléfonos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTeléfonos
            // 
            this.cmbTeléfonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeléfonos.FormattingEnabled = true;
            this.cmbTeléfonos.Location = new System.Drawing.Point(67, 13);
            this.cmbTeléfonos.Name = "cmbTeléfonos";
            this.cmbTeléfonos.Size = new System.Drawing.Size(205, 21);
            this.cmbTeléfonos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teléfono";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(15, 40);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(126, 23);
            this.btnInhabilitar.TabIndex = 1;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(146, 40);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTeléfonos);
            this.Name = "BajaCliente";
            this.Text = "Baja de Cliente";
            this.Load += new System.EventHandler(this.BajaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTeléfonos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnVolver;
    }
}