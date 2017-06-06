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

namespace UberFrba.Alta_Usuario
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
            mostrarRoles();
        }

        private void label2_Click(object sender, EventArgs e)
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
                bool resultado = Conexion.executeProcedure("ALTA_USUARIO", Conexion.generarArgumentos("@USUARIO", "@CONTRA"), usuario.Text, contraseña.Text);
                if (resultado)
                {
                    agregarRoles();
                    MessageBox.Show("Usuario creado correctamente");
                    Close();
                }
            }
        }

        private bool validaciones() {
            if (usuario.Text == "") {
                MessageBox.Show("Ingrese un usuario");
                return false;
            }

            if (contraseña.Text == "") {
                MessageBox.Show("Ingrese una contraseña");
                return false;
            }

            if (roles.CheckedItems.Count == 0) {
                MessageBox.Show("Debe seleccionar al menos un rol");
                return false;
            }
            return true;
        }
        private void mostrarRoles(){
            roles.DataSource = Conexion.obtenerTablaProcedure("GET_ROLES",Conexion.generarArgumentos("@DESCRIPCION"),"");
            roles.ValueMember = "rol_id";
            roles.DisplayMember = "rol_descripcion";
        }
        private void agregarRoles()
        {
            SqlDataReader reader = Conexion.ejecutarQuery("Select usua_id from USUARIO WHERE usua_usuario like '%" + usuario.Text + "%'");
            reader.Read();
            string usua = (reader["usua_id"].ToString());
            reader.Close();
            foreach (DataRowView rowView in roles.CheckedItems)
            {
                Conexion.executeProcedure("AGREGAR_ROLES", Conexion.generarArgumentos("@USUARIO", "@ROL"), usua, rowView["rol_id"]);
            }
        }
    }
}
