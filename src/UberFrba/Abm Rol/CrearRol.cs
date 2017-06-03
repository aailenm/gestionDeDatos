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

namespace UberFrba.Abm_Rol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarFuncionalidades();
        }

        private void MostrarFuncionalidades() {
            checkedListBox1.DataSource = Conexion.cargarTablaConsulta("GET_FUNCIONALIDADES");
            checkedListBox1.ValueMember = "func_id";
            checkedListBox1.DisplayMember = "func_descripcion";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Limpiar() {
            descripcion.Clear();
            checkedListBox1.SelectedItems.Clear();
            MostrarFuncionalidades();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (descripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el rol");
            } else{
                bool resultado = Conexion.executeProcedure("ALTA_ROL", Conexion.generarArgumentos("@DESCRIPCION"), descripcion.Text);
                agregarFuncionalidades();
                if (resultado)
                {
                    MessageBox.Show("Rol creado");
                    Limpiar();
                }
            }
        }
        private void agregarFuncionalidades() {
           SqlDataReader reader = Conexion.ejecutarQuery("Select rol_id from ROL WHERE ROL_DESCRIPCION like '%" + descripcion.Text +"%'");
           reader.Read();
           string rol = (reader["rol_id"].ToString());
           reader.Close();
            foreach (DataRowView rowView in checkedListBox1.CheckedItems) {
                Conexion.executeProcedure("AGREGAR_FUNCIONALIDAD", Conexion.generarArgumentos("@FUNCIONALIDAD", "@ROL"), rowView["func_id"], rol);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
