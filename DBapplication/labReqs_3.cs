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
    public partial class labReqs_3 : Form
    {
        Controller controllerObj;
        public labReqs_3()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private int DuplicateCheck()
        {
            DataTable Dnum = new DataTable();
            Dnum = controllerObj.CheckDnum(Convert.ToInt32(textBox2.Text));
            if (Dnum != null)
                return Dnum.Rows.Count;
            else
                return 0;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numeric values for Department number.");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numeric values for Manager SSN.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                //int check = DuplicateCheck();
                DataTable dt =new DataTable();
               // if (check == 0)
                {
                    string formattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    int r = controllerObj.InsertDepartment(textBox1.Text.ToString(), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),formattedDate);
                    dt = controllerObj.SelectDepartments3();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("Department inserted successfully with Dnumber: "+ Convert.ToInt32(textBox2.Text));
                }
                //else
                  //  MessageBox.Show("Duplicate Dnumber entered. Operation halted.");
            }
        }

        private void labReqs_3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.SelectDepartments3();
            dataGridView1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
