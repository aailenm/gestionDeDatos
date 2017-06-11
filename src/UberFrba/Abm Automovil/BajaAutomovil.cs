using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil {
    public partial class BajaAutomovil : Form {
        public BajaAutomovil() {
            InitializeComponent();
        }

        private void refrescarPatentes() {
            cmbPatente.DataSource = Conexion.cargarTablaConsulta("GET_PATENTES");
            cmbPatente.SelectedIndex = 0;
            cmbPatente.Focus();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("BAJA_AUTOMOVIL", Conexion.generarArgumentos("@ID"), cmbPatente.SelectedValue))
                MessageBox.Show("Auto dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refrescarPatentes();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaAutomovil_Load(object sender, EventArgs e) {
            cmbPatente.ValueMember = "auto_id";
            cmbPatente.DisplayMember = "auto_patente";
            refrescarPatentes();
        }
    }
}
