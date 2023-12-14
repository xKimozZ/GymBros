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
    public partial class labReqs_Home : Form
    {
        public labReqs_Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labReqs_1 w = new labReqs_1();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labReqs_3 w = new labReqs_3();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labReqs_4 w = new labReqs_4();
            w.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labReqs_5 w = new labReqs_5();
            w.Show();
        }
    }
}
