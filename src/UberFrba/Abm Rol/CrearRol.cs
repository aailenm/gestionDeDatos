using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UberFrba.Abm_Rol {
    public partial class Alta_Rol : Form
    {
        public Alta_Rol()
        {
            InitializeComponent();
            MostrarFuncionalidades();
        }

        private void MostrarFuncionalidades() {
            roles.DataSource = Conexion.cargarTablaConsulta("GET_FUNCIONALIDADES");
            roles.ValueMember = "func_id";
            roles.DisplayMember = "func_descripcion";
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
            int i;
            for (i = 0; (roles.Items.Count - 1) > i; i++) roles.SetItemChecked(i, false);
                MostrarFuncionalidades();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(validaciones()){
                bool resultado = Conexion.executeProcedure("ALTA_ROL", Conexion.generarArgumentos("@DESCRIPCION"), descripcion.Text);
                if (resultado)
                {
                    agregarFuncionalidades();
                    MessageBox.Show("Rol creado");
                    Limpiar();
                }
            }
        }
        private bool validaciones() {
           
            if (descripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el rol");
                return false;
            }
            if (roles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un rol");
                return false;
            }
            return true;
        }
        private void agregarFuncionalidades() {
           SqlDataReader reader = Conexion.ejecutarQuery("Select rol_id from RUBIRA_SANTOS.ROL WHERE ROL_DESCRIPCION like '%" + descripcion.Text +"%'");
           reader.Read();
           string rol = (reader["rol_id"].ToString());
           reader.Close();
            foreach (DataRowView rowView in roles.CheckedItems) {
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
