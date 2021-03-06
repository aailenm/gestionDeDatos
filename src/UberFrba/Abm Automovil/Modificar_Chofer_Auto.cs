﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class Modificar_Chofer_Auto : Form, ComunicacionForms
    {
        string auto;
        public Modificar_Chofer_Auto()
        {
            InitializeComponent();
            Funciones.llenarCombo_Turno(turnOrigen);
            Funciones.llenarCombo_Turno(turnNuevo);
        }

       public void editarChofer(string id){
           chofnNuevo.Text = id;
       }
       public void editarCliente(string id){}
       public void editarAuto(string id){}
       public void editarTurno(string id) { }
       public void editar(string id) { }

       public void setAuto(string id) {
           this.auto = id;
       }
        public void setChofOriginal(string id) {
            this.chofOrigen.Text = id;
        }

        public void setTurnoOriginal(ListControl id) {
            if (id.SelectedIndex != -1)
            {
                this.turnOrigen.SelectedValue = id.SelectedValue;
            }
            else this.turnOrigen.SelectedValue = 0;
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                string turnv;
                if (turnOrigen.SelectedIndex.ToString().Equals("-1")) turnv = "0";
                else turnv = turnOrigen.SelectedValue.ToString();
                bool conex = Conexion.executeProcedure("MODIFICAR_AUTO_POR_TURNO", Conexion.generarArgumentos("@CHOFERN", "@TURNON", "@CHOFERV","@TURNOV","@AUTO"), chofnNuevo.Text, turnNuevo.SelectedValue, chofOrigen.Text, turnv, auto);
                if (conex)
                {
                    Modificar_Auto modif = this.Owner as Modificar_Auto;
                    modif.editarChofer(chofnNuevo.Text);
                    string id = turnNuevo.SelectedValue.ToString();
                   // modif.editarTurno(id);
                    Funciones.choferPorTurno(modif.getCmbTurnos(),chofnNuevo.Text );
                    modif.getCmbTurnos().SelectedValue = id;
                    MessageBox.Show("Chofer y turno modificados.");
                    Close();
                }
            }
        }
        private bool validaciones() {
            if (turnNuevo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un turno");
                return false;
            }
            if (chofnNuevo.Text == "") {
                MessageBox.Show("Debe seleccionar un chofer");
                return false;
            }
            return true;
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer bc = new Abm_Chofer.BusquedaChofer();
            bc.ShowDialog(this);
        }

        private void turnNuevo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void turnOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
