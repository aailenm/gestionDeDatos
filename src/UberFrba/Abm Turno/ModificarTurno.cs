using System;
using System.Data;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno {
    public partial class Modificar_Turno : Form {
        public Modificar_Turno() {
            InitializeComponent();
            Limpiar();
            HDH.Minimum = 0;
            HDH.Maximum = 23;

            HDM.Minimum = 0;
            HDM.Maximum = 59;

            HHH.Minimum = 0;
            HHH.Maximum = 23;

            HHM.Minimum = 0;
            HHM.Maximum = 59;


            HHH.Value = 0;
            HHM.Value = 0;
            HDH.Value = 0;
            HDM.Value = 0;
        }

        private bool validaciones() {
            if (!Funciones.validacionPrecio(VKM.Text))
            {
                MessageBox.Show("El valor del kilometro solo acepta numeros y una sola , para los decimales");
                return false;
            }
            else if (0 >= Double.Parse(VKM.Text))
            {
                MessageBox.Show("El valor del kilometro debe ser mayor a 0");
                return false;
            }
            if (!Funciones.validacionPrecio(PB.Text))
            {
                MessageBox.Show("El campo precio base solo acepta numeros y una sola , para los decimales");
                return false;
            }
            else if (0 >= Double.Parse(PB.Text))
            {
                MessageBox.Show("El valor del precio base debe ser mayor a 0");
                return false;
            }
            if (HDM.Text == "")
            {
                MessageBox.Show("El campo Hora desde no puede estar vacio");
                return false;
            }
            if (HHM.Text == "")
            {
                MessageBox.Show("El campo Hora hasta no puede estar vacio");
                return false;
            }
            if (HDH.Text == "")
            {
                MessageBox.Show("El campo Hora desde no puede estar vacio");
                return false;
            }
            if (HHH.Text == "")
            {
                MessageBox.Show("El campo Hora Hasta no puede estar vacio");
                return false;
            }

            if (!Funciones.esNumero(HDH.Text))
            {
                MessageBox.Show("El campo horas de Hora desde debe ser un número ");
                return false;
            }
            if (!Funciones.esNumero(HDM.Text))
            {
                MessageBox.Show("El campo minutos de Hora desde debe ser un número");
                return false;
            }
            if (!Funciones.esNumero(HHH.Text))
            {
                MessageBox.Show("El campo de horas Hora Hasta debe ser un número");
                return false;
            }
            if (!Funciones.esNumero(HHM.Text))
            {
                MessageBox.Show("El campo de minutos Hora Hasta debe ser un número");
                return false;
            }
            if (DETALLE.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }
            if (VKM.Text == "")
            {
                MessageBox.Show("El campo Valor del KM no puede estar vacio");
                return false;
            }

            if (PB.Text == "")
            {
                MessageBox.Show("El campo Precio Base no puede estar vacio");
                return false;
            }
            if (Funciones.esMuyGrande(Double.Parse(PB.Text)))
            {
                MessageBox.Show("El numero ingresado es muy grande. Verifique si es correcto");
                return false;
            }
            if (Funciones.esMuyGrande(Double.Parse(VKM.Text)))
            {
                MessageBox.Show("El numero ingresado es muy grande. Verifique si es correcto");
                return false;
            }
            return true;
        }

        private void Limpiar() {
            cmbTurno.ValueMember = "turn_id";
            cmbTurno.DisplayMember = "turn_descripcion";
            cmbTurno.DataSource = Conexion.cargarTablaConsulta("GET_TODOS_TURNOS");
            cmbTurno.SelectedIndex = -1;
           labelEstado.Text = "";
           habilit.Enabled = false ;
            HHH.ResetText();
            HHM.ResetText();
            HDM.ResetText();
            HDH.ResetText();
            DETALLE.Clear();
            VKM.Clear();
            PB.Clear();
        }

        private void ModificarTurno_Load(object sender, EventArgs e) {

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTurno.SelectedIndex != -1)
            {
                DataTable dt = Conexion.obtenerTablaProcedure("GET_TURNO",Conexion.generarArgumentos("@ID"),cmbTurno.SelectedValue);
                if (dt.Rows[0][6].ToString().Equals("True")) labelEstado.Text = "HABILITADO";
                else
                {
                    labelEstado.Text = "DESHABILITADO";
                    habilit.Enabled = true;
                }
                string horaInicial = dt.Rows[0][1].ToString();
                string horaFinal = dt.Rows[0][2].ToString();
                HDH.Text = horaInicial.Substring(0, 2);
                HDM.Text = horaInicial.Substring(3, 2);
                HHH.Text = horaFinal.Substring(0, 2);
                HHM.Text = horaFinal.Substring(3, 2);
                DETALLE.Text = dt.Rows[0][3].ToString();
                VKM.Text = dt.Rows[0][4].ToString();
                PB.Text = dt.Rows[0][5].ToString();
            }
        }

        private void btnMod_Click(object sender, EventArgs e) {
            if (validaciones()){
                if(Funciones.validacionesCrearTurno(HDH.Value, HDM.Value, HHH.Value, HHM.Value,DETALLE.Text, cmbTurno.SelectedValue.ToString())){
                    bool result = Conexion.executeProcedure("MODIFICAR_TURNO", Conexion.generarArgumentos("@ID", "@DESCRIPCION", "@HORA_INICIO", "@HORA_FIN", "@PRECIOBASE", "@VALORKM"), cmbTurno.SelectedValue, DETALLE.Text, HDH.Text + ":" + HDM.Text, HHH.Text + ":" + HHM.Text, Convert.ToDouble(PB.Text), Convert.ToDouble(VKM.Text));
                    if(result){
                        MessageBox.Show("Turno modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                if (Funciones.validacionesCrearTurno(HDH.Value, HDM.Value, HHH.Value, HHM.Value, DETALLE.Text, cmbTurno.SelectedValue.ToString()))
                {
                    bool conex = Conexion.executeProcedure("HABILITAR_TURNO", Conexion.generarArgumentos("@ID", "@DESCRIPCION", "@HORA_INICIO", "@HORA_FIN", "@PRECIOBASE", "@VALORKM"),
                        cmbTurno.SelectedValue, DETALLE.Text, HDH.Text + ":" + HDM.Text, HHH.Text + ":" + HHM.Text, Convert.ToDouble(PB.Text), Convert.ToDouble(VKM.Text));
                    if (conex)
                    {
                        MessageBox.Show("Turno habilitado correctamente");
                        Limpiar();
                    }
                }
            }
        }

        private void PB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
