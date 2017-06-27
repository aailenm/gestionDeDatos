using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UberFrba.Login {
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
            deshabilitarTodo();
        }

        private void deshabilitarTodo()
        {
            rolBaja.Visible = false;
            rolToolStripMenuItem.Visible = false;
            rolToolStripMenuItem2.Visible = false;
            rolToolStripMenuItem3.Visible = false;

            usuarioToolStripMenuItem3.Visible = false;
            usuarioToolStripMenuItem2.Visible = false;
            usuarioToolStripMenuItem1.Visible = false;

            automovilBaja.Visible = false;
            automovilToolStripMenuItem.Visible = false;
            automovilToolStripMenuItem2.Visible = false;
            automovilToolStripMenuItem3.Visible = false;
            
            clienteToolStripMenuItem2.Visible = false;
            choferToolStripMenuItem4.Visible = false;

            turnoBaja.Visible = false;
            turnoToolStripMenuItem.Visible = false;
            turnoToolStripMenuItem2.Visible = false;
            turnoToolStripMenuItem3.Visible = false;

            facturaciónToolStripMenuItem.Visible = false;
            generarEstadisticasToolStripMenuItem.Visible = false;
            rendiciónToolStripMenuItem.Visible = false;
            registrarToolStripMenuItem.Visible = false;
        }

        public void habilitarFuncionalidadesPorRol(string id)
        {
            SqlDataReader reader = Conexion.ejecutarQuery("SELECT F.func_id FROM RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD RPF JOIN RUBIRA_SANTOS.FUNCIONALIDAD F ON F.func_id = RPF.func_id WHERE RPF.func_habilitada = 1 and RPF.rol_id =" + id);
            List<int> funcionalidades = new List<int>();
            while (reader.Read())
            {
                int j = 0;
                funcionalidades.Add(Convert.ToInt32(reader[j]));
                j = j + 1;
            }
            reader.Close();

            for (int i = 0; i < funcionalidades.Count; i++)
            {
                habilitarFuncionalidad(funcionalidades[i]);
            }
        }

        private void habilitarFuncionalidad(int func) { 
            if(func == 1)  rolToolStripMenuItem.Visible = true;
            if(func == 2) rolBaja.Visible = true;
            if(func == 3) rolToolStripMenuItem2.Visible = true;
            if(func == 4) rolToolStripMenuItem3.Visible = true;

            if (func == 5) usuarioToolStripMenuItem3.Visible = true;
            if (func == 6) usuarioToolStripMenuItem2.Visible = true;
            if (func == 7) usuarioToolStripMenuItem1.Visible = true;

            if(func == 8) clienteToolStripMenuItem2.Visible = true;
            if(func == 9) choferToolStripMenuItem4.Visible = true;

            if(func == 10) automovilToolStripMenuItem.Visible = true;
            if(func == 11) automovilBaja.Visible = true;
            if(func == 12) automovilToolStripMenuItem2.Visible = true;
            if(func == 13) automovilToolStripMenuItem3.Visible = true;

            if(func == 14) turnoToolStripMenuItem.Visible = true;
            if(func == 15) turnoBaja.Visible = true;
            if(func == 16) turnoToolStripMenuItem2.Visible = true;
            if(func == 17) turnoToolStripMenuItem3.Visible = true;

            if(func == 18) registrarToolStripMenuItem.Visible = true;
            if(func == 19) rendiciónToolStripMenuItem.Visible = true;
            if(func == 20) facturaciónToolStripMenuItem.Visible = true;
            if(func == 21) generarEstadisticasToolStripMenuItem.Visible = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void choferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BajaChofer form = new Abm_Chofer.BajaChofer();
            form.ShowDialog();
        }

        private void automovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Automovil.Alta_Automovil form = new Abm_Automovil.Alta_Automovil();
            form.ShowDialog();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Rol.Alta_Rol form = new Abm_Rol.Alta_Rol();
            form.ShowDialog();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Turno.Alta_Turno form = new Abm_Turno.Alta_Turno();
            form.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Usuario.AltaUsuario usu = new Abm_Usuario.AltaUsuario();
            usu.ShowDialog();
        }

        private void choferToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Abm_Usuario.AltaUsuario usu = new Abm_Usuario.AltaUsuario();
            usu.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Usuario.BajaUsuario form = new Abm_Usuario.BajaUsuario();
            form.ShowDialog();
        }

        private void rolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Rol.Baja_Rol form = new Abm_Rol.Baja_Rol();
            form.ShowDialog();
        }

        private void turnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Turno.Baja_Turno form = new Abm_Turno.Baja_Turno();
            form.ShowDialog();
        }

        private void automovilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Automovil.Baja_Automovil form = new Abm_Automovil.Baja_Automovil();
            form.ShowDialog();
        }

        private void choferToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer form = new Abm_Chofer.BusquedaChofer();
            form.ShowDialog();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Abm_Cliente.BusquedaCliente form = new Abm_Cliente.BusquedaCliente();
            form.ShowDialog();
        }

        private void automovilToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Abm_Automovil.BusquedaAuto form = new Abm_Automovil.BusquedaAuto();
            form.ShowDialog();
        }

        private void rolToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Abm_Rol.BusquedaRol form = new Abm_Rol.BusquedaRol();
            form.ShowDialog();
        }

        private void turnoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Abm_Turno.BusquedaTurno form = new Abm_Turno.BusquedaTurno();
            form.ShowDialog();
        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion.Crear_Factura form = new Facturacion.Crear_Factura();
            form.ShowDialog();
        }

        private void crearRendicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rendicion_Viajes.Crear_Pago form = new Rendicion_Viajes.Crear_Pago();
            form.ShowDialog();
        }

        private void generarEstadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.GenerarListados form = new Listado_Estadistico.GenerarListados();
            form.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Viajes.Registro_Viajes form = new Registro_Viajes.Registro_Viajes();
            form.ShowDialog();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Login log = new Login();
            log.Show();
        }

        private void automovilToolStripMenuItem2_Click(object sender, EventArgs e) {
            Abm_Automovil.Modificar_Auto form = new Abm_Automovil.Modificar_Auto();
            form.ShowDialog();
        }

        private void rolToolStripMenuItem2_Click(object sender, EventArgs e) {
            Abm_Rol.Modificar_Rol form = new Abm_Rol.Modificar_Rol();
            form.ShowDialog();
        }

        private void turnoToolStripMenuItem2_Click(object sender, EventArgs e) {
            Abm_Turno.Modificar_Turno form = new Abm_Turno.Modificar_Turno();
            form.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click_1(object sender, EventArgs e) {
            Abm_Usuario.Modificar_Usuario form = new Abm_Usuario.Modificar_Usuario();
            form.ShowDialog();
        }

        private void usuarioToolStripMenuItem3_Click(object sender, EventArgs e) {
            Abm_Usuario.AltaUsuario form = new Abm_Usuario.AltaUsuario();
            form.ShowDialog();
        }

        private void usuarioToolStripMenuItem2_Click(object sender, EventArgs e) {
            Abm_Usuario.BajaUsuario form = new Abm_Usuario.BajaUsuario();
            form.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            Abm_Cliente.BajaCliente form = new Abm_Cliente.BajaCliente();
            form.ShowDialog();
        }
    }
}
