namespace UberFrba.Facturacion
{
    partial class Crear_Factura
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
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fechainicio = new System.Windows.Forms.DateTimePicker();
            this.seleccionar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(324, 372);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(304, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(12, 372);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(304, 23);
            this.aceptar.TabIndex = 4;
            this.aceptar.Text = "Crear";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cliente";
            // 
            // client
            // 
            this.client.AcceptsTab = true;
            this.client.Enabled = false;
            this.client.Location = new System.Drawing.Point(417, 19);
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.Size = new System.Drawing.Size(100, 20);
            this.client.TabIndex = 8;
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(417, 47);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 3;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Importe total";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(12, 99);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(304, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Viajes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fechafin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fechainicio);
            this.groupBox1.Controls.Add(this.seleccionar);
            this.groupBox1.Controls.Add(this.client);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Fecha fin de factura";
            // 
            // fechafin
            // 
            this.fechafin.Location = new System.Drawing.Point(132, 47);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(200, 20);
            this.fechafin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha inicio de factura";
            // 
            // fechainicio
            // 
            this.fechainicio.Location = new System.Drawing.Point(132, 19);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(200, 20);
            this.fechainicio.TabIndex = 0;
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(523, 19);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(85, 20);
            this.seleccionar.TabIndex = 2;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.button5_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(324, 99);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(304, 23);
            this.limpiar.TabIndex = 2;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 225);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Crear_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Crear_Factura";
            this.Text = "Creación de Factura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechainicio;
    }
}