using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno {
    public partial class BajaTurno : Form {
        public BajaTurno() {
            InitializeComponent();
        }

        private void refrescarTurnos() {
            cmbDesc.DataSource = Conexion.cargarTablaConsulta("GET_TURNOS");
            cmbDesc.SelectedIndex = 0;
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
    }
}
