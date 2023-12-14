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
    public partial class labReqs_5 : Form
    {
        Controller controllerObj;
        public labReqs_5()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepartments();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnumber";
            dt = controllerObj.SelectEmployees();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Fname";
            comboBox2.ValueMember = "SSN";
        }

        private void labReqs_5_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = controllerObj.DepartmentManager();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                DataTable dt = new DataTable();
                int r = controllerObj.UpdateManager(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
                dt = controllerObj.DepartmentManager();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                MessageBox.Show("Employee " + comboBox2.SelectedText + " is now manager of Dnumber: " + Convert.ToInt32(comboBox1.SelectedValue));
            }
        }
    }
}
