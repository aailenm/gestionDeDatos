namespace UberFrba.Abm_Automovil {
    partial class BajaAutomovil {
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
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbPatente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(12, 15);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente";
            this.lblPatente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(15, 38);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(117, 23);
            this.btnInhabilitar.TabIndex = 2;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(155, 38);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbPatente
            // 
            this.cmbPatente.FormattingEnabled = true;
            this.cmbPatente.Location = new System.Drawing.Point(64, 12);
            this.cmbPatente.Name = "cmbPatente";
            this.cmbPatente.Size = new System.Drawing.Size(208, 21);
            this.cmbPatente.TabIndex = 8;
            // 
            // BajaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 74);
            this.Controls.Add(this.cmbPatente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lblPatente);
            this.Name = "BajaAutomovil";
            this.Text = "BajaAutomovil";
            this.Load += new System.EventHandler(this.BajaAutomovil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtPatente_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbPatente;
    }
}