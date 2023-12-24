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
    public partial class StaffPTUpdate : UserControl
    {
        Controller controllerObj;
        public StaffPTUpdate()
        {
            InitializeComponent();
            controllerObj = new Controller();

            // fill sessions combobox
            DataTable Sessions = controllerObj.GetSessionsByStaff(AppSession.UserId);
            comboBox1.DataSource = Sessions;
            comboBox1.ValueMember = "Session_ID";
            comboBox1.DisplayMember = "Date";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
         
            int result = controllerObj.UpdatePrivateSession(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value, false);


            if (result == 1)
            {
                MessageBox.Show("Session added successfully!");


            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DataTable sessionsByThisStaff = controllerObj.GetSessionsByStaff(AppSession.UserId);
            comboBox1.DataSource = sessionsByThisStaff;
            comboBox1.ValueMember = "Session_ID";
            comboBox1.DisplayMember = "Date";
        }
    }
    }

