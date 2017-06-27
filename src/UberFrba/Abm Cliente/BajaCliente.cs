using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente {
    public partial class BajaCliente : Form {
        public BajaCliente() {
            InitializeComponent();
        }

        private void refrescarClientes() {
            cmbTeléfonos.DataSource = Conexion.cargarTablaConsulta("GET_CLIENTES");
            cmbTeléfonos.SelectedIndex = 0;
            cmbTeléfonos.Focus();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("BAJA_CLIENTE", Conexion.generarArgumentos("@ID"), cmbTeléfonos.SelectedValue))
                MessageBox.Show("Cliente dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("No fue posible dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            refrescarClientes();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaCliente_Load(object sender, EventArgs e) {
            cmbTeléfonos.ValueMember = "clie_id";
            cmbTeléfonos.DisplayMember = "clie_telefono";
            refrescarClientes();
        }
    }
}
