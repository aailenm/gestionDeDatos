using System;
using System.Data;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno {
    public partial class Modificar_Turno : Form {
        public Modificar_Turno() {
            InitializeComponent();
        }

        private void refrescarCampos() {
            DataTable dt = Conexion.obtenerTablaProcedure("GET_TURNO", Conexion.generarArgumentos("@ID"), cmbTurno.SelectedValue);
            string horaInicial = dt.Rows[0][1].ToString();
            string horaFinal = dt.Rows[0][2].ToString();
            txtHoraInicialA.Text = horaInicial.Substring(0, 2);
            txtHoraInicialB.Text = horaInicial.Substring(3, 2);
            txtHoraFinalA.Text = horaFinal.Substring(0, 2);
            txtHoraFinalB.Text = horaFinal.Substring(3, 2);
            txtDesc.Text = dt.Rows[0][3].ToString();
            txtValorKm.Text = dt.Rows[0][4].ToString();
            txtPrecioBase.Text = dt.Rows[0][5].ToString();
        }

        private void refrescarTurnos() {
            cmbTurno.DataSource = Conexion.cargarTablaConsulta("GET_TURNOS");
            cmbTurno.SelectedIndex = 0;
            refrescarCampos();
            cmbTurno.Focus();
        }

        private void ModificarTurno_Load(object sender, EventArgs e) {
            cmbTurno.ValueMember = "turn_id";
            cmbTurno.DisplayMember = "turn_descripcion";
            refrescarTurnos();
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e) {
            refrescarCampos();
        }

        private void btnMod_Click(object sender, EventArgs e) {
            if (Conexion.executeProcedure("MODIFICAR_TURNO", Conexion.generarArgumentos("@ID", "@DESCRIPCION", "@HORA_INICIO", "@HORA_FIN", "@PRECIOBASE", "@VALORKM"), cmbTurno.SelectedValue, txtDesc.Text, txtHoraInicialA.Text + ":" + txtHoraInicialB.Text, txtHoraFinalA.Text + ":" + txtHoraFinalB.Text, Convert.ToDouble(txtPrecioBase.Text), Convert.ToDouble(txtValorKm.Text)))
                MessageBox.Show("Turno modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refrescarTurnos();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
