using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class MemberServices : UserControl
    {
        Controller controllerObj;
        DataTable services;
        DataTable classes;
        public MemberServices()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void MemberServices_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label6.Text = "";

            services = controllerObj.GetAllServices();
            comboBox1.DisplayMember = "Service_Name";
            comboBox1.ValueMember = "Service_Name";
            comboBox1.DataSource = services;


            classes = controllerObj.GetAllClassTypes();
            comboBox2.DisplayMember = "Class_Type";
            comboBox2.ValueMember = "Class_Type";
            comboBox2.DataSource = classes;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedService = (string)comboBox1.SelectedValue;
            services.PrimaryKey = new DataColumn[] { services.Columns["Service_Name"] };
            DataRow row = services.Rows.Find(selectedService);
            bool availability = Convert.ToBoolean(row["Availability"]);
            string description = row["Description"].ToString();
            int serviceMgrID = Convert.ToInt32(row["Service_Mgr_ID"]);

            string avail;
            if (availability)
                avail = "Yes";
            else
                avail = "No";

                int cost = controllerObj.TransactionAmount("Extra_Service_payment");
            string manname = controllerObj.FnameUser(serviceMgrID) + " " + controllerObj.LnameUser(serviceMgrID);

            label3.Text = $"Cost: {cost}, Availabile: {avail}, Manager: {manname}";
            label4.Text = $"{description}";

            int renewcheck = controllerObj.AlreadyUseService(AppSession.UserId, selectedService);
            if (renewcheck != 0)
                label3.Text += $"Renew Date: {controllerObj.GetSubscriptionRenewal(AppSession.UserId, selectedService)}";
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            label3.Text = $"";
            label4.Text = $"";
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

        private void Editbutton_Click(object sender, EventArgs e)
        {
            controllerObj.LoginAttempt(AppSession.UserId, textBox1.Text.ToString());

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

            string selectedService = (string)comboBox1.SelectedValue;
            int renewcheck = controllerObj.AlreadyUseService(AppSession.UserId, selectedService);
            if (renewcheck == 0)
            {
                DateTime sublength = DateTime.Now;
                sublength = sublength.AddMonths(1);
                controllerObj.InsertServiceUsing(AppSession.UserId, selectedService, sublength);
                MessageBox.Show("New service registered!\nYou have paid " + controllerObj.TransactionAmount("extra_service_payment")
    + "\nYour new renewal date is " + sublength.ToLongDateString() + ".");
            }
            else
            {
                DateTime sublength = DateTime.Now;
                sublength = sublength.AddMonths(1);
                controllerObj.UpdateServiceRenewal(sublength, AppSession.UserId);
                MessageBox.Show("Service renewal successful!\nYou have paid " + controllerObj.TransactionAmount("extra_service_payment")
                    + "\nYour new renewal date is " + sublength.ToLongDateString() + ".");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Editbutton_Click(sender, e);
        }
    }
}
