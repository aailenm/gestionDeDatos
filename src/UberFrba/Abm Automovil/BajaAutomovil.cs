using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil {
    public partial class Baja_Automovil : Form, ComunicacionForms {
        public Baja_Automovil() {
            InitializeComponent();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(patente.Text))
            {
                MessageBox.Show("Elija un auto");
            }
            else
            {
                if (Conexion.executeProcedure("BAJA_AUTOMOVIL", Conexion.generarArgumentos("@ID"), patente.Text))
                    MessageBox.Show("Auto dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                patente.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaAutomovil_Load(object sender, EventArgs e) {

        }

        private void cmbPatente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaAuto busqueda = new BusquedaAuto();
            busqueda.Show(this);
        }

        public void editarChofer(string id) { }
        public void editarCliente(string id) { }
        public void editarAuto(string id) {
            patente.Text = id;

        }
        public void editarTurno(string id) { }
        public void editar(string id) { }
    }
}
