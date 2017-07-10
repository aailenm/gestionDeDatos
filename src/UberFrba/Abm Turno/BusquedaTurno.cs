using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno
{
    public partial class BusquedaTurno : Form
    {
        public BusquedaTurno()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= Conexion.obtenerTablaProcedure("filtro_turno", Conexion.generarArgumentos("@descripcion"),
                 descripcion.Text);
            this.dataGridView1.Columns["turn_id"].Visible = false;
            if (dataGridView1.RowCount == 0) MessageBox.Show("No hay turnos con la descripción indicada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            descripcion.Clear();
            dataGridView1.DataSource = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["chof_id"].Value.ToString();
                ComunicacionForms comunic = this.Owner as ComunicacionForms;
                if (comunic != null)
                    comunic.editar(id);
                Close();
            }
        }
    }
}
