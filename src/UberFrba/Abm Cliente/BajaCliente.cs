using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente {
    public partial class BajaCliente : Form, ComunicacionForms {
        public BajaCliente() {
            InitializeComponent();
        }

        private void refrescarClientes() {

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cliente.Text))
            {
                MessageBox.Show("Elija un cliente");
            }
            else
            {
                if (Conexion.executeProcedure("BAJA_CLIENTE", Conexion.generarArgumentos("@ID"), cliente.Text))
                    MessageBox.Show("Cliente dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("No fue posible dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cliente.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaCliente_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaCliente bus = new BusquedaCliente();
            bus.Show(this);
        }

        public void editarChofer(string id)
        {
        }
        public void editarCliente(string id) {
            cliente.Text = id;
        }
        public void editarAuto(string id) { }
        public void editarTurno(string id) { }
        public void editar(string id) { }
    }
}
