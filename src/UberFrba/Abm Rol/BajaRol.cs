using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol {
    public partial class Baja_Rol : Form, ComunicacionForms {
        public Baja_Rol() {
            InitializeComponent();
        }

        private void refrescarRoles() {
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rol.Text))
            {
                MessageBox.Show("Elija un rol");
            }
            else
            {
                if (Conexion.executeProcedure("BAJA_ROL", Conexion.generarArgumentos("@ID"), rol.Text))
                    MessageBox.Show("Rol dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rol.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaRol_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaRol bus = new BusquedaRol();
            bus.Show(this);
        }

        public void editarChofer(string id)
        {
        }
        public void editarCliente(string id)
        {
        }
        public void editarAuto(string id) { }
        public void editarTurno(string id) { }
        public void editar(string id) {
            rol.Text = id;
        }
    }
}
