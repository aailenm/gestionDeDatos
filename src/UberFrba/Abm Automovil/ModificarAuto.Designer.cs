﻿namespace UberFrba.Abm_Automovil
{
    partial class Modificar_Auto
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.turnos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chofer = new System.Windows.Forms.TextBox();
            this.marcas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar Auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botonBuscar);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.auto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.turnos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.patente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.modelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chofer);
            this.groupBox1.Controls.Add(this.marcas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 236);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(161, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 50;
            this.button6.Text = "Habilitar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.botonHabili);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.Control;
            this.labelEstado.ForeColor = System.Drawing.Color.Red;
            this.labelEstado.Location = new System.Drawing.Point(93, 16);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(51, 13);
            this.labelEstado.TabIndex = 49;
            this.labelEstado.Text = "<estado>";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(55, 13);
            this.auto.Name = "auto";
            this.auto.ReadOnly = true;
            this.auto.Size = new System.Drawing.Size(32, 20);
            this.auto.TabIndex = 48;
            this.auto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Auto";
            // 
            // turnos
            // 
            this.turnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turnos.Enabled = false;
            this.turnos.FormattingEnabled = true;
            this.turnos.Location = new System.Drawing.Point(55, 203);
            this.turnos.Name = "turnos";
            this.turnos.Size = new System.Drawing.Size(121, 21);
            this.turnos.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Turno";
            // 
            // patente
            // 
            this.patente.Location = new System.Drawing.Point(55, 160);
            this.patente.Name = "patente";
            this.patente.Size = new System.Drawing.Size(100, 20);
            this.patente.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Patente";
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(55, 120);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(100, 20);
            this.modelo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Modelo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Cambiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Chofer";
            // 
            // chofer
            // 
            this.chofer.Enabled = false;
            this.chofer.Location = new System.Drawing.Point(55, 46);
            this.chofer.Name = "chofer";
            this.chofer.ReadOnly = true;
            this.chofer.Size = new System.Drawing.Size(100, 20);
            this.chofer.TabIndex = 40;
            this.chofer.TextChanged += new System.EventHandler(this.chofer_TextChanged);
            // 
            // marcas
            // 
            this.marcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcas.FormattingEnabled = true;
            this.marcas.Location = new System.Drawing.Point(55, 82);
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(121, 21);
            this.marcas.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Marca";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 47;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.botonModificar);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 49;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Modificar_Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 335);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Modificar_Auto";
            this.Text = "Modificar Automóvil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox chofer;
        private System.Windows.Forms.ComboBox marcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox turnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox auto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button botonHabilitar;
        private System.Windows.Forms.Button button6;
    }
}