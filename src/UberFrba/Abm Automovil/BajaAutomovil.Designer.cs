namespace UberFrba.Abm_Automovil {
    partial class Baja_Automovil {
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
            this.patente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(12, 15);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(29, 13);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Auto";
            this.lblPatente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(15, 39);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(117, 23);
            this.btnInhabilitar.TabIndex = 1;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(155, 39);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // patente
            // 
            this.patente.Enabled = false;
            this.patente.Location = new System.Drawing.Point(62, 12);
            this.patente.Name = "patente";
            this.patente.Size = new System.Drawing.Size(70, 20);
            this.patente.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Baja_Automovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 70);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lblPatente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Baja_Automovil";
            this.Text = "Baja de Automóvil";
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
        private System.Windows.Forms.TextBox patente;
        private System.Windows.Forms.Button button1;
    }
}