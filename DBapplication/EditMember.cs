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
    public partial class EditMember : UserControl
    {
        Controller controllerObj;
        public EditMember()
        {
            InitializeComponent();
            controllerObj = new Controller();
            // initally male is checked
            radioButtonMale.Checked = true;
            
            // fill members combobox
            DataTable members = controllerObj.getNamesMembers();
            memberCombo.DataSource = members;
            memberCombo.ValueMember = "User_ID";
            memberCombo.DisplayMember = "Fname";
        }

        private void EditMember_Load(object sender, EventArgs e)
        {

        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            
        }

        private void Editbutton_Click(object sender, EventArgs e)
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

            int gender = (radioButtonMale.Checked) ? 1 : 0;

            
            int result = controllerObj.UpdateUser(Convert.ToInt32(memberCombo.SelectedValue), fname, lname, pass, age, contactInfo, emergencyContact, gender);

           
            if (result == 1)
            {
                MessageBox.Show("Member editted successfully!");
                dataGridView1.DataSource = controllerObj.GetMemberInformation(Convert.ToInt32(memberCombo.SelectedValue));
                dataGridView1.Refresh();
                DataTable members = controllerObj.getNamesMembers();
                memberCombo.DataSource = members;
                memberCombo.ValueMember = "User_ID";
                memberCombo.DisplayMember = "Fname";
                memberCombo.Refresh();

            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContactInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmergencyContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
