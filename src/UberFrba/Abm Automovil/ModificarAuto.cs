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
            button6.Enabled = false;
            button3.Enabled = false;
        }

        public void editarAuto(string id)
        {
            auto.Text = id;
            SqlDataReader reader = Conexion.ejecutarQuery("select auto_habilitado from RUBIRA_SANTOS.AUTOMOVIL where auto_id  like '%" + auto.Text + "%'");
            reader.Read();
            string estadoAuto = (reader["auto_habilitado"].ToString());
            reader.Close();
            if (estadoAuto.Equals("True"))
            {
                labelEstado.Text = "HABILITADO";
                button6.Enabled = false;
            }
            else
                labelEstado.Text = "INHABILITADO";
           
        }
        public void editarCliente(string id)
        {
                
          }
        public void editar(string id)
        {

        }
        public void editarTurno(string id) {
            turnos.SelectedValue = id;
        }
        public void editarChofer(string id)
        {
            chofer.Text = id;
        }
        
        private void LlenarCombos()
        {
            Funciones.llenarCombo_Marca(marcas);
            Funciones.llenarCombo_Turno(turnos);
        }
        
        private void botonBuscar(object sender, EventArgs e)
        {
            Abm_Automovil.BusquedaAuto buscar = new Abm_Automovil.BusquedaAuto();
            buscar.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Automovil.Modificar_Chofer_Auto mca = new Modificar_Chofer_Auto();
            mca.setChofOriginal(chofer.Text);
            mca.setTurnoOriginal(turnos);
            mca.setAuto(auto.Text);
            mca.Show(this);
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
                bool conex = Conexion.executeProcedure("MODIFICAR_AUTO", Conexion.generarArgumentos("@auto", "@nuevaMarca","@modelo","@patente"),
                 auto.Text, marcas.SelectedValue,modelo.Text,patente.Text);
                if (conex)
                {
                    MessageBox.Show("Auto modificado correctamente");
                }
            }
        }
        private bool validaciones()
        {
            if (marcas.SelectedIndex == -1)
            {
                MessageBox.Show("El campo Marca no puede estar vacio");
                return false;
            }
            if (turnos.SelectedIndex == -1)
            {
                MessageBox.Show("El campo Turno no puede estar vacio");
                return false;
            }
            if (modelo.Text == "")
            {
                MessageBox.Show("El campo Modelo no puede estar vacio");
                return false;
            }

            if (patente.Text == "")
            {
                MessageBox.Show("El campo Patente no puede estar vacio");
                return false;
            }

            if (chofer.Text == "")
            {
                MessageBox.Show("El campo Chofer no puede estar vacio");
                return false;
            }
            return true;
        }   
        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar() {
            Funciones.llenarCombo_Marca(marcas);
            Funciones.llenarCombo_Turno(turnos);
            modelo.Clear();
            patente.Clear();
            chofer.Clear();
            auto.Clear();
            labelEstado.Text = "";
            button6.Enabled = false;
            button3.Enabled = false;
        }
        private void botonHabili(object sender, EventArgs e)
        {
            bool conex = Conexion.executeProcedure("HABILITAR_AUTO", Conexion.generarArgumentos("@idAuto"), auto.Text);
            if (conex)
            {
                MessageBox.Show("Automovil habilitado correctamente");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (auto.Text != "")
            {
                button6.Enabled = true;
                string query = "SELECT auto_marca, auto_modelo, auto_patente from RUBIRA_SANTOS.AUTOMOVIL where auto_id=" + auto.Text;
                SqlDataReader reader = Conexion.ejecutarQuery(query);
                reader.Read();
                modelo.Text = (reader["auto_modelo"].ToString());
                patente.Text = (reader["auto_patente"].ToString());
                marcas.SelectedValue= (Int32.Parse(reader["auto_marca"].ToString()));
                reader.Close();
            }
        }

        private void chofer_TextChanged(object sender, EventArgs e)
        {
            if (chofer.Text != "") button3.Enabled = true;
        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
