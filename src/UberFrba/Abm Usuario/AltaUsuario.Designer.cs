﻿namespace UberFrba.Abm_Usuario
{
    partial class AltaUsuario
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
            this.roles = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dpto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.piso = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nomb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechanac = new System.Windows.Forms.DateTimePicker();
            this.mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roles);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // roles
            // 
            this.roles.FormattingEnabled = true;
            this.roles.Location = new System.Drawing.Point(349, 19);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(225, 79);
            this.roles.TabIndex = 2;
            this.roles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.roles_ItemCheck);
            this.roles.SelectedIndexChanged += new System.EventHandler(this.roles_SelectedIndexChanged);
            this.roles.SelectedValueChanged += new System.EventHandler(this.roles_SelectedValueChanged);
            this.roles.CausesValidationChanged += new System.EventHandler(this.roles_CausesValidationChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Roles";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Contraseña";
            // 
            // contraseña
            // 
            this.contraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.contraseña.Location = new System.Drawing.Point(79, 45);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(137, 20);
            this.contraseña.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.Enabled = false;
            this.usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usuario.Location = new System.Drawing.Point(79, 19);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(137, 20);
            this.usuario.TabIndex = 0;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(349, 45);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(51, 20);
            this.cp.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Departamento";
            // 
            // dpto
            // 
            this.dpto.Location = new System.Drawing.Point(486, 19);
            this.dpto.Name = "dpto";
            this.dpto.Size = new System.Drawing.Size(51, 20);
            this.dpto.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Piso";
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(349, 19);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(51, 20);
            this.piso.TabIndex = 1;
            this.piso.TextChanged += new System.EventHandler(this.piso_TextChanged);
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(74, 45);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(235, 20);
            this.local.TabIndex = 3;
            this.local.TextChanged += new System.EventHandler(this.local_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Localidad *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "CP *";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(79, 71);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(137, 20);
            this.dni.TabIndex = 2;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "DNI *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // apell
            // 
            this.apell.Location = new System.Drawing.Point(79, 45);
            this.apell.Name = "apell";
            this.apell.Size = new System.Drawing.Size(137, 20);
            this.apell.TabIndex = 1;
            this.apell.TextChanged += new System.EventHandler(this.apell_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Apellido *";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nomb
            // 
            this.nomb.Location = new System.Drawing.Point(79, 19);
            this.nomb.Name = "nomb";
            this.nomb.Size = new System.Drawing.Size(137, 20);
            this.nomb.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Nombre *";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fechanac);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nomb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dni);
            this.groupBox2.Controls.Add(this.apell);
            this.groupBox2.Controls.Add(this.mail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // fechanac
            // 
            this.fechanac.Location = new System.Drawing.Point(349, 71);
            this.fechanac.Name = "fechanac";
            this.fechanac.Size = new System.Drawing.Size(225, 20);
            this.fechanac.TabIndex = 5;
            this.fechanac.ValueChanged += new System.EventHandler(this.fechanac_ValueChanged);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(349, 19);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(225, 20);
            this.mail.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mail *";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(349, 45);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(225, 20);
            this.tel.TabIndex = 4;
            this.tel.TextChanged += new System.EventHandler(this.tel_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Teléfono*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Fecha de Nacimiento *";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cp);
            this.groupBox3.Controls.Add(this.local);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.piso);
            this.groupBox3.Controls.Add(this.dpto);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dirección";
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(74, 19);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(235, 20);
            this.calle.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Calle *";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AltaUsuario";
            this.Text = "Alta de Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.CheckedListBox roles;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dpto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fechanac;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.Label label6;
    }
}