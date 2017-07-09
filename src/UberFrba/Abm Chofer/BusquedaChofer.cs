using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer {
    public partial class BusquedaChofer : Form
    {
        public BusquedaChofer()
        {
            InitializeComponent();

        }

        private bool validaciones()
        {
            if (!Funciones.esNumero(dni.Text))
            {
                MessageBox.Show("El DNI solo puede contener numeros");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
                dataGridView1.DataSource = Conexion.obtenerTablaProcedure("filtro_chofer", Conexion.generarArgumentos("@nombre", "@apellido", "@dni"),
                    nombre.Text, apellido.Text, dni.Text);
            this.dataGridView1.Columns["chof_id"].Visible = false;
            this.dataGridView1.Columns["auto_id"].Visible = false;
                        
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
            string idchofer = dataGridView1.Rows[e.RowIndex].Cells["chof_id"].Value.ToString();
            string idauto = dataGridView1.Rows[e.RowIndex].Cells["auto_id"].Value.ToString();
            ComunicacionForms comunic = this.Owner as ComunicacionForms;
            if (comunic != null)
                comunic.editarChofer(idchofer);
                comunic.editarAuto(idauto);
            Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

    }
}
