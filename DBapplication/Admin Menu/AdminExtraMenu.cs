using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Admin_Menu
{
    public partial class AdminExtraMenu : UserControl
    {
        Controller controllerObj;
        public AdminExtraMenu()
        {
            controllerObj = new Controller();
            InitializeComponent();
            panelAdd.Hide();
            panelUpdate.Hide();
            paneldel.Hide();
            comboBoxServiceMgr.Visible = false;
            comboBoxServiceMgr.Enabled = false;
            ServiceMgr.Visible = false;
            LoadServiceManagers();
        }
        private void LoadServiceManagers()
        {
            DataTable managers = controllerObj.GetStaffByRole("Manager");
            comboBoxServiceMgr.DisplayMember = "Staff_ID";
            comboBoxServiceMgr.ValueMember = "Staff_ID";
            comboBoxServiceMgr.DataSource = managers;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
            panelUpdate.Hide();
            paneldel.Hide();
            panelselect.Visible = true;
            panelselect.Top = buttonAdd.Top;
            comboBoxServiceMgr.Visible = true;
            comboBoxServiceMgr.Enabled = true;
            ServiceMgr.Visible = true;
        }

        private void button2add_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            string serviceName = txtServiceName.Text.Trim();
            string description = txtDescription.Text.Trim();
            int serviceMgrId;

            // Validate service name
            if (string.IsNullOrEmpty(serviceName))
            {
                MessageBox.Show("Please enter a valid service name.");
                return;
            }

            // Validate service manager selection
            if (!int.TryParse(comboBoxServiceMgr.SelectedValue?.ToString(), out serviceMgrId))
            {
                MessageBox.Show("Please select a valid service manager from the list.");
                return;
            }

            // Call the InsertExtraService method to add a new extra service record
            int result = controllerObj.InsertExtraService(serviceName, description, serviceMgrId);

            if (result == 1)
            {
                MessageBox.Show("Extra service added successfully!");
            }
            else
            {
                MessageBox.Show("Error adding extra service. Please check the input and try again.");
            }
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            // Assuming you have controls to get the input data from the user
            string serviceName = txtServiceName.Text.Trim();
            string description = txtDescription.Text.Trim();
            int serviceMgrId;

            // Validate service name
            if (string.IsNullOrEmpty(serviceName))
            {
                MessageBox.Show("Please enter a valid service name.");
                return;
            }

            // Validate service manager selection
            if (!int.TryParse(comboBoxServiceMgr.SelectedValue?.ToString(), out serviceMgrId))
            {
                MessageBox.Show("Please select a valid service manager from the list.");
                return;
            }

            // Call the UpdateExtraService method to update an existing extra service record
            int result = controllerObj.UpdateExtraService(serviceName, description, serviceMgrId);

            if (result == 1)
            {
                MessageBox.Show("Extra service updated successfully!");

                // Optionally, clear input fields
                txtServiceName.Text = "";
                txtDescription.Text = "";
                comboBoxServiceMgr.SelectedIndex = -1; // Assuming you want to clear the selection

                // Optionally, provide additional user feedback
                // For example: lblStatus.Text = "Extra service updated successfully!";
            }
            else
            {
                MessageBox.Show("Error updating extra service. Please check the input and try again.");
            }
        }
    }
}
