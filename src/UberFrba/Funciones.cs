using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace UberFrba {
    class Funciones
    {

        internal static bool validacionesCrearTurno(decimal horaDesde, decimal minutosDesde, decimal horaHasta, decimal minutosHasta, string descripcion) {
            int hd = Int32.Parse(horaDesde.ToString());
            int md = Int32.Parse(minutosDesde.ToString());
            int hh = Int32.Parse(horaHasta.ToString());
            int mh = Int32.Parse(minutosHasta.ToString());
            
            if (hd > hh) {
                MessageBox.Show("El turno debe comenzar y finalizar el mismo dia. La hora de inicio no puede ser mayor a la de fin");
                return false;
            }
            if ((hd == hh) && (md > mh))
            {
                MessageBox.Show("El turno debe comenzar y finalizar el mismo dia. La hora de inicio no puede ser mayor a la de fin");
                return false;
            }
            if (hd == hh && md == mh)
            {
                MessageBox.Show("La hora inicio y la hora fin no pueden ser iguales, porque no es un rango de horarios validos");
                return false;
            }
            //hasta aca, validaciones simples
            SqlDataReader reader = Conexion.ejecutarQuery("select turn_id, turn_habilitado, turn_descripcion, turn_hora_inicio, turn_hora_fin from RUBIRA_SANTOS.TURNO ";
            reader.Read();
            while(reader.Read()){
                if (reader["turn_descripcion"]== descripcion)
                {
                    MessageBox.Show("Ya existe un turno con esta descripcion");
                    return false;
                }else if (reader["turn_habilitado"] == "0" )
                {
                    // si el turno no esta habilitado, no hacemos nada, y vuelve a iterar
                } else if () //el turno esta habilitado. Pregunto si existe una franja mas grande que la actual
                {
                    MessageBox.Show("");
                    return false;
                }
            }
            reader.Close();
            return true;
        }
        /*verifica que una cadena text sea solo de numeros*/
        internal static bool esNumero(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        internal static bool validacionPrecio(string porc)
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

        internal static void llenarCombo_Turno(ComboBox combo) {
            combo.ValueMember = "turn_id";
            combo.DisplayMember = "turn_descripcion";
            combo.DataSource = Conexion.cargarTablaConsulta("GET_TURNOS");
            combo.SelectedIndex = -1;
        }
        internal static int calcularMeses(DateTime inicio, DateTime fin) {
            int resultado = 0;
            inicio = inicio.Date;
            fin = fin.Date;
            while (inicio < fin)
            {
                inicio = inicio.AddMonths(1);
                resultado++;
            }
            return resultado;
        }
        internal static void llenarCombo_Listados(ComboBox combo)
        {
            combo.Items.Insert(0, "Choferes con mayor recaudación");
            combo.Items.Insert(1, "Choferes con el viaje más largo realizado");
            combo.Items.Insert(2, "Clientes con mayor consumo");
            combo.Items.Insert(3, "Cliente que repitió mas veces automovil");
            combo.SelectedIndex = -1;
        }
        internal static void llenarCombo_Marca(ComboBox combo)
        {
            combo.ValueMember = "marc_id";
            combo.DisplayMember = "marc_detalle";
            combo.DataSource = Conexion.cargarTablaConsulta("GET_MARCAS");
            combo.SelectedIndex = -1;
        }
        /* los datetimepiker solo ponen fechas, y el horario en 00.00. Para agergarles el horario, se usa esta funcion */
        internal static DateTime TransformarDateConTime(string fecha, string horas, string minutos) {
            DateTime horaTransformada = new DateTime();
            int hora = int.Parse(horas);
            int minuto = int.Parse(minutos);
            horaTransformada = DateTime.Parse(fecha);
            horaTransformada = horaTransformada.AddHours(hora);
            horaTransformada = horaTransformada.AddMinutes(minuto);
            return horaTransformada;
        }

        internal static DateTime ObtenerFecha()
        {
            string fecha;
            fecha = System.Configuration.ConfigurationSettings.AppSettings["fecha"];
            DateTime fechaHoy = Convert.ToDateTime(fecha);
            return fechaHoy;
        }
    }
}
