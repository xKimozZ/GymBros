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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AdminLogin a = new AdminLogin();
            Admin a = new Admin();
            a.Show();
             
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Provided_Functionalities f = new Provided_Functionalities(0);//for admin
        //    f.Show();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
