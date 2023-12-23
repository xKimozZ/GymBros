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
    public partial class Login : Form
    {
        Controller controllerObj;
        public Login()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//validation part
            {
                MessageBox.Show("User ID field empty.");
                return;
            }
            if (textBox2.Text == "")//validation part
            {
                MessageBox.Show("Password field empty.");
                return;
            }
            DataTable dt = new DataTable();
            dt = controllerObj.LoginAttempt(Convert.ToInt32(textBox1.Text), textBox2.Text);
            if (dt != null)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("The user ID and/or password you entered is not correct.");
            }

            //int s = controllerObj.UpdateClass2(textBox2.Text, Convert.ToInt32(textBox3.Text), textBox1.Text);
            //dt = controllerObj.AllClass();
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
