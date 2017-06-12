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

namespace UberFrba.Login
{
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

            automovilBaja.Visible = false;
            automovilToolStripMenuItem.Visible = false;
            automovilToolStripMenuItem2.Visible = false;
            automovilToolStripMenuItem3.Visible = false;

            clienteBaja.Visible = false;
            clienteToolStripMenuItem1.Visible = false;
            clienteToolStripMenuItem2.Visible = false;
            usuarioToolStripMenuItem.Visible = false;

            choferBaja.Visible = false;
            choferToolStripMenuItem1.Visible = false;
            choferToolStripMenuItem3.Visible = false;
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
            if(func == 5) usuarioToolStripMenuItem.Visible = true;
            if(func == 6) clienteBaja.Visible = true;
            if(func == 7) clienteToolStripMenuItem1.Visible = true;
            if (func == 8) clienteToolStripMenuItem2.Visible = true;
            if (func == 9) choferToolStripMenuItem1.Visible = true;
            if(func == 10) choferBaja.Visible = true;
            if(func == 11) choferToolStripMenuItem3.Visible = true;
            if(func == 12) choferToolStripMenuItem4.Visible = true;
            if(func == 13) automovilToolStripMenuItem.Visible = true;
            if(func == 14) automovilBaja.Visible = true;
            if(func == 15) automovilToolStripMenuItem2.Visible = true;
            if(func == 16) automovilToolStripMenuItem3.Visible = true;
            if(func == 17) turnoToolStripMenuItem.Visible = true;
            if(func == 18) turnoBaja.Visible = true;
            if(func == 19) turnoToolStripMenuItem2.Visible = true;
            if(func == 20) turnoToolStripMenuItem3.Visible = true;
            if(func == 21) registrarToolStripMenuItem.Visible = true;
            if(func == 22) rendiciónToolStripMenuItem.Visible = true;
            if(func == 23) facturaciónToolStripMenuItem.Visible = true;
            if(func == 24) generarEstadisticasToolStripMenuItem.Visible = true;
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
            Abm_Usuario.AltaUsuario usu = new Abm_Usuario.AltaUsuario();
            usu.Show();
        }

        private void automovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Automovil.Form1 form = new Abm_Automovil.Form1();
            form.Show();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Rol.Form1 form = new Abm_Rol.Form1();
            form.Show();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Turno.Alta_turno form = new Abm_Turno.Alta_turno();
            form.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Usuario.AltaUsuario usu = new Abm_Usuario.AltaUsuario();
            usu.Show();
        }

        private void choferToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Abm_Usuario.AltaUsuario usu = new Abm_Usuario.AltaUsuario();
            usu.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Usuario.BajaUsuario form = new Abm_Usuario.BajaUsuario();
            form.Show();
        }

        private void choferToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void rolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Rol.BajaRol form = new Abm_Rol.BajaRol();
            form.Show();
        }

        private void turnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Turno.BajaTurno form = new Abm_Turno.BajaTurno();
            form.Show();
        }

        private void automovilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Automovil.BajaAutomovil form = new Abm_Automovil.BajaAutomovil();
            form.Show();
        }

        private void choferToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer form = new Abm_Chofer.BusquedaChofer();
            form.Show();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Abm_Cliente.BusquedaCliente form = new Abm_Cliente.BusquedaCliente();
            form.Show();
        }

        private void automovilToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Abm_Automovil.BusquedaAuto form = new Abm_Automovil.BusquedaAuto();
            form.Show();
        }

        private void rolToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Abm_Rol.BusquedaRol form = new Abm_Rol.BusquedaRol();
            form.Show();
        }

        private void turnoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Abm_Turno.BusquedaTurno form = new Abm_Turno.BusquedaTurno();
            form.Show();
        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion.Form1 form = new Facturacion.Form1();
            form.Show();
        }

        private void crearRendicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rendicion_Viajes.Form1 form = new Rendicion_Viajes.Form1();
            form.Show();
        }

        private void generarEstadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.GenerarListados form = new Listado_Estadistico.GenerarListados();
            form.Show();
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
            Registro_Viajes.Form1 form = new Registro_Viajes.Form1();
            form.Show();
        }

        private void choferToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void clienteBaja_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }
    }
}
