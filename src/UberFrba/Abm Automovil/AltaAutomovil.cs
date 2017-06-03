using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UberFrba.Abm_Automovil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LlenarCombos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer form = new Abm_Chofer.BusquedaChofer();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                bool conex = Conexion.executeProcedure("ALTA_AUTOMOVIL",Conexion.generarArgumentos("@MARCA", "@MODELO", "@PATENTE", "@TURNO", "@CHOFER"),
                 comboBox1.SelectedValue, textBox1.Text, textBox2.Text, comboBox2.SelectedValue, textBox3.Text);
                if(conex) MessageBox.Show("Auto creado correctamente");
                Limpiar();
            }
        }
        
        private bool validaciones(){
            if (comboBox1.SelectedIndex == -1) { 
                MessageBox.Show("El campo Marca no puede estar vacio");
                return false;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("El campo Turno no puede estar vacio");
                return false;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("El campo Modelo no puede estar vacio");
                return false;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("El campo Patente no puede estar vacio");
                return false;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("El campo Chofer no puede estar vacio");
                return false;
            }
            return true;
        }   

        private void Limpiar() {
            LlenarCombos();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void LlenarCombos()
        {
            comboBox1.ValueMember = "marc_id";
            comboBox1.DisplayMember = "marc_detalle";
            comboBox1.DataSource = Conexion.cargarTablaConsulta("GET_MARCAS");
            comboBox1.SelectedIndex = -1;

            comboBox2.ValueMember = "turn_id";
            comboBox2.DisplayMember = "turn_descripcion";
            comboBox2.DataSource = Conexion.cargarTablaConsulta("GET_TURNOS");
            comboBox2.SelectedIndex = -1;


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
