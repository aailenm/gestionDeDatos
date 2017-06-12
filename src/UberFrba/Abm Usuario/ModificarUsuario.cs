using System.Windows.Forms;

namespace UberFrba.Abm_Usuario {
    public partial class Modificar_Usuario : Form {
        public Modificar_Usuario() {
            InitializeComponent();
        }

        private void refrescarCampos() {
            txtUsuario.Text = cmbUsuario.Text;
        }

        private void refrescarUsuarios() {
            cmbUsuario.DataSource = Conexion.cargarTablaConsulta("GET_USUARIOS");
            cmbUsuario.SelectedIndex = 0;
            refrescarCampos();
            cmbUsuario.Focus();
        }

        private void Modificar_Usuario_Load(object sender, System.EventArgs e) {
            cmbUsuario.ValueMember = "usua_id";
            cmbUsuario.DisplayMember = "usua_usuario";
            refrescarUsuarios();
        }

        private void btnMod_Click(object sender, System.EventArgs e) {

        }

        private void btnVolver_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, System.EventArgs e) {
            refrescarCampos();
        }
    }
}
