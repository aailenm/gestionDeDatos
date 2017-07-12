namespace UberFrba.Rendicion_Viajes
{
    partial class Crear_Pago
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
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalviaje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TURNO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FECHA = new System.Windows.Forms.DateTimePicker();
            this.CHOF = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalViajeees = new System.Windows.Forms.TextBox();
            this.porcentaje = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Chofer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Viajes";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Total:";
            // 
            // totalviaje
            // 
            this.totalviaje.AutoSize = true;
            this.totalviaje.Location = new System.Drawing.Point(286, 366);
            this.totalviaje.Name = "totalviaje";
            this.totalviaje.Size = new System.Drawing.Size(61, 13);
            this.totalviaje.TabIndex = 58;
            this.totalviaje.Text = "Porcentaje:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TURNO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FECHA);
            this.groupBox1.Controls.Add(this.CHOF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Viajes";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 2;
            this.button4.Text = "Seleccionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Fecha";
            // 
            // TURNO
            // 
            this.TURNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TURNO.FormattingEnabled = true;
            this.TURNO.Location = new System.Drawing.Point(68, 45);
            this.TURNO.Name = "TURNO";
            this.TURNO.Size = new System.Drawing.Size(246, 21);
            this.TURNO.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Turno";
            // 
            // FECHA
            // 
            this.FECHA.Location = new System.Drawing.Point(68, 19);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(246, 20);
            this.FECHA.TabIndex = 0;
            // 
            // CHOF
            // 
            this.CHOF.Enabled = false;
            this.CHOF.Location = new System.Drawing.Point(407, 19);
            this.CHOF.Name = "CHOF";
            this.CHOF.Size = new System.Drawing.Size(100, 20);
            this.CHOF.TabIndex = 67;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(594, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Total Viajes:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 216);
            this.dataGridView1.TabIndex = 2;
            // 
            // totalViajeees
            // 
            this.totalViajeees.Enabled = false;
            this.totalViajeees.Location = new System.Drawing.Point(174, 363);
            this.totalViajeees.Name = "totalViajeees";
            this.totalViajeees.Size = new System.Drawing.Size(100, 20);
            this.totalViajeees.TabIndex = 63;
            this.totalViajeees.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // porcentaje
            // 
            this.porcentaje.Location = new System.Drawing.Point(353, 363);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(100, 20);
            this.porcentaje.TabIndex = 65;
            this.porcentaje.TextChanged += new System.EventHandler(this.porcentaje_TextChanged);
            // 
            // TOTAL
            // 
            this.TOTAL.Enabled = false;
            this.TOTAL.Location = new System.Drawing.Point(506, 363);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(100, 20);
            this.TOTAL.TabIndex = 66;
            this.TOTAL.TextChanged += new System.EventHandler(this.TOTAL_TextChanged);
            // 
            // Crear_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 423);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.totalViajeees);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.totalviaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Crear_Pago";
            this.Text = "Creación de Pago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalviaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CHOF;
        private System.Windows.Forms.TextBox totalViajeees;
        private System.Windows.Forms.TextBox porcentaje;
        private System.Windows.Forms.TextBox TOTAL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TURNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FECHA;
    }
}