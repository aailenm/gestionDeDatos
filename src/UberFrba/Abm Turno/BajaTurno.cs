using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno {
    public partial class Baja_Turno : Form {
        public Baja_Turno() {
            InitializeComponent();
        }

        private void refrescarTurnos() {
            cmbDesc.DataSource = Conexion.cargarTablaConsulta("GET_HABILITADOS_TURNOS");
            cmbDesc.SelectedIndex = -1;
            cmbDesc.Focus();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("BAJA_TURNO", Conexion.generarArgumentos("@ID"), cmbDesc.SelectedValue))
                MessageBox.Show("Turno dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refrescarTurnos();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaTurno_Load(object sender, EventArgs e) {
            cmbDesc.ValueMember = "turn_id";
            cmbDesc.DisplayMember = "turn_descripcion";
            refrescarTurnos();
        }

        private void cmbDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
