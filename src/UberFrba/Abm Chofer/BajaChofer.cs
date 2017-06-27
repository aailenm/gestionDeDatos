using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer {
    public partial class BajaChofer : Form {
        public BajaChofer() {
            InitializeComponent();
        }

        private void refrescarChoferes() {
            cmbTeléfonos.DataSource = Conexion.cargarTablaConsulta("GET_CHOFERES");
            cmbTeléfonos.SelectedIndex = 0;
            cmbTeléfonos.Focus();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("BAJA_CHOFER", Conexion.generarArgumentos("@ID"), cmbTeléfonos.SelectedValue))
                MessageBox.Show("Chofer dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("No fue posible dar de baja al chofer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            refrescarChoferes();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaChofer_Load(object sender, EventArgs e) {
            cmbTeléfonos.ValueMember = "chof_id";
            cmbTeléfonos.DisplayMember = "chof_telefono";
            refrescarChoferes();
        }
    }
}
