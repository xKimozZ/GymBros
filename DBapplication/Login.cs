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
            int checkID = controllerObj.LoginAttempt(Convert.ToInt32(textBox1.Text),textBox2.Text);
            if (checkID != 0)
            {
                string fname = controllerObj.FnameUser(Convert.ToInt32(textBox1.Text));
                AppSession.Login(Convert.ToInt32(textBox1.Text), fname);
                int IsMember = controllerObj.LoginMember(Convert.ToInt32(textBox1.Text));
                if (IsMember == 0)
                {
                    string role = controllerObj.LoginStaff(Convert.ToInt32(textBox1.Text));
                    if (role == "Admin")
                    {
                        MessageBox.Show("Admin");
                        Staff staff = new Staff(); //temp until admin form is made
                        staff.Show();
                    }
                    else
                    {
                        MessageBox.Show(role);
                        Staff staff = new Staff();
                        staff.Show();
                    }
                }
                else
                { 
                MessageBox.Show("Member");
                Member member = new Member(Convert.ToInt32(textBox1.Text));
                member.Show();
                }
                this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
