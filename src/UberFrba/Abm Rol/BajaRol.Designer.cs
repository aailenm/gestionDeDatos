namespace UberFrba.Abm_Rol {
    partial class Baja_Rol {
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
            this.lblRol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(15, 38);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(117, 23);
            this.btnInhabilitar.TabIndex = 1;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(12, 15);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // rol
            // 
            this.rol.Enabled = false;
            this.rol.Location = new System.Drawing.Point(41, 12);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(91, 20);
            this.rol.TabIndex = 5;
            // 
            // Baja_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 74);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lblRol);
            this.Name = "Baja_Rol";
            this.Text = "Baja de Rol";
            this.Load += new System.EventHandler(this.BajaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rol;
    }
}