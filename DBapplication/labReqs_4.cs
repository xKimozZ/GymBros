using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class labReqs_4 : Form
    {
        Controller controllerObj;
        public labReqs_4()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepartments();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnumber";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedItem == null)//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                DataTable dt = new DataTable();
                int r = controllerObj.InsertLocation(Convert.ToInt32(comboBox1.SelectedValue), textBox1.Text);
                    dt = controllerObj.SelectDepLocAll4();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("Location " + textBox1.Text + " inserted successfully to Dnumber: " + Convert.ToInt32(comboBox1.SelectedValue));
            }
        }

        private void labReqs_4_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = controllerObj.SelectDepLocAll4();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
