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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "1234")//Password can be saved in the DB encrypted rather than being hardcoded.
            {
                //Login successful
                Provided_Functionalities f = new Provided_Functionalities(1);
                f.Show();
            }
            else
            {
                MessageBox.Show("Password isn't correct");
            }
            this.Close();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
