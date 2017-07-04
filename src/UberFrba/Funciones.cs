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
            TimeSpan nuevoInicio = new TimeSpan(hd,md,0);
            TimeSpan nuevoFin = new TimeSpan(hh,mh,0) ;
            //hasta aca, validaciones simples
            SqlDataReader reader = Conexion.ejecutarQuery("select turn_id, turn_habilitado, turn_descripcion, turn_hora_inicio, turn_hora_fin from RUBIRA_SANTOS.TURNO ");
            while(reader.Read()){
                TimeSpan viejoInicio = TimeSpan.Parse((reader["turn_hora_inicio"].ToString()).Substring(0,8));
                TimeSpan viejoFin = TimeSpan.Parse((reader["turn_hora_fin"].ToString()).Substring(0,8));
                if (turnoACompararEstaHabilitado(reader["turn_habilitado"].ToString())){
                    if(!existeDescripcionTurno(reader["turn_descripcion"].ToString(), descripcion)){
                        if(!franjaMayor(nuevoInicio, nuevoFin, viejoInicio, viejoFin)){
                            if(!franjaMayor(viejoInicio, viejoFin, nuevoInicio, nuevoFin)){
                                if(!horaDentroDeRangoExistente(nuevoInicio, viejoInicio, viejoFin)){
                                     if(!horaDentroDeRangoExistente(nuevoFin, viejoInicio, viejoFin)){
                                            // si todo está bien, al salir del método devolvería true
                                     }else{
                                     MessageBox.Show("La hora fin está dentro de un turno existente");
                                     return false;
                                     }//la nueva hora de fin esta dentro de un rango horario existente
                                }else{
                                    MessageBox.Show("La hora inicio está dentro de un turno existente");
                                    return false;
                                }// la nueva hora de inicio esta dentro de un rango horario existente
                            }else{
                                MessageBox.Show("El nuevo rango horario está dentro de un rango mayor");
                            return false;
                            }//la franja nueva esta dentro de otra mas grande
                        }else{
                            MessageBox.Show("El nuevo rango horario abarca a un turno más pequeño.");
                            return false;
                        } // la nueva franja abarca a 1 mas chica
                    }else{
                        MessageBox.Show("Ya existe un turno con esa descripción.");
                        return false;
                        //no hago nada, no es un error que un turno no este habilitado
                    }// descripcion turno
                } else {
                    //no hago nada, no es un error que un turno no este habilitado
                }// comparo contra turnos habilitados nomas
            }
            reader.Close();
            return true;
        }

        internal static bool existeDescripcionTurno(string turno1, string turno2) {
            if (turno1.Equals(turno2)) return true;
            else return false;
        }

        internal static bool turnoACompararEstaHabilitado(string habilitado)
        {
            if(habilitado.Equals("True")) return true;
            else return false;
        }

        /*devuelve verdadero si la primera franja abarca (o contiene) a la segunda*/
        internal static bool franjaMayor( TimeSpan menorInicio, TimeSpan mayorFin, TimeSpan mayorInicio, TimeSpan menorFin) {
            if ((TimeSpan.Compare(menorInicio,mayorInicio) == -1) && (TimeSpan.Compare(mayorFin, menorFin) == 1)) return true;
            else return false;
        }

        internal static bool horaDentroDeRangoExistente(TimeSpan hora, TimeSpan inicioRango, TimeSpan finRango)
        {
            if ((TimeSpan.Compare(hora, inicioRango) == 1) && (TimeSpan.Compare(hora, finRango) == -1)) return true;
            else return false;
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
