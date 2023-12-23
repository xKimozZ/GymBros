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

    public partial class EditStaffOwnProfile : UserControl
    {
        Controller controllerObj;
        public EditStaffOwnProfile()
        {
        
            InitializeComponent();
            controllerObj = new Controller();
            // initally male is checked
            radioButtonMale.Checked = true;
            // fill member grid
            dataGridView1.DataSource = controllerObj.getNamesStaff();
            dataGridView1.Refresh();
        }

        private void EditProfilebutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            string pass = txtPass.Text.Trim();
            int age;

            // Validate age input
            if (!int.TryParse(txtAge.Text, out age) || age < 16)
            {
                MessageBox.Show("Invalid age. Please enter a valid age greater than or equal to 16.");
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

            // Call the EditMember function with validated input
            int result = controllerObj.UpdateUser(Convert.ToInt32(AppSession.UserId), fname, lname, pass, age, contactInfo, emergencyContact, gender);

            // Check the result and provide appropriate feedback to the user
            if (result == 1)
            {
                MessageBox.Show("Profile editted successfully!");
                dataGridView1.DataSource = controllerObj.getNamesStaff();
                dataGridView1.Refresh();
                
            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }
    }
}
