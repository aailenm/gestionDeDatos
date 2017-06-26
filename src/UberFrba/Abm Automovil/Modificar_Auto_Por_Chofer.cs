using System;
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
    public partial class Modificar_Auto_Por_Chofer : Form
    {
        public string model;
        public string patente;
        public int marca;

        public Modificar_Auto_Por_Chofer()
        {
            InitializeComponent();
            Abm_Automovil.BusquedaAuto busq = new Abm_Automovil.BusquedaAuto();
            busq.SetPatente(patente);
            busq.SetModelo(model);
            busq.SetMarca(marca);
            busq.Show(this);
            busq.button1_Click(this,EventArgs.Empty);
        }

        public void setModelo(string mod) {
            this.model = mod;
        }

        public void setPatente(string Patente)
        {
            this.patente = Patente;
        }

        public void setMarca(int marc)
        {
            marca = marc;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BusquedaChofer busq = new Abm_Chofer.BusquedaChofer();
            busq.Show(this);
        }
    }
}
