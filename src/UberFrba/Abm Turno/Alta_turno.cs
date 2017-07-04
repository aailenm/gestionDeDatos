using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno {
    public partial class Alta_Turno : Form
    {
        public Alta_Turno()
        {
            InitializeComponent();
            HDH.Minimum = 0;
            HDH.Maximum = 23;

            HDM.Minimum = 0;
            HDM.Maximum = 59;

            HHH.Minimum = 0;
            HHH.Maximum = 23;
             
            HHM.Minimum = 0;
            HHM.Maximum = 59;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                if (Funciones.validacionesCrearTurno(HDH.Value, HDM.Value, HHH.Value, HHM.Value,DETALLE.Text))
                {
                    bool result = Conexion.executeProcedure("ALTA_TURNO",
                          Conexion.generarArgumentos("@DESCRIPCION", "@HORA_INICIO", "@HORA_FIN", "@PRECIOBASE", "@VALORKM"),
                          DETALLE.Text, HDH.Text + ':' + HDM.Text, HHH.Text + ':' + HHM.Text, Double.Parse(PB.Text), Double.Parse(VKM.Text));
                    if (result)
                    {
                        MessageBox.Show("Turno creado");
                        Close();
                    }
                }
            }
        }

        private bool validaciones() {
            if (!Funciones.validacionPrecio(VKM.Text)) {
                MessageBox.Show("El valor del kilometro solo acepta numeros y una sola , para los decimales");
                return false;
            } else if (0 >= Double.Parse(VKM.Text)) {
                MessageBox.Show("El valor del kilometro debe ser mayor a 0");
                return false;
            }
            if (!Funciones.validacionPrecio(PB.Text))
            {
                MessageBox.Show("El campo precio base solo acepta numeros y una sola , para los decimales");
                 return false;
            } else if (0 >= Double.Parse(PB.Text))
            {
                MessageBox.Show("El valor del precio base debe ser mayor a 0");
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
           
             if(!Funciones.esNumero(HDH.Text)){
            MessageBox.Show("El campo horas de Hora desde debe ser un número ");
                 return false;
            }
             if(!Funciones.esNumero(HDM.Text)){
            MessageBox.Show("El campo minutos de Hora desde debe ser un número");
                 return false;
            }
            if(!Funciones.esNumero(HHH.Text)){
            MessageBox.Show("El campo de horas Hora Hasta debe ser un número");
                return false;
            }
            if(!Funciones.esNumero(HHM.Text)){
            MessageBox.Show("El campo de minutos Hora Hasta debe ser un número");
                return false;
            }
             if (DETALLE.Text == "")
             {
                 MessageBox.Show("El campo Nombre no puede estar vacio");
                 return false;
             }
             if (VKM.Text == "")
             {
                 MessageBox.Show("El campo Valor del KM no puede estar vacio");
                 return false;
             }

             if (PB.Text == "")
             {
                 MessageBox.Show("El campo Precio Base no puede estar vacio");
                 return false;
             }
            return true;
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PB_TextChanged(object sender, EventArgs e)
        {

        }

        private void HHD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HHH_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
