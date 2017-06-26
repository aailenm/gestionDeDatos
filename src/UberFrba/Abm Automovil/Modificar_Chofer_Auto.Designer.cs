namespace UberFrba.Abm_Automovil
{
    partial class Modificar_Chofer_Auto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.turnOrigen = new System.Windows.Forms.ComboBox();
            this.chofOrigen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.turnNuevo = new System.Windows.Forms.ComboBox();
            this.chofnNuevo = new System.Windows.Forms.TextBox();
            this.Modificar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.turnOrigen);
            this.groupBox1.Controls.Add(this.chofOrigen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Originales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turno Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chofer Original";
            // 
            // turnOrigen
            // 
            this.turnOrigen.Enabled = false;
            this.turnOrigen.FormattingEnabled = true;
            this.turnOrigen.Location = new System.Drawing.Point(382, 29);
            this.turnOrigen.Name = "turnOrigen";
            this.turnOrigen.Size = new System.Drawing.Size(121, 21);
            this.turnOrigen.TabIndex = 1;
            this.turnOrigen.SelectedIndexChanged += new System.EventHandler(this.turnOrigen_SelectedIndexChanged);
            // 
            // chofOrigen
            // 
            this.chofOrigen.Enabled = false;
            this.chofOrigen.Location = new System.Drawing.Point(103, 29);
            this.chofOrigen.Name = "chofOrigen";
            this.chofOrigen.Size = new System.Drawing.Size(100, 20);
            this.chofOrigen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.turnNuevo);
            this.groupBox2.Controls.Add(this.chofnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos a Modificar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Turno Nuevo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chofer Nuevo";
            // 
            // turnNuevo
            // 
            this.turnNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turnNuevo.FormattingEnabled = true;
            this.turnNuevo.Location = new System.Drawing.Point(382, 35);
            this.turnNuevo.Name = "turnNuevo";
            this.turnNuevo.Size = new System.Drawing.Size(121, 21);
            this.turnNuevo.TabIndex = 2;
            this.turnNuevo.SelectedIndexChanged += new System.EventHandler(this.turnNuevo_SelectedIndexChanged);
            // 
            // chofnNuevo
            // 
            this.chofnNuevo.Enabled = false;
            this.chofnNuevo.Location = new System.Drawing.Point(103, 36);
            this.chofnNuevo.Name = "chofnNuevo";
            this.chofnNuevo.Size = new System.Drawing.Size(100, 20);
            this.chofnNuevo.TabIndex = 1;
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(485, 187);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(404, 187);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Modificar_Chofer_Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 226);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificar_Chofer_Auto";
            this.Text = "Modificar_Chofer_Auto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox turnOrigen;
        private System.Windows.Forms.TextBox chofOrigen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox turnNuevo;
        private System.Windows.Forms.TextBox chofnNuevo;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Cancelar;
    }
}