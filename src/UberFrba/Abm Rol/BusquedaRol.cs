using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol
{
    public partial class BusquedaRol : Form
    {
        public BusquedaRol()
        {
            InitializeComponent();
            dataGridView1.DataSource = -1;
            dataGridView1.ReadOnly = true;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conexion.obtenerTablaProcedure("GET_ROLES", Conexion.generarArgumentos("@DESCRIPCION"), descripcion.Text);
            dataGridView1.Columns["rol_id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = -1;
            descripcion.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["rol_id"].Value.ToString();
                ComunicacionForms comunic = this.Owner as ComunicacionForms;
                if (comunic != null)
                    comunic.editar(id);
                Close();
            }
        }
    }
}
