using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Login
{
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

        }
        public void setCombo(DataTable a) 
        {
            comboBox1.ValueMember = "rol_id";
            comboBox1.DisplayMember = "rol_descripcion";
            comboBox1.DataSource = a;
            comboBox1.SelectedIndex = -1;
        }
    }
}
