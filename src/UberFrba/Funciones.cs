using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
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
        /*llena los combobox, es necsario que el nombre del combobox y el nombre del procedure sean igual, y sea eso lo que se le pasa por parametro*/
        internal static void LlenarComboBox(string s) { 
        }

        internal static DateTime TransformarDateConTime(string fecha, string horas, string minutos) {
            DateTime horaTransformada = new DateTime();
            int hora = int.Parse(horas);
            int minuto = int.Parse(minutos);
            horaTransformada = DateTime.Parse(fecha);
            horaTransformada = horaTransformada.AddHours(hora);
            horaTransformada = horaTransformada.AddMinutes(minuto);
            return horaTransformada;
        }
    }
}
