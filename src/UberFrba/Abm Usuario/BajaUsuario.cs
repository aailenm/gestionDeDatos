using System;
using System.Windows.Forms;

namespace UberFrba.Alta_Usuario {
    public partial class BajaUsuario : Form {
        public BajaUsuario() {
            InitializeComponent();
        }

        private void refrescarUsuarios() {
            cmbUsuario.DataSource = Conexion.cargarTablaConsulta("GET_USUARIOS");
            cmbUsuario.SelectedIndex = 0;
            cmbUsuario.Focus();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("BAJA_USUARIO", Conexion.generarArgumentos("@ID"), cmbUsuario.SelectedValue))
                MessageBox.Show("Usuario dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refrescarUsuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaUsuario_Load(object sender, EventArgs e) {
            cmbUsuario.ValueMember = "usua_id";
            cmbUsuario.DisplayMember = "usua_usuario";
            refrescarUsuarios();
        }
    }
}
