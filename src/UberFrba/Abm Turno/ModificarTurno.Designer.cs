namespace UberFrba.Abm_Turno {
    partial class Modificar_Turno {
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
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.DETALLE = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.habilit = new System.Windows.Forms.Button();
            this.HHM = new System.Windows.Forms.NumericUpDown();
            this.HHH = new System.Windows.Forms.NumericUpDown();
            this.HDM = new System.Windows.Forms.NumericUpDown();
            this.HDH = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(43, 15);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(84, 12);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(103, 21);
            this.cmbTurno.TabIndex = 0;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(15, 43);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DETALLE
            // 
            this.DETALLE.Location = new System.Drawing.Point(84, 40);
            this.DETALLE.Name = "DETALLE";
            this.DETALLE.Size = new System.Drawing.Size(275, 20);
            this.DETALLE.TabIndex = 1;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(84, 67);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(275, 20);
            this.PB.TabIndex = 2;
            this.PB.TextChanged += new System.EventHandler(this.PB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio Base";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VKM
            // 
            this.VKM.Location = new System.Drawing.Point(84, 94);
            this.VKM.Name = "VKM";
            this.VKM.Size = new System.Drawing.Size(275, 20);
            this.VKM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor del Km";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora Inicial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hora Final";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(15, 175);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(166, 23);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(193, 175);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(166, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.Control;
            this.labelEstado.ForeColor = System.Drawing.Color.Red;
            this.labelEstado.Location = new System.Drawing.Point(193, 15);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(51, 13);
            this.labelEstado.TabIndex = 50;
            this.labelEstado.Text = "<estado>";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // habilit
            // 
            this.habilit.Location = new System.Drawing.Point(275, 12);
            this.habilit.Name = "habilit";
            this.habilit.Size = new System.Drawing.Size(84, 21);
            this.habilit.TabIndex = 10;
            this.habilit.Text = "Habilitar";
            this.habilit.UseVisualStyleBackColor = true;
            this.habilit.Click += new System.EventHandler(this.button1_Click);
            // 
            // HHM
            // 
            this.HHM.Location = new System.Drawing.Point(142, 148);
            this.HHM.Name = "HHM";
            this.HHM.ReadOnly = true;
            this.HHM.Size = new System.Drawing.Size(39, 20);
            this.HHM.TabIndex = 7;
            // 
            // HHH
            // 
            this.HHH.Location = new System.Drawing.Point(84, 149);
            this.HHH.Name = "HHH";
            this.HHH.ReadOnly = true;
            this.HHH.Size = new System.Drawing.Size(39, 20);
            this.HHH.TabIndex = 6;
            // 
            // HDM
            // 
            this.HDM.Location = new System.Drawing.Point(142, 120);
            this.HDM.Name = "HDM";
            this.HDM.ReadOnly = true;
            this.HDM.Size = new System.Drawing.Size(39, 20);
            this.HDM.TabIndex = 5;
            // 
            // HDH
            // 
            this.HDH.Location = new System.Drawing.Point(84, 120);
            this.HDH.Name = "HDH";
            this.HDH.ReadOnly = true;
            this.HDH.Size = new System.Drawing.Size(39, 20);
            this.HDH.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = ":";
            // 
            // Modificar_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 208);
            this.Controls.Add(this.HHM);
            this.Controls.Add(this.HHH);
            this.Controls.Add(this.HDM);
            this.Controls.Add(this.HDH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.habilit);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VKM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.DETALLE);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Modificar_Turno";
            this.Text = "Modificación de Turno";
            this.Load += new System.EventHandler(this.ModificarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox DETALLE;
        private System.Windows.Forms.TextBox PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button habilit;
        private System.Windows.Forms.NumericUpDown HHM;
        private System.Windows.Forms.NumericUpDown HHH;
        private System.Windows.Forms.NumericUpDown HDM;
        private System.Windows.Forms.NumericUpDown HDH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}