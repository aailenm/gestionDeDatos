using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                bool conex = Conexion.executeProcedure("ALTA_CHOFER", Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP"),
                nomb.Text, apell.Text,dni.Text, mail.Text, tel.Text, fechanac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text);
                if (conex) MessageBox.Show("Chofer creado correctamente");
                Limpiar();
            }
        }

        private void Limpiar() {
            nomb.Clear();
            apell.Clear();
            dni.Clear();
            tel.Clear();
            mail.Clear();
            fechanac.Checked = false;
            calle.Clear();
            piso.Clear();
            dpto.Clear();
            local.Clear();
            cp.Clear();
        }

        private bool validaciones() {

            if (!(Funciones.esNumero(dni.Text)))
            {
                MessageBox.Show("Solo se aceptan numeros en el DNI");
                return false;
            }

            if (!(Funciones.esNumero(tel.Text)))
            {
                MessageBox.Show("Solo se aceptan numeros en el Telefono");
                return false;
            }

            if(nomb.Text == "" ){
            MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }

             if(apell.Text == ""){
            MessageBox.Show("El campo Apellido no puede estar vacio");
                return false;
            }
             if(dni.Text == ""){
            MessageBox.Show("El campo DNI no puede estar vacio");
                return false;
            }

             if(mail.Text == ""){
            MessageBox.Show("El campo mail no puede estar vacio");
                return false;
            }

             if(tel.Text == ""){
            MessageBox.Show("El campo Telefono no puede estar vacio");
                return false;
            }

             if (fechanac.Value >= DateTime.Today)
             {
            MessageBox.Show("La fecha de nacimiento es incorrecta");
                return false;
            }

             if (calle.Text == "")
             {
                 MessageBox.Show("El campo calle no puede estar vacía");
                 return false;
             }

             if (cp.Text == "")
             {
                 MessageBox.Show("El campo codigo postal no puede estar vacía");
                 return false;
             }


             if (local.Text == "")
             {
                 MessageBox.Show("El campo localidad no puede estar vacía");
                 return false;
             }
            return true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
