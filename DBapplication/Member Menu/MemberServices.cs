using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            label5.Text = "";
            label6.Text = "";
            label10.Text = "";
            label11.Text = "";

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
            updateServiceGUI(selectedService);
        }

        private void updateServiceGUI(string type)
        {
            services.PrimaryKey = new DataColumn[] { services.Columns["Service_Name"] };
            DataRow row = services.Rows.Find(type);
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

            int renewcheck = controllerObj.AlreadyUseService(AppSession.UserId, type);
            if (renewcheck != 0)
                label5.Text = $"Renew Date: {controllerObj.GetSubscriptionRenewal(AppSession.UserId, type)}";
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            label3.Text = $"";
            label5.Text = $"";
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
            if (checkID == 0)
            {
                MessageBox.Show("The password you entered is not correct.");
                return;
            }

            string selectedService = (string)comboBox1.SelectedValue;
            controllerObj.InsertMemberTransaction(AppSession.UserId, "Extra_service_payment");
            int renewcheck = controllerObj.AlreadyUseService(AppSession.UserId, selectedService);
            if (renewcheck == 0)
            {
                DateTime sublength = DateTime.Now;
                sublength = sublength.AddMonths(1);
                controllerObj.InsertServiceUsing(AppSession.UserId, selectedService, sublength);
                MessageBox.Show("New service registered!\nYou have paid " + controllerObj.TransactionAmount("extra_service_payment")
                + "\nYour renewal date is " + sublength.ToLongDateString() + ".");
            }
            else
            {
                DateTime sublength = controllerObj.GetSubscriptionRenewal(AppSession.UserId,selectedService);
                sublength = sublength.AddMonths(1);
                controllerObj.UpdateServiceRenewal(sublength, AppSession.UserId);
                MessageBox.Show("Service renewal successful!\nYou have paid " + controllerObj.TransactionAmount("extra_service_payment")
                + "\nYour new renewal date is " + sublength.ToLongDateString() + ".");
            }
            updateServiceGUI(selectedService);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = null;
            label6.Text = $"";
            label10.Text = $"";
            label11.Text = $"";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedClass = (string)comboBox2.SelectedValue;
            updateClassGUI(selectedClass);
        }

        private void updateClassGUI(string type)
        {
            classes.PrimaryKey = new DataColumn[] { classes.Columns["Class_Type"] };
            DataRow row = classes.Rows.Find(type);
            int classMgr = Convert.ToInt32(row["Class_Mgr"]);
            bool availability = Convert.ToBoolean(row["Availability"]);
            string description = row["Description"].ToString();
            int instructorID = row["Instructor_ID"] != DBNull.Value ? Convert.ToInt32(row["Instructor_ID"]) : -1;
            DateTime date = Convert.ToDateTime(row["Date"]);
            TimeSpan time = (TimeSpan)row["Time"];
            string location = row["Location"].ToString();
            int registeredNum = Convert.ToInt32(row["Registered_Num"]);
            int classMaxLimit = Convert.ToInt32(row["Class_Max_Limit"]);
            
            string avail;
            if (availability)
                avail = "Yes";
            else
                avail = "No";

            int cost = controllerObj.TransactionAmount("Class_payment");
            string manname = controllerObj.FnameUser(classMgr) + " " + controllerObj.LnameUser(classMgr);
            string instructorname = controllerObj.FnameUser(instructorID) + " " + controllerObj.LnameUser(instructorID);

            label6.Text = $"Cost: {cost}, Availabile: {avail}, Manager: {manname}\n" +
                $"Instructor: {instructorname}, Capacity: {classMaxLimit}, Open places: {classMaxLimit - registeredNum}";
            label11.Text = $"Date: {date}, Time: {time}, Location: {location}";
            label10.Text = $"{description}";

            //int renewcheck = controllerObj.AlreadyUseService(AppSession.UserId, type);
            //if (renewcheck != 0)
            //    label5.Text = $"Renew Date: {controllerObj.GetSubscriptionRenewal(AppSession.UserId, type)}";
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (checkID == 0)
            {
                MessageBox.Show("The password you entered is not correct.");
                return;
            }

            string selectedClass = (string)comboBox2.SelectedValue;
            int checkClass = controllerObj.AlreadyUseClass(AppSession.UserId, selectedClass);
            if (checkClass != 0)
            {
                MessageBox.Show("You already registered this class.");
                return;
            }

            classes.PrimaryKey = new DataColumn[] { classes.Columns["Class_Type"] };
            DataRow row = classes.Rows.Find(selectedClass); ;
            int registeredNum = Convert.ToInt32(row["Registered_Num"]);
            int classMaxLimit = Convert.ToInt32(row["Class_Max_Limit"]);
            if (registeredNum == classMaxLimit)
            {
                MessageBox.Show("No places are available for this class.");
                return;
            }

            DateTime date = Convert.ToDateTime(row["Date"]);
            TimeSpan time = (TimeSpan)row["Time"];

            controllerObj.InsertMemberTransaction(AppSession.UserId, "Class_payment");
            controllerObj.InsertAttendsClass(AppSession.UserId,selectedClass);
            controllerObj.IncrementClassRegistered(registeredNum++, selectedClass);
            MessageBox.Show("New class registered!\nYou have paid " + controllerObj.TransactionAmount("class_payment")
            + "\nThe class date is " + date.ToLongDateString() + " at "+ time.ToString() +".");
            
            updateClassGUI(selectedClass);
        }
    }
}
