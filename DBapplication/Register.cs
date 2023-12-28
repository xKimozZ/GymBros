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
    public partial class Register : Form
    {
        Controller controllerObj;
        public Register()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                signupButton_Click(sender, e);
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                signupButton_Click(sender, e);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                signupButton_Click(sender, e);
        }

        private void txtRecheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                signupButton_Click(sender, e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
                signupButton_Click(sender, e);
        }

        private void txtContactInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
                signupButton_Click(sender, e);
        }

        private void txtEmergencyContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
                signupButton_Click(sender, e);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != "")
                txtRecheck.ReadOnly = false;
            else
            {
                txtRecheck.ReadOnly = true;
                txtRecheck.Text = "";
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            string pass = txtPass.Text.Trim();
            string rechk = txtRecheck.Text.Trim();
            int age;

            if (txtFname.Text == "" || txtLname.Text == "" || txtPass.Text == "" || txtRecheck.Text == "" || txtAge.Text == ""
            || txtContactInfo.Text == "" || txtEmergencyContact.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

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

            // Validate password input
            if (rechk != pass)
            {
                MessageBox.Show("The passwords you entered are not the same.");
                return;
            }

            bool gender = (radioButtonMale.Checked) ? true : false; // Assuming you have radio buttons for gender

            // Call the EditMember function with validated input
            int id = controllerObj.InsertUser(fname, lname, gender, age, pass, emergencyContact, contactInfo);

            // Check the result and provide appropriate feedback to the user
            if (id != -1)
            {
                DateTime renew = DateTime.Now;
                renew = renew.AddMonths(1);
                MessageBox.Show("Welcome!\n\nPayment completed!\n\nPlease return to the Welcome page and click on Login and enter your info to start!\n\n" +
                    "Your renewal date will be on: " + renew + " and your ID is: "+id);
                controllerObj.InsertMember(id, renew);
                controllerObj.InsertMemberTransaction(id, "Membership_fees");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }
    }
}
