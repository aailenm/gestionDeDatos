using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Registro_Viajes
{
    public partial class Form1 : Form, ComunicacionForms
    {
        public Form1()
        {
            InitializeComponent();
            Funciones.llenarCombo_Turno(turn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void editarChofer(string id)
        {
            chof.Text = id;
        }
        public void editar(string id)
        {

        }
        public void editarTurno(string id) {
            turn.SelectedValue = id;
        }
        public void editarCliente(string id)
        {
            clie.Text = id;
        }
        public void editarAuto(string id)
        {
            auto.Text = id;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar(){
            chof.Clear();
            auto.Clear();
            clie.Clear();
            cantkm.Clear();
            HHH.Clear();
            HHM.Clear();
            HDH.Clear();
            HDM.Clear();
            finic.ResetText();
            ffin.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                bool result = Conexion.executeProcedure("ALTA_VIAJE", Conexion.generarArgumentos("@CANTIDADKM", "@FECHAINICIO", "@FECHAFIN", "@TURNO", "@AUTO", "@CHOFER", "@CLIENTE"),
                    cantkm.Text, Funciones.TransformarDateConTime(finic.Value.ToShortDateString(), HDH.Text, HDM.Text), Funciones.TransformarDateConTime(ffin.Value.ToShortDateString(), HHH.Text, HHM.Text), turn.SelectedValue, auto.Text, chof.Text, clie.Text);
                if (result)
                {
                    MessageBox.Show("Viaje creado");
                    Limpiar();
                }
            }
        }

        private bool validaciones() {
            if (turn.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un turno");
                return false;
            }
            if(chof.Text == ""){
            MessageBox.Show("El campo Chofer no puede estar vacio");
                return false;
            }
            if(auto.Text == ""){
            MessageBox.Show("El campo Automovil no puede estar vacio");
                return false;
            }
            if(clie.Text == ""){
            MessageBox.Show("El campo Cliente no puede estar vacio");
                return false;
            }
            if (HDM.Text == "")
            {
                MessageBox.Show("El campo Hora desde no puede estar vacio");
                return false;
            }
            if (HHM.Text == "")
            {
                MessageBox.Show("El campo Hora hasta no puede estar vacio");
                return false;
            }
            if (HDH.Text == "")
            {
                MessageBox.Show("El campo Hora desde no puede estar vacio");
                return false;
            }
            if (HHH.Text == "")
            {
                MessageBox.Show("El campo Hora Hasta no puede estar vacio");
                return false;
            }
            if (!Funciones.esNumero(HDH.Text))
            {
                MessageBox.Show("El campo horas de Hora desde debe ser un número ");
                return false;
            }
            if (!Funciones.esNumero(HDM.Text))
            {
                MessageBox.Show("El campo minutos de Hora desde debe ser un número");
                return false;
            }
            if (!Funciones.esNumero(HHH.Text))
            {
                MessageBox.Show("El campo de horas Hora Hasta debe ser un número");
                return false;
            }
            if (!Funciones.esNumero(HHM.Text))
            {
                MessageBox.Show("El campo de minutos Hora Hasta debe ser un número");
                return false;
            }

            if ((Int32.Parse(HHM.Text) > 60) || (Int32.Parse(HDM.Text) > 60) || (0 > Int32.Parse(HHM.Text)) || (0 > Int32.Parse(HDM.Text)))
            {
                MessageBox.Show("El campo minutos no es valido. Por favor ingrese un valor de 0 a 59");
                return false;
            }
            if ((Int32.Parse(HHH.Text) > 23) || (Int32.Parse(HDH.Text) > 23) || (0 > Int32.Parse(HHH.Text)) || (0 > Int32.Parse(HDH.Text)))
            {
                MessageBox.Show("El campo horas no es valido. Por favor ingrese un valor de 0 a 23");
                return false;
            }
            if (ffin.Value >= DateTime.Today || finic.Value >= DateTime.Today)
            {
            MessageBox.Show("Fechas invalidas");
                return false;
            }
            if (cantkm.Text == "")
            {
                MessageBox.Show("El campo Cantidad de km no puede estar vacio");
                return false;
            }
            if (!Funciones.esNumero(cantkm.Text))
            {
                MessageBox.Show("El campo Cantidad de km solo acepta numeros");
                return false;
            }
            if (0 > Int32.Parse(cantkm.Text))
            {
                MessageBox.Show("El campo Cantidad de km debe ser mayor a 0");
                return false;
            }
            return true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer chofer = new Abm_Chofer.BusquedaChofer();
            chofer.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abm_Automovil.BusquedaAuto auto = new Abm_Automovil.BusquedaAuto();
            auto.editarChofer(chof.Text);
            auto.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abm_Cliente.BusquedaCliente cliente = new Abm_Cliente.BusquedaCliente();
            cliente.Show(this);
        }
    }
}
