using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UberFrba.Abm_Automovil {
    public partial class Modificar_Auto : Form, ComunicacionForms
    {
        
        
        public Modificar_Auto()
        {
            InitializeComponent();
            LlenarCombos();
            labelEstado.Text = "" ;
        }
        public void editarAuto(string id)
        {
            textBox4.Text = id;
            SqlDataReader reader = Conexion.ejecutarQuery("select auto_habilitado from RUBIRA_SANTOS.AUTOMOVIL where auto_id  like '%" + textBox4.Text + "%'");
            reader.Read();
            string estadoAuto = (reader["auto_habilitado"].ToString());
            reader.Close();
            if (estadoAuto.Equals("True"))
                labelEstado.Text = "HABILITADO";
            else
                labelEstado.Text = "INHABILITADO";
           
        }
        public void editarCliente(string id)
        {
                
          }
        public void editar(string id)
        {

        }
        public void guardarMarca(string marca)
        {
            comboBox1.Text = marca;

        }
        public void guardarPatente(string patente)
        {
            textBox2.Text = patente;

        }
        public void guardarModelo(string modelo)
        {
            textBox1.Text = modelo;

        }
        public void editarTurno(string turno)
        {
            comboBox2.Text = turno;
         
        }
        public void editarChofer(string id)
        {
            textBox3.Text = id;
        }
        
        private void LlenarCombos()
        {
            Funciones.llenarCombo_Marca(comboBox1);
            Funciones.llenarCombo_Turno(comboBox2);
        }
        
        private void botonBuscar(object sender, EventArgs e)
        {
            Abm_Automovil.BusquedaAuto buscar = new Abm_Automovil.BusquedaAuto();

            buscar.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonModificar(object sender, EventArgs e)
        {
            if( validaciones())
            {
                bool conex = Conexion.executeProcedure("MODIFICAR_AUTO", Conexion.generarArgumentos("@auto", "@nuevaMarca","@modelo","@patente","@chofer","@turno"),
                 textBox4.Text, comboBox1.Text,textBox1.Text,textBox2.Text,textBox3.Text,comboBox2.Text);
                if (conex)
                {
                    MessageBox.Show("Auto modificado correctamente");
                }
            }
        }
        private bool validaciones()
        {
            if (comboBox1.SelectedIndex == -1)
            {
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
        private void button5_Click(object sender, EventArgs e)
        {
            Funciones.llenarCombo_Marca(comboBox1);
            Funciones.llenarCombo_Turno(comboBox2);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            labelEstado.Text = "";

        }

        private void botonHabili(object sender, EventArgs e)
        {
            bool conex = Conexion.executeProcedure("HABILITAR_AUTO", Conexion.generarArgumentos("@id"), textBox4.Text);
            if (conex)
            {
                MessageBox.Show("Automovil habilitado correctamente");
            }
        }
    }
}
