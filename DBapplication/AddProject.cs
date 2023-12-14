using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AddProject : Form
    {
        Controller controllerObj;
        public AddProject()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepartments();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnumber";
            comboBox1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r =controllerObj.InsertProject(textBox1.Text.ToString(), Convert.ToInt32(textBox2.Text),textBox3.Text.ToString(),Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Project inserted successfully");
            }
        }
    }
}
