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
    public partial class Provided_Functionalities : Form
    {
       
        public Provided_Functionalities(int a)
        {
            InitializeComponent();
            if (a == 0) //1 for admin, 0 for other
            {
                this.button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RetrieveProjects RP = new RetrieveProjects();
            RP.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewEmployees v = new ViewEmployees();
            v.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject p = new AddProject();
            p.Show();
        }

        private void labReqsButton_Click(object sender, EventArgs e)
        {
            labReqs_Home l = new labReqs_Home();
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            demo1_AddMember f = new demo1_AddMember();
            f.Show();
        }

       
    }
}
