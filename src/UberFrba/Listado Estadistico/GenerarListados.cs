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
            Funciones.llenarCombo_Listados(comboBox1);
            INICIO.Value = Funciones.ObtenerFecha();
            FIN.Value = Funciones.ObtenerFecha();
            dataGridView1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(validaciones()){
                switch (comboBox1.SelectedIndex)
                {
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
                        dataGridView1.DataSource = Conexion.obtenerTablaProcedure("AUTO_MAS_USADO", Conexion.generarArgumentos("@FECHA_INICIO", "@FECHAFIN"), INICIO.Value.ToShortDateString(), FIN.Value.ToShortDateString());
                        break;
                }
            }
        }

        private bool validaciones() {
            if (INICIO.Value >= FIN.Value) {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la de fin");
                return false;
            }
            if((FIN.Value.Month - INICIO.Value.Month).ToString()!="3"){
                MessageBox.Show("Las consultas para obtener listados deben ser trimestrales. Verifique las fechas elegidas");
                return false;
            }
            if ((FIN.Value.Year != INICIO.Value.Year) && INICIO.Value.Month<10){
                MessageBox.Show("Las consultas para obtener listados deben ser trimestrales. Verifique las fechas elegidas");
                return false;
            }
            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar un tipo de listado");
                return false;
            }
            return true;
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            Funciones.llenarCombo_Listados(comboBox1);
            INICIO.Value = Funciones.ObtenerFecha();
            FIN.Value = Funciones.ObtenerFecha();
            dataGridView1.DataSource = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
