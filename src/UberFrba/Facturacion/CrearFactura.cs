using System;
using System.Windows.Forms;

namespace UberFrba.Facturacion {
    public partial class Crear_Factura : Form, ComunicacionForms
    {
        double tot = 0;
        public Crear_Factura()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            fechafin.Value = Funciones.ObtenerFecha();
            fechainicio.Value = Funciones.ObtenerFecha();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void editar(string id)
        {

        }
        public void editarTurno(string id) {
        
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abm_Cliente.BusquedaCliente cliente = new Abm_Cliente.BusquedaCliente();
            cliente.Show(this);
        }

        public void editarChofer(string id)
        {
    
        }
        public void editarCliente(string id)
        { 
        client.Text = id;
        }
        public void editarAuto(string id)
        { 
        
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if(validaciones())
           dataGridView1.DataSource = Conexion.obtenerTablaProcedure("VIAJE_FACTURA", Conexion.generarArgumentos("@FECHAI", "@FECHAF", "@CLIENTE"),
               fechainicio.Value.ToShortDateString(), fechafin.Value.ToShortDateString(), client.Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
             tot = tot + Convert.ToInt32(row.Cells[7].Value);
            }
            if (dataGridView1.Rows.Count==0)
                MessageBox.Show("No hay viajes entre las fechas indicadas");
            else
                total.Text = "$" + tot.ToString();
        }

        private bool validaciones() {
            if (fechainicio.Value >= Funciones.ObtenerFecha())
            {
                MessageBox.Show("Fecha inicio mayor al dìa de hoy.");
                return false;
            }

            if (fechafin.Value > Funciones.ObtenerFecha())
            {
                MessageBox.Show("Fecha fin mayor al día de hoy.");
                return false;
            }

            if (fechainicio.Value >= fechafin.Value)
            {
                MessageBox.Show("Fecha inicio mayor a fecha fin.");
                return false;
            }

            if (client.Text == "")
            {
                MessageBox.Show("Debe ingresar un cliente");
                return false;
            }
            return true;
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            client.Clear();
            fechainicio.Value = Funciones.ObtenerFecha();
            fechafin.Value = Funciones.ObtenerFecha();
            total.Clear();
            dataGridView1.DataSource = -1;

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (validaciones() && dataGridView1.RowCount != 0)
            {
                bool result = Conexion.executeProcedure("CREAR_FACTURA", Conexion.generarArgumentos("@CLIENTE", "@FECHAI", "@FECHAF", "@TOTAL"),
                      client.Text, fechainicio.Value.ToShortDateString(), fechafin.Value.ToShortDateString(), tot);
                if (result) MessageBox.Show("Factura creada");
            }
            else MessageBox.Show("No hay datos en la lista");
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
