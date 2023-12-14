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
    public partial class labReqs_1 : Form
    {
        Controller controllerObj;
        public labReqs_1()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void labReqs_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectSalaryLess40k();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            label1.Text = "Less than 40k operation executed";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetMaxAverageSalary();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            label1.Text = "Average and max operation executed";

            if (dt.Rows.Count != 0)
            {
                object Max = dt.Rows[0]["MaxSalary"];
                object Avg = dt.Rows[0]["AvgSalary"];
                int maxSalary = Convert.ToInt32(Max);
                int avgSalary = Convert.ToInt32(Avg);
                MessageBox.Show("Maximum Salary: "+maxSalary+"\n Average Salary: "+avgSalary+"\n" );
            }
            else
            MessageBox.Show("No data found");
        }
    }
}
