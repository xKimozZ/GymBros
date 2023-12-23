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
    public partial class MemberData : UserControl
    {
        Controller controllerObj;
        public MemberData()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Editbutton_Click(object sender, EventArgs e)
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
            int SessionID = 101; //Temporary.

            // Call the EditMember function with validated input
            int result = controllerObj.UpdateUser(SessionID, fname, lname, pass, age, contactInfo, emergencyContact, gender);

            // Check the result and provide appropriate feedback to the user
            if (result == 1)
            {
                MessageBox.Show("Member editted successfully!");
                dataGridView1.DataSource = controllerObj.getNamesMembers();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }
    }
}
