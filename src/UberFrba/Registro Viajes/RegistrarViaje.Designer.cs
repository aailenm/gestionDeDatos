namespace UberFrba.Registro_Viajes
{
    partial class Registro_Viajes
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
            this.cantkm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ffin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.finic = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.TextBox();
            this.chof = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HDM = new System.Windows.Forms.TextBox();
            this.HDH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HHM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HHH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantkm
            // 
            this.cantkm.Location = new System.Drawing.Point(125, 150);
            this.cantkm.Name = "cantkm";
            this.cantkm.Size = new System.Drawing.Size(51, 20);
            this.cantkm.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Cantidad de KM";
            // 
            // clie
            // 
            this.clie.Enabled = false;
            this.clie.ImeMode = System.Windows.Forms.ImeMode.On;
            this.clie.Location = new System.Drawing.Point(93, 124);
            this.clie.Name = "clie";
            this.clie.ReadOnly = true;
            this.clie.Size = new System.Drawing.Size(100, 20);
            this.clie.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Cliente";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(296, 279);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 60;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(215, 279);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(75, 23);
            this.crear.TabIndex = 59;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Fin del viaje";
            // 
            // ffin
            // 
            this.ffin.Location = new System.Drawing.Point(112, 202);
            this.ffin.Name = "ffin";
            this.ffin.Size = new System.Drawing.Size(200, 20);
            this.ffin.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Inicio del viaje";
            // 
            // finic
            // 
            this.finic.Location = new System.Drawing.Point(112, 176);
            this.finic.Name = "finic";
            this.finic.Size = new System.Drawing.Size(200, 20);
            this.finic.TabIndex = 55;
            this.finic.ValueChanged += new System.EventHandler(this.finic_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Turno";
            // 
            // turn
            // 
            this.turn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turn.FormattingEnabled = true;
            this.turn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.turn.Location = new System.Drawing.Point(93, 97);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(121, 21);
            this.turn.TabIndex = 53;
            this.turn.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Automovil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Chofer";
            // 
            // auto
            // 
            this.auto.Enabled = false;
            this.auto.ImeMode = System.Windows.Forms.ImeMode.On;
            this.auto.Location = new System.Drawing.Point(93, 70);
            this.auto.Name = "auto";
            this.auto.ReadOnly = true;
            this.auto.Size = new System.Drawing.Size(100, 20);
            this.auto.TabIndex = 65;
            // 
            // chof
            // 
            this.chof.Enabled = false;
            this.chof.ImeMode = System.Windows.Forms.ImeMode.On;
            this.chof.Location = new System.Drawing.Point(93, 43);
            this.chof.Name = "chof";
            this.chof.ReadOnly = true;
            this.chof.Size = new System.Drawing.Size(100, 20);
            this.chof.TabIndex = 66;
            this.chof.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 67;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 68;
            this.button4.Text = "Seleccionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 69;
            this.button5.Text = "Seleccionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.HDM);
            this.groupBox1.Controls.Add(this.HDH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.HHM);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.HHH);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 261);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = ":";
            // 
            // HDM
            // 
            this.HDM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HDM.Location = new System.Drawing.Point(141, 216);
            this.HDM.Name = "HDM";
            this.HDM.Size = new System.Drawing.Size(32, 20);
            this.HDM.TabIndex = 63;
            // 
            // HDH
            // 
            this.HDH.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HDH.Location = new System.Drawing.Point(90, 216);
            this.HDH.Name = "HDH";
            this.HDH.Size = new System.Drawing.Size(32, 20);
            this.HDH.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = ":";
            // 
            // HHM
            // 
            this.HHM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HHM.Location = new System.Drawing.Point(311, 216);
            this.HHM.Name = "HHM";
            this.HHM.Size = new System.Drawing.Size(32, 20);
            this.HHM.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Hora Hasta";
            // 
            // HHH
            // 
            this.HHH.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HHH.Location = new System.Drawing.Point(260, 216);
            this.HHH.Name = "HHH";
            this.HHH.Size = new System.Drawing.Size(32, 20);
            this.HHH.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Hora Desde";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Datos del viaje";
            // 
            // Registro_Viajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 317);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chof);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.cantkm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ffin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registro_Viajes";
            this.Text = "Registro de Viajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cantkm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox clie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ffin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker finic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox auto;
        private System.Windows.Forms.TextBox chof;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        protected System.Windows.Forms.ComboBox turn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HDM;
        private System.Windows.Forms.TextBox HDH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HHM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HHH;
        private System.Windows.Forms.Label label11;
    }
}