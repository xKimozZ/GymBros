using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class AdminStaffMenu : UserControl
    {
        Controller controllerObj;
        public AdminStaffMenu()
        {
            InitializeComponent();
            controllerObj = new Controller();
            // Array of strings with the desired values 
            string[] roles = { "Trainer", "Front Desk", "Manager" };
            comboBoxRole2.Items.AddRange(roles);
            comboBoxRoles.Items.AddRange(roles);
            comboBoxRole2.SelectedItem = roles[0];

            DataTable st = controllerObj.getNamesStaff();
            comboBoxID.DisplayMember = "Staff_ID";
            comboBoxID.ValueMember = "Lname";
            comboBoxID.DataSource = st;

            labelLname.Visible = false;
            panelManager.Hide();
            panelAdminPay.Hide();
            panelAdd.Hide();
        }


        private void buttonProfile_Click(object sender, EventArgs e)
        {
            panelAdminPay.Hide();
            panelAdd.Hide();
            panelManager.Show();

            labelLname.Visible = true;
            labelID.Visible = true;
            comboBoxID.Visible = true;
            comboBoxID.Enabled = true;

            panelselect.Visible = true;
            panelselect.Top = buttonProfile.Top;
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelManager.Hide();
            panelAdminPay.Hide();
            panelAdd.Show();

            labelID.Visible = false;
            labelLname.Visible = false;
            comboBoxID.Visible = false;
            comboBoxID.Enabled = false;

            // initally male is checked
            radioButtonMale.Checked = true;
            
            panelselect.Visible = true;
            panelselect.Top = buttonAdd.Top;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2add_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            string pass = txtPass.Text.Trim();
            int age;
            string Role = comboBoxRole2.SelectedItem.ToString();

            // Validate age input
            if (!int.TryParse(txtAge.Text, out age) || age < 18)
            {
                MessageBox.Show("Invalid age. Please enter a valid age greater than or equal to 18.");
                return;
            }

            int contactInfo;
            int emergencyContact;

            // Validate contactInfo input
            if (!int.TryParse(txtContactInfo.Text, out contactInfo))
            {
                MessageBox.Show("Invalid contact information. Please enter a valid number.");
                return;
            }

            // Validate emergencyContact input
            if (!int.TryParse(txtEmergencyContact.Text, out emergencyContact))
            {
                MessageBox.Show("Invalid emergency contact information. Please enter a valid number.");
                return;
            }

            int gender = (radioButtonMale.Checked) ? 1 : 0; // Assuming you have radio buttons for gender

            // Call the AddMember function with validated input
            int result = controllerObj.AddStaff(fname, lname, pass, age, contactInfo, emergencyContact, gender, Role);

            // Check the result and provide appropriate feedback to the user
            if (result == 1)
            {
                MessageBox.Show("Staff added successfully!");
            }
            else
            {
                MessageBox.Show("Error adding Staff. Please check the input and try again.");
            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLname.Visible = true;
            labelLname.Text = "Last name: " + comboBoxID.SelectedValue.ToString();
        }

        private void buttonAddadmin_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (comboBoxID.Text == "")   //validation part
            {
                MessageBox.Show("No Staff selected");
                return;
            }
            int result = controllerObj.UpdateStaffRole(Convert.ToInt32(comboBoxID.Text), "Admin");
            if (result == 1)
            {
                MessageBox.Show("Admin added successfully!");
            }
            else
            {
                MessageBox.Show("Error adding Admin. Please check the input and try again.");
            }
        }

        private void buttonRoleChange_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (comboBoxID.Text == "")   //validation part
            {
                MessageBox.Show("No Staff selected");
                return;
            }
            if (comboBoxRoles.Text == "")   //validation part
            {
                MessageBox.Show("No Role selected");
                return;
            }
            int result = controllerObj.UpdateStaffRole(Convert.ToInt32(comboBoxID.Text), comboBoxRoles.Text );
            if (result == 1)
            {
                MessageBox.Show("Role changed successfully!");
            }
            else
            {
                MessageBox.Show("Error changing role. Please check the input and try again.");
            }
        }


        private void buttonDel_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (comboBoxID.Text == "")   //validation part
            {
                MessageBox.Show("No Staff selected");
                return;
            }
            int result = controllerObj.DeleteUser(Convert.ToInt32(comboBoxID.Text));
            if (result == 1)
            {
                MessageBox.Show("Staff deleted successfully!");
            }
            else
            {
                MessageBox.Show("Error deleting Staff. Please check the input and try again.");
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            panelManager.Hide();
            panelAdd.Hide();
            panelAdminPay.Show();

            labelLname.Visible = true;
            labelID.Visible = true;
            comboBoxID.Visible = true;
            comboBoxID.Enabled = true;

            panelselect.Visible = true;
            panelselect.Top = buttonPay.Top;
        }

        private void buttonPaypanel_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            if (comboBoxID.Text == "")   // Validation part
            {
                MessageBox.Show("No Staff selected");
                return;
            }

            int staffId = Convert.ToInt32(comboBoxID.Text);

            // Call the GetRoleByStaffId method to get the current role
            string currentRole = controllerObj.GetRoleByStaffId(staffId);

            if (currentRole == null)
            {
                MessageBox.Show("Error retrieving staff role. Please check the input and try again.");
                return;
            }

            // Determine the transaction type based on the current role
            string transactionType = (currentRole == "Admin") ? "Salary_Admin" : "Salary_Staff";

            // Insert into Staff_Trans table
            int insertResult = controllerObj.InsertStaffTransaction(staffId, transactionType);

            if (insertResult == 1)
            {
                MessageBox.Show($"Transaction inserted successfully! Transaction Type: {transactionType}");
            }
            else
            {
                MessageBox.Show("Error inserting transaction. Please check the input and try again.");
            }
        }
    }
}
    