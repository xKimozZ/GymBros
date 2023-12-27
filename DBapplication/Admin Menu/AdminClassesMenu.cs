using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            panelUpdate.Hide();
            paneldel.Hide();

            labelMgr.Visible = false;
            labelId.Visible = false;
            comboBoxClassMgr.Visible = false;
            comboBoxClassMgr.Enabled = false;
            comboBoxInstructorId.Visible = false;
            comboBoxInstructorId.Enabled = false;

            // Set data source for Class Manager ComboBox
            LoadClassManagers();

            // Set data source for Instructor ComboBox
            LoadInstructors();

            LoadClassTypes();
        }
        private void LoadClassTypes()
        {
            DataTable classTypes = controllerObj.GetAllClassTypes();
            comboBoxClassType.DisplayMember = "Class_Type";
            comboBoxClassType.ValueMember = "Class_Type";
            comboBoxClassType.DataSource = classTypes;
            comboBoxdel.DisplayMember = "Class_Type";
            comboBoxdel.ValueMember = "Class_Type";
            comboBoxdel.DataSource = classTypes;
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
            panelUpdate.Hide();
            paneldel.Hide();
            panelselect.Visible = true;
            panelselect.Top = buttonAdd.Top;
            labelMgr.Visible = true;
            labelId.Visible = true;
            comboBoxClassMgr.Visible = true;
            comboBoxClassMgr.Enabled = true;
            comboBoxInstructorId.Visible = true;
            comboBoxInstructorId.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            string classType = comboBoxClassType.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(classType))
            {
                MessageBox.Show("Please select a valid Class Type from the list.");
                return;
            }

            int newClassMgr;

            // Validate new class manager selection
            if (comboBoxClassMgr.SelectedValue == null || !int.TryParse(comboBoxClassMgr.SelectedValue.ToString(), out newClassMgr))
            {
                MessageBox.Show("Please select a valid new Class Manager from the list.");
                return;
            }

            string newDescription = txtClassDescription2.Text.Trim();
            int newInstructorId;

            // Validate new instructor ID selection
            if (comboBoxInstructorId.SelectedValue == null || !int.TryParse(comboBoxInstructorId.SelectedValue.ToString(), out newInstructorId))
            {
                MessageBox.Show("Please select a valid new Instructor ID from the list.");
                return;
            }

            // Get new date and time from DateTimePicker controls
            DateTime newDateTime = dateTimePicker2.Value;

            // Extract new date and time components
            DateTime newDate = newDateTime.Date;
            TimeSpan newTime;

            // Validate new time input
            if (!TimeSpan.TryParse(txtTime2.Text, out newTime))
            {
                MessageBox.Show("Invalid new time format. Please enter a valid time.");
                return;
            }

            string newLocation = txtLocation2.Text.Trim();
            int newClassMaxLimit;

            // Validate new class max limit input
            if (!int.TryParse(textBoxclassupd.Text, out newClassMaxLimit))
            {
                MessageBox.Show("Invalid new class max limit. Please enter a valid number.");
                return;
            }

            // Determine availability based on radio button selection
            bool newAvailability = checkBox1.Checked;

            // Call the UpdateClass function with validated input
            int result = controllerObj.UpdateClass(classType, newClassMgr, newDescription, newInstructorId, newDate, newTime, newLocation, newClassMaxLimit, newAvailability);

            // Check the result and provide appropriate feedback to the user
            if (result == 1)
            {
                MessageBox.Show("Class updated successfully!");
            }
            else
            {
                MessageBox.Show("Error updating class. Please check the input and try again.");
            }

        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            panelAdd.Hide();
            panelUpdate.Show();
            paneldel.Hide();
            panelselect.Visible = true;
            panelselect.Top = buttonManage.Top;
            labelMgr.Visible = true;
            labelId.Visible = true;
            comboBoxClassMgr.Visible = true;
            comboBoxClassMgr.Enabled = true;
            comboBoxInstructorId.Visible = true;
            comboBoxInstructorId.Enabled = true;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string classType = comboBoxClassType.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(classType))
            {
                MessageBox.Show("Please select a valid Class Type from the list.");
                return;
            }

            int result = controllerObj.DeleteClass(classType);

            if (result == 1)
            {
                MessageBox.Show("Class deleted successfully!");
            }
            else
            {
                MessageBox.Show("Error deleting class. Please check the input and try again.");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            labelMgr.Visible = false;
            labelId.Visible = false;
            comboBoxClassMgr.Visible = false;
            comboBoxClassMgr.Enabled = false;
            comboBoxInstructorId.Visible = false;
            comboBoxInstructorId.Enabled = false;
            panelselect.Visible = true;
            panelselect.Top = buttonRemove.Top;
            paneldel.Show();
            panelUpdate.Hide();
            panelAdd.Hide();
        }
    }
}
