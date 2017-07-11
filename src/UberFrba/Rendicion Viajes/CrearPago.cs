using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UberFrba.Rendicion_Viajes
{
    public partial class Crear_Pago : Form, ComunicacionForms
    {
        double totalViajes = 0;        
        public Crear_Pago()
        {
            InitializeComponent();
            Funciones.llenarCombo_Turno(TURNO);
            dataGridView1.ReadOnly = true;
            FECHA.Value = Funciones.ObtenerFecha();
            TOTAL.Text = "0";
            traerDefaultDePorcentaje();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                dataGridView1.DataSource = Conexion.obtenerTablaProcedure("VIAJES_RENDICION", Conexion.generarArgumentos("@CHOFER", "@TURNO", "@FECHA"),
                    CHOF.Text, TURNO.SelectedValue, FECHA.Value.ToShortDateString());
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    totalViajes = totalViajes + Convert.ToDouble(row.Cells[7].Value);
                }
                if (dataGridView1.Rows.Count == 0)
                    MessageBox.Show("No hay viajes realizados en la fecha");
                else
                    totalViajeees.Text = "$" + totalViajes.ToString();
            }
        }
        public void traerDefaultDePorcentaje()
        {
            SqlDataReader reader = Conexion.ejecutarQuery("select TOP 1 r.pago_porcentaje from RUBIRA_SANTOS.RENDICION_VIAJE r order by r.pago_id DESC");
            reader.Read();
            porcentaje.Text = (reader["pago_porcentaje"].ToString());
        }
        public void editarChofer(string id)
        {
            CHOF.Text = id;
            Funciones.choferPorTurno(TURNO, id);
        }

        public void editarCliente(string id)
        {

        }
        public void editarAuto(string id)
        {

        }

        public void editar(string id)
        {

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer chof = new Abm_Chofer.BusquedaChofer();
            chof.ShowDialog(this);
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funciones.llenarCombo_Turno(TURNO);
            CHOF.Clear();
            totalViajeees.Clear();
            porcentaje.Clear();
            TOTAL.Clear();
            FECHA.Value = Funciones.ObtenerFecha();
            dataGridView1.DataSource = -1;
            porcentaje.Text = "0";
            Funciones.choferPorTurno(TURNO, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validacionPorcentaje(porcentaje.Text))
            {
                MessageBox.Show("El porcentaje solo acepta números y '.' para indicar los decimales. Solo se puede utilizar el . una sola vez");
            }
            else if (Double.Parse(porcentaje.Text) <= 0)
            {
                MessageBox.Show("Debe ingresar un porcentaje mayor a 0.");
            }
            else if (Double.Parse(porcentaje.Text) > 100) {
                MessageBox.Show("Debe ingresar un porcentaje menor a 100.");
            }
            else
            {
                if (validaciones())
                {
                    bool result = Conexion.executeProcedure("CREAR_RENDICION", Conexion.generarArgumentos("@CHOFER", "@TOTAL", "@TURNO", "@FECHA", "@PORCENTAJE"),
                       CHOF.Text, Double.Parse(TOTAL.Text), TURNO.SelectedValue, FECHA.Value.ToShortDateString(), Double.Parse(porcentaje.Text));
                    if (result)
                    {
                        MessageBox.Show("Rendición creada");
                        Close();
                    }
                }
            }
        }

        private bool validaciones()
        {

            if (CHOF.Text == "")
            {
                MessageBox.Show("Debe seleccionar un chofer");
                return false;
            }
            if (FECHA.Value > Funciones.ObtenerFecha())
            {
                MessageBox.Show("Fecha inválida");
                return false;
            }
            if (TURNO.Text == "")
            {
                MessageBox.Show("Debe seleccionar un turno");
                return false;
            }

            return true;
        }

        private void TOTAL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void porcentaje_TextChanged(object sender, EventArgs e)
        {
            if (porcentaje.Text == "") porcentaje.Text = "0";
            else if (!validacionPorcentaje(porcentaje.Text))
            {
                MessageBox.Show("El porcentaje solo acepta números y ',' para indicar los decimales. Solo se puede utilizar la , una sola vez");
            }
            else {
                double totalCalculado = totalViajes + (totalViajes * Double.Parse(porcentaje.Text)*0.01) ;
                TOTAL.Text = totalCalculado.ToString();
            }
        }

        private bool validacionPorcentaje(string porc)
        {
            int comas = 0;
            foreach (char c in porc)
            {
                if (!Char.IsDigit(c) && c != ',') return false;
                else if (c == ',')
                {
                    comas++;
                    if (comas > 1) return false;
                }
            }
            
            return true;
        }

        private void TOTAL_TextChanged(object sender, EventArgs e)
        {
        }

        private void TURNO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (totalViajeees.Text != "")
            {
                double totalCalculado = totalViajes + (totalViajes * Double.Parse(porcentaje.Text) * 0.01);
                TOTAL.Text = totalCalculado.ToString();
            }
        }
    }
}
