using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente
{
    public partial class BusquedaCliente : Form
    {
        public BusquedaCliente()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private bool validaciones() {
            if (!Funciones.esNumero(dni.Text)) {
                MessageBox.Show("El DNI solo puede contener numeros");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
                dataGridView1.DataSource = Conexion.obtenerTablaProcedure("filtro_cliente", Conexion.generarArgumentos("@nombre", "@apellido", "@dni"),
                    nombre.Text, apellido.Text, dni.Text);
            this.dataGridView1.Columns["clie_id"].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            apellido.Clear();
            dni.Clear();
            dataGridView1.DataSource = -1;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["clie_id"].Value.ToString();
            ComunicacionForms comunic = this.Owner as ComunicacionForms;
            if (comunic != null)
                comunic.editarCliente(id);
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["clie_id"].Value.ToString();
            ComunicacionForms comunic = this.Owner as ComunicacionForms;
            if (comunic != null)
                comunic.editarCliente(id);
            Close();

        }
    }
}
