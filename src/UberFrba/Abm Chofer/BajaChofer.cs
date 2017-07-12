using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer {
    public partial class BajaChofer : Form, ComunicacionForms {
        public BajaChofer() {
            InitializeComponent();
        }


        private void btnInhabilitar_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(chofer.Text))
            {
                MessageBox.Show("Elija un chofer");
            }
            if (Conexion.executeProcedure("BAJA_CHOFER", Conexion.generarArgumentos("@ID"), chofer.Text))
                MessageBox.Show("Chofer dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("No fue posible dar de baja al chofer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            chofer.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaChofer_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaChofer bus = new BusquedaChofer();
            bus.Show(this);
        }

        public void editarChofer(string id)
        {
            chofer.Text = id;
        }
        public void editarCliente(string id) { }
        public void editarAuto(string id) { }
        public void editarTurno(string id) { }
        public void editar(string id) { }
    }
}
