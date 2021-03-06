﻿using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace UberFrba.Abm_Usuario
{
    public partial class Modificar_Usuario : Form
    {
        bool clienteChequeado= false;
        bool choferChequeado = false;
        List<int> rolesIniciales = new List<int>();
        public Modificar_Usuario()
        {
            InitializeComponent();
            mostrarRoles();
            labelCh.Text = "";
            labelCli.Text = "";
            label8.Text = "";
            btnCliente.Enabled = false;
            btnChofer.Enabled = false;
            habilitusua.Enabled = false;
            btnMod.Enabled = true;
            habilitarDatos(false);
            dtpFechaNac.Value = Funciones.ObtenerFecha();
            roles.Enabled = false;
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
            rolesIniciales = new List<int>();
            SqlDataReader reader = Conexion.ejecutarQuery("Select rol_id from RUBIRA_SANTOS.ROL_POR_USUARIO where usua_id = " + cmbUsuario.SelectedValue);
            while (reader.Read())
            {
                int rol = Int32.Parse(reader["rol_id"].ToString());
                roles.SetItemChecked(rol - 1, true);
                rolesIniciales.Add(rol);
            }
            if (reader.HasRows) traerDatos();
            else { 
                 LimpiarCampos();
                 Limpiar();
                 labelCh.Text = "";
                 labelCli.Text = "";
                 MessageBox.Show("El usuario no tiene ningun rol asignado.");
            }
            reader.Close();
        }

        private void refrescarUsuarios()
        {
            cmbUsuario.DataSource = Conexion.cargarTablaConsulta("GET_USUARIOS_TOTALES");
            cmbUsuario.SelectedIndex = -1;
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
                MessageBox.Show("Debe ingresar un usuario a modificar");
            }
            else
            {

                traerRoles();
                roles.Enabled = true;
                SqlDataReader reader = Conexion.ejecutarQuery("Select usua_habilitado from RUBIRA_SANTOS.USUARIO where usua_id = " + cmbUsuario.SelectedValue);
                reader.Read();
                string usuahabi = reader["usua_habilitado"].ToString();
                if (usuahabi.Equals("True"))
                {
                    label8.Text = "Usuario Habilitado";
                    habilitusua.Enabled = false;
                }
                else
                {
                    label8.Text = "Usuario Inhabilitado";
                    habilitusua.Enabled = true;
                }
                reader.Close();
                //traerDatos();
            }
        }

        private void traerDatos()
        {
            if (rolesIniciales.Contains(2)) {
                // si es cliente
                habilitarDatos(true); // por si es administrador
                traerDatosCliente();
            }
            else
            {
                // si no es cliente ni chofer, los trato a todos por igual
                habilitarDatos(false);
                btnChofer.Enabled = false;
                btnCliente.Enabled = false;
            }
            if (rolesIniciales.Contains(3)) {
                // si es chofer
                habilitarDatos(true); // por si es administrador
                traerDatosChofer();
            } else {
                // si no es cliente ni chofer, los trato a todos por igual
                habilitarDatos(false);
                btnChofer.Enabled = false;
                btnCliente.Enabled = false;
            }
        }

        private void traerDatosChofer() {
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
                labelCh.Text = "Chofer habilitado";
                btnChofer.Enabled = false;
            }
            else
            {
                labelCh.Text = "Chofer inhabilitado";
                btnChofer.Enabled = true;
            }
        }
        private void traerDatosCliente() {
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
                labelCli.Text = "Cliente habilitado";
                btnCliente.Enabled = false;
            }
            else
            {
                labelCli.Text = "Cliente inhabilitado";
                btnCliente.Enabled = true;
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
            habilitarChofer();
        }
        private void habilitarChofer()
        {
            if (Conexion.executeProcedure("HABILITAR_CHOFER", Conexion.generarArgumentos("@idChofer"), cmbUsuario.SelectedValue)) 
                MessageBox.Show("Rol modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelCh.Text = "Chofer habilitado";
                btnChofer.Enabled = false;
        }
        private void habilitarCliente(){
                    if (Conexion.executeProcedure("HABILITAR_CLIENTE", Conexion.generarArgumentos("@idCliente"), cmbUsuario.SelectedValue))
                    MessageBox.Show("Rol modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelCli.Text = "Cliente habilitado";
                    btnCliente.Enabled = false;
        }


        private void btnMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario a modificar");
            }
            else
            {
                modificarPorRol();
            }
        }
        private void modificarPorRol()
        {

            if (validaciones())
            {
                foreach (DataRowView rowView in roles.Items)
                {
                    int rol = Int32.Parse(rowView.Row["rol_id"].ToString());
                    if (roles.CheckedItems.Contains(rowView))
                    {
                        if (rolesIniciales.Contains(rol))
                        {
                            //si estaba en los roles que ya tenia y sigue tildado
                            modificarUsuario(rol);
                        }
                        else
                        {//es un rol nuevo a agregar
                            //INSERT EN ROL POR USUARIO Y EN ROL
                            agregarNuevoRol(rol);
                            modificarRol(rol);

                        }
                    }
                    else
                    //si el rol no esta chequeado pero lo estaba
                    {
                        if (rolesIniciales.Contains(rol))
                        {
                            modificarUsuario(rol);
                            inhabilitarUsuario(rol);

                        }

                    }//llave del foreach
                  

                }
                MessageBox.Show("Usuario modificado correctamente.");
                Close();
            }//del if

        }
        private void inhabilitarUsuario(int rol)
        {
            Conexion.executeProcedure("INHABILITAR_USUARIO_ROL", Conexion.generarArgumentos("@IDUSUARIO", "@IDROL"), cmbUsuario.SelectedValue, rol);
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
        private void modificarRol(int rol) {
            Conexion.executeProcedure("AGREGAR_ROLES", Conexion.generarArgumentos("@USUARIO", "@ROL"), cmbUsuario.SelectedValue, rol);
            
        }
        private void agregarNuevoRol(int rol)
        {
            if (rol == 2)
            {
                if (!existe(2))
                {
                    Conexion.executeProcedure("ALTA_CLIENTE", Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP", "@USUARIO"), nomb.Text, apell.Text, dni.Text, mail.Text, tel.Text, dtpFechaNac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text, cmbUsuario.SelectedValue);
                }
                else {
                    habilitarCliente();
                    modificarUsuario(rol);
                }

            }
            if (rol == 3)
            {
                if (!existe(3))
                {
                    Conexion.executeProcedure("ALTA_CHOFER", Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP", "@USUARIO"), nomb.Text, apell.Text, dni.Text, mail.Text, tel.Text, dtpFechaNac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text, cmbUsuario.SelectedValue);
                }
                else
                {
                    habilitarChofer();
                    modificarUsuario(rol);
                }
            }
        }
        private bool existe(int rol)
        {   List<int> rols = new List<int>();
            SqlDataReader reader = Conexion.ejecutarQuery("select r.rol_id from RUBIRA_SANTOS.ROL_POR_USUARIO r where r.usua_id = " + cmbUsuario.SelectedValue);

            while (reader.Read())
            {
                int r = Int32.Parse(reader["rol_id"].ToString());
                rols.Add(r);
            }
            if (rols.Contains(rol))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool validaciones()
        {
            if (roles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un rol");
                return false;
            }
            if (dni.Enabled == true)
            {
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
                //strings
                if(!(Funciones.esString(local.Text)))
                {
                    MessageBox.Show("Solo se aceptan letras en la localidad");
                    return false;
                }

                if (!(Funciones.esString(nomb.Text)))
                {
                    MessageBox.Show("Solo se aceptan letras en el nombre ");
                    return false;
                }
                if (!(Funciones.esString(apell.Text)))
                {
                    MessageBox.Show("Solo se aceptan letras en el apellido");
                    return false;
                }

                //fin strings
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
                if (piso.Text.Length > 4)
                {
                    MessageBox.Show("El piso no puede tener mas de cuatro digitos");
                    return false;
                }

                if (dpto.Text.Length > 4)
                {
                    MessageBox.Show("El depto no puede tener mas de cuatro digitos");
                    return false;
                }
                if (dni.Text.Length > 8 )
                {
                    MessageBox.Show("El numero de dni no puede tener mas de ocho digitos");
                    return false;
                }

                if (tel.Text.Length > 15)
                {
                    MessageBox.Show("El numero de telefono no puede tener mas de quince digitos");
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
            return true;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            habilitarCliente();
        }

        private void labelCh_Click(object sender, EventArgs e)
        {

        }

        private void habilitusua_Click(object sender, EventArgs e)
        {
            if (Conexion.executeProcedure("HABILITAR_USUARIO", Conexion.generarArgumentos("@ID"), cmbUsuario.SelectedValue))
                MessageBox.Show("Usuario habilitado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label8.Text = "Usuario Habilitado";
            habilitusua.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DataRowView data = roles.Items[e.Index] as DataRowView;
            if (data.Row["rol_id"].ToString() == "2") {
                if (!roles.CheckedItems.Contains(data)) clienteChequeado = true;
                else clienteChequeado = false;
            }
            if (data.Row["rol_id"].ToString() == "3")
            {
                if (!roles.CheckedItems.Contains(data)) choferChequeado = true;
                else choferChequeado = false;
            }
            if (clienteChequeado || choferChequeado) habilitarDatos(true);
            else habilitarDatos(false);
           /*DataRowView data = roles.Items[e.Index] as DataRowView;
           if (!roles.CheckedItems.Contains(data) && (data.Row["rol_id"].ToString() == "2" || data.Row["rol_id"].ToString() == "3")) habilitarDatos(true);
           else {
               if (!roles.CheckedItems.Contains((DataRowView x) => x.Row["rol_id"].ToString())) habilitarDatos(true);
               else habilitarDatos(false);
           }*/
        }

    }
}

