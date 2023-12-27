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
            LoadServiceNames();
        }
        private void LoadServiceManagers()
        {
            DataTable managers = controllerObj.GetStaffByRole("Manager");
            comboBoxServiceMgr.DisplayMember = "Staff_ID";
            comboBoxServiceMgr.ValueMember = "Staff_ID";
            comboBoxServiceMgr.DataSource = managers;
        }
        private void LoadServiceNames()
        {
            DataTable ServiceNames = controllerObj.GetAllServices();
            comboBoxClassType.DisplayMember = "Service_Name";
            comboBoxClassType.ValueMember = "Service_Name";
            comboBoxClassType.DataSource = ServiceNames;
            comboBoxdel.DisplayMember = "Service_Name";
            comboBoxdel.ValueMember = "Service_Name";
            comboBoxdel.DataSource = ServiceNames;
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
            panelAdd.Hide();
            panelUpdate.Show();
            paneldel.Hide();
            panelselect.Visible = true;
            panelselect.Top = buttonManage.Top;
            comboBoxServiceMgr.Visible = true;
            comboBoxServiceMgr.Enabled = true;
            ServiceMgr.Visible = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            // Assuming you have controls to get the input data from the user
            string serviceName = comboBoxClassType.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(serviceName))
            {
                MessageBox.Show("Please select a valid serviceName from the list.");
                return;
            }

            string description = txtDescription.Text.Trim();
            int serviceMgrId;


            // Validate service manager selection
            if (!int.TryParse(comboBoxServiceMgr.SelectedValue?.ToString(), out serviceMgrId))
            {
                MessageBox.Show("Please select a valid service manager from the list.");
                return;
            }
            bool newAvailability = checkBox1.Checked;
            // Call the UpdateExtraService method to update an existing extra service record
            int result = controllerObj.UpdateExtraService(serviceName, description, serviceMgrId, newAvailability);

            if (result == 1)
            {
                MessageBox.Show("Extra service updated successfully!");

                txtServiceName.Text = "";
                txtDescription.Text = "";
            }
            else
            {
                MessageBox.Show("Error updating extra service. Please check the input and try again.");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            ServiceMgr.Visible = false;
            comboBoxServiceMgr.Visible = false;
            comboBoxServiceMgr.Enabled = false;

            panelselect.Visible = true;
            panelselect.Top = buttonRemove.Top;
            paneldel.Show();
            panelUpdate.Hide();
            panelAdd.Hide();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string serviceName = comboBoxdel.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(serviceName))
            {
                MessageBox.Show("Please select a valid Service Type from the list.");
                return;
            }

            int result = controllerObj.DeleteService(serviceName);

            if (result == 1)
            {
                MessageBox.Show("Service deleted successfully!");
                LoadServiceNames();
            }
            else
            {
                MessageBox.Show("Error deleting Service. Please check the input and try again.");
            }
        }
    }
}
