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
    public partial class RetrieveProjects : Form
    {
        Controller controllerObj;
        public RetrieveProjects()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepLoc();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Dnumber";
            comboBox1.ValueMember = "Dlocation";
           
        }
        private void RetrieveProjects_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectProject(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

       
    }
}
