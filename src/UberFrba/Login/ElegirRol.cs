using System;
using System.Data;
using System.Windows.Forms;

namespace UberFrba.Login {
    public partial class ElegirRol : Form
    {
        public ElegirRol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) MessageBox.Show("Elija un rol");
            else
            {
                MenuGeneral menu = new MenuGeneral();
                menu.habilitarFuncionalidadesPorRol(comboBox1.SelectedValue.ToString());
                menu.Show();
                this.Close();
            }
        }
        public void setCombo(DataTable a) 
        {
            comboBox1.ValueMember = "rol_id";
            comboBox1.DisplayMember = "rol_descripcion";
            comboBox1.DataSource = a;
            comboBox1.SelectedIndex = 0;
        }
    }
}
