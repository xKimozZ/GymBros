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
    public partial class StaffClasses : UserControl
    {
        Controller controllerObj;
        public StaffClasses()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllClasses();
            classCombo.DataSource = dt;
            classCombo.ValueMember = "Class_Type";
            classCombo.DisplayMember = "Class_Type";
            CheckIn_radio.Checked = true;
        }

        private void CheckIn_radio_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            updt_panel.Hide();
            CheckIn_pnl.Show();
            string classType = (classCombo.SelectedValue).ToString();
            DataTable members = controllerObj.getAttendingClassMembers(classType);
            memberCombo.DataSource = members;
            memberCombo.ValueMember = "User_ID";
            memberCombo.DisplayMember = "Fname";
            DataTable dt = controllerObj.getAllClassAttenders(classType);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Update_radio_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            updt_panel.Show();
            CheckIn_pnl.Hide();
            DataTable dt = controllerObj.GetAllClasses();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void updt_btn_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DateTime currentDate = DateTime.Now;
            DateTime selectedDate = (dateTimePicker1.Value).Date;
            TimeSpan currentTime = currentDate.TimeOfDay;
            TimeSpan time;
            if (selectedDate <= currentDate)
            {
                MessageBox.Show("Invalid Date");
            }
            else if (!TimeSpan.TryParse(timeBox.Text.ToString(), out time))
            {
                MessageBox.Show("Invalid Time Format. Use 24-Hour Format");
            }
            else
            {
                string classType = (classCombo.SelectedValue).ToString();
                int r = controllerObj.updateClassDateTime(selectedDate, time, classType);
                if (r == 1) MessageBox.Show("Success");
                else MessageBox.Show("Fail");

                DataTable dt = controllerObj.GetAllClasses();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            string classType = (classCombo.SelectedValue).ToString();
            int mem_id = Convert.ToInt32(memberCombo.SelectedValue);
            DateTime currentDate = DateTime.Now;
            DateTime classDate = controllerObj.getDateClass(classType);
            TimeSpan currentTime = currentDate.TimeOfDay;
            TimeSpan classTime = controllerObj.getTimeClass(classType);
            classTime.Add(new TimeSpan(1, 0, 0));   // Add One hour
            if (currentDate.Date > classDate)
            {
                int r = controllerObj.dropClass(mem_id, classType);
                if (r == 1) MessageBox.Show("Too Late");
                else MessageBox.Show("Error");
            }
            else if (currentDate.Date == classDate && currentTime > classTime)
            {
                int r = controllerObj.dropClass(mem_id, classType);
                if (r == 1) MessageBox.Show("Too Late");
                else MessageBox.Show("Error");
            }
            else
            {
                int r = controllerObj.dropClass(mem_id, classType);
                if (r == 1)
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Fail");
            }
            DataTable members = controllerObj.getAttendingClassMembers(classType);
            memberCombo.DataSource = members;
            memberCombo.ValueMember = "User_ID";
            memberCombo.DisplayMember = "Fname";
            DataTable dt = controllerObj.getAllClassAttenders(classType);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void classCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (CheckIn_radio.Checked)
            {
                string classType = (classCombo.SelectedValue).ToString();
                DataTable members = controllerObj.getAttendingClassMembers(classType);
                memberCombo.DataSource = members;
                memberCombo.ValueMember = "User_ID";
                memberCombo.DisplayMember = "Fname";
                DataTable dt = controllerObj.getAllClassAttenders(classType);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            
        }
    }
}
