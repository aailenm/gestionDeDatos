using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Listado_Estadistico
{
    public partial class GenerarListados : Form
    {
        public GenerarListados()
        {
            InitializeComponent();
            LlenarCombo();
            dataGridView1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LlenarCombo() {
            comboBox1.Items.Insert(0, "Choferes con mayor recaudación");
            comboBox1.Items.Insert(1, "Choferes con el viaje más largo realizado");
            comboBox1.Items.Insert(2, "Clientes con mayor consumo");
            comboBox1.Items.Insert(3, "Cliente que repitió mas veces automovil");
            comboBox1.SelectedIndex = -1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex){
                case 0:
                    dataGridView1.DataSource = Conexion.obtenerTablaProcedure("MAYOR_RECAUDACION", Conexion.generarArgumentos("@FECHA_INICIO", "@FECHAFIN"), INICIO.Value.ToShortDateString(), FIN.Value.ToShortDateString());
                    break;
                case 1:
                    dataGridView1.DataSource = Conexion.obtenerTablaProcedure("VIAJE_LARGO", Conexion.generarArgumentos("@FECHA_INICIO", "@FECHAFIN"), INICIO.Value.ToShortDateString(), FIN.Value.ToShortDateString());
                    break;
                case 2:
                    dataGridView1.DataSource = Conexion.obtenerTablaProcedure("MAYOR_CONSUMO", Conexion.generarArgumentos("@FECHA_INICIO", "@FECHAFIN"), INICIO.Value.ToShortDateString(), FIN.Value.ToShortDateString());
                    break;
                case 3:
                    dataGridView1.DataSource = Conexion.obtenerTablaProcedure("", Conexion.generarArgumentos("@FECHA_INICIO", "@FECHAFIN"), INICIO.Value.ToShortDateString(), FIN.Value.ToShortDateString());
                    break;
                default: MessageBox.Show("Seleccione un tipo de listado estadistico");
                    break;
            }
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            LlenarCombo();
            INICIO.ResetText();
            FIN.ResetText();
            dataGridView1.DataSource = -1;
        }
    }
}
