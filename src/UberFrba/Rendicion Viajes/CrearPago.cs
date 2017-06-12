using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Rendicion_Viajes
{
    public partial class Form1 : Form, ComunicacionForms
    {
        double porc = 0;
        double totalViajes=0;
        public Form1()
        {
            InitializeComponent();
            Funciones.llenarCombo_Turno(TURNO);
            dataGridView1.ReadOnly = true;
            FECHA.Value = Funciones.ObtenerFecha();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(validaciones()){
                dataGridView1.DataSource = Conexion.obtenerTablaProcedure("VIAJES_RENDICION",Conexion.generarArgumentos("@CHOFER","@TURNO","@FECHA"),
                    CHOF.Text, TURNO.SelectedValue, FECHA.Value.ToShortDateString());
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    totalViajes = totalViajes + Convert.ToDouble(row.Cells[7].Value);
                }
                if (dataGridView1.Rows.Count == 0)
                    MessageBox.Show("No hay viajes realizados en la fecha");
                else
                    textBox1.Text = "$" + totalViajes.ToString();
            }
        }

        public void editarChofer(string id) {
            CHOF.Text = id;
        }

        public void editarCliente(string id) { 
        
        }
        public void editarAuto(string id) { 
        
        }

        public void editar(string id)
        {

        }
        public void editarTurno(string id) {
            TURNO.SelectedValue = id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer chof = new Abm_Chofer.BusquedaChofer();
            chof.Show(this);
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funciones.llenarCombo_Turno(TURNO);
            CHOF.Clear();
            textBox1.Clear();
            porcentaje.Clear();
            TOTAL.Clear();
            FECHA.Value = Funciones.ObtenerFecha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones() && TOTAL.Text != "")
            {
                bool result = Conexion.executeProcedure("CREAR_RENDICION", Conexion.generarArgumentos("@CHOFER", "@TOTAL", "@TURNO", "@FECHA", "@PORCENTAJE"),
                   CHOF.Text, TOTAL.Text, TURNO.SelectedValue, FECHA.Value.ToShortDateString(), porc);
                if (result) MessageBox.Show("Rendición creada");
            }
            else MessageBox.Show("Debe ingresar el total a pagar");
        }

        private bool validaciones() { 
            if(CHOF.Text == ""){
                MessageBox.Show("Debe seleccionar un chofer");
                return false;
            }
            if (FECHA.Value > Funciones.ObtenerFecha())
            {
                MessageBox.Show("Fecha inválida");
                return false;
            }
            if(TURNO.Text == ""){
                MessageBox.Show("Debe seleccionar un turno");
                return false;
            }
            return true;
        }

        private void TOTAL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void porcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOTAL_TextChanged(object sender, EventArgs e)
        {
            if(TOTAL.Text == "") TOTAL.Text = "0";
            if (!Funciones.esNumero(TOTAL.Text)) MessageBox.Show("Solo se pueden ingresar números en el campo Total");
            if (totalViajes != 0 && Funciones.esNumero(TOTAL.Text))
            {
                porc = Convert.ToDouble(TOTAL.Text) / totalViajes;
                    porcentaje.Text = (Convert.ToDouble(TOTAL.Text)/totalViajes).ToString();
                }
            }

        private void CHOF_TextChanged(object sender, EventArgs e)
        {
        }

        private void TURNO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
}
