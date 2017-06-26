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
            Funciones.llenarCombo_Marca(marca);
        }

        private void BusquedaAuto_Load(object sender, EventArgs e)
        {

        }
        public void editar(string id)
        {

        }

        public void editarTurno(string id) { 
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (marca.SelectedIndex == -1) MessageBox.Show("Seleccione una marca");
            else
            {
                dataGridView1.DataSource = Conexion.obtenerTablaProcedure("filtro_automovil", Conexion.generarArgumentos("@marca", "@modelo", "@patente", "@chofer"),
                    marca.SelectedValue, modelo.Text, patente.Text, chofer.Text);
                this.dataGridView1.Columns["chof_id"].Visible = false;
                this.dataGridView1.Columns["auto_id"].Visible = false;
                this.dataGridView1.Columns["turn_id"].Visible = false;
                this.dataGridView1.Columns["MARCA"].Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funciones.llenarCombo_Marca(marca);
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
            string id_auto = dataGridView1.Rows[e.RowIndex].Cells["auto_id"].Value.ToString();
            string id_chofer = dataGridView1.Rows[e.RowIndex].Cells["chof_id"].Value.ToString();
            string id_turno = dataGridView1.Rows[e.RowIndex].Cells["turn_id"].Value.ToString();
            ComunicacionForms comunic = this.Owner as ComunicacionForms;
            if (comunic != null)
            {
                comunic.editarAuto(id_auto);
                comunic.editarChofer(id_chofer);
                comunic.editarTurno(id_turno);
            }
            Close();
        }

    }
}
