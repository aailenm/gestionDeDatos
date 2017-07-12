using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno {
    public partial class Baja_Turno : Form, ComunicacionForms {
        public Baja_Turno() {
            InitializeComponent();
        }

        private void refrescarTurnos() {

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(turno.Text))
            {
                MessageBox.Show("Elija un turno");
            }
            else
            {
                if (Conexion.executeProcedure("BAJA_TURNO", Conexion.generarArgumentos("@ID"), turno.Text))
                    MessageBox.Show("Turno dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                turno.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaTurno_Load(object sender, EventArgs e) {

        }

        private void cmbDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaTurno bus = new BusquedaTurno();
            bus.Show(this);
        }

        public void editarChofer(string id)
        {
        }
        public void editarCliente(string id)
        {
        }
        public void editarAuto(string id) { }
        public void editar(string id) {
            turno.Text = id;
        }

    }
}
