namespace UberFrba.Abm_Turno {
    partial class Baja_Turno {
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.turno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(17, 39);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(117, 23);
            this.btnInhabilitar.TabIndex = 1;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(14, 15);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Turno";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turno
            // 
            this.turno.Enabled = false;
            this.turno.Location = new System.Drawing.Point(49, 13);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(85, 20);
            this.turno.TabIndex = 11;
            // 
            // Baja_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 70);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lblDesc);
            this.Name = "Baja_Turno";
            this.Text = "Baja de Turno";
            this.Load += new System.EventHandler(this.BajaTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox turno;
    }
}