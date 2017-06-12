using System;
using System.Windows.Forms;

namespace UberFrba {
    class Funciones
    {
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

        internal static void llenarCombo_Turno(ComboBox combo) {
            combo.ValueMember = "turn_id";
            combo.DisplayMember = "turn_descripcion";
            combo.DataSource = Conexion.cargarTablaConsulta("GET_TURNOS");
            combo.SelectedIndex = -1;
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
