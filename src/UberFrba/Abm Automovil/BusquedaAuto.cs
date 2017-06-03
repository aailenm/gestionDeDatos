using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class BusquedaAuto : Form, ComunicacionForms
    {
        public BusquedaAuto()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            LlenarCombo();
        }
        public void Chofer(string id)
        {
            chofer.Text = id;
        }
        private void BusquedaAuto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.dataSet11.CLIENTE);

        }

        private void LlenarCombo()
        {
            marca.ValueMember = "marc_id";
            marca.DisplayMember = "marc_detalle";
            marca.DataSource = Conexion.cargarTablaConsulta("GET_MARCAS");
            marca.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conexion.obtenerTablaProcedure("filtro_automovil", Conexion.generarArgumentos("@marca", "@modelo", "@patente", "@chofer"), 
                marca.SelectedValue, modelo.Text, patente.Text,chofer.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarCombo();
            modelo.Clear();
            patente.Clear();
            chofer.Clear();
            dataGridView1.DataSource = -1;
        }

        public void editarChofer(string id) {
            chofer.Text = id;
        }
        public void editarAuto(string id)
        { 
        
        }
        public void editarCliente(string id)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer chof = new Abm_Chofer.BusquedaChofer();
            chof.Show(this);
        }

        private void marca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["auto_id"].Value.ToString();
            ComunicacionForms comunic = this.Owner as ComunicacionForms;
            if (comunic != null)
                comunic.editarAuto(id);
            Close();
        }

    }
}
