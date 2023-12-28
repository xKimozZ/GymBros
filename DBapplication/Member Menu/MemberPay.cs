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
    public partial class MemberPay : UserControl
    {
        Controller controllerObj;
        public MemberPay()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {

            string pass = textBox1.Text.Trim();
            string rechk = textBox2.Text.Trim();

            if (pass == "")
            {
                MessageBox.Show("Please enter your password to confirm renewal.");
                return;
            }

            if (rechk == "")
            {
                MessageBox.Show("Please re-enter the password to confirm renewal.");
                return;
            }

            if (rechk != pass)
            {
                MessageBox.Show("The passwords you entered are not the same.");
                return;
            }

            int checkID = controllerObj.LoginAttempt(AppSession.UserId, textBox1.Text);
            if (checkID != 0)
            {
                DateTime renew = controllerObj.GetRenewalDate(AppSession.UserId);
                renew = renew.AddMonths(1);
                MessageBox.Show("Payment successful!\nYou have paid "+ controllerObj.TransactionAmount("membership_fees")
                    +"\nYour new renewal date is " + renew.ToLongDateString() + ".");
                label3.Text = renew.ToString();
                controllerObj.UpdateRenewalDate(renew,AppSession.UserId);
                controllerObj.InsertMemberTransaction(AppSession.UserId, "Membership_fees");
            }
            else
            {
                MessageBox.Show("The password you entered is not correct.");
                return;
            }
        }

        private void MemberPay_Load(object sender, EventArgs e)
        {
            DateTime renew = controllerObj.GetRenewalDate(AppSession.UserId);
            label3.Text = renew.ToString();
            int payment = controllerObj.TransactionAmount("Membership_fees");
            label4.Text = payment.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox2.ReadOnly = false;
            else
            {
                textBox2.ReadOnly = true;
                textBox2.Text = "";    
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Editbutton_Click(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Editbutton_Click(sender, e);
        }
    }
}
