using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication.Admin_Menu
{
    public partial class AdminClassesMenu : UserControl
    {
        Controller controllerObj;
        public AdminClassesMenu()
        {
            controllerObj = new Controller();
            InitializeComponent();
            panelAdd.Hide();

            // Set data source for Class Manager ComboBox
            LoadClassManagers();

            // Set data source for Instructor ComboBox
            
            LoadInstructors();
        }

        private void LoadClassManagers()
        {
            DataTable managers = controllerObj.GetStaffByRole("Manager");
            comboBoxClassMgr.DisplayMember = "Staff_ID";
            comboBoxClassMgr.ValueMember = "Staff_ID";
            comboBoxClassMgr.DataSource = managers;
        }

        private void LoadInstructors()
        {
            DataTable trainers = controllerObj.GetStaffByRole("Trainer");
            comboBoxInstructorId.DisplayMember = "Staff_ID";
            comboBoxInstructorId.ValueMember = "Staff_ID";
            comboBoxInstructorId.DataSource = trainers;
        }

        private void button2add_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            string classType = txtClassType.Text.Trim();
            int classMgr;

            // Validate class manager selection
            if (comboBoxClassMgr.SelectedValue == null || !int.TryParse(comboBoxClassMgr.SelectedValue.ToString(), out classMgr))
            {
                MessageBox.Show("Please select a valid Class Manager from the list.");
                return;
            }

            string description = txtClassDescription.Text.Trim();
            int instructorId;

            // Validate instructor ID selection
            if (comboBoxInstructorId.SelectedValue == null || !int.TryParse(comboBoxInstructorId.SelectedValue.ToString(), out instructorId))
            {
                MessageBox.Show("Please select a valid Instructor ID from the list.");
                return;
            }
            // Get date and time from DateTimePicker controls
            DateTime dateTime = dateTimePicker1.Value;

            // Extract date and time components
            DateTime date = dateTime.Date;
            TimeSpan time;

            // Validate time input
            if (!TimeSpan.TryParse(txtTime.Text, out time))
            {
                MessageBox.Show("Invalid time format. Please enter a valid time.");
                return;
            }

            string location = txtLocation.Text.Trim();
            int classMaxLimit;

            // Validate class max limit input
            if (!int.TryParse(txtClassMaxLimit.Text, out classMaxLimit))
            {
                MessageBox.Show("Invalid class max limit. Please enter a valid number.");
                return;
            }

            // Call the InsertClass function with validated input
            int result = controllerObj.InsertClass(classType, classMgr, description, instructorId, date, time, location, classMaxLimit);

            // Check the result and provide appropriate feedback to the user
            if (result == 1)
            {
                MessageBox.Show("Class added successfully!");
            }
            else
            {
                MessageBox.Show("Error adding class. Please check the input and try again.");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
            panelselect.Visible = true;
            panelselect.Top = buttonAdd.Top;
        }
    }
}
