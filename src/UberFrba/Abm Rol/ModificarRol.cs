using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol {
    public partial class Modificar_Rol : Form {
        public Modificar_Rol() {
            InitializeComponent();
        }

        private void refrescarRoles() {
            cmbRol.DataSource = Conexion.obtenerTablaProcedure("GET_ROLES", Conexion.generarArgumentos("@DESCRIPCION"), "");
            cmbRol.SelectedIndex = 0;
            txtDesc.Text = cmbRol.Text;
            cmbRol.Focus();
        }

        private void btnMod_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("MODIFICAR_ROL", Conexion.generarArgumentos("@ID", "@DESC"), cmbRol.SelectedValue, txtDesc.Text))
                MessageBox.Show("Rol modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refrescarRoles();
        }

        private void ModificarRol_Load(object sender, EventArgs e) {
            cmbRol.ValueMember = "rol_id";
            cmbRol.DisplayMember = "rol_descripcion";
            refrescarRoles();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e) {
            txtDesc.Text = cmbRol.Text;
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
