using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace UberFrba.Abm_Usuario
{
    public partial class Modificar_Usuario : Form
    {
        List<int> rolesIniciales = new List<int>();
        public Modificar_Usuario()
        {
            InitializeComponent();
            mostrarRoles();
        }

        private void mostrarRoles()
        {
            roles.DataSource = Conexion.obtenerTablaProcedure("GET_ROLES", Conexion.generarArgumentos("@DESCRIPCION"), "");
            roles.ValueMember = "rol_id";
            roles.DisplayMember = "rol_descripcion";
        }

        private void Modificar_Usuario_Load(object sender, System.EventArgs e)
        {
            cmbUsuario.ValueMember = "usua_id";
            cmbUsuario.DisplayMember = "usua_usuario";
            refrescarUsuarios();
        }

        public void traerRoles()
        {

            SqlDataReader reader = Conexion.ejecutarQuery("Select rol_id from RUBIRA_SANTOS.ROL_POR_USUARIO where usua_id = " + cmbUsuario.SelectedValue);
            while (reader.Read())
            {
                int rol = Int32.Parse(reader["rol_id"].ToString());
                roles.SetItemChecked(rol - 1, true);
                rolesIniciales.Add(rol);
                traerDatos(rol);
                btnMod.Enabled = true;
            }
            reader.Close();
        }

        private void refrescarUsuarios()
        {
            cmbUsuario.DataSource = Conexion.cargarTablaConsulta("GET_USUARIOS_TOTALES");
            cmbUsuario.SelectedIndex = 0;
            cmbUsuario.Focus();
        }

        private void Limpiar()
        {
            int cant = roles.Items.Count;
            for (int i = 0; i < cant; i++)
            {
                roles.SetItemChecked(i, false);
            }
        }

        private void cmbUsuario_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {
            Limpiar();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            nomb.Clear();
            apell.Clear();
            dni.Clear();
            tel.Clear();
            mail.Clear();
            calle.Clear();
            piso.Clear();
            dpto.Clear();
            local.Clear();
            cp.Clear();
        }
        private void mostrarDatos(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el usuario a modificar.", "Hay campos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            traerRoles();

            //traerDatos();
        }
        private void traerDatos(int rol)
        {
            if (rol == 1)
            {
                habilitarDatos(false);
                button2.Enabled = false;
            }
            if (rol == 2)
            {
                habilitarDatos(true); //por si es administrador
                SqlDataReader reader = Conexion.ejecutarQuery("select C.clie_nombre, C.clie_apellido, C.clie_dni, C.clie_mail, C.clie_telefono, C.clie_fechaNacimiento,D.dire_calle,D.dire_piso,D.dire_depto, D.dire_localidad,D.dire_cp, C.clie_habilitado from RUBIRA_SANTOS.CLIENTE C join RUBIRA_SANTOS.DIRECCION D on C.clie_direccion=D.dire_id where C.clie_usua=" + cmbUsuario.SelectedValue);
                reader.Read();
                nomb.Text = reader["clie_nombre"].ToString();
                apell.Text = reader["clie_apellido"].ToString();
                dni.Text = reader["clie_dni"].ToString();
                mail.Text = reader["clie_mail"].ToString();
                tel.Text = reader["clie_telefono"].ToString();
                dtpFechaNac.Text = reader["clie_fechaNacimiento"].ToString();
                calle.Text = reader["dire_calle"].ToString();
                piso.Text = reader["dire_piso"].ToString();
                dpto.Text = reader["dire_depto"].ToString();
                local.Text = reader["dire_localidad"].ToString();
                cp.Text = reader["dire_cp"].ToString();
                string hab = reader["clie_habilitado"].ToString();
                reader.Close();
                if (hab.Equals("True"))
                {
                    estado.Text = "";
                    button2.Enabled = false;
                }
                else
                {
                    estado.Text = "Cliente inhabilitado";
                    button2.Enabled = true;
                }
            }
            if (rol == 3)
            {
                habilitarDatos(true); //por si es administrador
                SqlDataReader reader = Conexion.ejecutarQuery("select C.chof_nombre, C.chof_apellido, C.chof_dni, C.chof_mail, C.chof_telefono, C.chof_fechaNacimiento,D.dire_calle,D.dire_piso,D.dire_depto, D.dire_localidad,D.dire_cp, C.chof_habilitado from RUBIRA_SANTOS.CHOFER C join RUBIRA_SANTOS.DIRECCION D on C.chof_direccion=D.dire_id where C.chof_usua=" + cmbUsuario.SelectedValue);
                reader.Read();
                nomb.Text = reader["chof_nombre"].ToString();
                apell.Text = reader["chof_apellido"].ToString();
                dni.Text = reader["chof_dni"].ToString();
                mail.Text = reader["chof_mail"].ToString();
                tel.Text = reader["chof_telefono"].ToString();
                dtpFechaNac.Text = reader["chof_fechaNacimiento"].ToString();
                calle.Text = reader["dire_calle"].ToString();
                piso.Text = reader["dire_piso"].ToString();
                dpto.Text = reader["dire_depto"].ToString();
                local.Text = reader["dire_localidad"].ToString();
                cp.Text = reader["dire_cp"].ToString();
                string hab = reader["chof_habilitado"].ToString();
                reader.Close();
                if (hab.Equals("True"))
                {
                    estado.Text = "";
                    button2.Enabled = false;
                }
                else
                {
                    estado.Text = "Chofer inhabilitado";
                    button2.Enabled = true;
                }
            }
        }
        private void habilitarDatos(bool estado)
        {
            nomb.Enabled = estado;
            apell.Enabled = estado; ;
            dni.Enabled = estado; ;
            mail.Enabled = estado; ;
            tel.Enabled = estado;
            dtpFechaNac.Enabled = estado;
            calle.Enabled = estado;
            piso.Enabled = estado;
            dpto.Enabled = estado;
            local.Enabled = estado;
            cp.Enabled = estado;

        }


        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void nomb_TextChanged(object sender, EventArgs e)
        {

        }

        private void habilitar(object sender, EventArgs e)
        {
            habilitarUsuario();
        }
        private void habilitarUsuario()
        {
            if (estado.Text == "Chofer inhabilitado")
            {
                if (Conexion.executeProcedure("HABILITAR_CHOFER", Conexion.generarArgumentos("@idChofer"), cmbUsuario.SelectedValue)) 
                    MessageBox.Show("Rol modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            if (estado.Text == "Cliente inhabilitado")
            {

                if (Conexion.executeProcedure("HABILITAR_CLIENTE", Conexion.generarArgumentos("@idCliente"), cmbUsuario.SelectedValue))
                    MessageBox.Show("Rol modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
        }


        private void btnMod_Click(object sender, EventArgs e)
        {
            modificarPorRol();

        }
        private void modificarPorRol()
        {
            if (validaciones())
            {
                
                foreach (DataRowView rowView in roles.CheckedItems){
                    int rol = Int32.Parse(rowView["rol_id"].ToString());
                    if (rolesIniciales.Contains(rol)){
                    //si estaba en los roles que ya tenia y sigue tildado
                        modificarUsuario(rol);
                        }
                    else
                        {//es un rol nuevo a agregar
                            //INSERT EN ROL POR USUARIO Y EN ROL
                            agregarNuevoRol(rol);
                            
                        }
                }
                foreach(DataRowView rowView in roles.Items){
                    int rol = Int32.Parse(rowView["rol_id"].ToString());
                        //si el rol no esta chequeado pero lo estaba
                    if(!roles.CheckedItems.Contains(rowView["rol_id"])){
                        if (rolesIniciales.Contains(rol)) {
                            modificarUsuario(rol);
                            inhabilitarUsuario(rol);
                         
                        }
                    }
                      
                }//llave del foreach
            
                MessageBox.Show("Usuario modificado correctamente.");
                Close();

            }//del if

        }
        private void inhabilitarUsuario(int rol)
        {
            if (rol == 2)
            {
                Conexion.executeProcedure("INHABILITAR_CLIENTE", Conexion.generarArgumentos("@idUsuario"), cmbUsuario.SelectedValue);
            }
            if (rol == 3)
            {
                Conexion.executeProcedure("INHABILITAR_CHOFER", Conexion.generarArgumentos("@idUsuario"), cmbUsuario.SelectedValue);
            }
        }
        private void modificarUsuario(int rol)
        {
            if (rol == 2)
            {
                Conexion.executeProcedure("MODIFICAR_CLIENTE", Conexion.generarArgumentos("@usuaCliente", "@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP"), cmbUsuario.SelectedValue, nomb.Text, apell.Text, dni.Text, mail.Text, tel.Text, dtpFechaNac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text);

            }//cierra if de rol
            if (rol == 3)
            {
                Conexion.executeProcedure("MODIFICAR_CHOFER", Conexion.generarArgumentos("@usuaChofer", "@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP"), cmbUsuario.SelectedValue, nomb.Text, apell.Text, dni.Text, mail.Text, tel.Text, dtpFechaNac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text);
            }//cierra if de rol
        }
        private void agregarNuevoRol(int rol)
        {
            Conexion.executeProcedure("AGREGAR_ROLES", Conexion.generarArgumentos("@USUARIO", "@ROL"), cmbUsuario.SelectedValue, rol);
            if (rol == 2)
            {
                Conexion.executeProcedure("ALTA_CLIENTE", Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP", "@USUARIO"), nomb.Text, apell.Text, dni.Text, mail.Text, tel.Text, dtpFechaNac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text, cmbUsuario.SelectedValue);


            }
            if (rol == 3)
            {
                Conexion.executeProcedure("ALTA_CHOFER", Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP", "@USUARIO"), nomb.Text, apell.Text, dni.Text, mail.Text, tel.Text, dtpFechaNac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text, cmbUsuario.SelectedValue);

            }
        }

        private bool validaciones()
        {
            if (roles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un rol");
                return false;
            }

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

            if (nomb.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }

            if (apell.Text == "")
            {
                MessageBox.Show("El campo Apellido no puede estar vacio");
                return false;
            }
            if (dni.Text == "")
            {
                MessageBox.Show("El campo DNI no puede estar vacio");
                return false;
            }

            if (mail.Text == "")
            {
                MessageBox.Show("El campo mail no puede estar vacio");
                return false;
            }

            if (tel.Text == "")
            {
                MessageBox.Show("El campo Telefono no puede estar vacio");
                return false;
            }

            if (dtpFechaNac.Value >= Funciones.ObtenerFecha())
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

    }
}

