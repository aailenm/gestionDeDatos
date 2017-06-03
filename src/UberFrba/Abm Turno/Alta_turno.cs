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
    public partial class Alta_turno : Form
    {
        public Alta_turno()
        {
            InitializeComponent();
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
                Conexion.executeProcedure("ALTA_TURNO",
                    Conexion.generarArgumentos("@DESCRIPCION", "@HORA_INICIO", "@HORA_FIN", "@PRECIOBASE", "@VALORKM"),
                    DETALLE.Text, HDH.Text + ':' + HDM.Text, HHH.Text + ':' + HHM.Text, PB.Text, VKM.Text);
                MessageBox.Show("Turno creado");
            }
        }

        private bool validaciones() {
            if(!Funciones.esNumero(PB.Text)){
                MessageBox.Show("El campo Precio Base debe ser un número");
                return false;
            }
             if(!Funciones.esNumero(VKM.Text)){
                MessageBox.Show("El campo Valor del KM debe ser un número");
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
             if((Int32.Parse(HHM.Text) > 60) || (Int32.Parse(HDM.Text) > 60) || (0 > Int32.Parse(HHM.Text)) || (0 > Int32.Parse(HDM.Text))){
            MessageBox.Show("El campo minutos no es valido. Por favor ingrese un valor de 0 a 59");
                 return false;
            }
             if ((Int32.Parse(HHH.Text) > 23) || (Int32.Parse(HDH.Text) > 23) || (0 > Int32.Parse(HHH.Text)) || (0 > Int32.Parse(HDH.Text)))
             {
                 MessageBox.Show("El campo horas no es valido. Por favor ingrese un valor de 0 a 23");
                 return false;
             }
             if (DETALLE.Text == "")
             {
                 MessageBox.Show("El campo Nombre no puede estar vacio");
                 return false;
             }
             if (HDH.Text == "")
             {
                 MessageBox.Show("El campo Hora desde no puede estar vacio");
                 return false;
             }
             if (HDM.Text == "")
             {
                 MessageBox.Show("El campo Hora desde no puede estar vacio");
                 return false;
             }
             if (HHH.Text == "")
             {
                 MessageBox.Show("El campo Hora Hasta no puede estar vacio");
                 return false;
             }
             if (HHM.Text == "")
             {
                 MessageBox.Show("El campo Hora hasta no puede estar vacio");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
