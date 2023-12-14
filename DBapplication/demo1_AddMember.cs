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
    public partial class demo1_AddMember : Form
    {
        Controller controllerObj;
        public demo1_AddMember()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passBox.Text == "" || ageBox.Text == "" || EmrgncyBox.Text == "" || ContactBox.Text == "" || passBox.Text == ""
                || lNameBox.Text == "" || fNameBox.Text == "" || comboBox1.SelectedItem== null)//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                //int check = DuplicateCheck();
                DataTable dt = new DataTable();
                // if (check == 0)
                {
                    bool gender= false;
                    string selectedText = comboBox1.SelectedItem.ToString();

                    if (selectedText.Equals("Male", StringComparison.OrdinalIgnoreCase))
                    {
                        gender = false;
                    }
                    else if (selectedText.Equals("Female", StringComparison.OrdinalIgnoreCase))
                    {
                        gender = true;
                    }

                        string fname = fNameBox.Text.ToString();
                        string lname = lNameBox.Text.ToString();
                        int age = Convert.ToInt32(ageBox.Text);
                        string pass = passBox.Text.ToString();
                        int emergency = Convert.ToInt32(EmrgncyBox.Text);
                        int contact = Convert.ToInt32(ContactBox.Text);

                        int r = controllerObj.InsertUser(fname, lname, gender, age, pass, emergency, contact);
                        dt = controllerObj.ViewAllUsers();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                        MessageBox.Show("User inserted successfully");
                }
                //else
                //  MessageBox.Show("Duplicate Dnumber entered. Operation halted.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numeric values for this entry.");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
