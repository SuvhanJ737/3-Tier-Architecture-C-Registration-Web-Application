using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using System.Windows.Forms;

namespace Application_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facade fc = Facade.get_Controller();
            MessageBox.Show (fc.get_Data_into_Facade(textBox1.Text, textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facade fc = Facade.get_Controller();
            DataSet ds = fc.retrive_Pass(textBox3.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
