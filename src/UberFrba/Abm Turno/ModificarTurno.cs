using System;
using System.Data;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno {
    public partial class Modificar_Turno : Form {
        public Modificar_Turno() {
            InitializeComponent();
        }

        private bool validaciones() {
            Double valor = 0;
            if (txtValorKm.Text == "") {
                MessageBox.Show("El valor del kilómetro no puede estar vacio");
                return false;
            }
            if (!Double.TryParse(txtValorKm.Text, out valor)) {
                MessageBox.Show("El valor del kilómetro debe ser un número");
                return false;
            }
            if (valor <= 0) {
                MessageBox.Show("El valor del kilómetro debe ser mayor a 0");
                return false;
            }
            if (txtPrecioBase.Text == "") {
                MessageBox.Show("El campo Precio Base no puede estar vacío");
                return false;
            }
            if (!Double.TryParse(txtPrecioBase.Text, out valor)) {
                MessageBox.Show("El campo Precio Base debe ser un número");
                return false;
            }
            if (valor <= 0) {
                MessageBox.Show("El valor del precio base debe ser mayor a 0");
                return false;
            }
            if (!Funciones.esNumero(txtHoraInicialA.Text)) {
                MessageBox.Show("El campo de hora inicial debe ser un número ");
                return false;
            }
            if (txtHoraInicialA.Text == "") {
                MessageBox.Show("El campo de hora inicial no puede estar vacio");
                return false;
            }
            if (!Funciones.esNumero(txtHoraInicialB.Text)) {
                MessageBox.Show("El campo de minuto inicial debe ser un número");
                return false;
            }
            if (txtHoraInicialB.Text == "") {
                MessageBox.Show("El campo de minuto inicial no puede estar vacio");
                return false;
            }
            if (txtHoraFinalA.Text == "") {
                MessageBox.Show("El campo de hora final no puede estar vacio");
                return false;
            }
            if (!Funciones.esNumero(txtHoraFinalB.Text)) {
                MessageBox.Show("El campo de hora final debe ser un número");
                return false;
            }
            if (!Funciones.esNumero(txtHoraFinalB.Text)) {
                MessageBox.Show("El campo de minutos Hora Hasta debe ser un número");
                return false;
            }
            if (txtHoraFinalB.Text == "") {
                MessageBox.Show("El campo de minuto final no puede estar vacio");
                return false;
            }
            if ((Int32.Parse(txtHoraInicialB.Text) > 60) || (Int32.Parse(txtHoraFinalB.Text) > 60) || (0 > Int32.Parse(txtHoraInicialB.Text)) || (0 > Int32.Parse(txtHoraFinalB.Text))) {
                MessageBox.Show("Uno de los campos de minutos es inválido. Por favor ingrese un valor de 0 a 59");
                return false;
            }
            if ((Int32.Parse(txtHoraInicialA.Text) > 23) || (Int32.Parse(txtHoraFinalA.Text) > 23) || (0 > Int32.Parse(txtHoraInicialA.Text)) || (0 > Int32.Parse(txtHoraFinalA.Text))) {
                MessageBox.Show("Uno de los campos de horas es inválido. Por favor ingrese un valor de 0 a 23");
                return false;
            }
            if (txtDesc.Text == "") {
                MessageBox.Show("El campo descripción no puede estar vacio");
                return false;
            }
            return true;
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
            if (validaciones() && Conexion.executeProcedure("MODIFICAR_TURNO", Conexion.generarArgumentos("@ID", "@DESCRIPCION", "@HORA_INICIO", "@HORA_FIN", "@PRECIOBASE", "@VALORKM"), cmbTurno.SelectedValue, txtDesc.Text, txtHoraInicialA.Text + ":" + txtHoraInicialB.Text, txtHoraFinalA.Text + ":" + txtHoraFinalB.Text, Convert.ToDouble(txtPrecioBase.Text), Convert.ToDouble(txtValorKm.Text)))
                MessageBox.Show("Turno modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refrescarTurnos();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
