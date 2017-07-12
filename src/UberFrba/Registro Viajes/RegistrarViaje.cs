using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UberFrba.Registro_Viajes {
    public partial class Registro_Viajes : Form, ComunicacionForms
    {
        public Registro_Viajes()
        {
            InitializeComponent();
            finic.Value = Funciones.ObtenerFecha();
            ffin.Value = Funciones.ObtenerFecha();
            HDH.Minimum = 0;
            HDH.Maximum = 23;

            HDM.Minimum = 0;
            HDM.Maximum = 59;

            HHH.Minimum = 0;
            HHH.Maximum = 23;

            HHM.Minimum = 0;
            HHM.Maximum = 59;

            HHH.Value = 0;
            HHM.Value = 0;
            HDH.Value = 0;
            HDM.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void editarChofer(string id)
        {
            chof.Text = id;
            Funciones.choferPorTurno(turn,id);
        }
        public void editar(string id)
        {

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
            HHH.Value =0;
            HHM.Value = 0;
            HDH.Value = 0;
            HDM.Value = 0;
            finic.Value = Funciones.ObtenerFecha();
            ffin.Value = Funciones.ObtenerFecha();
            Funciones.choferPorTurno(turn, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones() && validarViaje())
            {
                bool result = Conexion.executeProcedure("ALTA_VIAJE", Conexion.generarArgumentos("@CANTIDADKM", "@FECHAINICIO", "@FECHAFIN", "@TURNO", "@AUTO", "@CHOFER", "@CLIENT"),
                    Double.Parse(cantkm.Text), Funciones.TransformarDateConTime(finic.Value.ToShortDateString(), HDH.Value, HDM.Value), Funciones.TransformarDateConTime(ffin.Value.ToShortDateString(), HHH.Value, HHM.Value), turn.SelectedValue, auto.Text, chof.Text, clie.Text);
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
           
            if (ffin.Value > Funciones.ObtenerFecha() || finic.Value > Funciones.ObtenerFecha())
            {
            MessageBox.Show("Fechas invalidas");
                return false;
            }
            if (cantkm.Text == "")
            {
                MessageBox.Show("El campo Cantidad de km no puede estar vacio");
                return false;
            }
            if (!validacionDouble(cantkm.Text))
            {
                MessageBox.Show("El campo Cantidad de km solo acepta numeros y una sola ','");
                return false;
            }
            if (0 >= Double.Parse(cantkm.Text))
            {
                MessageBox.Show("El campo Cantidad de km debe ser mayor a 0");
                return false;
            }
            if (Funciones.esMuyGrande(Double.Parse(cantkm.Text)))
            {
                MessageBox.Show("El numero ingresado es muy grande. Verifique si es correcto");
                return false;
            }
            if (finic.Value == ffin.Value)
            {
                if (Int32.Parse(HDH.Text) > Int32.Parse(HHH.Text))
                {
                    MessageBox.Show("Hora invalida, hora de inicio no puede ser mayor la hora de fin");
                    return false;
                }
                if (Int32.Parse(HDH.Text) == Int32.Parse(HHH.Text))
                {
                    if (Int32.Parse(HDM.Text) >= Int32.Parse(HHM.Text))
                    {
                        MessageBox.Show("Hora invalida, minutos de inicio no pueden ser mayor o igual a minutos de fin");
                        return false;
                    }
                }

            }
            else {
                MessageBox.Show("El viaje debe comenzar y finalizar el mismo día");
                return false;
            }
            
            return true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void finic_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool validacionDouble(string porc)
        {
            int comas = 0;
            foreach (char c in porc)
            {
                if (!Char.IsDigit(c) && c != ',') return false;
                else if (c == ',')
                {
                    comas++;
                    if (comas > 1) return false;
                }
            }

            return true;
        }

        
        private bool validarViaje()
        {
            SqlDataReader reader = Conexion.ejecutarQuery("select viaj_id, CAST(viaj_fyh_inicio as time) inicioV, CAST(viaj_fyh_fin as time) finV, viaj_cliente, viaj_chofer from RUBIRA_SANTOS.VIAJE where  CONVERT(VARCHAR(10), CAST(viaj_fyh_fin AS DATE), 103) = '" + ffin.Value.ToShortDateString().ToString() + "'"); // como la fecha del viaje tiene que ser dentro de un mismo dia, me fijo con una sola fecha
            TimeSpan inicio = TimeSpan.Parse(HDH.Value.ToString() + ':' + HDM.Value.ToString() );
            TimeSpan fin = TimeSpan.Parse(HHH.Value.ToString() + ':' + HHM.Value.ToString());
            while (reader.Read())
            {
                TimeSpan nuevoInicio = TimeSpan.Parse(reader["inicioV"].ToString());
                TimeSpan nuevoFin = TimeSpan.Parse(reader["finV"].ToString());
                if (Funciones.horaDentroDeRangoExistente(inicio,nuevoInicio, nuevoFin) || Funciones.horaDentroDeRangoExistente(fin, nuevoInicio, nuevoFin) ||Funciones.franjaMayor(inicio, fin, nuevoInicio, nuevoFin))
                { //si hora inicio u hora fin del viaje estan dentro de otro viaje o abarca a uno mas chico
                    if (reader["viaj_chofer"].ToString().Equals(chof.Text) || reader["viaj_cliente"].ToString().Equals(clie.Text))
                    {
                        MessageBox.Show("No se puede crear el viaje porque el cliente o el chofer ya tienen asignado un viaje en esa franja horaria.");
                        return false;
                    }
                }
            }
            return true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer chofer = new Abm_Chofer.BusquedaChofer();
            chofer.ShowDialog(this);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            Abm_Automovil.BusquedaAuto auto = new Abm_Automovil.BusquedaAuto();
            auto.editarChofer(chof.Text);
            auto.ShowDialog(this);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Abm_Cliente.BusquedaCliente cliente = new Abm_Cliente.BusquedaCliente();
            cliente.ShowDialog(this);
        }
    }
}
