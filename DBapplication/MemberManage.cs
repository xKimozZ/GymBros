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
    public partial class MemberManage : UserControl
    {
        Controller controllerObj;
        public MemberManage()
        {
            InitializeComponent();
            controllerObj = new Controller();
            // initally male is checked
            radioButtonMale.Checked = true;
            // fill member grid
            dataGridView1.DataSource = controllerObj.getAllMembers();
            dataGridView1.Refresh();

          
        }

        private void MemberManage_Load(object sender, EventArgs e)
        {

        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            string pass = txtPass.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string contactInfoText = txtContactInfo.Text.Trim();
            string emergencyContactText = txtEmergencyContact.Text.Trim();

            // Validate empty textboxes
            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(ageText) || string.IsNullOrEmpty(contactInfoText) || string.IsNullOrEmpty(emergencyContactText))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            int age;

            // Validate age input
            if (!int.TryParse(ageText, out age) || age < 16)
            {
                MessageBox.Show("Invalid age. Please enter a valid age greater than or equal to 16.");
                return;
            }

            int contactInfo;
            int emergencyContact;

            // Validate contactInfo input
            if (!int.TryParse(contactInfoText, out contactInfo))
            {
                MessageBox.Show("Invalid contact information. Please enter a valid number.");
                return;
            }

            // Validate emergencyContact input
            if (!int.TryParse(emergencyContactText, out emergencyContact))
            {
                MessageBox.Show("Invalid emergency contact information. Please enter a valid number.");
                return;
            }

            int gender = (radioButtonMale.Checked) ? 1 : 0;

        
            int result = controllerObj.AddMember(fname, lname, pass, age, contactInfo, emergencyContact, gender);

           
            if (result == 1)
            {
                MessageBox.Show("Member added successfully!");
                dataGridView1.DataSource = controllerObj.getNamesMembers();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Error adding member. Please check the input and try again.");
            }

        }

    }
}
