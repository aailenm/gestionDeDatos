using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace UberFrba.Abm_Automovil {
    public partial class Alta_Automovil : Form, ComunicacionForms
    {
        public Alta_Automovil()
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
            form.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void editarChofer(string id)
        {
            chofer.Text = id;
        }
        public void editar(string id)
        {

        }
        public void editarTurno(string id)
        {

        }
        public void editarCliente(string id)
        {
   
        }
        public void editarAuto(string id)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                bool conex = Conexion.executeProcedure("ALTA_AUTOMOVIL",Conexion.generarArgumentos("@MARCA", "@MODELO", "@PATENTE", "@TURNO", "@CHOFER"),
                 marcas.SelectedValue, modelo.Text, patente.Text, turnos.SelectedValue, chofer.Text);
                if (conex)
                {
                    MessageBox.Show("Auto creado correctamente");
                    Limpiar();
                }
            }
        }
        
        private bool validaciones(){
            if (marcas.SelectedIndex == -1) { 
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
            if (patente.Text.Length > 10)
            {
                MessageBox.Show("El campo Patente no puede tener mas de 10 digitos");
                return false;
            }
            if (modelo.Text.Length > 10)
            {
                MessageBox.Show("El campo modelo no puede tener mas de 10 digitos");
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
            SqlDataReader reader = Conexion.ejecutarQuery("SELECT chof_habilitado FROM RUBIRA_SANTOS.CHOFER WHERE CHOF_ID = " + chofer.Text);
            reader.Read();
            if(reader["chof_habilitado"].ToString().Equals("False")){
                MessageBox.Show("El chofer seleccionado no se encuentra habilitado.");
                reader.Close();
                return false;
            }
            reader.Close();
            return true;
        }
       
        private void Limpiar() {
            LlenarCombos();
            modelo.Clear();
            patente.Clear();
            chofer.Clear();
        }

        private void LlenarCombos()
        {
            Funciones.llenarCombo_Marca(marcas);
            Funciones.llenarCombo_Turno(turnos);
        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
