using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol {
    public partial class Baja_Rol : Form {
        public Baja_Rol() {
            InitializeComponent();
        }

        private void refrescarRoles() {
            cmbRol.DataSource = Conexion.obtenerTablaProcedure("GET_ROLES", Conexion.generarArgumentos("@DESCRIPCION"), "");
            cmbRol.SelectedIndex = 0;
            cmbRol.Focus();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("BAJA_ROL", Conexion.generarArgumentos("@ID"), cmbRol.SelectedValue))
                MessageBox.Show("Rol dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refrescarRoles();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaRol_Load(object sender, EventArgs e) {
            cmbRol.ValueMember = "rol_id";
            cmbRol.DisplayMember = "rol_descripcion";
            refrescarRoles();
        }
    }
}
